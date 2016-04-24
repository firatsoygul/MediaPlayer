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
        public ListViewItem klasorden_Listele(int no, string dosya) // listview son sıra numarası ve dosya yolu
        {

            Form1 frm1 = (Form1)Application.OpenForms["Form1"];

            ListViewItem yItem = new ListViewItem();
            IWMPMedia media = frm1.axWindowsMediaPlayer1.newMedia(dosya);
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

        DataTable table1 = new DataTable("Bilgiler"); //Tablo oluşturuluyor.

        public ListeGrup()
        {
            //Kolonlar oluşturuluyor.
            table1.Columns.Add("DosyaAdi");
            table1.Columns.Add("Dizin");
            table1.Columns.Add("Sure");
            table1.Columns.Add("Album");
            table1.Columns.Add("Sanatci");
            table1.Columns.Add("Tur");
        }

        public void Ekle(string yol) //Dosya dizinini dışardan alarak dosya bilgilerini tablolara ekler.
        {
            IWMPMedia media = frm1.axWindowsMediaPlayer1.newMedia(yol); //media dosyası tanımlanıyor.
            string sanatci, album, tur;
            //Medyanın sanatçı bilgisi boşsa, Bilinmeyen Sanatçı görünecek.
            if (media.getItemInfo("Author") == "")
            {
                sanatci = "Bilinmeyen Sanatçı";
            }
            else
            {
                sanatci = media.getItemInfo("Author");
            }
            //Medyanın albüm bilgisi boşsa, Bilinmeyen Albüm görünecek.
            if (media.getItemInfo("Album") == "")
            {
                album = "Bilinmeyen Albüm";
            }
            else
            {
                album = media.getItemInfo("Album");
            }

            tur = Path.GetExtension(media.sourceURL);

            //Bilgiler DataTable satırlarına ekleniyor.
            table1.Rows.Add(media.name, media.sourceURL, media.durationString, album, sanatci, tur);
        }


        public void sil() //Tablo satırlarının heppsini siler.
        {
            for (int i = 0; i > table1.Rows.Count; i++)
            {
                table1.Rows[i].Delete();
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

    }
    #endregion
}
