using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data;
using System.IO;

namespace MediaPlayer.ListelemeIslemleri
{
    #region Listele
    class Listele
    {
        public ListViewItem klasorden_Listele(int no, string dosyaYolu) // listview son sıra numarası ve dosya yolu
        {

            Form1 frm1 = (Form1)Application.OpenForms["Form1"];

            ListViewItem yItem = new ListViewItem();
            IWMPMedia media = frm1.axWindowsMediaPlayer1.newMedia(dosyaYolu);
            no += 1;
            yItem.Text = no.ToString();
            yItem.SubItems.AddRange(new[] { media.name, media.durationString, media.sourceURL });
            return yItem;
        }
    }
    #endregion

    #region ListeGrup  //Eklenen dosyaların bilgilerini, DataTable içinde gruplar halinde tutar ve istenildiğinde sunar.
    class ListeGrup 
    {
        Form1 frm1 = (Form1)Application.OpenForms["Form1"];
        private WMPLib.WindowsMediaPlayer wmp_Listele;
        IWMPMedia mediaL;

        DataTable table1 = new DataTable("Bilgiler"); //Tablo oluşturuluyor.
        DataTable table2 = new DataTable("Sorgu"); //Sorgu tablosu oluşturuluyor.

        public ListeGrup()
        {
            wmp_Listele = new WMPLib.WindowsMediaPlayer();
            //Kolonlar oluşturuluyor.
            table1.Columns.Add("DosyaAdi");
            table1.Columns.Add("Dizin");
            table1.Columns.Add("Sure");
            table1.Columns.Add("Album");
            table1.Columns.Add("Sanatci");
            table1.Columns.Add("Tur");

            table2.Columns.Add("DosyaAdi");
            table2.Columns.Add("Dizin");
            table2.Columns.Add("Sure");
            table2.Columns.Add("Album");
            table2.Columns.Add("Sanatci");
            table2.Columns.Add("Tur");

        }

        public void Ekle(string yol, params string[] dosya_Turu) //Dosya dizinini dışardan alarak dosya bilgilerini tablolara ekler.
        {
            mediaL = wmp_Listele.newMedia(yol); //media dosyası tanımlanıyor.
            string sanatci, album, tur;

            //Medyanın sanatçı bilgisi boşsa, Bilinmeyen Sanatçı görünecek.
            if (mediaL.getItemInfo("Author") == "")
            {
                sanatci = "Bilinmeyen Sanatçı";
            }
            else
            {
                sanatci = mediaL.getItemInfo("Author");
            }
            //Medyanın albüm bilgisi boşsa, Bilinmeyen Albüm görünecek.
            if (mediaL.getItemInfo("Album") == "")
            {
                album = "Bilinmeyen Albüm";
            }
            else
            {
                album = mediaL.getItemInfo("Album");
            }

            tur = Path.GetExtension(mediaL.sourceURL);

            //Bilgiler DataTable satırına ekleniyor.
            table1.Rows.Add(mediaL.name, mediaL.sourceURL, mediaL.durationString, album, sanatci, tur);
        }


        public void sil(string tabloAdi="") //Tablo satırlarını siler.
        {
                switch (tabloAdi)
                {
                    case "Bilgi":
                    for (int i = 0; i < table1.Rows.Count; i++)
                    {
                        table1.Rows.RemoveAt(i);
                    }
                    table1.AcceptChanges();
                    break;
                    case "Sorgu":
                    for (int i = 0; i < table2.Rows.Count; i++)
                    {
                        table2.Rows.RemoveAt(i);
                    }
                    table2.AcceptChanges();
                        break;
                    default:
                    for (int i = 0; i < table1.Rows.Count; i++)
                    {
                        table1.Rows.RemoveAt(i);
                    }
                    table1.AcceptChanges();
                    for (int i = 0; i < table2.Rows.Count; i++)
                    {
                        table2.Rows.RemoveAt(i);
                    }
                    table2.AcceptChanges();
                    break;
                }
        }


