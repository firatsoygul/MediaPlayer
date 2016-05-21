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
    public class Seslendir
    {
        //WindowsMediaPlayer wmp = new WindowsMediaPlayer(); //Uyarı seslerini okuyan player.
        private WMPLib.WindowsMediaPlayer wmp_Baslik;
        private WMPLib.WindowsMediaPlayer wmp_Aciklama;
        private WMPLib.WindowsMediaPlayer wmp_UyariveHata;
        private WMPLib.WindowsMediaPlayer wmp_Media;

        IWMPMedia mediaCL1, mediaCL2, mediaCL3, mediaCL4, mediaCL5, mediaCL6, mediaCL7;
        IWMPMedia mediaM1, mediaM2;
        double durCL = 0, durM = 0;

        IWMPPlaylist plylst_BaslikCalmaListeleri;
        IWMPPlaylist plylst_BaslikMuzik;
        IWMPPlaylist plylst_BaslikVideo;
        IWMPPlaylist plylst_BaslikOynat;
        IWMPPlaylist plylst_BaslikAyarlar;
        IWMPPlaylist plylst_BaslikYardim;

        IWMPPlaylist plylst_AciklamaCalmaListeleri;
        IWMPPlaylist plylst_AciklamaMuzik;
        IWMPPlaylist plylst_AciklamaVideo;
        IWMPPlaylist plylst_AciklamaOynat;
        IWMPPlaylist plylst_AciklamaAyarlar;
        IWMPPlaylist plylst_AciklamaYardim;


        public Seslendir()
        {
            wmp_Baslik = new WMPLib.WindowsMediaPlayer();
            wmp_Aciklama = new WMPLib.WindowsMediaPlayer();
            wmp_UyariveHata = new WMPLib.WindowsMediaPlayer();
            wmp_Media = new WMPLib.WindowsMediaPlayer();

            //wmp_Baslik.PositionChange += new _WMPOCXEvents_PositionChangeEventHandler(wmp_Baslik_PositionChange);
            wmp_Baslik.PlayStateChange += new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(wmp_Baslik_PlayStateChange);
            //wmp_Baslik.PlayStateChange += wmp_Baslik_PlayStateChange;

            //Çalma Listeleri Menüsü seslendirmesi

            plylst_BaslikCalmaListeleri = wmp_Baslik.playlistCollection.newPlaylist("SeslendirmeBaslik");
            plylst_AciklamaCalmaListeleri = wmp_Media.playlistCollection.newPlaylist("SeslendirmeAciklamaCalmaListeleri");

            mediaCL1 = wmp_Media.newMedia(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MediaPlayer\\Ses" + "\\m1.mp3");
            mediaCL2 = wmp_Media.newMedia(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MediaPlayer\\Ses" + "\\a1.mp3");
            mediaCL3 = wmp_Media.newMedia(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MediaPlayer\\Ses" + "\\a2.mp3");
            mediaCL4 = wmp_Media.newMedia(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MediaPlayer\\Ses" + "\\a3.mp3");
            mediaCL5 = wmp_Media.newMedia(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MediaPlayer\\Ses" + "\\a4.mp3");
            mediaCL6 = wmp_Media.newMedia(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MediaPlayer\\Ses" + "\\a5.mp3");
            mediaCL7 = wmp_Media.newMedia(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MediaPlayer\\Ses" + "\\a6.mp3");

            plylst_BaslikCalmaListeleri.appendItem(mediaCL1);
            plylst_AciklamaCalmaListeleri.appendItem(mediaCL2);
            plylst_AciklamaCalmaListeleri.appendItem(mediaCL3);
            plylst_AciklamaCalmaListeleri.appendItem(mediaCL4);
            plylst_AciklamaCalmaListeleri.appendItem(mediaCL5);
            plylst_AciklamaCalmaListeleri.appendItem(mediaCL6);
            plylst_AciklamaCalmaListeleri.appendItem(mediaCL7);

            for (int i = 0; i < plylst_AciklamaCalmaListeleri.count; i++)
            {
                durCL += plylst_AciklamaCalmaListeleri.Item[i].duration;
            }

            //Muzik Menüsü Seslendirmesi

            plylst_BaslikMuzik = wmp_Baslik.playlistCollection.newPlaylist("SeslendirmeMuzik");
            plylst_AciklamaMuzik = wmp_Media.playlistCollection.newPlaylist("SeslendirmeAciklamaMuzik");

            mediaM1 = wmp_Media.newMedia(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MediaPlayer\\Ses" + "\\m2.mp3");
            //media2 = wmp_Media.newMedia(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MediaPlayer\\Ses" + "\\a7.mp3");

            plylst_BaslikMuzik.appendItem(mediaM1);
            //plylst_AciklamaCalmaListeleri.appendItem(mediaM2);

            for (int i = 0; i < plylst_AciklamaMuzik.count; i++)
            {
                durM += plylst_AciklamaMuzik.Item[i].duration;
            }



            //wmp.CurrentItemChange += new _WMPOCXEvents_PlayStateChangeEventHandler(wmp_CurrentItemChange);
        }


        public void sesOynat(string konum, bool baslikSesiAcikmi, bool aciklamaSesiAcikmi, bool uyariSesiAcikmi, int baslikSesi, int aciklamaSesi, int uyariveHataSesi)
        {
            wmp_Baslik.controls.stop();
            wmp_Aciklama.controls.stop();
            wmp_UyariveHata.controls.stop();

            wmp_Baslik.close();
            wmp_Aciklama.close();
            wmp_UyariveHata.close();
            wmp_Media.close();

            //var prc = Process.GetProcessesByName("wmplayer");
            //if (prc.Length > 0) prc[prc.Length - 1].Kill();

            

            switch (konum)
            {
                case "tabPage_CalmaListeleri":
                    
                    if (baslikSesiAcikmi)
                    {
                        
                        wmp_Baslik.currentPlaylist = plylst_BaslikCalmaListeleri;
                        wmp_Baslik.settings.volume = baslikSesi;
                        wmp_Baslik.controls.play();
                        
                    }
                    
                    if (aciklamaSesiAcikmi)
                    {
                        System.Threading.Thread.Sleep(Convert.ToInt32(wmp_Baslik.currentMedia.duration));
                        
                        wmp_Aciklama.currentPlaylist = plylst_AciklamaCalmaListeleri;
                        wmp_Aciklama.settings.volume = aciklamaSesi;
                        wmp_Aciklama.controls.play();
                      
                        
                    }
                    
                    if (uyariSesiAcikmi)
                    {
                        System.Threading.Thread.Sleep(Convert.ToInt32(durCL));
                        // IWMPPlaylist plylst_UyariveHata = wmp_UyariveHata.playlistCollection.newPlaylist("SeslendirmeUyariveHata");
                        //WMPLib.IWMPMedia media8;
                        //media8 = wmp_UyariveHata.newMedia(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MediaPlayer\\Ses" + "\\a1.mp3");
                        //plylst_UyariveHata.appendItem(media8);

                        //wmp_UyariveHata.currentPlaylist = plylst_UyariveHata;
                        //wmp_UyariveHata.controls.play();
                    }


                    break;
                case "tabPage_Muzik":

                    if (baslikSesiAcikmi)
                    {

                        wmp_Baslik.currentPlaylist = plylst_BaslikMuzik;
                        wmp_Baslik.settings.volume = baslikSesi;
                        wmp_Baslik.controls.play();

                    }

                    if (aciklamaSesiAcikmi)
                    {
                        System.Threading.Thread.Sleep(Convert.ToInt32(wmp_Baslik.currentMedia.duration));

                        wmp_Aciklama.currentPlaylist = plylst_AciklamaMuzik;
                        wmp_Aciklama.settings.volume = aciklamaSesi;
                        wmp_Aciklama.controls.play();


                    }

                    if (uyariSesiAcikmi)
                    {
                        System.Threading.Thread.Sleep(Convert.ToInt32(durM));
                    }

                    wmp_Baslik.URL = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MediaPlayer\\Ses" + "\\m2.mp3";
                    break;
                case "tabPage_Video":
                    wmp_Baslik.URL = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MediaPlayer\\Ses" + "\\m3.mp3";
                    break;
                case "tabPage_Oynat":
                    wmp_Baslik.URL = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MediaPlayer\\Ses" + "\\m4.mp3";
                    break;
                case "tabPage_Ayarlar":
                    wmp_Baslik.URL = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MediaPlayer\\Ses" + "\\m5.mp3";
                    break;
                case "tabPage_Yardim":
                    wmp_Baslik.URL = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MediaPlayer\\Ses" + "\\m6.mp3";
                    break;
                default: break;
            }

        }

        private void wmp_Baslik_PositionChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {

        }

        private void wmp_Baslik_PlayStateChange(int NewState)
        {
                if (NewState == 8)
                {
                    //Your Code Here
                }
        }

        //public void sesOynat(string konum, bool baslikSesiAcikmi, bool aciklamaSesiAcikmi, bool uyariSesiAcikmi, int baslikSesi, int aciklamaSesi, int uyariveHataSesi)
        //{
        //    wmp_Baslik.controls.stop();
        //    wmp_Aciklama.controls.stop();
        //    wmp_UyariveHata.controls.stop();

        //    wmp_Baslik.close();
        //    wmp_Aciklama.close();
        //    wmp_UyariveHata.close();
        //    wmp_Media.close();

        //    var prc = Process.GetProcessesByName("wmplayer");
        //    if (prc.Length > 0) prc[prc.Length - 1].Kill();

        //    double dur = 0;

        //    switch (konum)
        //    {
        //        case "tabPage_CalmaListeleri":

        //            if (baslikSesiAcikmi)
        //            {
        //                IWMPPlaylist plylst_Baslik = wmp_Baslik.playlistCollection.newPlaylist("SeslendirmeBaslik");
        //                WMPLib.IWMPMedia media1;
        //                media1 = wmp_Baslik.newMedia(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MediaPlayer\\Ses" + "\\m1.mp3");
        //                plylst_Baslik.appendItem(media1);
        //                wmp_Baslik.currentPlaylist = plylst_Baslik;
        //                wmp_Baslik.settings.volume = baslikSesi;
        //                wmp_Baslik.controls.play();

        //            }

        //            if (aciklamaSesiAcikmi)
        //            {
        //                wmp_Media.close();
        //                System.Threading.Thread.Sleep(Convert.ToInt32(wmp_Baslik.currentMedia.duration));
        //                WMPLib.IWMPPlaylist plylst_Aciklama = wmp_Media.playlistCollection.newPlaylist("SeslendirmeAciklama");


        //                media2 = wmp_Media.newMedia(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MediaPlayer\\Ses" + "\\a1.mp3");
        //                media3 = wmp_Media.newMedia(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MediaPlayer\\Ses" + "\\a2.mp3");
        //                media4 = wmp_Media.newMedia(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MediaPlayer\\Ses" + "\\a3.mp3");
        //                media5 = wmp_Media.newMedia(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MediaPlayer\\Ses" + "\\a4.mp3");
        //                media6 = wmp_Media.newMedia(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MediaPlayer\\Ses" + "\\a5.mp3");
        //                media7 = wmp_Media.newMedia(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MediaPlayer\\Ses" + "\\a6.mp3");

        //                plylst_Aciklama.appendItem(media2);
        //                plylst_Aciklama.appendItem(media3);
        //                plylst_Aciklama.appendItem(media4);
        //                plylst_Aciklama.appendItem(media5);
        //                plylst_Aciklama.appendItem(media6);
        //                plylst_Aciklama.appendItem(media7);

        //                for (int i = 0; i < plylst_Aciklama.count; i++)
        //                {
        //                    dur += plylst_Aciklama.Item[i].duration;
        //                }

        //                wmp_Aciklama.currentPlaylist = plylst_Aciklama;
        //                wmp_Aciklama.settings.volume = aciklamaSesi;
        //                wmp_Aciklama.controls.play();


        //            }
        //            System.Threading.Thread.Sleep(Convert.ToInt32(dur));
        //            if (uyariSesiAcikmi)
        //            {
        //                // IWMPPlaylist plylst_UyariveHata = wmp_UyariveHata.playlistCollection.newPlaylist("SeslendirmeUyariveHata");
        //                //WMPLib.IWMPMedia media8;
        //                //media8 = wmp_UyariveHata.newMedia(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MediaPlayer\\Ses" + "\\a1.mp3");
        //                //plylst_UyariveHata.appendItem(media8);

        //                //wmp_UyariveHata.currentPlaylist = plylst_UyariveHata;
        //                //wmp_UyariveHata.controls.play();
        //            }


        //            break;
        //        case "tabPage_Muzik":
        //            wmp_Baslik.URL = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MediaPlayer\\Ses" + "\\m2.mp3";
        //            break;
        //        case "tabPage_Video":
        //            wmp_Baslik.URL = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MediaPlayer\\Ses" + "\\m3.mp3";
        //            break;
        //        case "tabPage_Oynat":
        //            wmp_Baslik.URL = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MediaPlayer\\Ses" + "\\m4.mp3";
        //            break;
        //        case "tabPage_Ayarlar":
        //            wmp_Baslik.URL = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MediaPlayer\\Ses" + "\\m5.mp3";
        //            break;
        //        case "tabPage_Yardim":
        //            wmp_Baslik.URL = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MediaPlayer\\Ses" + "\\m6.mp3";
        //            break;
        //        default: break;
        //    }

        //}
    }

    //Çalışırken durdurulabilen iş parçacığı oluşturmayı sağlıyor.
    //( http://stackoverflow.com/questions/800767/how-to-kill-background-worker-completely )

    public class AbortableBackgroundWorker : BackgroundWorker
    {

        private Thread workerThread;

        protected override void OnDoWork(DoWorkEventArgs e)
        {
            workerThread = Thread.CurrentThread;
            try
            {
                base.OnDoWork(e);
            }
            catch (ThreadAbortException)
            {
                e.Cancel = true; 
                Thread.ResetAbort(); 
            }
        }


        public void Abort()
        {
            if (workerThread != null)
            {
                workerThread.Abort();
                workerThread = null;
            }
        }
    }
}
