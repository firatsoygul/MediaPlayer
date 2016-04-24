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

namespace MediaPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mpButon_Dosya_Ekle_Click(object sender, EventArgs e)
        {
            if (openFileDialog_Dosya_Ekle.ShowDialog() == System.Windows.Forms.DialogResult.OK)//Ok tuşuna basıldıysa...
            {
                foreach (var dosya in openFileDialog_Dosya_Ekle.FileNames)//Seçilen dosya kadar döngüye giriliyor.
                {
                    Listele Item = new Listele(); // Yeni ListView Itemi oluşturuluyor.
                    listView_Tum_Liste.Items.Add(Item.klasorden_Listele(listView_Tum_Liste.Items.Count, dosya)); //Oluşturulan Item tüm liste listViewine ekleniyor.
                }
            }

            /* Albüm listesi oluşturuluyor.*/
            ListeGrup lg = new ListeGrup(); //Yeni bir listeleme grubu oluşturuluyor.
            listView_Album.Items.Clear(); //Albüm listView temizleniyor.
            foreach (ListViewItem item in listView_Tum_Liste.Items) //Tüm listesindeki satır kadar döngüye giriliyor.
            {
                lg.Ekle(item.SubItems[3].Text);//Tüm listesindeki parçaların dizinleri, ilgili sütundan alınarak listeleme grubu nesnesine gönderiliyor.
                listView_Album.Items.Add(lg.Bilgi(item.Index, new[] { "Album", "Sanatci", "DosyaAdi", "Sure", "Dizin" }));//Listeleme grubu nesnesinin dataTablesindeki satır nosu ve istenen bilgiler girilerek, Item olarak döndürülüyor ve Album ListViewine Item olarak ekleniyor. 
            }
            lg.sil(); //Datatable boşaltılıyor.

            /* Sanatçı listesi oluşturuluyor. */
            listView_Sanatci.Items.Clear(); //Sanatçı listView temizleniyor.
            foreach (ListViewItem item in listView_Tum_Liste.Items)
            {
                lg.Ekle(item.SubItems[3].Text);//Tüm listesindeki parçaların dizinleri, ilgili sütundan alınarak listeleme grubu nesnesine gönderiliyor.
                listView_Sanatci.Items.Add(lg.Bilgi(item.Index, new[] { "Sanatci", "DosyaAdi", "Sure", "Dizin" }));//Listeleme grubu nesnesinin dataTablesindeki satır nosu ve istenen bilgiler girilerek, Item olarak döndürülüyor ve Sanatçı ListViewine Item olarak ekleniyor. 
            }
            lg.sil(); //Datatable boşaltılıyor.
        }

        private void mpButon_Klasor_Ekle_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog_Klasor_Ekle.ShowDialog() == System.Windows.Forms.DialogResult.OK)//Ok tuşuna basıldıysa...
            {
                
                foreach (var dosya in Directory.GetFiles(folderBrowserDialog_Klasor_Ekle.SelectedPath))//Seçilen dosya kadar döngüye giriliyor.
                {
                    
                    Listele Item = new Listele();// Yeni ListView Itemi oluşturuluyor.
                    listView_Tum_Liste.Items.Add(Item.klasorden_Listele(listView_Tum_Liste.Items.Count, dosya)); //Oluşturulan Item tüm liste listViewine ekleniyor.
                }
            }

            /* Albüm listesi oluşturuluyor.*/
            ListeGrup lg = new ListeGrup(); //Yeni bir listeleme grubu oluşturuluyor.
            listView_Album.Items.Clear(); //Albüm listView temizleniyor.
            foreach (ListViewItem item in listView_Tum_Liste.Items) //Tüm listesindeki satır kadar döngüye giriliyor.
            {
                lg.Ekle(item.SubItems[3].Text);//Tüm listesindeki parçaların dizinleri, ilgili sütundan alınarak listeleme grubu nesnesine gönderiliyor.
                listView_Album.Items.Add(lg.Bilgi(item.Index, new[] { "Album", "Sanatci", "DosyaAdi", "Sure", "Dizin" }));//Listeleme grubu nesnesinin dataTablesindeki satır nosu ve istenen bilgiler girilerek, Item olarak döndürülüyor ve Album ListViewine Item olarak ekleniyor. 
            }
            lg.sil(); //Datatable boşaltılıyor.

            /* Sanatçı listesi oluşturuluyor. */
            listView_Sanatci.Items.Clear(); //Sanatçı listView temizleniyor.
            foreach (ListViewItem item in listView_Tum_Liste.Items)
            {
                lg.Ekle(item.SubItems[3].Text);//Tüm listesindeki parçaların dizinleri, ilgili sütundan alınarak listeleme grubu nesnesine gönderiliyor.
                listView_Sanatci.Items.Add(lg.Bilgi(item.Index, new[]{"Sanatci", "DosyaAdi", "Sure", "Dizin" }));//Listeleme grubu nesnesinin dataTablesindeki satır nosu ve istenen bilgiler girilerek, Item olarak döndürülüyor ve Sanatçı ListViewine Item olarak ekleniyor. 
            }
            lg.sil(); //Datatable boşaltılıyor.
        }

        public IWMPPlaylist tumListe;

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
            label_Sanatci.Text = axWindowsMediaPlayer1.currentMedia.getItemInfo("Album").ToString();
            label_ParcaAdi.Text = axWindowsMediaPlayer1.currentMedia.name;
        }

        private void axWindowsMediaPlayer1_CurrentItemChange(object sender, AxWMPLib._WMPOCXEvents_CurrentItemChangeEvent e)
        {
            //listView_Tum_Liste.Focus();
            //listView_Tum_Liste.Items[???].Selected=true;
        }

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
        }

        private void listView_Sanatci_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            ListView_to_Playlist pl = new ListView_to_Playlist(listView_Sanatci, 3, "Sanatçı Listesi", listView_Sanatci.SelectedItems[0].Index); //Yeni playlist oluşturuluyor.
            axWindowsMediaPlayer1.currentPlaylist = pl.Playlist(); //"Playlist" mediaPlayera ekleniyor.
            axWindowsMediaPlayer1.Ctlcontrols.playItem(axWindowsMediaPlayer1.currentPlaylist.get_Item(pl.Secilen()));// Oynat
            //pl.sil(); //Playlist siliniyor.
            mpTabControl_Ana_Menu.SelectedIndex = 3;//Oynatma sekmesini aç.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //axWindowsMediaPlayer1.uiMode = "none";

        }

        
            

        private void mpButon_Sil_Click(object sender, EventArgs e)
        {
            MPUyari u2 = new MPUyari();
            u2.Goster("Hata", "Bu dosya türleri desteklenmiyor.","HATA !");

        }
        int i = 1;
        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            
        }

        private void axWindowsMediaPlayer1_PositionChange(object sender, AxWMPLib._WMPOCXEvents_PositionChangeEvent e)
        {
            i += 1;

            label_Zaman.Text = i.ToString();
        }
    }
}