        public ListViewItem Bilgi(int siraNo, params string[] grup) //Medya bilgileri döndürülüyor.
        {
            ListViewItem Item = new ListViewItem(); //Yeni listViewItem oluşturuluyor.
            try
            {
                Item.Text = table1.Rows[siraNo][grup[0]].ToString(); //Yeni oluşturulan listViewItem ilk sutununa, DateTablodaki istenilen satır ve sütundaki bilgi giriliyor.
            }
            catch (Exception)
            {

                Item.Text = grup[0];  //Eğer istenen bilgi tablolarda yok ise, istenen bilginin kendisi Itemin ilk değeri olarak giriliyor.
            }

            for (int i = 1; i < grup.Length; i++) // Itemin sonraki sutunlarını doldurmak için döngüye giriliyor.
            {
                try
                {
                    Item.SubItems.Add(table1.Rows[siraNo][grup[i]].ToString()); //Yeni oluşturulan listViewItem sonraki sutunlarına, DateTablodaki istenilen satır ve sütundaki bilgiler sırayla giriliyor.
                }
                catch (Exception)
                {
                    Item.SubItems.Add(grup[i]); //Eğer istenen bilgi tablolarda yok ise, istenen bilginin kendisi, Itemin sutununa değer olarak giriliyor.
                }          
                
            }

            return Item;
        }
        public void Sorgu(params string[] turler) //İstenen dosya türleri.
        { 
            /* Sorgu oluşturuluyor. */
            string srg = "Tur IN ('" + turler[0];
            for (int i = 1; i < turler.Length; i++)
            {
                srg += "', '" + turler[i];
            }
            srg += "')";

            DataRow[] dr = table1.Select(srg); //Sorgu sonucu DataRow dizinine aktarılıyor.
            
            /*Dizindeki bilgiler tabloya aktarılıyor.*/
            for (int i = 0; i < dr.Length; i++)
            {
                DataRow nr = table2.NewRow();
                nr["DosyaAdi"] = dr[i]["DosyaAdi"];
                nr["Dizin"] = dr[i]["Dizin"];
                nr["Sure"] = dr[i]["Sure"];
                nr["Album"] = dr[i]["Album"];
                nr["Sanatci"] = dr[i]["Sanatci"];
                nr["Tur"] = dr[i]["Tur"];
                table2.Rows.Add(nr);
            }
        }

        /// <summary>
        /// Dosya bilgileri listeye ekleneceği sıra ile karışık çağrılabilir Örn. SorguBilgi(new[] { "DosyaAdi", "Sure", "Dizin", "Album" });
        /// </summary>
        public List<ListViewItem> SorguBilgi(string[] grup)
        {
            List<ListViewItem> ItemList;

            if (table2.Rows.Count>0)
            {
                ItemList = new List<ListViewItem>();
                
                for (int i = 0; i < table2.Rows.Count; i++)
                {
                    ListViewItem Items = new ListViewItem(); //Yeni listViewItem oluşturuluyor.
                  try
                  {
                    switch (table2.Rows[i]["Tur"].ToString())
                    {
                        case ".amr":
                            Items.ImageKey = "amr.png";
                            break;
                        case ".mp3":
                            Items.ImageKey = "mp3.png";
                            break;
                        case ".wav":
                            Items.ImageKey = "wav.png";
                            break;
                        case ".wma":
                            Items.ImageKey = "wma.png";
                            break;
                        case ".avi":
                            Items.ImageKey = "avi.png";
                            break;
                        case ".mp4":
                            Items.ImageKey = "mp4.png";
                            break;
                        case ".mpeg":
                            Items.ImageKey = "mpeg.png";
                            break;
                        case ".mpg":
                            Items.ImageKey = "mpg.png";
                            break;
                        case ".wmv":
                            Items.ImageKey = "wmv.png";
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception)
                {
                        //Aşağıdaki kod çalıştırıldığında eğer eklenen dosya türü tablolarda yok ise, istenen bilginin kendisi ıtemin ilk değeri olarak giriliyor,
                        //desteklenmeyen dosyalar için listede uyarı görüntülenir.
                        //Items.Text = grup[i];
                        //Items.SubItems.Add("Eklenen dosya desteklenmiyor.");
                    }

                    for (int j = 0; j < grup.Length; j++) // ıtemin sonraki sutunlarını doldurmak için döngüye giriliyor.
                {
                    try
                    {
                        Items.SubItems.Add(table2.Rows[i][grup[j]].ToString()); //Yeni oluşturulan listViewItem sonraki sutunlarına, DateTablodaki istenilen satır ve sütundaki bilgiler sırayla giriliyor.
                    }
                    catch (Exception)
                    {
                         //Aşağıdaki kod çalıştırıldığında eğer eklenen dosya türü bilgisi tablolarda yok ise,
                         //listede uyarı görüntülenir.
                         //Items.SubItems.Add("Dosya bilgisi bulunamadı.");
                        }

                    }
                    ItemList.Add(Items);
              }
                return ItemList;
            }
            else
            {
                return ItemList = null;
            }

            
        }
    }
    #endregion
}
