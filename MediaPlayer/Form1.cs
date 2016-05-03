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
using System.IO;
using WMPLib;
using System.Threading;

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
        #region Dosya Ekle
        private void mpButon_Dosya_Ekle_Click(object sender, EventArgs e)
        {
            MPUyari uyari = new MPUyari();// Uyarı nesnesi oluşturuluyor.
            if (openFileDialog_Dosya_Ekle.ShowDialog() == System.Windows.Forms.DialogResult.OK)//Ok tuşuna basıldıysa...
            {
                foreach (var dosya in openFileDialog_Dosya_Ekle.FileNames)//Seçilen dosya kadar döngüye giriliyor.
                {
                    Listele Item = new Listele(); // Yeni ListView Itemi oluşturuluyor.
                    listView_Tum_Liste.Items.Add(Item.klasorden_Listele(listView_Tum_Liste.Items.Count, dosya)); //Oluşturulan Item tüm liste listViewine ekleniyor.
                }

                uyari.Goster("Uyari", "Seçilen Dosyalar Listelere Ekleniyor...", "Dosyalar Ekleniyor...");
                backgroundWorker_ListeOlustur.RunWorkerAsync();//Listeler Oluşturuluyor.
            }
        }
        #endregion Dosya Ekle
        #region Klasör Ekle
        int dosyaHatasi = 0;//Eklenen dosyaların türleri uygun değilse miktarı alınıyor.
        private void mpButon_Klasor_Ekle_Click(object sender, EventArgs e)
        {
            MPUyari uyari = new MPUyari();// Uyarı nesnesi oluşturuluyor.

            if (folderBrowserDialog_KlasorEkle.ShowDialog() == System.Windows.Forms.DialogResult.OK)//Ok tuşuna basıldıysa...
            {
                
                foreach (var dosya in Directory.GetFiles(folderBrowserDialog_KlasorEkle.SelectedPath))//Seçilen dosya kadar döngüye giriliyor.
                {
                    /* Desteklenmeyen dosyalar kontrol ediliyor. */
                    if (Path.GetExtension(dosya) == ".amr" || Path.GetExtension(dosya) == ".mp3" || Path.GetExtension(dosya) == ".wma" || Path.GetExtension(dosya) == ".wav" || Path.GetExtension(dosya) == ".avi" || Path.GetExtension(dosya) == ".mp4" || Path.GetExtension(dosya) == ".mpg" || Path.GetExtension(dosya) == ".mpeg" || Path.GetExtension(dosya) == ".wmv")
                    {
                        Listele Item = new Listele();// Yeni ListView Itemi oluşturuluyor.
                        listView_Tum_Liste.Items.Add(Item.klasorden_Listele(listView_Tum_Liste.Items.Count, dosya)); //Oluşturulan Item tüm liste listViewine ekleniyor.
                    }
                    else
                    {
                        dosyaHatasi += 1; // Desteklenmeyen dosya varsa sayısı alınıyor.
                    }
                }

                uyari.Goster("Uyari", "Seçilen Dosyalar Listelere Ekleniyor...", "Dosyalar Ekleniyor...");
                backgroundWorker_ListeOlustur.RunWorkerAsync();//Listeler Oluşturuluyor.
            }

        }
        #endregion Klasör Ekle
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
            listView_Muzik.Items.Clear(); //Müzik listesi temizleniyor.

            lg.Sorgu(new[] { ".mp3", ".wma", ".wav", ".amr" }); //Nesne içindeki sorgu tablosu hazırlanıyor.

            foreach (ListViewItem item in listView_Tum_Liste.Items)
            {
                ListViewItem l = lg.SorguBilgi(item.Index, new[] { "DosyaAdi", "Sure", "Sanatci", "Album", "Dizin" });
                if (l != null)//Gelen Item null değer içeriyorsa listviewe ekleme.
                {
                    listView_Muzik.Items.Add(l);
                }
            }

            lg.sil("Sorgu"); //Sorgu tablosu boşaltılıyor.

            /* Video listesi oluşturuluyor.*/
            //uyari.Goster("Uyari", "Video Listesi Oluşturuluyor...", "Dosyalar Ekleniyor...");
            ListeGrup lg_v = new ListeGrup(); //Yeni bir listeleme grubu oluşturuluyor.
            foreach (ListViewItem item in listView_Tum_Liste.Items) //Tüm listesindeki satır kadar döngüye giriliyor.
            {
                lg_v.Ekle(item.SubItems[3].Text);//Tüm listesindeki parçaların dizinleri, ilgili sütundan alınarak listeleme grubu nesnesine gönderiliyor.
                listView_Album.Items.Add(lg_v.Bilgi(item.Index, new[] { "Album", "Sanatci", "DosyaAdi", "Sure", "Dizin" }));//Listeleme grubu nesnesinin dataTablesindeki satır nosu ve istenen bilgiler girilerek, Item olarak döndürülüyor ve Album ListViewine Item olarak ekleniyor. 
                listView_Sanatci.Items.Add(lg_v.Bilgi(item.Index, new[] { "Sanatci", "DosyaAdi", "Sure", "Dizin" }));//Listeleme grubu nesnesinin dataTablesindeki satır nosu ve istenen bilgiler girilerek, Item olarak döndürülüyor ve Sanatçı ListViewine Item olarak ekleniyor. 
            }
            listView_Video.Items.Clear(); //Müzik listesi temizleniyor.

            lg_v.Sorgu(new[] { ".mp4", ".avi", ".mpg", ".mpeg", ".wmv" }); //Nesne içindeki sorgu tablosu hazırlanıyor.

            foreach (ListViewItem item in listView_Tum_Liste.Items)
            {
                ListViewItem l = lg_v.SorguBilgi(item.Index, new[] { "DosyaAdi", "Sure", "Dizin", "Album" });
                if (l != null)//Gelen Item null değer içeriyorsa listviewe ekleme.
                {
                    listView_Video.Items.Add(l);
                }
            }

            lg_v.sil(); //Bütün tablolar boşaltılıyor.
        }
        #endregion Listeleri Oluştur
        public IWMPPlaylist tumListe;
        #region Tüm Liste Çift Tıklama
        private void listView_Tum_Liste_MouseDoubleClick(object sender, MouseEventArgs e)
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
        #endregion Tüm Liste Çift Tıklama
        #region axMediaPlayer Mevcut Medyadaki Değişim
        private void axWindowsMediaPlayer1_CurrentItemChange(object sender, AxWMPLib._WMPOCXEvents_CurrentItemChangeEvent e)
        {
            kontolEtiketleriniAyarla();//Player altındaki sanatçı ve albüm ismini değiştirir.
            //listView_Tum_Liste.Focus();
            //listView_Tum_Liste.Items[???].Selected=true;
        }
        #endregion axMediaPlayer Mevcut Medyadaki Değişim
        #region Kontrol labelleri sanatçı ve şarkı ismi

        private void kontolEtiketleriniAyarla()
        {
            label_SanatciAdi.Text = axWindowsMediaPlayer1.currentMedia.getItemInfo("Title").ToString();
            label_ParcaAdi.Text = axWindowsMediaPlayer1.currentMedia.name;
        }

        #endregion Kontrol labelleri sanatçı ve şarkı ismi
        #region Albüm Listesi Çift Tıklama
        private void listView_Album_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tumListe = axWindowsMediaPlayer1.playlistCollection.newPlaylist("Albüm Listesi"); //Yeni playlist oluşturuluyor.
            axWindowsMediaPlayer1.Ctlcontrols.stop();// MediaPlayer nesnesi çalıyor olma ihtimaline karşı durduruluyor.

            foreach (ListViewItem pl in listView_Album.Items) //Albüm listesinin olduğu listview satır sayısı kadar döngüye giriliyor.
            {
                IWMPMedia media = axWindowsMediaPlayer1.newMedia(pl.SubItems[4].Text); //Yeni media nesnesi oluşturuluyor ve listview.itemin ilgili sütunundan url alınıyor.
                tumListe.appendItem(media); //Oluşturulan medya "Tüm Listeye" ekleniyor.
            }

            int sn = listView_Album.SelectedItems[0].Index; // Tıklanan parçanın numarası tutuluyor, oynatmaya bu parçadan başlanacak.
            axWindowsMediaPlayer1.currentPlaylist = tumListe; //"Albüm listesi" mediaPlayera ekleniyor.
            axWindowsMediaPlayer1.Ctlcontrols.playItem(axWindowsMediaPlayer1.currentPlaylist.get_Item(sn));// Oynat
            mpTabControl_Ana_Menu.SelectedIndex = 3;//Oynatma sekmesini aç.
            kontolEtiketleriniAyarla();//Player altındaki sanatçı ve albüm ismini değiştirir.
        }
        #endregion Albüm Listesi Çift Tıklama
        #region Sanatçı Listesi Çift Tıklama
        private void listView_Sanatci_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            ListView_to_Playlist pl = new ListView_to_Playlist(listView_Sanatci, 3, "Sanatçı Listesi", listView_Sanatci.SelectedItems[0].Index); //Yeni playlist oluşturuluyor.
            axWindowsMediaPlayer1.currentPlaylist = pl.Playlist(); //"Playlist" mediaPlayera ekleniyor.
            axWindowsMediaPlayer1.Ctlcontrols.playItem(axWindowsMediaPlayer1.currentPlaylist.get_Item(pl.Secilen()));// Oynat
            //pl.sil(); //Playlist siliniyor.
            mpTabControl_Ana_Menu.SelectedIndex = 3;//Oynatma sekmesini aç.
            //kontolEtiketleriniAyarla();//Player altındaki sanatçı ve albüm ismini değiştirir.
        }
        #endregion Sanatçı Listesi Çift Tıklama
        #region Form Load
        private void Form1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.uiMode = "none";

        }
        #endregion Form Load
        #region Sil Buton Tıklama
        private void mpButon_Sil_Click(object sender, EventArgs e)
        {
            MPUyari u2 = new MPUyari();
            u2.Goster("Hata", "Bu dosya türleri desteklenmiyor.","HATA !");

        }
        #endregion Sil Buton Tıklama
        #region axMediaPlayer Medya Akış değişimi
        private void axWindowsMediaPlayer1_PositionChange(object sender, AxWMPLib._WMPOCXEvents_PositionChangeEvent e)
        {
            int i = 1;
            i += 1;

            label_Zaman.Text = i.ToString();
        }
        #endregion axMediaPlayer Medya Akış değişimi

        private void backgroundWorker_ListeOlustur_DoWork(object sender, DoWorkEventArgs e)
        {
            ListeleriOlustur();
        }

        private void backgroundWorker_ListeOlustur_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MPUyari uyari = new MPUyari();
            if (dosyaHatasi == 0) //Desteklenmeyen dosya yok ise,
            {
                uyari.Goster("Onay", "Seçilen dosyalar listelere eklendi.", "DOSYALAR EKLENDİ");
            }
            else //Desteklenmeyen dosya varsa
            {
                uyari.Goster("Uyari", "Desteklenmeyen bazı (" + dosyaHatasi.ToString() + ") dosyalar listeye eklenemedi.", "UYARI");
                dosyaHatasi = 0;
            }
        }

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
        #region Kontrol tuşları

        private void button_KontrolOynat_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.currentPlaylist.count != 0)//Çalma listesi yüklü değilse durdur butonunu gösterme.
            {
                button_KontrolOynat.Visible = false;
                button_KontrolDurdur.Visible = true;
                axWindowsMediaPlayer1.Ctlcontrols.play();// Oynat
            }

        }

        private void button_KontrolDurdur_Click(object sender, EventArgs e)
        {
            button_KontrolDurdur.Visible = false;
            button_KontrolOynat.Visible = true;
            axWindowsMediaPlayer1.Ctlcontrols.pause();// Duraklat
        }

        private void button_Kontrolileri_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.currentPlaylist.count != 0)//Çalma listesi yüklü değilse durdur butonunu gösterme.
            {
                axWindowsMediaPlayer1.Ctlcontrols.next();// Sonraki parça
                button_KontrolOynat.Visible = false;
                button_KontrolDurdur.Visible = true;
            }
        }

        private void button_KontrolGeri_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.currentPlaylist.count != 0)//Çalma listesi yüklü değilse durdur butonunu gösterme.
            {
                axWindowsMediaPlayer1.Ctlcontrols.previous();// Önceki parça.
                button_KontrolOynat.Visible = false;
                button_KontrolDurdur.Visible = true;
            }
        }

        private void button_KontrolDur_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();// Durdur.
        }

        #endregion Kontrol tuşları

        private void axWindowsMediaPlayer1_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                //Thread.Sleep(1000);
                
                label_Zaman.Text = axWindowsMediaPlayer1.currentMedia.durationString;
            }
            int i = 1;
            label_Zaman.Text = i++.ToString();
        }


        private void axWindowsMediaPlayer1_StatusChange(object sender, EventArgs e)
        {

        }

        private void Durdur(object sender, EventArgs e)
        {

        }
    }
}
