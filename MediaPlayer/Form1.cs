using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaPlayer.ListelemeIslemleri;
using MediaPlayer.Playlist;
using MediaPlayer.Uyari;
using MediaPlayer.Gezinme;
using MediaPlayer.Seslendirme;
using System.IO;
using WMPLib;
using System.Threading;
using System.Resources;
using System.Globalization;
using System.Collections;
using System.Speech.Synthesis;
using MediaPlayer.DizinYoneticisi;

namespace MediaPlayer
{
    public partial class Form1 : Form
    {
        private System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1)); //Resim klasörü.

        public Form1()
        {
            
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false; //Multi-Thread engeli kaldırılıyor.
        }
        //ses.SpeakAsyncCancelAll();
        public bool seslendirmeBaslikAcikmi=true, seslendirmeAciklamaAcikmi=true, seslendirmeUyariveHataAcikmi=true, seslendirmeKonusmaSesiAcikmi=true; //Seslendirmelerin açık-kapalı durumunu tutan değişkenler.
        public string sonAcilanDizin = string.Empty; // En son dosya yüklenen dizini tutuyor.
        public int seslendirmeBaslikSesi=100, seslendirmeAciklamaSesi=100, seslendirmeUyariveHataSesi=100, seslendirmeKonusmaSesi=100;
        public Seslendirme.Uyari SesliUyari = new Seslendirme.Uyari();
        bool backgroundCompletedEventCancel = true; // İş parçacığının tamamlandığında yapılacakları tutan eventi iptal eden değişken.
        public SpeechSynthesizer ses = new SpeechSynthesizer();
        #region Form Load
        private void Form1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.uiMode = "none";
            backgroundWorker_UyariSesleriOlustur.RunWorkerAsync();
            trackBar_Oynat.MinimumSize = new System.Drawing.Size(950, 25);
            /*Seslendirme*/
            trackBar_Ses.Value = axWindowsMediaPlayer1.settings.volume;
            trackBar_SeslendirmeBaslik.Value = seslendirmeBaslikSesi;
            trackBar_SeslendirmeAciklama.Value = seslendirmeAciklamaSesi;
            trackBar_SeslendirmeUyariveHata.Value = seslendirmeUyariveHataSesi;
            trackBar_konusma.Value = seslendirmeKonusmaSesi;
            checkBox_BaslikSesleri.Checked = seslendirmeBaslikAcikmi;
            checkBox_AciklamaSesleri.Checked = seslendirmeAciklamaAcikmi;
            checkBox_UyariveHataSesleri.Checked = seslendirmeUyariveHataAcikmi;
            checkBox_OkumaSesleri.Checked = seslendirmeKonusmaSesiAcikmi;
            seslendir.Durdur();


        }

        #endregion Form Load
        #region Form Tuş yakalama

        //MediaPlayer.Gezinme.Gezinme tus = new MediaPlayer.Gezinme.Gezinme();
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            //gezinme(mpTabControl_Ana_Menu.SelectedTab.Name, 1);

            

            //ListViewItem item = new ListViewItem();
            //item.Text = mpTabControl_Listeler.TabPages["tabPage_Tum_Listeler"].ContainsFocus.ToString();
            //item.SubItems.Add(mpTabControl_Listeler.TabPages["tabPage_Tum_Listeler"].Focused.ToString());
            //item.SubItems.Add(mpTabControl_Listeler.TabPages["tabPage_Tum_Listeler"].CanFocus.ToString());
            //item.SubItems.Add(mpButon_Dosya_Ekle.Focused.ToString());
            //listView_Tum_Liste.Items.Add(item);


            //if (e.KeyCode == Keys.Down)
            //{
            //    ListViewItem item = new ListViewItem();
            //    item.Text = "ONAY";
            //    listView_Tum_Liste.Items.Add(item);

            //}

            //if (e.KeyCode == Keys.Up)
            //{
            //    gezinme(mpTabControl_Ana_Menu.SelectedTab.Name, e);
            //}
        }
        #endregion Form Tuş yakalama
        #region Dosya Ekle
        private void mpButon_Dosya_Ekle_Click(object sender, EventArgs e)
        {
            DosyaYonetici dsY = new DosyaYonetici();
            dsY.ShowDialog();
        }

        public void dosyaEkle(ArrayList gelendosyalar)
        {
            MPUyari uyari = new MPUyari();// Uyarı nesnesi oluşturuluyor.

            foreach (string dosya in gelendosyalar)//Seçilen dosya kadar döngüye giriliyor.
            {
                string dosyaD = dosya.Replace("\\\\", "\\");
                /* Desteklenmeyen dosyalar kontrol ediliyor. */
                if (Path.GetExtension(dosyaD) == ".amr" || Path.GetExtension(dosyaD) == ".mp3" || Path.GetExtension(dosyaD) == ".wma" || Path.GetExtension(dosyaD) == ".wav" || Path.GetExtension(dosyaD) == ".avi" || Path.GetExtension(dosyaD) == ".mp4" || Path.GetExtension(dosyaD) == ".mpg" || Path.GetExtension(dosyaD) == ".mpeg" || Path.GetExtension(dosyaD) == ".wmv")
                {
                    Listele Item = new Listele(); // Yeni ListView Itemi oluşturuluyor.
                    listView_Tum_Liste.Items.Add(Item.klasorden_Listele(listView_Tum_Liste.Items.Count, dosyaD)); //Oluşturulan Item tüm liste listViewine ekleniyor.
                    dosyaEklendi += 1; //Eklenen dosya miktarı.
                }
                else
                {
                    dosyaHatasi += 1; // Desteklenmeyen dosya varsa sayısı alınıyor.
                }
            }

            uyari.Goster("Uyari", "Seçilen Dosyalar Listelere Ekleniyor...", "Dosyalar Ekleniyor...");
            backgroundWorker_ListeOlustur.RunWorkerAsync();//Listeler Oluşturuluyor.

        }

        #endregion Dosya Ekle
        #region Klasör Ekle
        int dosyaHatasi = 0;//Eklenen dosyaların türleri uygun değilse miktarı alınıyor.
        int dosyaEklendi = 0; //Her defasında eklenen dosya sayısı.

        private void mpButon_Klasor_Ekle_Click(object sender, EventArgs e)
        {
            DizinYonetici dy = new DizinYonetici();
            dy.ShowDialog();

        }

        public void dizinEkle(string dizin)
        {
            MPUyari uyari = new MPUyari();// Uyarı nesnesi oluşturuluyor.
            seslendir.Durdur();
            SesliUyari.Oynat(3, seslendirmeUyariveHataAcikmi, seslendirmeUyariveHataSesi);

            foreach (var dosya in Directory.GetFiles(dizin))//Seçilen dosya kadar döngüye giriliyor.
            {
                /* Desteklenmeyen dosyalar kontrol ediliyor. */
                if (Path.GetExtension(dosya) == ".amr" || Path.GetExtension(dosya) == ".mp3" || Path.GetExtension(dosya) == ".wma" || Path.GetExtension(dosya) == ".wav" || Path.GetExtension(dosya) == ".avi" || Path.GetExtension(dosya) == ".mp4" || Path.GetExtension(dosya) == ".mpg" || Path.GetExtension(dosya) == ".mpeg" || Path.GetExtension(dosya) == ".wmv")
                {
                    Listele Item = new Listele();// Yeni ListView Itemi oluşturuluyor.
                    listView_Tum_Liste.Items.Add(Item.klasorden_Listele(listView_Tum_Liste.Items.Count, dosya)); //Oluşturulan Item tüm liste listViewine ekleniyor.
                    dosyaEklendi += 1;
                }
                else
                {
                    dosyaHatasi += 1; // Desteklenmeyen dosya varsa sayısı alınıyor.
                }
            }

            uyari.Goster("Uyari", "Seçilen Dosyalar Listelere Ekleniyor...", "Dosyalar Ekleniyor...");
            SesliUyari.Oynat(16, seslendirmeUyariveHataAcikmi, seslendirmeUyariveHataSesi);
            backgroundWorker_ListeOlustur.RunWorkerAsync();//Listeler Oluşturuluyor.

        }
        #endregion Klasör Ekle
        

        #region BackGroundWorker Liste Oluştur
        private void backgroundWorker_ListeOlustur_DoWork(object sender, DoWorkEventArgs e)
        {
            ListeleriOlustur();
        }

        private void backgroundWorker_ListeOlustur_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (backgroundCompletedEventCancel == true)
            {
                MPUyari uyari = new MPUyari();
                if (dosyaHatasi == 0) //Desteklenmeyen dosya yok ise,
                {
                    if (dosyaEklendi > 0)//Eklenen dosya varsa...
                    {
                        uyari.Goster("Onay", "Seçilen dosyalar listelere eklendi.", "DOSYALAR EKLENDİ");
                        SesliUyari.Oynat(17, seslendirmeUyariveHataAcikmi, seslendirmeUyariveHataSesi);
                        dosyaEklendi = 0;
                    }
                    else // Eklenen dosya yoksa...
                    {
                        uyari.Goster("Uyari", "Hiç bir dosya bulunamadı.", "DOSYA BULUNAMADI");
                        //SesliUyari.Oynat(19, seslendirmeUyariveHataAcikmi, seslendirmeUyariveHataSesi);
                    }
                }
                else //Desteklenmeyen dosya varsa
                {
                    uyari.Goster("Uyari", "Desteklenmeyen bazı (" + dosyaHatasi.ToString() + ") dosyalar listeye eklenemedi.", "UYARI");
                    dosyaHatasi = 0;
                    SesliUyari.Oynat(18, seslendirmeUyariveHataAcikmi, seslendirmeUyariveHataSesi);
                }
            }
            else
            {
                backgroundCompletedEventCancel = true;
            }
            
        }
        #endregion BackGroundWorker Liste Oluştur

        public IWMPPlaylist tumListe;

       
        #region Kontrol labelleri sanatçı ve şarkı ismi

        private void kontolEtiketleriniAyarla()
        {
            button_KontrolOynat.Visible = false;
            button_KontrolDurdur.Visible = true;
            label_SanatciAdi.Text = axWindowsMediaPlayer1.currentMedia.getItemInfo("Title").ToString();
            label_ParcaAdi.Text = axWindowsMediaPlayer1.currentMedia.name;
            trackBar_Oynat.Maximum = Convert.ToInt16(axWindowsMediaPlayer1.currentMedia.duration);
        }

        #endregion Kontrol labelleri sanatçı ve şarkı ismi

        #region Listeleri Oluştur
        public void ListeleriOlustur()
        {
            
            /* Albüm ve Sanatçı listeleri oluşturuluyor.*/
            //uyari.Goster("Uyari", "Albüm ve Sanatçı Listeleri Oluşturuluyor...", "Dosyalar Ekleniyor...");
            ListeGrup lg = new ListeGrup(); //Yeni bir listeleme grubu oluşturuluyor.
            listView_Album.Items.Clear(); //Albüm listView temizleniyor.
            listView_Sanatci.Items.Clear(); //Sanatçı listView temizleniyor.
            foreach (ListViewItem item in listView_Tum_Liste.Items) //Tüm listesindeki satır kadar döngüye giriliyor.
            {
                lg.Ekle(item.SubItems[3].Text);//Tüm listesindeki parçaların dizinleri, ilgili sütundan alınarak listeleme grubu nesnesine gönderiliyor.
                listView_Album.Items.Add(lg.Bilgi(item.Index, new[] { "Album", "Sanatci", "DosyaAdi", "Sure", "Dizin" }));//Listeleme grubu nesnesinin dataTablesindeki satır nosu ve istenen bilgiler girilerek, Item olarak döndürülüyor ve Album ListViewine Item olarak ekleniyor. 
                listView_Sanatci.Items.Add(lg.Bilgi(item.Index, new[] { "Sanatci", "DosyaAdi", "Sure", "Dizin" }));//Listeleme grubu nesnesinin dataTablesindeki satır nosu ve istenen bilgiler girilerek, Item olarak döndürülüyor ve Sanatçı ListViewine Item olarak ekleniyor. 
            }


            /* Müzik listesi oluşturuluyor.*/
            //uyari.Goster("Uyari", "Müzik Listesi Oluşturuluyor...", "Dosyalar Ekleniyor...");
            ListeGrup lg_m = new ListeGrup(); //Yeni bir listeleme grubu oluşturuluyor.
            foreach (ListViewItem item in listView_Tum_Liste.Items) //Tüm listesindeki satır kadar döngüye giriliyor.
            {
                lg_m.Ekle(item.SubItems[3].Text);//Tüm listesindeki parçaların dizinleri, ilgili sütundan alınarak listeleme grubu nesnesine gönderiliyor.
            }
            listView_Muzik.Items.Clear(); //Müzik listesi temizleniyor.

            lg_m.Sorgu(new[] { ".mp3", ".wma", ".wav", ".amr" }); //Nesne içindeki sorgu tablosu hazırlanıyor.

            List<ListViewItem> l_m = lg_m.SorguBilgi(new[] { "DosyaAdi", "Sure", "Sanatci", "Album", "Dizin" });
                if (l_m != null)//Gelen Item null değer içeriyorsa listviewe ekleme.
                {
                    listView_Muzik.Items.AddRange(l_m.ToArray());
                }

            lg_m.sil("Sorgu"); //Sorgu tablosu boşaltılıyor.


            /* Video listesi oluşturuluyor.*/
            //uyari.Goster("Uyari", "Video Listesi Oluşturuluyor...", "Dosyalar Ekleniyor...");
            ListeGrup lg_v = new ListeGrup(); //Yeni bir listeleme grubu oluşturuluyor.
            foreach (ListViewItem item in listView_Tum_Liste.Items) //Tüm listesindeki satır kadar döngüye giriliyor.
            {
                lg_v.Ekle(item.SubItems[3].Text);//Tüm listesindeki parçaların dizinleri, ilgili sütundan alınarak listeleme grubu nesnesine gönderiliyor.
            }
            listView_Video.Items.Clear(); //Müzik listesi temizleniyor.
            lg_v.Sorgu(new[] { ".mp4", ".avi", ".mpg", ".mpeg", ".wmv" }); //Nesne içindeki sorgu tablosu hazırlanıyor.

                List<ListViewItem> l_v = lg_v.SorguBilgi(new[] { "DosyaAdi", "Sure", "Dizin", "Album" });
                if (l_v != null)//Gelen Item null değer içeriyorsa listviewe ekleme.
                {
                    listView_Video.Items.AddRange(l_v.ToArray());
                }
            int ff = 0;
            lg_v.sil(); //Bütün tablolar boşaltılıyor.
            //lg_v.deneme();
        }
        #endregion Listeleri Oluştur
        #region Listeden Oynat

        private void tumListedenEnter()
        {
            tumListe = axWindowsMediaPlayer1.playlistCollection.newPlaylist("Tüm Liste"); //Yeni playlist oluşturuluyor.
            axWindowsMediaPlayer1.Ctlcontrols.stop();// MediaPlayer nesnesi çalıyor olma ihtimaline karşı durduruluyor.

            foreach (ListViewItem pl in listView_Tum_Liste.Items) //Tüm listenin olduğu listview satır sayısı kadar döngüye giriliyor.
            {
                IWMPMedia media = axWindowsMediaPlayer1.newMedia(pl.SubItems[3].Text); //Yeni media nesnesi oluşturuluyor ve listview.itemin ilgili sütunundan url alınıyor.
                tumListe.appendItem(media); //Oluşturulan medya "Tüm Listeye" ekleniyor.
            }

            int sn = listView_Tum_Liste.SelectedItems[0].Index;

            axWindowsMediaPlayer1.currentPlaylist = tumListe; //"Tüm Liste" mediaPlayera ekleniyor.
            //axWindowsMediaPlayer1.URL = listView_Tum_Liste.SelectedItems[0].SubItems[3].Text; //Seçilen satırın 4. sırasındaki (konum) hücresi.
            //axWindowsMediaPlayer1.URL = axWindowsMediaPlayer1.currentPlaylist.Item[sn].sourceURL;
            axWindowsMediaPlayer1.Ctlcontrols.playItem(axWindowsMediaPlayer1.currentPlaylist.get_Item(sn));// Oynat
            mpTabControl_Ana_Menu.SelectedIndex = 3;//Oynatma sekmesini aç.
            kontolEtiketleriniAyarla();//Player altındaki sanatçı ve albüm ismini değiştirir.
        }

        private void listedenOynat(ListView liste, int dizinhangiSutunda, int secilenSatir)
        {

            tumListe = axWindowsMediaPlayer1.playlistCollection.newPlaylist("Liste"); //Yeni playlist oluşturuluyor.
            axWindowsMediaPlayer1.Ctlcontrols.stop();// MediaPlayer nesnesi çalıyor olma ihtimaline karşı durduruluyor.
            
            foreach (ListViewItem item in liste.Items) //Albüm listesinin olduğu listview satır sayısı kadar döngüye giriliyor.
             {
                    IWMPMedia media = axWindowsMediaPlayer1.newMedia(item.SubItems[dizinhangiSutunda].Text); //Yeni media nesnesi oluşturuluyor ve listview.itemin ilgili sütunundan url alınıyor.
                    tumListe.appendItem(media); //Oluşturulan medya "Playliste" ekleniyor.
             }

            //int sn = listView_Album.SelectedItems[0].Index; // Tıklanan parçanın numarası tutuluyor, oynatmaya bu parçadan başlanacak.
            try
            {
                axWindowsMediaPlayer1.currentPlaylist = tumListe; //"Albüm listesi" mediaPlayera ekleniyor.
                axWindowsMediaPlayer1.Ctlcontrols.playItem(axWindowsMediaPlayer1.currentPlaylist.get_Item(secilenSatir));// Oynat
                mpTabControl_Ana_Menu.SelectedIndex = 3;//Oynatma sekmesini aç.
                kontolEtiketleriniAyarla();//Player altındaki sanatçı ve albüm ismini değiştirir.
            }
            catch (Exception)
            {
            }
        }

        #endregion Listeden Oynat
        #region Listeden Sil
        private void tumListesindenSil() // Tum Listesinden gerekli satırı silip, sonraki seçilecek satırı belirler.
        {
            if (listView_Tum_Liste.Items.Count > 0 && listView_Tum_Liste.SelectedItems.Count > 0) // Listede yüklü item varsa...
            {
                int si = listView_Tum_Liste.SelectedItems[0].Index; // Silinecek olan seçili itemin indexi alınıyor.
                listView_Tum_Liste.SelectedItems[0].Remove(); // Seçili item siliniyor.

                List<ListViewItem> itemList = new List<ListViewItem>();
                int sonSiraNo = -1;
                foreach (ListViewItem dosyaYolu in listView_Tum_Liste.Items)//Seçilen dosya kadar döngüye giriliyor.
                {
                    Listele Item = new Listele();// Yeni ListView Itemi oluşturuluyor.
                    itemList.Add(Item.klasorden_Listele(sonSiraNo += 1, dosyaYolu.SubItems[3].Text)); //ilksıradaki itemitem listineekleniyor.
                    listView_Tum_Liste.Items.Remove(dosyaYolu); // Okunan satırsiliniyor.
                }

                listView_Tum_Liste.Items.AddRange(itemList.ToArray()); //Oluşturulan Item listesi tüm liste listViewine ekleniyor.
                                                                       //backgroundCompletedEventCancel = false; // Uyarılar gösterilmesin
                                                                       //backgroundWorker_ListeOlustur.RunWorkerAsync();//Listeler Oluşturuluyor.
                if (listView_Tum_Liste.Items.Count == 0) // Listede item kalmadıysa..
                {
                    //Birşey yapma.
                }
                else if (listView_Tum_Liste.Items.Count < si + 1) //Listedeki item sayısı seçilen indexten az ise...
                {
                    //listView_Tum_Liste.Sorting = SortOrder.Ascending;
                    //listView_Tum_Liste.Sort();
                    listView_Tum_Liste.Focus();
                    listView_Tum_Liste.Select();
                    listView_Tum_Liste.Items[si - 1].Focused = true;
                    listView_Tum_Liste.Items[si - 1].Selected = true; // Tıklanan sırayı tekrar seç.
                }
                else if (listView_Tum_Liste.Items.Count >= si + 1) //Listedeki item sayısı seçilen indexten fazla yada eşit ise...
                {
                    //listView_Tum_Liste.Sorting = SortOrder.Ascending;
                    //listView_Tum_Liste.Sort();
                    listView_Tum_Liste.Focus();
                    listView_Tum_Liste.Select();
                    listView_Tum_Liste.Items[si].Focused = true;
                    listView_Tum_Liste.Items[si].Selected = true; // Bir önceki itemi seç.
                }
            }
        }

        
        #endregion Listeden Sil
        #region Listeler Çift Tıklama Olayı
        #region Tüm Liste Çift Tıklama
        private void listView_Tum_Liste_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tumListedenEnter();
        }
        #endregion Tüm Liste Çift Tıklama
        
        #region Albüm Listesi Çift Tıklama
        private void listView_Album_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listedenOynat(listView_Album, 4, listView_Album.SelectedItems[0].Index);
            //tumListe = axWindowsMediaPlayer1.playlistCollection.newPlaylist("Albüm Listesi"); //Yeni playlist oluşturuluyor.
            //axWindowsMediaPlayer1.Ctlcontrols.stop();// MediaPlayer nesnesi çalıyor olma ihtimaline karşı durduruluyor.

            //foreach (ListViewItem pl in listView_Album.Items) //Albüm listesinin olduğu listview satır sayısı kadar döngüye giriliyor.
            //{
            //    IWMPMedia media = axWindowsMediaPlayer1.newMedia(pl.SubItems[4].Text); //Yeni media nesnesi oluşturuluyor ve listview.itemin ilgili sütunundan url alınıyor.
            //    tumListe.appendItem(media); //Oluşturulan medya "Tüm Listeye" ekleniyor.
            //}

            //int sn = listView_Album.SelectedItems[0].Index; // Tıklanan parçanın numarası tutuluyor, oynatmaya bu parçadan başlanacak.
            //axWindowsMediaPlayer1.currentPlaylist = tumListe; //"Albüm listesi" mediaPlayera ekleniyor.
            //axWindowsMediaPlayer1.Ctlcontrols.playItem(axWindowsMediaPlayer1.currentPlaylist.get_Item(sn));// Oynat
            //mpTabControl_Ana_Menu.SelectedIndex = 3;//Oynatma sekmesini aç.
            //kontolEtiketleriniAyarla();//Player altındaki sanatçı ve albüm ismini değiştirir.
        }
        #endregion Albüm Listesi Çift Tıklama
        
        #region Sanatçı Listesi Çift Tıklama
        private void listView_Sanatci_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listedenOynat(listView_Sanatci, 3, listView_Sanatci.SelectedItems[0].Index);
            //axWindowsMediaPlayer1.Ctlcontrols.stop();
            //ListView_to_Playlist pl = new ListView_to_Playlist(listView_Sanatci, 3, "Sanatçı Listesi", listView_Sanatci.SelectedItems[0].Index); //Yeni playlist oluşturuluyor.
            //axWindowsMediaPlayer1.currentPlaylist = pl.Playlist(); //"Playlist" mediaPlayera ekleniyor.
            //axWindowsMediaPlayer1.Ctlcontrols.playItem(axWindowsMediaPlayer1.currentPlaylist.get_Item(pl.Secilen()));// Oynat
            ////pl.sil(); //Playlist siliniyor.
            //mpTabControl_Ana_Menu.SelectedIndex = 3;//Oynatma sekmesini aç.
            ////kontolEtiketleriniAyarla();//Player altındaki sanatçı ve albüm ismini değiştirir.
        }
        #endregion Sanatçı Listesi Çift Tıklama
        
        #region Müzik Listesi Çift Tıklama
        private void listView_Muzik_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listedenOynat(listView_Muzik, 5, listView_Muzik.SelectedItems[0].Index);
        }
        #endregion Müzik Listesi Çift Tıklama
        
        #region Video Listesi Çift Tıklama
        private void listView_Video_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listedenOynat(listView_Video, 3, listView_Video.SelectedItems[0].Index);
        }
        #endregion Video Listesi Çift Tıklama
        #endregion Listeler Çift Tıklama Olayı
        #region Listeler KeyDown
        private void listView_Tum_Liste_KeyDown(object sender, KeyEventArgs e)
        {
            if (listView_Tum_Liste.Items.Count > 0 && listView_Tum_Liste.SelectedItems.Count > 0) // Listede yüklü item varsa...
            {
                switch (e.KeyCode)
                {
                    case Keys.Delete:
                        tumListesindenSil();
                        break;
                    case Keys.Enter:
                        tumListedenEnter();
                        break;
                    case Keys.Space:
                        tumListedenEnter();
                        break;
                    default:
                        break;
                }
            }
        }

        private void listView_Album_KeyDown(object sender, KeyEventArgs e)
        {
            if (listView_Album.Items.Count > 0 && listView_Album.SelectedItems.Count > 0) // Listede yüklü item varsa...
            {
                switch (e.KeyCode)
                {
                    case Keys.Delete:
                        listView_Album.SelectedItems[0].Remove();
                        break;
                    case Keys.Enter:
                        listedenOynat(listView_Album, 4, listView_Album.SelectedItems[0].Index);
                        break;
                    case Keys.Space:
                        listedenOynat(listView_Album, 4, listView_Album.SelectedItems[0].Index);
                        break;
                    default:
                        break;
                }

                int si = listView_Album.SelectedItems[0].Index; // Silinecek olan seçili itemin indexi alınıyor.

                //if (e.KeyValue == 46) //DEL tuşuna basıldıysa.
                //{
                //    listView_Album.SelectedItems[0].Remove(); // Seçili item siliniyor.
                //}

                if (listView_Album.Items.Count == 0) // Listede item kalmadıysa..
                {
                    //Birşey yapma.
                }
                else if (listView_Album.Items.Count < si + 1) //Listedeki item sayısı seçilen indexten az ise...
                {
                    listView_Album.Items[si - 1].Selected = true; // Tıklanan sırayı tekrar seç.
                }
                else if (listView_Album.Items.Count >= si + 1) //Listedeki item sayısı seçilen indexten fazla yada eşit ise...
                {
                    listView_Album.Items[si].Selected = true; // Bir önceki itemi seç.
                }
            }
        }

        private void listView_Sanatci_KeyDown(object sender, KeyEventArgs e)
        {
            if (listView_Sanatci.Items.Count > 0 && listView_Sanatci.SelectedItems.Count > 0) // Listede yüklü item varsa...
            {
                switch (e.KeyCode)
                {
                    case Keys.Delete:
                        listView_Sanatci.SelectedItems[0].Remove();
                        break;
                    case Keys.Enter:
                        listedenOynat(listView_Sanatci, 3, listView_Sanatci.SelectedItems[0].Index);
                        break;
                    case Keys.Space:
                        listedenOynat(listView_Sanatci, 3, listView_Sanatci.SelectedItems[0].Index);
                        break;
                    default:
                        break;
                }

                int si = listView_Sanatci.SelectedItems[0].Index; // Silinecek olan seçili itemin indexi alınıyor.

                //if (e.KeyValue == 46) //DEL tuşuna basıldıysa.
                //{
                //    listView_Sanatci.SelectedItems[0].Remove(); // Seçili item siliniyor.
                //}

                if (listView_Sanatci.Items.Count == 0) // Listede item kalmadıysa..
                {
                    //Birşey yapma.
                }
                else if (listView_Sanatci.Items.Count < si + 1) //Listedeki item sayısı seçilen indexten az ise...
                {
                    listView_Sanatci.Items[si - 1].Selected = true; // Tıklanan sırayı tekrar seç.
                }
                else if (listView_Sanatci.Items.Count >= si + 1) //Listedeki item sayısı seçilen indexten fazla yada eşit ise...
                {
                    listView_Sanatci.Items[si].Selected = true; // Bir önceki itemi seç.
                }
            }
        }

        private void listView_Muzik_KeyDown(object sender, KeyEventArgs e)
        {
            if (listView_Muzik.Items.Count > 0 && listView_Muzik.SelectedItems.Count > 0) // Listede yüklü item varsa...
            {
                switch (e.KeyCode)
                {
                    case Keys.Delete:
                        listView_Muzik.SelectedItems[0].Remove();
                        break;
                    case Keys.Enter:
                        listedenOynat(listView_Muzik, 5, listView_Muzik.SelectedItems[0].Index);
                        break;
                    case Keys.Space:
                        listedenOynat(listView_Muzik, 5, listView_Muzik.SelectedItems[0].Index);
                        break;
                    default:
                        break;
                }

                int si = listView_Muzik.SelectedItems[0].Index; // Silinecek olan seçili itemin indexi alınıyor.

                //if (e.KeyValue == 46) //DEL tuşuna basıldıysa.
                //{
                //    listView_Muzik.SelectedItems[0].Remove(); // Seçili item siliniyor.
                //}

                if (listView_Muzik.Items.Count == 0) // Listede item kalmadıysa..
                {
                    //Birşey yapma.
                }
                else if (listView_Muzik.Items.Count < si + 1) //Listedeki item sayısı seçilen indexten az ise...
                {
                    listView_Muzik.Items[si - 1].Selected = true; // Tıklanan sırayı tekrar seç.
                }
                else if (listView_Muzik.Items.Count >= si + 1) //Listedeki item sayısı seçilen indexten fazla yada eşit ise...
                {
                    listView_Muzik.Items[si].Selected = true; // Bir önceki itemi seç.
                }
            }
        }

        private void listView_Video_KeyDown(object sender, KeyEventArgs e)
        {
            if (listView_Video.Items.Count > 0 && listView_Video.SelectedItems.Count > 0) // Listede yüklü item varsa...
            {
                switch (e.KeyCode)
                {
                    case Keys.Delete:
                        listView_Video.SelectedItems[0].Remove();
                        break;
                    case Keys.Enter:
                        listedenOynat(listView_Video, 3, listView_Video.SelectedItems[0].Index);
                        break;
                    case Keys.Space:
                        listedenOynat(listView_Video, 3, listView_Video.SelectedItems[0].Index);
                        break;
                    default:
                        break;
                }

                int si = listView_Video.SelectedItems[0].Index; // Silinecek olan seçili itemin indexi alınıyor.

                //if (e.KeyValue == 46) //DEL tuşuna basıldıysa.
                //{
                //    listView_Video.SelectedItems[0].Remove(); // Seçili item siliniyor.
                //}

                if (listView_Video.Items.Count == 0) // Listede item kalmadıysa..
                {
                    //Birşey yapma.
                }
                else if (listView_Video.Items.Count < si + 1) //Listedeki item sayısı seçilen indexten az ise...
                {
                    listView_Video.Items[si - 1].Selected = true; // Tıklanan sırayı tekrar seç.
                }
                else if (listView_Video.Items.Count >= si + 1) //Listedeki item sayısı seçilen indexten fazla yada eşit ise...
                {
                    listView_Video.Items[si].Selected = true; // Bir önceki itemi seç.
                }
            }
        }
        #endregion Listeler KeyDown

        #region Sil Butonu
        private void mpButon_Sil_Click(object sender, EventArgs e)
        {
            tumListesindenSil();
        }
        #endregion Sil Butonu

        #region axMediaPlayer Events
        #region axMediaPlayer Mevcut Medyadaki Değişim
        private void axWindowsMediaPlayer1_CurrentItemChange(object sender, AxWMPLib._WMPOCXEvents_CurrentItemChangeEvent e)
        {
            kontolEtiketleriniAyarla();//Player altındaki sanatçı ve albüm ismini değiştirir.
            //listView_Tum_Liste.Focus();
            //listView_Tum_Liste.Items[???].Selected=true;
        }
        #endregion axMediaPlayer Mevcut Medyadaki Değişim
        #endregion axMediaPlayer Events

        #region Kontrol butonları resimleri

        private void button_KontrolGeri_MouseMove(object sender, MouseEventArgs e)
        {
            button_KontrolGeri.BackgroundImage = Properties.Resources.geri_ust;
        }

        private void button_KontrolGeri_MouseLeave(object sender, EventArgs e)
        {
            button_KontrolGeri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_KontrolGeri.BackgroundImage")));
        }

        private void button_KontrolOynat_MouseMove(object sender, MouseEventArgs e)
        {
            button_KontrolOynat.BackgroundImage = Properties.Resources.oynat_ust;
        }

        private void button_KontrolOynat_MouseLeave(object sender, EventArgs e)
        {
            //button_KontrolOynat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_KontrolOynat.BackgroundImage")));
            button_KontrolOynat.BackgroundImage = Properties.Resources.oynat;
        }

        private void button_Kontrolileri_MouseMove(object sender, MouseEventArgs e)
        {
            button_Kontrolileri.BackgroundImage = Properties.Resources.ileri_ust;
        }

        private void button_Kontrolileri_MouseLeave(object sender, EventArgs e)
        {
            button_Kontrolileri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Kontrolileri.BackgroundImage")));
        }

        private void button_KontrolDurdur_MouseMove(object sender, MouseEventArgs e)
        {
            button_KontrolDurdur.BackgroundImage = Properties.Resources.durdur_ust;
        }

        private void button_KontrolDurdur_MouseLeave(object sender, EventArgs e)
        {
            //button_KontrolDurdur.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_KontrolDurdur.BackgroundImage")));
            button_KontrolDurdur.BackgroundImage = Properties.Resources.durdur;
        }

        private void button_KontrolDur_MouseMove(object sender, MouseEventArgs e)
        {
            button_KontrolDur.BackgroundImage = Properties.Resources.dur_ust;
        }

        private void button_KontrolDur_MouseLeave(object sender, EventArgs e)
        {
            button_KontrolDur.BackgroundImage = Properties.Resources.dur;
        }

        #endregion Kontrol butonları resimleri
        #region MediaPlayer Kontrolleri

        private void button_KontrolOynat_Click(object sender, EventArgs e)
        {
            seslendir.Durdur();
            if (axWindowsMediaPlayer1.currentPlaylist.count != 0)//Çalma listesi yüklü değilse durdur butonunu gösterme.
            {
                button_KontrolOynat.Visible = false;
                button_KontrolDurdur.Visible = true;
                axWindowsMediaPlayer1.Ctlcontrols.play();// Oynat
            }
            seslendir.Durdur();
        }

        private void button_KontrolDurdur_Click(object sender, EventArgs e)
        {
            seslendir.Durdur();
            button_KontrolDurdur.Visible = false;
            button_KontrolOynat.Visible = true;
            axWindowsMediaPlayer1.Ctlcontrols.pause();// Duraklat
            seslendir.Durdur();
        }

        private void button_Kontrolileri_Click(object sender, EventArgs e)
        {
            seslendir.Durdur();
            if (axWindowsMediaPlayer1.currentPlaylist.count != 0)//Çalma listesi yüklü değilse durdur butonunu gösterme.
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();//Dur
                axWindowsMediaPlayer1.Ctlcontrols.next();// Sonraki parça
                axWindowsMediaPlayer1.Ctlcontrols.play();//Oynat
                button_KontrolOynat.Visible = false;
                button_KontrolDurdur.Visible = true;
            }
        }

        private void button_KontrolGeri_Click(object sender, EventArgs e)
        {
            seslendir.Durdur();
            if (axWindowsMediaPlayer1.currentPlaylist.count != 0)//Çalma listesi yüklü değilse durdur butonunu gösterme.
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();//Dur
                axWindowsMediaPlayer1.Ctlcontrols.previous();// Önceki parça.
                axWindowsMediaPlayer1.Ctlcontrols.play();//Oynat
                button_KontrolOynat.Visible = false;
                button_KontrolDurdur.Visible = true;
            }
        }

        private void button_KontrolDur_Click(object sender, EventArgs e)
        {
            seslendir.Durdur();
            button_KontrolOynat.Visible = true;
            button_KontrolDurdur.Visible = false;
            axWindowsMediaPlayer1.Ctlcontrols.stop();// Durdur.
        }

        private void trackBar_Ses_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = trackBar_Ses.Value;
        }
        private void trackBar_Oynat_MouseUp(object sender, MouseEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = trackBar_Oynat.Value;
            label_Zaman.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
            mpTabControl_Ana_Menu.SelectedTab.Focus();
            //trackBar_Ses.Focus(); //İlerleme çubuğu etrafındaki seçim alanını kaldırmak için ses seviyesi çubuğu seçiliyor.
        }

        int zamanGosterimModeli = 0; // Zaman  gösterge labelinde hangi zaman türünün gösterileceğini belirler. 0=Geçen Süre, 1=Kalan Süre.
        private void label_Zaman_Click(object sender, EventArgs e)
        {
            if (zamanGosterimModeli < 1)
            {
                zamanGosterimModeli = 1; //Kalan süre gösterilecek.
            }
            else
            {
                zamanGosterimModeli = 0; //Geçen Süre gösterilecek.
            }
        }

        private void timer_OynatmaZamani_Tick(object sender, EventArgs e) // İlerleme çubuğunu ve zaman labelini işleyen timer.
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying) //Player çalışıyorsa...
            {
                trackBar_Oynat.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition; // İlerleme çubuğunu, medyanın o anki süresine getir.

                if (zamanGosterimModeli == 0)
                {
                    label_Zaman.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString; // Labelde medyanın o anki zamanını göster.
                }
                else if (zamanGosterimModeli == 1)
                {
                    label_Zaman.Text = Math.Floor(axWindowsMediaPlayer1.currentMedia.duration - axWindowsMediaPlayer1.Ctlcontrols.currentPosition).ToString();// Labelde medyanın bitimine kalan zamanı göster.
                }

            }
        }
        #endregion MediaPlayer Kontrolleri
        #region MediaPlayer Events
        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {

            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                trackBar_Oynat.Maximum = (int)axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration;
                timer_OynatmaZamani.Start();
            }
            else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                timer_OynatmaZamani.Stop();
            }
            else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer_OynatmaZamani.Stop();
                trackBar_Oynat.Value = 0;
            }

        }

        private void Durdur(object sender, EventArgs e)
        {

        }
        #endregion MediaPlayer Events
        #region Uyarı Seslerini Dışa Aktar
        private void mp3DosyalariDisaAktar()
        {
            ResourceSet resourceSet = MediaPlayer.Sesler.ResourceManager.GetResourceSet(CultureInfo.CurrentUICulture, true, true);
            string sesDizini = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MediaPlayer\\Ses";

            try
            {
                if (!Directory.Exists(sesDizini))
                {
                    Directory.CreateDirectory(sesDizini);
                }
                foreach (DictionaryEntry dosya in resourceSet)
                {
                    if (!System.IO.File.Exists(sesDizini + "\\" + dosya.Key.ToString() + ".mp3"))
                    {
                        File.WriteAllBytes(sesDizini + "\\" + dosya.Key.ToString() + ".mp3", (byte[])dosya.Value);
                    }
                }
            }
            catch (Exception)
            {
            }
        }
        #endregion Uyarı Seslerini Dışa Aktar
        #region BackGroundWorker Uyarı Seslerini Dışa Aktar
        private void backgroundWorker_UyariSesleriOlustur_DoWork(object sender, DoWorkEventArgs e)
        {
            mp3DosyalariDisaAktar();
        }
        #endregion BackGroundWorker Uyarı Seslerini Dışa Aktar

        #region Seslendirme
        public BaslikveAciklama seslendir = new BaslikveAciklama();
        private void backgroundWorker_Seslendirme_DoWork(object sender, DoWorkEventArgs e)
        {
            seslendir.Durdur();
            string d = (string)e.Argument;
            seslendir.Oynat(d, seslendirmeBaslikAcikmi, seslendirmeAciklamaAcikmi, seslendirmeBaslikSesi, seslendirmeAciklamaSesi);
        }
        //Ana Menü tabları seçildiğinde
        private void mpTabControl_Ana_Menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            seslendir.Oynat(mpTabControl_Ana_Menu.SelectedTab.Name, seslendirmeBaslikAcikmi, seslendirmeAciklamaAcikmi, seslendirmeBaslikSesi, seslendirmeAciklamaSesi);
        }

        //Listelerin olduğu listview  tabları seçildiğinde
        private void mpTabControl_Listeler_SelectedIndexChanged(object sender, EventArgs e)
        {
            ses.SpeakAsyncCancelAll();
            seslendir.Durdur();
            SesliUyari.Durdur();
            seslendir.Oynat(mpTabControl_Listeler.SelectedTab.Name, seslendirmeBaslikAcikmi, seslendirmeAciklamaAcikmi, seslendirmeBaslikSesi, seslendirmeAciklamaSesi);
        }
        //Dosya Seç Butonu Seçildiğinde
        private void mpButon_Dosya_Ekle_Enter(object sender, EventArgs e)
        {
            seslendir.Durdur();
            SesliUyari.Oynat(8,seslendirmeUyariveHataAcikmi, seslendirmeUyariveHataSesi);
        }
        //Klasör Seç Butonu Seçildiğinde
        private void mpButon_Klasor_Ekle_Enter(object sender, EventArgs e)
        {
            SesliUyari.Durdur();
            seslendir.Durdur();
            SesliUyari.Oynat(5, seslendirmeUyariveHataAcikmi, seslendirmeUyariveHataSesi);
        }

        private void mpButon_Dosya_Ekle_Leave(object sender, EventArgs e)
        {
            SesliUyari.Durdur();
            seslendir.Oynat(mpTabControl_Listeler.SelectedTab.Name, seslendirmeBaslikAcikmi, seslendirmeAciklamaAcikmi, seslendirmeBaslikSesi, seslendirmeAciklamaSesi);
        }

        private void mpButon_Klasor_Ekle_Leave(object sender, EventArgs e)
        {
            /* Klasör ekle tuşundan çıkıldıktan sonra tüm listenin ilk satırının seçilmesi için*/
            if (listView_Tum_Liste.SelectedItems.Count > 0 && listView_Tum_Liste.Focused)
            {
                listView_Tum_Liste.Items[0].Focused = true;
                listView_Tum_Liste.Items[0].Selected = true;
            }
        }
        // Geri Butonu Seçildiğinde
        private void button_KontrolGeri_Enter(object sender, EventArgs e)
        {
            seslendir.Oynat("4", seslendirmeBaslikAcikmi, seslendirmeAciklamaAcikmi, seslendirmeBaslikSesi, seslendirmeAciklamaSesi);
        }
        // Stop butonu Seçildiğinde
        private void button_KontrolDur_Enter(object sender, EventArgs e)
        {
            seslendir.Oynat("1", seslendirmeBaslikAcikmi, seslendirmeAciklamaAcikmi, seslendirmeBaslikSesi, seslendirmeAciklamaSesi);
        }
        // Duraklat butonu Seçildiğinde
        private void button_KontrolDurdur_Enter(object sender, EventArgs e)
        {
            seslendir.Oynat("2", seslendirmeBaslikAcikmi, seslendirmeAciklamaAcikmi, seslendirmeBaslikSesi, seslendirmeAciklamaSesi);
        }
        // Oynat Butonu Seçildiğinde
        private void button_KontrolOynat_Enter(object sender, EventArgs e)
        {
            seslendir.Oynat("0", seslendirmeBaslikAcikmi, seslendirmeAciklamaAcikmi, seslendirmeBaslikSesi, seslendirmeAciklamaSesi);
        }
        // İleri Butonu Seçildiğinde
        private void button_Kontrolileri_Enter(object sender, EventArgs e)
        {
            seslendir.Oynat("3", seslendirmeBaslikAcikmi, seslendirmeAciklamaAcikmi, seslendirmeBaslikSesi, seslendirmeAciklamaSesi);
        }
        // Ses seviyesi Seçildiğinde
        private void trackBar_Ses_Enter(object sender, EventArgs e)
        {
            seslendir.Oynat("5", seslendirmeBaslikAcikmi, seslendirmeAciklamaAcikmi, seslendirmeBaslikSesi, seslendirmeAciklamaSesi);
        }
        // İlerleme çubuğu Seçildiğinde
        private void trackBar_Oynat_Enter(object sender, EventArgs e)
        {
            seslendir.Oynat("6", seslendirmeBaslikAcikmi, seslendirmeAciklamaAcikmi, seslendirmeBaslikSesi, seslendirmeAciklamaSesi);
        }
        // Başlık açıkmı Seçildiğinde
        private void checkBox_BaslikSesleri_Enter(object sender, EventArgs e)
        {
            checkBox_BaslikSesleri.Focus();
            if (checkBox_BaslikSesleri.Checked)
            {
                seslendir.Oynat("7", seslendirmeBaslikAcikmi, seslendirmeAciklamaAcikmi, seslendirmeBaslikSesi, seslendirmeAciklamaSesi);
            }
            else
            {
                seslendir.Oynat("8", seslendirmeBaslikAcikmi, seslendirmeAciklamaAcikmi, seslendirmeBaslikSesi, seslendirmeAciklamaSesi);
            }
        }
        // Başlık ses oranı Seçildiğinde
        private void trackBar_SeslendirmeBaslik_Enter(object sender, EventArgs e)
        {
            seslendir.Oynat("13", seslendirmeBaslikAcikmi, seslendirmeAciklamaAcikmi, seslendirmeBaslikSesi, seslendirmeAciklamaSesi);
        }
        // Açıklamar açık mı Seçildiğinde
        private void checkBox_AciklamaSesleri_Enter(object sender, EventArgs e)
        {
            checkBox_AciklamaSesleri.Focus();
            if (checkBox_AciklamaSesleri.Checked)
            {
                seslendir.Oynat("9", seslendirmeBaslikAcikmi, seslendirmeAciklamaAcikmi, seslendirmeBaslikSesi, seslendirmeAciklamaSesi);
            }
            else
            {
                seslendir.Oynat("10", seslendirmeBaslikAcikmi, seslendirmeAciklamaAcikmi, seslendirmeBaslikSesi, seslendirmeAciklamaSesi);
            }
        }
        // Açıklama ses oranı Seçildiğinde
        private void trackBar_SeslendirmeAciklama_Enter(object sender, EventArgs e)
        {
            seslendir.Oynat("14", seslendirmeBaslikAcikmi, seslendirmeAciklamaAcikmi, seslendirmeBaslikSesi, seslendirmeAciklamaSesi);
        }
        // Uyari ve hata açık mı Seçildiğinde
        private void checkBox_UyariveHataSesleri_Enter(object sender, EventArgs e)
        {
            checkBox_UyariveHataSesleri.Focus();
            if (checkBox_UyariveHataSesleri.Checked)
            {
                seslendir.Oynat("11", seslendirmeBaslikAcikmi, seslendirmeAciklamaAcikmi, seslendirmeBaslikSesi, seslendirmeAciklamaSesi);
            }
            else
            {
                seslendir.Oynat("12", seslendirmeBaslikAcikmi, seslendirmeAciklamaAcikmi, seslendirmeBaslikSesi, seslendirmeAciklamaSesi);
            }
        }
        // Uyarı ve hata ses oranı Seçildiğinde
        private void trackBar_SeslendirmeUyariveHata_Enter(object sender, EventArgs e)
        {
            seslendir.Oynat("15", seslendirmeBaslikAcikmi, seslendirmeAciklamaAcikmi, seslendirmeBaslikSesi, seslendirmeAciklamaSesi);
        }

        #endregion Seslendirme
        #region Seslendirme denetimleri
        private void checkBox_BaslikSesleri_CheckedChanged(object sender, EventArgs e)
        {
            seslendirmeBaslikAcikmi = checkBox_BaslikSesleri.Checked; //Başlık seslendirmelerinin kullanıcı tarafından tercihi tutuluyor.
            if (checkBox_BaslikSesleri.Checked)
            {
                seslendir.Oynat("7", seslendirmeBaslikAcikmi, seslendirmeAciklamaAcikmi, seslendirmeBaslikSesi, seslendirmeAciklamaSesi);
            }
            else
            {
                seslendir.Oynat("8", true, seslendirmeAciklamaAcikmi, seslendirmeBaslikSesi, seslendirmeAciklamaSesi);
            }

        }
        private void checkBox_AciklamaSesleri_CheckedChanged(object sender, EventArgs e)
        {
            seslendirmeAciklamaAcikmi = checkBox_AciklamaSesleri.Checked; //Açıklama seslendirmelerinin kullanıcı tarafından tercihi tutuluyor.
            if (checkBox_AciklamaSesleri.Checked)
            {
                seslendir.Oynat("9", seslendirmeBaslikAcikmi, seslendirmeAciklamaAcikmi, seslendirmeBaslikSesi, seslendirmeAciklamaSesi);
            }
            else
            {
                seslendir.Oynat("10", seslendirmeBaslikAcikmi, seslendirmeAciklamaAcikmi, seslendirmeBaslikSesi, seslendirmeAciklamaSesi);
            }
        }

        private void checkBox_UyariveHataSesleri_CheckedChanged(object sender, EventArgs e)
        {
            seslendirmeUyariveHataAcikmi = checkBox_UyariveHataSesleri.Checked; //Uyarı ve hata seslendirmelerinin kullanıcı tarafından tercihi tutuluyor.
            if (checkBox_UyariveHataSesleri.Checked)
            {
                seslendir.Oynat("11", seslendirmeBaslikAcikmi, seslendirmeAciklamaAcikmi, seslendirmeBaslikSesi, seslendirmeAciklamaSesi);
            }
            else
            {
                seslendir.Oynat("12", seslendirmeBaslikAcikmi, seslendirmeAciklamaAcikmi, seslendirmeBaslikSesi, seslendirmeAciklamaSesi);
            }
        }

        private void trackBar_SeslendirmeBaslik_Scroll(object sender, EventArgs e)
        {
            seslendirmeBaslikSesi = trackBar_SeslendirmeBaslik.Value; //Başlık seslendirmelerinin ses ayarı.
            seslendir.Oynat("13", seslendirmeBaslikAcikmi, seslendirmeAciklamaAcikmi, seslendirmeBaslikSesi, seslendirmeAciklamaSesi);
        }

        private void trackBar_SeslendirmeAciklama_Scroll(object sender, EventArgs e)
        {
            seslendirmeAciklamaSesi = trackBar_SeslendirmeAciklama.Value; //Açıklama seslendirmelerinin ses ayarı.
            seslendir.Oynat("14", seslendirmeBaslikAcikmi, seslendirmeAciklamaAcikmi, seslendirmeAciklamaSesi, seslendirmeAciklamaSesi);

        }
        private void trackBar_SeslendirmeUyariveHata_Scroll(object sender, EventArgs e)
        {
            seslendirmeUyariveHataSesi = trackBar_SeslendirmeUyariveHata.Value; //Uyarı ve hata seslendirmelerinin ses ayarı.
            seslendir.Oynat("15", seslendirmeBaslikAcikmi, seslendirmeAciklamaAcikmi, seslendirmeUyariveHataSesi, seslendirmeAciklamaSesi);
        }
        #endregion Seslendirme denetimleri

        #region Kontroller seçildiğinde - çıkıldığında

        private void tabPage_Oynat_Enter(object sender, EventArgs e)
        {
            seslendir.Oynat(mpTabControl_Ana_Menu.SelectedTab.Name, seslendirmeBaslikAcikmi, seslendirmeAciklamaAcikmi, seslendirmeBaslikSesi, seslendirmeAciklamaSesi);
        }

        private void mpTabControl_Ana_Menu_Enter(object sender, EventArgs e)
        {

            //ilk açılışta okunacak.

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/firatsyg/MediaPlayer");
        }

        private void trackBar_Ses_Leave(object sender, EventArgs e)
        {
            seslendir.Oynat(mpTabControl_Ana_Menu.SelectedTab.Name, seslendirmeBaslikAcikmi, seslendirmeAciklamaAcikmi, seslendirmeBaslikSesi, seslendirmeAciklamaSesi);
        }

        private void listView_Muzik_Leave(object sender, EventArgs e)
        {
            ses.SpeakAsyncCancelAll();
            seslendir.Oynat(mpTabControl_Ana_Menu.SelectedTab.Name, seslendirmeBaslikAcikmi, seslendirmeAciklamaAcikmi, seslendirmeBaslikSesi, seslendirmeAciklamaSesi);
        }

        private void listView_Video_Leave(object sender, EventArgs e)
        {
            ses.SpeakAsyncCancelAll();
            seslendir.Oynat(mpTabControl_Ana_Menu.SelectedTab.Name, seslendirmeBaslikAcikmi, seslendirmeAciklamaAcikmi, seslendirmeBaslikSesi, seslendirmeAciklamaSesi);
        }

        private void checkBox_BaslikSesleri_Leave(object sender, EventArgs e)
        {
            seslendir.Oynat(mpTabControl_Ana_Menu.SelectedTab.Name, seslendirmeBaslikAcikmi, seslendirmeAciklamaAcikmi, seslendirmeBaslikSesi, seslendirmeAciklamaSesi);
        }

        private void listView_Tum_Liste_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_Tum_Liste.SelectedItems.Count > 0)
            {
                seslendir.Durdur();
                ses.SpeakAsyncCancelAll();
                ses.SpeakAsync(listView_Tum_Liste.SelectedItems[0].SubItems[1].Text);
            }
        }

        private void listView_Tum_Liste_Enter(object sender, EventArgs e)
        {
            SesliUyari.Durdur();
            seslendir.Durdur();
            if (listView_Tum_Liste.Items.Count > 0) // Listede yüklü item varsa...
            {
                //Tüm listenin ilk ögesi seçiliyor.
                listView_Tum_Liste.Items[0].Focused = true;
                listView_Tum_Liste.Items[0].Selected = true;

                if (listView_Tum_Liste.SelectedItems.Count > 0)
                {
                    ses.SpeakAsyncCancelAll();
                    ses.SpeakAsync(listView_Tum_Liste.SelectedItems[0].SubItems[1].Text);
                }
            }
            else if (listView_Tum_Liste.Items.Count < 1)
            {
                SesliUyari.Oynat(19, seslendirmeUyariveHataAcikmi, seslendirmeUyariveHataSesi);
            }
        }

        private void listView_Album_Enter(object sender, EventArgs e)
        {
            seslendir.Durdur();
            if (listView_Album.Items.Count > 0) // Listede yüklü item varsa...
            {
                //Albüm ilk ögesi seçiliyor.
                listView_Album.Items[0].Focused = true;
                listView_Album.Items[0].Selected = true;

                if (listView_Album.SelectedItems.Count > 0)
                {
                    ses.SpeakAsyncCancelAll();
                    ses.SpeakAsync(listView_Album.SelectedItems[0].SubItems[0].Text + listView_Album.SelectedItems[0].SubItems[1].Text + listView_Album.SelectedItems[0].SubItems[2].Text);
                }
            }
            else if (listView_Album.Items.Count < 1)
            {
                SesliUyari.Oynat(19, seslendirmeUyariveHataAcikmi, seslendirmeUyariveHataSesi);
            }
        }

        private void listView_Sanatci_Enter(object sender, EventArgs e)
        {
            seslendir.Durdur();
            if (listView_Sanatci.Items.Count > 0) // Listede yüklü item varsa...
            {
                //Sanatci ilk ögesi seçiliyor.
                listView_Sanatci.Items[0].Focused = true;
                listView_Sanatci.Items[0].Selected = true;

                if (listView_Sanatci.SelectedItems.Count > 0)
                {
                    ses.SpeakAsyncCancelAll();
                    ses.SpeakAsync(listView_Sanatci.SelectedItems[0].SubItems[0].Text + listView_Sanatci.SelectedItems[0].SubItems[1].Text);
                }
            }
            else if (listView_Sanatci.Items.Count < 1)
            {
                SesliUyari.Oynat(19, seslendirmeUyariveHataAcikmi, seslendirmeUyariveHataSesi);
            }
        }

        private void listView_Muzik_Enter(object sender, EventArgs e)
        {
            seslendir.Durdur();
            if (listView_Muzik.Items.Count > 0) // Listede yüklü item varsa...
            {
                //Muzik ilk ögesi seçiliyor.
                listView_Muzik.Items[0].Focused = true;
                listView_Muzik.Items[0].Selected = true;

                if (listView_Muzik.SelectedItems.Count > 0)
                {
                    ses.SpeakAsyncCancelAll();
                    ses.SpeakAsync(listView_Muzik.SelectedItems[0].SubItems[1].Text);
                }
            }
            else if (listView_Muzik.Items.Count < 1)
            {
                SesliUyari.Oynat(19, seslendirmeUyariveHataAcikmi, seslendirmeUyariveHataSesi);
            }
        }

        private void listView_Video_Enter(object sender, EventArgs e)
        {
            seslendir.Durdur();
            if (listView_Video.Items.Count > 0) // Listede yüklü item varsa...
            {
                //Muzik ilk ögesi seçiliyor.
                listView_Video.Items[0].Focused = true;
                listView_Video.Items[0].Selected = true;

                if (listView_Video.SelectedItems.Count > 0)
                {
                    ses.SpeakAsyncCancelAll();
                    ses.SpeakAsync(listView_Video.SelectedItems[0].SubItems[1].Text);
                }
            }
            else if (listView_Video.Items.Count < 1)
            {
                SesliUyari.Oynat(19, seslendirmeUyariveHataAcikmi, seslendirmeUyariveHataSesi);
            }
        }

        private void mpTabControl_Ana_Menu_Leave(object sender, EventArgs e)
        {
            listView_Muzik.Items[0].Focused = true;
            listView_Muzik.Items[0].Selected = true;
        }

        private void listView_Album_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_Album.SelectedItems.Count > 0)
            {
                seslendir.Durdur();
                ses.SpeakAsyncCancelAll();
                ses.SpeakAsync(listView_Album.SelectedItems[0].SubItems[0].Text + listView_Album.SelectedItems[0].SubItems[1].Text + listView_Album.SelectedItems[0].SubItems[2].Text);
            }
        }

        private void listView_Sanatci_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_Sanatci.SelectedItems.Count > 0)
            {
                seslendir.Durdur();
                ses.SpeakAsyncCancelAll();
                ses.SpeakAsync(listView_Sanatci.SelectedItems[0].SubItems[0].Text + listView_Sanatci.SelectedItems[0].SubItems[1].Text);
            }
        }

        private void listView_Muzik_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_Muzik.SelectedItems.Count > 0)
            {
                seslendir.Durdur();
                ses.SpeakAsyncCancelAll();
                ses.SpeakAsync(listView_Muzik.SelectedItems[0].SubItems[1].Text);
            }
        }

        private void tabPage_Tum_Listeler_Leave(object sender, EventArgs e)
        {
            /* Tab Conrolden çıkıldıktan sonra listelerin ilk satırının seçilmesi için*/
            if (listView_Tum_Liste.SelectedItems.Count > 0)
            {
                listView_Tum_Liste.Items[0].Focused = true;
                listView_Tum_Liste.Items[0].Selected = true;
            }
        }

        private void listView_Video_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_Video.SelectedItems.Count > 0)
            {
                seslendir.Durdur();
                ses.SpeakAsyncCancelAll();
                ses.SpeakAsync(listView_Video.SelectedItems[0].SubItems[1].Text);
            }
        }

        private void mpTabControl_Listeler_Selected(object sender, TabControlEventArgs e)
        {
            SesliUyari.Durdur();
            seslendir.Oynat(mpTabControl_Listeler.SelectedTab.Name, seslendirmeBaslikAcikmi, seslendirmeAciklamaAcikmi, seslendirmeBaslikSesi, seslendirmeAciklamaSesi);
        }


        private void mpTabControl_Listeler_Enter(object sender, EventArgs e)
        {
            seslendir.Durdur();
            SesliUyari.Durdur();
            seslendir.Oynat(mpTabControl_Listeler.SelectedTab.Name, seslendirmeBaslikAcikmi, seslendirmeAciklamaAcikmi, seslendirmeBaslikSesi, seslendirmeAciklamaSesi);
        }

        private void mpTabControl_Ana_Menu_Selected(object sender, TabControlEventArgs e)
        {
            seslendir.Oynat(mpTabControl_Ana_Menu.SelectedTab.Name, seslendirmeBaslikAcikmi, seslendirmeAciklamaAcikmi, seslendirmeBaslikSesi, seslendirmeAciklamaSesi);
        }

        private void checkBox_OkumaSesleri_CheckedChanged(object sender, EventArgs e)
        {
            seslendirmeKonusmaSesiAcikmi = checkBox_OkumaSesleri.Checked; //Konuşma seslendirmelerinin kullanıcı tarafından tercihi tutuluyor.
            if (checkBox_OkumaSesleri.Checked)
            {
                seslendir.Oynat("16", seslendirmeBaslikAcikmi, seslendirmeAciklamaAcikmi, seslendirmeBaslikSesi, seslendirmeAciklamaSesi);
            }
            else
            {
                seslendir.Oynat("17", seslendirmeBaslikAcikmi, seslendirmeAciklamaAcikmi, seslendirmeBaslikSesi, seslendirmeAciklamaSesi);
            }
        }

        private void trackBar_konusma_Leave(object sender, EventArgs e)
        {
            seslendir.Oynat(mpTabControl_Ana_Menu.SelectedTab.Name, seslendirmeBaslikAcikmi, seslendirmeAciklamaAcikmi, seslendirmeBaslikSesi, seslendirmeAciklamaSesi);
        }

        private void trackBar_konusma_Enter(object sender, EventArgs e)
        {
            ses.SpeakAsync("Konuşma ses seviyesi");
        }

        private void trackBar_Oynat_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = trackBar_Oynat.Value;
        }

        private void checkBox_OkumaSesleri_Enter(object sender, EventArgs e)
        {
            checkBox_OkumaSesleri.Focus();
            if (checkBox_OkumaSesleri.Checked)
            {
                seslendir.Oynat("16", seslendirmeBaslikAcikmi, seslendirmeAciklamaAcikmi, seslendirmeBaslikSesi, seslendirmeAciklamaSesi);
            }
            else
            {
                seslendir.Oynat("17", seslendirmeBaslikAcikmi, seslendirmeAciklamaAcikmi, seslendirmeBaslikSesi, seslendirmeAciklamaSesi);
            }
        }

        private void trackBar_konusma_Scroll(object sender, EventArgs e)
        {
            seslendirmeKonusmaSesi = trackBar_konusma.Value; //Konuşma seslendirmelerinin ses ayarı.
            ses.SpeakAsyncCancelAll();
            ses.Volume = seslendirmeKonusmaSesi;
            ses.SpeakAsync("Konuşma ses seviyesi");
        }

        private void mpTabControl_Listeler_Leave(object sender, EventArgs e)
        {
            seslendir.Oynat(mpTabControl_Ana_Menu.SelectedTab.Name, seslendirmeBaslikAcikmi, seslendirmeAciklamaAcikmi, seslendirmeBaslikSesi, seslendirmeAciklamaSesi);
        }


        private void listView_Tum_Liste_Leave(object sender, EventArgs e)
        {
            ses.SpeakAsyncCancelAll();
            SesliUyari.Durdur();
            //seslendir.Oynat(mpTabControl_Listeler.SelectedTab.Name, seslendirmeBaslikAcikmi, seslendirmeAciklamaAcikmi, seslendirmeBaslikSesi, seslendirmeAciklamaSesi);
            //tabPage_Album.Select();
            //SelectNextControl(tabPage_Album, true, true, true, false);
            //SelectNextControl(mpTabControl_Listeler., true, true, true, false);
            //mpTabControl_Listeler.SelectTab(0);
            //mpTabControl_Listeler.Focus();
            //tabPage_Tum_Listeler.Select();
            //mpTabControl_Listeler.SelectedIndex = 0;
            //tabPage_Tum_Listeler.Focus();
            //tabPage_Tum_Listeler.Select();
            //mpTabControl_Listeler.TabPages["tabPage_Tum_Listeler"].Focus();
            //mpTabControl_Listeler.TabPages["tabPage_Tum_Listeler"].Select();
            //tabPage_Tum_Listeler.SelectNextControl(mpTabControl_Listeler.TabPages[0], true, true, true, false);
            //tabPage_Tum_Listeler.SelectNextControl(mpTabControl_Listeler.TabPages["tabPage_Album"], true, false, true, true);
            //tabPage_Tum_Listeler.SelectNextControl(mpTabControl_Ana_Menu.Controls[0], true, true, true, true);
            //tabPage_Tum_Listeler.SelectNextControl(mpTabControl_Listeler, true, true, true, true);

            //if (nereden == "klasorSec")
            //{
            //    nereden = "";
            //    mpTabControl_Ana_Menu.Controls[0].Controls[0].Focus(); // Ana Menü tabcontrolü içindeki Listeler TabControle odaklanıyor.
            //    mpTabControl_Ana_Menu.Controls[0].Controls[0].Select(); // Ana Menü tabControlü içindeki Listeler TabControl seçiliyor.
            //    mpTabControl_Listeler.SelectedIndex = 0; // Listeler TabControlündeki Tüm Liste tabPage seçiliyor.
            //}


        }

        private void listView_Album_Leave(object sender, EventArgs e)
        {
            ses.SpeakAsyncCancelAll();
            seslendir.Oynat(mpTabControl_Listeler.SelectedTab.Name, seslendirmeBaslikAcikmi, seslendirmeAciklamaAcikmi, seslendirmeBaslikSesi, seslendirmeAciklamaSesi);
            mpTabControl_Ana_Menu.Controls[0].Controls[0].Focus();// Ana Menü tabcontrolü içindeki Listeler TabControle odaklanıyor.
            mpTabControl_Ana_Menu.Controls[0].Controls[0].Select();// Ana Menü tabControlü içindeki Listeler TabControl seçiliyor.
            mpTabControl_Listeler.SelectedIndex = 1; // Listeler TabControlündeki Albüm tabPage seçiliyor.
        }

        private void listView_Sanatci_Leave(object sender, EventArgs e)
        {
            ses.SpeakAsyncCancelAll();
            seslendir.Oynat(mpTabControl_Listeler.SelectedTab.Name, seslendirmeBaslikAcikmi, seslendirmeAciklamaAcikmi, seslendirmeBaslikSesi, seslendirmeAciklamaSesi);
            ses.SpeakAsyncCancelAll();
            mpTabControl_Ana_Menu.Controls[0].Controls[0].Focus();// Ana Menü tabcontrolü içindeki Listeler TabControle odaklanıyor.
            mpTabControl_Ana_Menu.Controls[0].Controls[0].Select();// Ana Menü tabControlü içindeki Listeler TabControl seçiliyor.
            mpTabControl_Listeler.SelectedIndex = 2; // Listeler TabControlündeki Sanatcı tabPage seçiliyor.
        }
        #endregion Kontroller seçildiğinde - çıkıldığında

    }
}
