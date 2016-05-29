using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaPlayer.Seslendirme;

namespace MediaPlayer.Gezinme
{
    public class Gezinme
    {
        Form1 frm1 = (Form1)Application.OpenForms["Form1"];
        MediaPlayer.Seslendirme.Uyari ses = new MediaPlayer.Seslendirme.Uyari();
        string tabNameO;
        bool tabDegisim;
        string[] tabCalmaListeleri = new string[3] { "tabPage_Tum_Listeler", "tabPage_Album", "tabPage_Sanatcilar"};
        string[] tabTumListe = new string[3] { "mpButon_Dosya_Ekle", "mpButon_Klasor_Ekle", "listView_Tum_Liste"};
        string[] tabOynat = new string[7] { "button_KontrolOynat", "button_KontrolDur", "button_KontrolDurdur", "button_KontrolGeri", "button_Kontrolileri", "trackBar_Ses", "trackBar_Oynat" };
        string[] tabAyarlar = new string[6] { "checkBox_BaslikSesleri", "trackBar_SeslendirmeBaslik", "checkBox_AciklamaSesleri", "trackBar_SeslendirmeAciklama", "checkBox_UyariveHataSesleri", "trackBar_SeslendirmeUyariveHata" };
        int dCalmaListeleri=0, dTumListe=0, dOynat=0, dAyarlar=0;

        public void gecisYap(string tabName) 
        {
            
            if (tabName == tabNameO) //Gelen tabName önceki ile aynımı
            {
                tabDegisim = true; //Aynıysa true
            }
            else
            {
                tabNameO = tabName; //Değilse eşitle
                tabDegisim = false; //ve false yap.
            }
            switch (tabName)
            {
                case "tabPage_CalmaListeleri":
                    if (tabDegisim == false)
                    {
                        dCalmaListeleri = 0;
                        frm1.tabPage_Tum_Listeler.Focus();
                        frm1.seslendir.Durdur();
                        frm1.seslendir.Oynat("tabPage_Tum_Listeler", frm1.seslendirmeBaslikAcikmi, frm1.seslendirmeAciklamaAcikmi, frm1.seslendirmeBaslikSesi, frm1.seslendirmeAciklamaSesi);
                        dCalmaListeleri = 1;
                    }
                    else
                    {
                        switch (dCalmaListeleri)
                        {
                            case 1:
                                frm1.tabPage_Album.Focus();
                                frm1.seslendir.Durdur();
                                frm1.seslendir.Oynat("tabPage_Album", frm1.seslendirmeBaslikAcikmi, frm1.seslendirmeAciklamaAcikmi, frm1.seslendirmeBaslikSesi, frm1.seslendirmeAciklamaSesi);
                                dCalmaListeleri = 2;
                                break;
                            case 2:
                                frm1.tabPage_Sanatcilar.Focus();
                                frm1.seslendir.Durdur();
                                frm1.seslendir.Oynat("tabPage_Sanatcilar", frm1.seslendirmeBaslikAcikmi, frm1.seslendirmeAciklamaAcikmi, frm1.seslendirmeBaslikSesi, frm1.seslendirmeAciklamaSesi);
                                dCalmaListeleri = 0;
                                break;
                            default:
                                break;
                        }

                    break;

                    }

                    break;
                case "tabPage_Muzik":
                    frm1.listView_Muzik.Focus();
                    break;
                case "tabPage_Video":
                    frm1.listView_Video.Focus();
                    break;
                case "tabPage_Oynat":
                    frm1.button_KontrolOynat.Focus();
                    break;
                case "tabPage_Ayarlar":
                    frm1.checkBox_BaslikSesleri.Focus();
                    break;
                case "tabPage_Yardim":

                    break;
                default:
                    break;
            }























            string[] ctrlNm = new string[7] { "button_KontrolOynat", "button_KontrolDur", "button_KontrolDurdur", "button_KontrolGeri", "button_Kontrolileri", "trackBar_Ses", "trackBar_Oynat" };
            if (frm1.mpTabControl_Ana_Menu.TabPages["tabPage_CalmaListeleri"].ContainsFocus)
            {
                int i = 0;
                string name = "";
                int sira;
                foreach (Control item in frm1.mpTabControl_Ana_Menu.TabPages[frm1.mpTabControl_Ana_Menu.SelectedIndex].Controls)
                {
                    if (item.Focused)
                    {
                        foreach (string str in ctrlNm)
                        {
                            if (str == item.Name)
                            {
                                name = str;   //Seçili olan control ismi.
                                sira = i;
                            }
                            i += 1;
                        }

                        //SelectNextControl(item, false, true, false, true);
                        //mpTabControl_Ana_Menu.TabPages[mpTabControl_Ana_Menu.SelectedIndex].Controls.IndexOf(item);
                    }
                }

                switch (name)
                {
                    case "button_KontrolOynat":
                        frm1.button_KontrolDur.Focus();     
                        break;
                    case "button_KontrolDur":
                        frm1.button_KontrolDurdur.Focus();
                        break;
                    case "button_KontrolDurdur":
                        frm1.button_KontrolGeri.Focus();
                        break;
                    case "button_KontrolGeri":
                        frm1.button_Kontrolileri.Focus();
                        break;
                    case "button_Kontrolileri":
                        frm1.trackBar_Ses.Focus();
                        break;
                    case "trackBar_Ses":
                        frm1.trackBar_Oynat.Focus();
                        break;
                    case "kontrolilerleme":
                        frm1.button_KontrolOynat.Focus();
                        break;
                    case "tabPage_Tum_Listeler":
                        frm1.mpTabControl_Listeler.SelectedIndex = 1;
                        break;
                    case "tabPage_Album":
                        frm1.mpTabControl_Listeler.SelectedIndex = 2;
                        break;
                        case "tabPage_Sanatcilar":
                        frm1.mpTabControl_Listeler.SelectedIndex = 0;
                        break;
                    default:
                        break;
                }
            }
            else 
            {
                string name = frm1.mpTabControl_Ana_Menu.TabPages[frm1.mpTabControl_Ana_Menu.SelectedIndex].Name;
                switch (name)
                {
                    case "tabPage_CalmaListeleri":
                        frm1.mpTabControl_Listeler.SelectedIndex = 0;
                        break;
                    case "tabPage_Muzik":
                        frm1.listView_Muzik.Focus();
                        break;
                    case "tabPage_Video":
                        frm1.listView_Video.Focus();
                        break;
                    case "tabPage_Oynat":
                        frm1.button_KontrolOynat.Focus();
                        break;
                    case "tabPage_Ayarlar":
                        frm1.checkBox_BaslikSesleri.Focus();
                        break;
                    case "tabPage_Yardim":

                        break;
                    default:
                        break;
                }
            }
        }
    }
}
