using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WMPLib;

namespace MediaPlayer.Seslendirme
{
    public class BaslikveAciklama
    {
        //WindowsMediaPlayer wmp = new WindowsMediaPlayer(); //Uyarı seslerini okuyan player.
        private WMPLib.WindowsMediaPlayer wmp_Baslik;
        private WMPLib.WindowsMediaPlayer wmp_Aciklama;
        private WMPLib.WindowsMediaPlayer wmp_UyariveHata;
        private WMPLib.WindowsMediaPlayer wmp_Media;

        IWMPMedia mediaCL1, mediaCL2, mediaCL3, mediaCL4, mediaCL5, mediaCL6, mediaCL7; //Çalma Listelerinde oynatılacak medyalar.
        IWMPMedia mediaM1, mediaM2; //Müzik menüsünde oynatılacak medyalar.
        IWMPMedia mediaV1, mediaV2; //Video menüsünde oynatılacak medyalar.
        IWMPMedia mediaO1, mediaO2; //Oynat menüsünde oynatılacak medyalar.
        IWMPMedia mediaA1, mediaA2; //Ayarlar menüsünde oynatılacak medyalar.
        IWMPMedia mediaY1, mediaY2; //Yardım menüsünde oynatılacak medyalar.
        IWMPMedia mediaTL1, mediaTL2; //Tüm Listeler menüsünde oynatılacak medyalar.
        IWMPMedia mediaALBM1, mediaALBM2; //Albüm menüsünde oynatılacak medyalar.
        IWMPMedia mediaSNT1, mediaSNT2; //Sanatçılar menüsünde oynatılacak medyalar.
        IWMPMedia[] mediaBTN = new IWMPMedia[18]; //Butonlar için gerekli medyalar.

        int toplamSureAciklamaCalmaListeleri = 0, toplamSureBaslikCalmaListeleri = 0;
        int toplamSureAciklamaMuzik = 0, toplamSureBaslikMuzik = 0;
        int toplamSureAciklamaVideo = 0, toplamSureBaslikVideo = 0;
        int toplamSureAciklamaOynat = 0, toplamSureBaslikOynat = 0;
        int toplamSureAciklamaAyarlar = 0, toplamSureBaslikAyarlar = 0;
        int toplamSureAciklamaYardim = 0, toplamSureBaslikYardim = 0;
        int toplamSureAciklamaTumListeler = 0, toplamSureBaslikTumListeler = 0;
        int toplamSureAciklamaAlbum = 0, toplamSureBaslikAlbum = 0;
        int toplamSureAciklamaSanatcilar = 0, toplamSureBaslikSanatcilar = 0;

        string konumO;
        bool baslikSesiAcikmiO, aciklamaSesiAcikmiO;
        int baslikSesiO, aciklamaSesiO;

        IWMPPlaylist plylst_BaslikCalmaListeleri;
        IWMPPlaylist plylst_BaslikMuzik;
        IWMPPlaylist plylst_BaslikVideo;
        IWMPPlaylist plylst_BaslikOynat;
        IWMPPlaylist plylst_BaslikAyarlar;
        IWMPPlaylist plylst_BaslikYardim;
        IWMPPlaylist plylst_BaslikTumListeler;
        IWMPPlaylist plylst_BaslikAlbum;
        IWMPPlaylist plylst_BaslikSanatcilar;

        IWMPPlaylist plylst_AciklamaCalmaListeleri;
        IWMPPlaylist plylst_AciklamaMuzik;
        IWMPPlaylist plylst_AciklamaVideo;
        IWMPPlaylist plylst_AciklamaOynat;
        IWMPPlaylist plylst_AciklamaAyarlar;
        IWMPPlaylist plylst_AciklamaYardim;
        IWMPPlaylist plylst_AciklamaTumListeler;
        IWMPPlaylist plylst_AciklamaAlbum;
        IWMPPlaylist plylst_AciklamaSanatcilar;




        public BaslikveAciklama()
        {
            wmp_Baslik = new WMPLib.WindowsMediaPlayer();
            wmp_Aciklama = new WMPLib.WindowsMediaPlayer();
            wmp_UyariveHata = new WMPLib.WindowsMediaPlayer();
            wmp_Media = new WMPLib.WindowsMediaPlayer();

            //Başlıkların okunması bittiğinde eğer varsa devamında açıklamanın okunabilmesi için gerekli olay oluştuluyor.
            wmp_Baslik.PlayStateChange += new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(wmp_Baslik_PlayStateChange);

            /* ÇALMA LİSTELERİ MENÜSÜ */

            //Başıkta ve açıklamalarda okunması için iki ayrı playlist oluşturuluyor.
            plylst_BaslikCalmaListeleri = wmp_Baslik.playlistCollection.newPlaylist("SeslendirmeBaslikCalmaListeleri");
            plylst_AciklamaCalmaListeleri = wmp_Media.playlistCollection.newPlaylist("SeslendirmeAciklamaCalmaListeleri");
            //Playlistlere eklenecek medyalar oluşturuluyor.
            mediaCL1 = wmp_Media.newMedia(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MediaPlayer\\Ses" + "\\m1.mp3");
            mediaCL2 = wmp_Media.newMedia(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MediaPlayer\\Ses" + "\\a1.mp3");
            mediaCL3 = wmp_Media.newMedia(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MediaPlayer\\Ses" + "\\a2.mp3");
            mediaCL4 = wmp_Media.newMedia(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MediaPlayer\\Ses" + "\\a3.mp3");
            mediaCL5 = wmp_Media.newMedia(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MediaPlayer\\Ses" + "\\a4.mp3");
            mediaCL6 = wmp_Media.newMedia(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MediaPlayer\\Ses" + "\\a5.mp3");
            mediaCL7 = wmp_Media.newMedia(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MediaPlayer\\Ses" + "\\a6.mp3");
            //Medyalar playlistlere ekleniyor.
            plylst_BaslikCalmaListeleri.appendItem(mediaCL1);
            plylst_AciklamaCalmaListeleri.appendItem(mediaCL2);
            plylst_AciklamaCalmaListeleri.appendItem(mediaCL3);
            plylst_AciklamaCalmaListeleri.appendItem(mediaCL4);
            plylst_AciklamaCalmaListeleri.appendItem(mediaCL5);
            plylst_AciklamaCalmaListeleri.appendItem(mediaCL6);
            plylst_AciklamaCalmaListeleri.appendItem(mediaCL7);
            //Playlistlerin toplam süreleri. (Arka arkaya çalınacak olan playerlarda bekleme süresi olarak kullanılacak.
            toplamSureBaslikCalmaListeleri = Convert.ToInt16(plylst_BaslikCalmaListeleri.Item[0].duration); //Başlık süresi.
            for (int i = 0; i < plylst_AciklamaCalmaListeleri.count; i++)
            {
                toplamSureAciklamaCalmaListeleri += Convert.ToInt16(plylst_AciklamaCalmaListeleri.Item[i].duration); // Açıklamaların toplam süresi.
            }

            /* MÜZİK MENÜSÜ */

            //Başıkta ve açıklamalarda okunması için iki ayrı playlist oluşturuluyor.
            plylst_BaslikMuzik = wmp_Baslik.playlistCollection.newPlaylist("SeslendirmeBaslikMuzik");
            plylst_AciklamaMuzik = wmp_Media.playlistCollection.newPlaylist("SeslendirmeAciklamaMuzik");
            //Playlistlere eklenecek medyalar oluşturuluyor.
            mediaM1 = wmp_Media.newMedia(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MediaPlayer\\Ses" + "\\m2.mp3");
            //media2 = wmp_Media.newMedia(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MediaPlayer\\Ses" + "\\a7.mp3"); //Şimdilik bu menüde açıklama yok.
            //Medyalar playlistlere ekleniyor.
            plylst_BaslikMuzik.appendItem(mediaM1);
            //plylst_AciklamaCalmaListeleri.appendItem(mediaM2); //Şimdilik bu menüde açıklama yok. 
            //Playlistlerin toplam süreleri. (Arka arkaya çalınacak olan playerlarda bekleme süresi olarak kullanılacak.
            toplamSureBaslikMuzik = Convert.ToInt16(plylst_BaslikMuzik.Item[0].duration); //Başlık süresi.
            for (int i = 0; i < plylst_AciklamaMuzik.count; i++)
            {
                toplamSureAciklamaMuzik += Convert.ToInt16(plylst_AciklamaMuzik.Item[i].duration); // Açıklamaların toplam süresi.
            }

            /* VIDEO MENÜSÜ */

            //Başıkta ve açıklamalarda okunması için iki ayrı playlist oluşturuluyor.
            plylst_BaslikVideo = wmp_Baslik.playlistCollection.newPlaylist("SeslendirmeBaslikVideo");
            plylst_AciklamaVideo = wmp_Media.playlistCollection.newPlaylist("SeslendirmeAciklamaVideo");
            //Playlistlere eklenecek medyalar oluşturuluyor.
            mediaV1 = wmp_Media.newMedia(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MediaPlayer\\Ses" + "\\m3.mp3");
            //mediaV2 = wmp_Media.newMedia(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MediaPlayer\\Ses" + "\\a7.mp3"); //Şimdilik bu menüde açıklama yok.
            //Medyalar playlistlere ekleniyor.
            plylst_BaslikVideo.appendItem(mediaV1);
            //plylst_AciklamaCalmaListeleri.appendItem(mediaV2); //Şimdilik bu menüde açıklama yok. 
            //Playlistlerin toplam süreleri. (Arka arkaya çalınacak olan playerlarda bekleme süresi olarak kullanılacak.
            toplamSureBaslikVideo = Convert.ToInt16(plylst_BaslikMuzik.Item[0].duration); //Başlık süresi.
            for (int i = 0; i < plylst_AciklamaVideo.count; i++)
            {
                toplamSureAciklamaVideo += Convert.ToInt16(plylst_AciklamaVideo.Item[i].duration); // Açıklamaların toplam süresi.
            }

            /* OYNAT MENÜSÜ */

            //Başıkta ve açıklamalarda okunması için iki ayrı playlist oluşturuluyor.
            plylst_BaslikOynat = wmp_Baslik.playlistCollection.newPlaylist("SeslendirmeBaslikOynat");
            plylst_AciklamaOynat = wmp_Media.playlistCollection.newPlaylist("SeslendirmeAciklamaOynat");
            //Playlistlere eklenecek medyalar oluşturuluyor.
            mediaO1 = wmp_Media.newMedia(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MediaPlayer\\Ses" + "\\m4.mp3");
            //mediaO2 = wmp_Media.newMedia(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MediaPlayer\\Ses" + "\\a7.mp3"); //Şimdilik bu menüde açıklama yok.
            //Medyalar playlistlere ekleniyor.
            plylst_BaslikOynat.appendItem(mediaO1);
            //plylst_AciklamaOynat.appendItem(mediaO2); //Şimdilik bu menüde açıklama yok. 
            //Playlistlerin toplam süreleri. (Arka arkaya çalınacak olan playerlarda bekleme süresi olarak kullanılacak.
            toplamSureBaslikOynat = Convert.ToInt16(plylst_BaslikOynat.Item[0].duration); //Başlık süresi.
            for (int i = 0; i < plylst_AciklamaOynat.count; i++)
            {
                toplamSureAciklamaOynat += Convert.ToInt16(plylst_AciklamaOynat.Item[i].duration); // Açıklamaların toplam süresi.
            }

            /* AYARLAR MENÜSÜ */

            //Başıkta ve açıklamalarda okunması için iki ayrı playlist oluşturuluyor.
            plylst_BaslikAyarlar = wmp_Baslik.playlistCollection.newPlaylist("SeslendirmeBaslikAyarlar");
            plylst_AciklamaAyarlar = wmp_Media.playlistCollection.newPlaylist("SeslendirmeAciklamaAyarlar");
            //Playlistlere eklenecek medyalar oluşturuluyor.
            mediaA1 = wmp_Media.newMedia(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MediaPlayer\\Ses" + "\\m5.mp3");
            //mediaA2 = wmp_Media.newMedia(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MediaPlayer\\Ses" + "\\a7.mp3"); //Şimdilik bu menüde açıklama yok.
            //Medyalar playlistlere ekleniyor.
            plylst_BaslikAyarlar.appendItem(mediaA1);
            //plylst_AciklamaAyarlar.appendItem(mediaA2); //Şimdilik bu menüde açıklama yok. 
            //Playlistlerin toplam süreleri. (Arka arkaya çalınacak olan playerlarda bekleme süresi olarak kullanılacak.
            toplamSureBaslikAyarlar = Convert.ToInt16(plylst_BaslikAyarlar.Item[0].duration); //Başlık süresi.
            for (int i = 0; i < plylst_AciklamaAyarlar.count; i++)
            {
                toplamSureAciklamaAyarlar += Convert.ToInt16(plylst_AciklamaAyarlar.Item[i].duration); // Açıklamaların toplam süresi.
            }

            /* HAKKINDA MENÜSÜ */

            //Başıkta ve açıklamalarda okunması için iki ayrı playlist oluşturuluyor.
            plylst_BaslikYardim = wmp_Baslik.playlistCollection.newPlaylist("SeslendirmeBaslikYardim");
            plylst_AciklamaYardim = wmp_Media.playlistCollection.newPlaylist("SeslendirmeAciklamaYardim");
            //Playlistlere eklenecek medyalar oluşturuluyor.
            mediaY1 = wmp_Media.newMedia(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MediaPlayer\\Ses" + "\\m7.mp3");
            mediaY2 = wmp_Media.newMedia(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MediaPlayer\\Ses" + "\\hk1.mp3"); //Menü açıklaması.
            //Medyalar playlistlere ekleniyor.
            plylst_BaslikYardim.appendItem(mediaY1);
            plylst_AciklamaYardim.appendItem(mediaY2);
            //Playlistlerin toplam süreleri. (Arka arkaya çalınacak olan playerlarda bekleme süresi olarak kullanılacak.
            toplamSureBaslikYardim = Convert.ToInt16(plylst_BaslikYardim.Item[0].duration); //Başlık süresi.
            for (int i = 0; i < plylst_AciklamaYardim.count; i++)
            {
                toplamSureAciklamaYardim += Convert.ToInt16(plylst_AciklamaYardim.Item[i].duration); // Açıklamaların toplam süresi.
            }

            /* TÜM LİSTELER MENÜSÜ */

            //Başıkta ve açıklamalarda okunması için iki ayrı playlist oluşturuluyor.
            plylst_BaslikTumListeler = wmp_Baslik.playlistCollection.newPlaylist("SeslendirmeBaslikTumListeler");
            plylst_AciklamaTumListeler = wmp_Media.playlistCollection.newPlaylist("SeslendirmeAciklamaTumListeler");
            //Playlistlere eklenecek medyalar oluşturuluyor.
            mediaTL1 = wmp_Media.newMedia(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MediaPlayer\\Ses" + "\\m1_1.mp3");
            //mediaTL2 = wmp_Media.newMedia(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MediaPlayer\\Ses" + "\\a7.mp3"); //Şimdilik bu menüde açıklama yok.
            //Medyalar playlistlere ekleniyor.
            plylst_BaslikTumListeler.appendItem(mediaTL1);
            //plylst_AciklamaTumListeler.appendItem(mediaTL2); //Şimdilik bu menüde açıklama yok. 
            //Playlistlerin toplam süreleri. (Arka arkaya çalınacak olan playerlarda bekleme süresi olarak kullanılacak.
            toplamSureBaslikTumListeler = Convert.ToInt16(plylst_BaslikTumListeler.Item[0].duration); //Başlık süresi.
            for (int i = 0; i < plylst_AciklamaTumListeler.count; i++)
            {
                toplamSureAciklamaTumListeler += Convert.ToInt16(plylst_AciklamaTumListeler.Item[i].duration); // Açıklamaların toplam süresi.
            }

            /* ALBÜM MENÜSÜ */

            //Başıkta ve açıklamalarda okunması için iki ayrı playlist oluşturuluyor.
            plylst_BaslikAlbum = wmp_Baslik.playlistCollection.newPlaylist("SeslendirmeBaslikAlbum");
            plylst_AciklamaAlbum = wmp_Media.playlistCollection.newPlaylist("SeslendirmeAciklamaAlbum");
            //Playlistlere eklenecek medyalar oluşturuluyor.
            mediaALBM1 = wmp_Media.newMedia(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MediaPlayer\\Ses" + "\\m1_2.mp3");
            //mediaALBM2 = wmp_Media.newMedia(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MediaPlayer\\Ses" + "\\a7.mp3"); //Şimdilik bu menüde açıklama yok.
            //Medyalar playlistlere ekleniyor.
            plylst_BaslikAlbum.appendItem(mediaALBM1);
            //plylst_AciklamaAlbum.appendItem(mediaALBM2); //Şimdilik bu menüde açıklama yok. 
            //Playlistlerin toplam süreleri. (Arka arkaya çalınacak olan playerlarda bekleme süresi olarak kullanılacak.
            toplamSureBaslikAlbum = Convert.ToInt16(plylst_BaslikAlbum.Item[0].duration); //Başlık süresi.
            for (int i = 0; i < plylst_AciklamaAlbum.count; i++)
            {
                toplamSureAciklamaAlbum += Convert.ToInt16(plylst_AciklamaAlbum.Item[i].duration); // Açıklamaların toplam süresi.
            }

            /* SANATÇILAR MENÜSÜ */

            //Başıkta ve açıklamalarda okunması için iki ayrı playlist oluşturuluyor.
            plylst_BaslikSanatcilar = wmp_Baslik.playlistCollection.newPlaylist("SeslendirmeBaslikSanatcilar");
            plylst_AciklamaSanatcilar = wmp_Media.playlistCollection.newPlaylist("SeslendirmeAciklamaSanatcilar");
            //Playlistlere eklenecek medyalar oluşturuluyor.
            mediaSNT1 = wmp_Media.newMedia(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MediaPlayer\\Ses" + "\\m1_3.mp3");
            //mediaSNT2 = wmp_Media.newMedia(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MediaPlayer\\Ses" + "\\a7.mp3"); //Şimdilik bu menüde açıklama yok.
            //Medyalar playlistlere ekleniyor.
            plylst_BaslikSanatcilar.appendItem(mediaSNT1);
            //plylst_AciklamaSanatcilar.appendItem(mediaSNT2); //Şimdilik bu menüde açıklama yok. 
            //Playlistlerin toplam süreleri. (Arka arkaya çalınacak olan playerlarda bekleme süresi olarak kullanılacak.
            toplamSureBaslikSanatcilar = Convert.ToInt16(plylst_BaslikSanatcilar.Item[0].duration); //Başlık süresi.
            for (int i = 0; i < plylst_AciklamaSanatcilar.count; i++)
            {
                toplamSureAciklamaSanatcilar += Convert.ToInt16(plylst_AciklamaSanatcilar.Item[i].duration); // Açıklamaların toplam süresi.
            }


            /* BUTONLAR */

            //Medyalar oluşturuluyor.
            for (int i = 0; i <= mediaBTN.Length - 1; i++)
            {
                mediaBTN[i] = wmp_Baslik.newMedia(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MediaPlayer\\Ses" + "\\k" + (i + 1) + ".mp3");
            }
        }

        public void Durdur()
        {
            wmp_Baslik.controls.stop();
            wmp_Aciklama.controls.stop();
            wmp_UyariveHata.controls.stop();
            wmp_Media.controls.stop();

            wmp_Baslik.close();
            wmp_Aciklama.close();
            wmp_UyariveHata.close();
            wmp_Media.close();

            //var prc = Process.GetProcessesByName("wmplayer ???");
            //if (prc.Length > 0) prc[prc.Length - 1].Kill();
        }

        /// <summary>
        ///Sırasıyla Name ya da buton no, başlık sesi açıkmı, Açıklama sesi açıkmı, Başlık ses seviyesi, Açıklama ses seviyesi. 
        ///Buton kodları= 0- oynatmayi_baslat, 1- oynatmayi_durdur, 2- duraklat, 3- sonraki, 4- onceki, 5- Ses, 6- İlerleme, 7- Başlık sesleri açık, 8- Başlık sesleri kapalı, 9- Açıklama sesleri açık, 10- Açıklama sesleri kapalı, 11- Uyarı sesleri açık, 12- Uyarı sesleri kapalı, 13- Başlık ses seviyesi, 14- Açıklama ses seviyesi, 15- Uyarı ses seviyesi, 16- konuşma sesleri açık, 17- konuşma sesleri kapalı.
        /// </summary>
        public void Oynat(string name, bool baslikSesiAcikmi, bool aciklamaSesiAcikmi, int baslikSesi, int aciklamaSesi)
        {
            konumO = name;
            baslikSesiAcikmiO = baslikSesiAcikmi;
            aciklamaSesiAcikmiO = aciklamaSesiAcikmi;
            baslikSesiO = baslikSesi;
            aciklamaSesiO = aciklamaSesi;

            Durdur();

            if (baslikSesiAcikmi)
            {
                BaslikOynat();
            }
            else if (aciklamaSesiAcikmi)
            {
                AciklamaOynat();
            }

        }

        public void BaslikOynat()
        {
            if (baslikSesiAcikmiO)
            {
                switch (konumO)
                {
                    case "tabPage_CalmaListeleri":
                        wmp_Baslik.currentPlaylist = plylst_BaslikCalmaListeleri;
                        wmp_Baslik.settings.volume = baslikSesiO;
                        wmp_Baslik.controls.play();
                        break;
                    case "tabPage_Muzik":
                        wmp_Baslik.currentPlaylist = plylst_BaslikMuzik;
                        wmp_Baslik.settings.volume = baslikSesiO;
                        wmp_Baslik.controls.play();
                        break;
                    case "tabPage_Video":
                        wmp_Baslik.currentPlaylist = plylst_BaslikVideo;
                        wmp_Baslik.settings.volume = baslikSesiO;
                        wmp_Baslik.controls.play();
                        break;
                    case "tabPage_Oynat":
                        wmp_Baslik.currentPlaylist = plylst_BaslikOynat;
                        wmp_Baslik.settings.volume = baslikSesiO;
                        wmp_Baslik.controls.play();
                        break;
                    case "tabPage_Ayarlar":
                        wmp_Baslik.currentPlaylist = plylst_BaslikAyarlar;
                        wmp_Baslik.settings.volume = baslikSesiO;
                        wmp_Baslik.controls.play();
                        break;
                    case "tabPage_Yardim":
                        wmp_Baslik.currentPlaylist = plylst_BaslikYardim;
                        wmp_Baslik.settings.volume = baslikSesiO;
                        wmp_Baslik.controls.play();
                        break;
                    case "tabPage_Tum_Listeler":
                        wmp_Baslik.currentPlaylist = plylst_BaslikTumListeler;
                        wmp_Baslik.settings.volume = baslikSesiO;
                        wmp_Baslik.controls.play();
                        break;
                    case "tabPage_Album":
                        wmp_Baslik.currentPlaylist = plylst_BaslikAlbum;
                        wmp_Baslik.settings.volume = baslikSesiO;
                        wmp_Baslik.controls.play();
                        break;
                    case "tabPage_Sanatcilar":
                        wmp_Baslik.currentPlaylist = plylst_BaslikSanatcilar;
                        wmp_Baslik.settings.volume = baslikSesiO;
                        wmp_Baslik.controls.play();
                        break;
                    default:
                        try
                        {
                            wmp_Baslik.currentMedia = mediaBTN[Convert.ToInt16(konumO)];
                            wmp_Baslik.settings.volume = baslikSesiO;
                            wmp_Baslik.controls.play();
                        }
                        catch (Exception)
                        {
                        }
                        break;
                }
            }
        }

        public void AciklamaOynat()
        {
            if (aciklamaSesiAcikmiO)
            {//
                switch (konumO)
                {
                    case "tabPage_CalmaListeleri":
                        wmp_Aciklama.currentPlaylist = plylst_AciklamaCalmaListeleri;
                        wmp_Aciklama.settings.volume = aciklamaSesiO;
                        wmp_Aciklama.controls.play();
                        break;
                    case "tabPage_Muzik":
                        wmp_Aciklama.currentPlaylist = plylst_AciklamaMuzik;
                        wmp_Aciklama.settings.volume = aciklamaSesiO;
                        wmp_Aciklama.controls.play();
                        break;
                    case "tabPage_Video":
                        wmp_Aciklama.currentPlaylist = plylst_AciklamaVideo;
                        wmp_Aciklama.settings.volume = aciklamaSesiO;
                        wmp_Aciklama.controls.play();
                        break;
                    case "tabPage_Oynat":
                        wmp_Aciklama.currentPlaylist = plylst_AciklamaOynat;
                        wmp_Aciklama.settings.volume = aciklamaSesiO;
                        wmp_Aciklama.controls.play();
                        break;
                    case "tabPage_Ayarlar":
                        wmp_Aciklama.currentPlaylist = plylst_AciklamaAyarlar;
                        wmp_Aciklama.settings.volume = aciklamaSesiO;
                        wmp_Aciklama.controls.play();
                        break;
                    case "tabPage_Yardim":
                        wmp_Aciklama.currentPlaylist = plylst_AciklamaYardim;
                        wmp_Aciklama.settings.volume = aciklamaSesiO;
                        wmp_Aciklama.controls.play();
                        break;
                    default: break;
                }
            } //
        }

        private void wmp_Baslik_PlayStateChange(int NewState)
        {
                if (NewState == 8)
                {
                AciklamaOynat();
                }
        }

    }

    public class Uyari
    {
        private WMPLib.WindowsMediaPlayer wmp_Uyari;
        //IWMPPlaylist plylst_UyariveHata;
        bool uyariveHataSesiAcikmiO;
        int uyariveHataSesiO;
        IWMPMedia[] mediaUvH = new IWMPMedia[21]; //Çalma Listelerinde oynatılacak medyalar.

        public Uyari()
        {
            wmp_Uyari = new WMPLib.WindowsMediaPlayer();
            //wmp_Uyari.PlayStateChange += new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(wmp_Uyari_PlayStateChange);

            /* UYARILAR OLUŞTURULUYOR*/

            //plylst_UyariveHata = wmp_Uyari.playlistCollection.newPlaylist("SeslendirmeUyariveHata");
            //Medyalar oluşturuluyor.
            for (int i = 0; i <= mediaUvH.Length-1; i++)
            {
                mediaUvH[i] = wmp_Uyari.newMedia(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MediaPlayer\\Ses" + "\\u" + (i+1) + ".mp3");
            }

        }

        /// <summary>
        /// Uyarı ve Hata kodu olarak aşağıdaki ilgili kod gönderilir. 1-Uyarı, 2-Lütfen bekleyin, 3-Klasör seçiniz, 4-Eklenecek dosyaları seçiniz, 5-Klasör ekle, 6-Listeden sil 7-Dosyalar ekleniyor, 8-Dosya ekle, 9-Dosya seçiniz, 10-Dosya konumu, 11-Dosya adı, 12-Sanatçı, 13-Sil, 14-Süre, 15-Silinecek dosyaları seçiniz, 16-Seçilen dosyalar listelere ekleniyor, 17-Dosyalar eklendi, 18-Desteklenmeyen bazı dosyalar listelere eklenemedi, 19-Liste boş, 20- çık, 21- iptal
        /// </summary>
        public void Oynat(int uyariVeyaHataKodu, bool uyariSesiAcikmi, int uyariSesi)
        {
            uyariveHataSesiAcikmiO = uyariSesiAcikmi;
            uyariveHataSesiO = uyariSesi;
            if (uyariveHataSesiAcikmiO)
            {
                wmp_Uyari.currentMedia = mediaUvH[uyariVeyaHataKodu-1];
                wmp_Uyari.settings.volume = uyariveHataSesiO;
                wmp_Uyari.controls.play();
            }
        }

        public void Durdur()
        {
            wmp_Uyari.controls.stop();
            wmp_Uyari.close();


            //var prc = Process.GetProcessesByName("wmplayer ???");
            //if (prc.Length > 0) prc[prc.Length - 1].Kill();
        }

        //private void wmp_Uyari_PlayStateChange(int NewState)
        //{
        //    if (NewState == 8)
        //    {
        //    }
        //}
    }

}
