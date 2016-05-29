using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Threading;

namespace MediaPlayer.DizinYoneticisi
{
    public partial class DizinYonetici : Form
    {
        Form1 frm1 = (Form1)Application.OpenForms["Form1"];

        public DizinYonetici()
        {
            InitializeComponent();
        }

        private void DizinYonetici_Load(object sender, EventArgs e)
        {
            frm1.seslendir.Durdur();
            frm1.SesliUyari.Durdur();
            //dizinListele();
            hddListele();

            listView_dizinler.Focus();
            listView_dizinler.Select();
            listView_dizinler.Items[0].Focused = true;
            listView_dizinler.Items[0].Selected = true;
        }

        private void listView_dizinler_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            //frm1.ses.SpeakAsyncCancelAll();
            if (listView_dizinler.SelectedItems.Count > 0)
            {
                dizinSec();
                listView_dizinler.Items[0].Focused = true;
                listView_dizinler.Items[0].Selected = true;
                //listView_dizinler.SelectedItems[0].SubItems[0].Text
            }
        }

        private void listView_dizinler_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
            {

                frm1.ses.SpeakAsyncCancelAll();
                if (listView_dizinler.SelectedItems.Count > 0)
                {
                    dizinSec();
                    listView_dizinler.Items[0].Focused = true;
                    listView_dizinler.Items[0].Selected = true;
                }
            }

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void listView_dizinler_SelectedIndexChanged(object sender, EventArgs e)
        {
            frm1.ses.SpeakAsyncCancelAll();
            if (listView_dizinler.SelectedItems.Count > 0)
            {

                if (listView_dizinler.SelectedItems[0].Index == 0)
                {
                    frm1.ses.SpeakAsync(listView_dizinler.SelectedItems[0].Text);
                    //frm1.ses.SpeakAsync(linkSplit(listView_dizinler.Items[0].Text)[linkSplit(listView_dizinler.Items[0].Text).Length - 1]);
                }
                else
                {
                    frm1.ses.SpeakAsync(listView_dizinler.SelectedItems[0].SubItems[0].Text);
                }
            }
        }

        private void DizinYonetici_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void mpButon_klasorEkle2_Click(object sender, EventArgs e)
        {
            if (listView_dizinler.SelectedItems.Count > 0)
            {
                dizinGonder();
                frm1.dizinEkle(secilenDizin);
                frm1.ses.SpeakAsyncCancelAll();
                this.Close();
            }
            else
            {
                this.Close();
            }
        }

        public void hddListele()//Bilgisayara bağlı hdd listeler.
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            listView_dizinler.Items.Add("Bilgisayarım");// Hdd lerin en başında ilk satırda Bilgisayarım yazıyor.
            foreach (DriveInfo d in allDrives)
            {
                listView_dizinler.Items.Add(d.Name.Split(Path.DirectorySeparatorChar)[0]); // hdd dizininin sonundaki \ kesme işareti atılıyor.
                //if (d.IsReady == true)
                //{
                //    listView_dizinler.Items.Add("  Volume label: {0}", d.VolumeLabel);
                //}
            }
        }

        public void dizinListele(string gelenDizin)
        {
            try
            {
                //label_tamDizin.Text = gelenDizin;
                //string[] dizinler = Directory.GetDirectories(@"c:\");
                string[] dizinler = Directory.GetDirectories(@gelenDizin);
                foreach (ListViewItem item in listView_dizinler.Items) // Liste temizleniyor.
                {
                    listView_dizinler.Items[item.Index].Remove();
                }

                /*ilk sıra*/
                ListViewItem itemD = new ListViewItem();
                itemD.Text = gelenDizin;
                itemD.BackColor = Color.Black;
                itemD.ForeColor = Color.Silver;
                listView_dizinler.Items.Add(itemD);
                foreach (string dizin in dizinler) // Dizin sayaısı kadar döngüye giriliyor.
                {

                    ListViewItem item = new ListViewItem();
                    item.Text = linkSplit(dizin)[linkSplit(dizin).Length - 1];
                    //item.SubItems.Add(linkSplit(dizin));
                    listView_dizinler.Items.Add(item);
                }
            }
            catch (Exception)
            {

            }
        }

        public string[] linkSplit(string yol)//Gelen string dizin adresini '\' işaretlerinden ayırır ve parçalar halinde dizine atar, dizi olarak çıkartır.
        {
            string[] kesik = yol.Split(Path.DirectorySeparatorChar);
            return kesik;
        }

        public void dizinSec()
        {
            if (listView_dizinler.SelectedItems[0].Index == 0) //İlk satıra tıklanırsa, dizinlerde geriye doğru hareket ediliyor. Dizinlerden  çıkılıyor.
            {
                try
                {
                    //Seçilen satırın textini dizine çevir, çevirilen dizini '\' işaretlerine göre bölümle, en sonda kalan bölümün sonuna '\' ekle ve bu bölümü asıl textin içinden çıkar.
                    string a = listView_dizinler.SelectedItems[0].Text.Replace(Path.GetDirectoryName(listView_dizinler.SelectedItems[0].Text).Split(Path.DirectorySeparatorChar).Last() + @"\", string.Empty);
                    dizinListele(a);//Oluşan linki metoda gönder.
                }
                catch (Exception)
                {
                    foreach (ListViewItem item in listView_dizinler.Items) // Liste temizleniyor.
                    {
                        listView_dizinler.Items[item.Index].Remove();
                    }
                    hddListele();
                }

            }
            else //İki ya da sonraki satırlara tıklanırsa dizinlerde ileri doğru hareket ediliyor, dizinlere giriliyor.
            {
                if (listView_dizinler.Items[0].Text == "Bilgisayarım")//Ana dizin olarak Bilgisayarım görünüyorsa...
                {
                    dizinListele(listView_dizinler.SelectedItems[0].Text + @"\"); //Ana dizini tıklanan itemden al.
                }
                else
                {
                    dizinListele(listView_dizinler.Items[0].Text + listView_dizinler.SelectedItems[0].Text + @"\"); //Ana dizini ilk itemden al.
                }

            }
        }

        public void dizinGonder() //Ana forma gönderilecek dizinler için.
        {
            if (listView_dizinler.SelectedItems[0].Index == 0) //İlk satıra tıklanırsa, dizinlerde geriye doğru hareket ediliyor. Dizinlerden  çıkılıyor.
            {
                try
                {
                    if (listView_dizinler.SelectedItems[0].Text == "Bilgisayarım")//Bilgisayarım seçildiyse
                    {
                        dizinDizisiOlustur(@"C:\"); //C: hddsini al.
                    }
                    else
                    {
                        //listvievin ilk satırı alınıyor.
                        string a = listView_dizinler.SelectedItems[0].Text;
                        dizinDizisiOlustur(a);//Oluşan linki metoda gönder.
                    }
                }
                catch (Exception)
                {

                }

            }
            else //İki ya da sonraki satırlara tıklanırsa...
            {
                if (listView_dizinler.Items[0].Text == "Bilgisayarım")//Ana dizin olarak Bilgisayarım görünüyorsa...
                {
                    dizinDizisiOlustur(listView_dizinler.SelectedItems[0].Text + @"\"); //Ana dizini tıklanan itemden al.
                }
                else
                {
                    dizinDizisiOlustur(listView_dizinler.Items[0].Text + listView_dizinler.SelectedItems[0].Text + @"\"); //Ana dizini ilk itemden al, seçilen satırı da sonuna ekle.
                }

            }
        }
        public string secilenDizin;
        public void dizinDizisiOlustur(string gelenDizin) // Ana forma gönderilecek dizi değişkeni oluşturur.
        {
            try
            {
                ////string[] dizinler = Directory.GetDirectories(@"c:\");
                //string[] dizinler = Directory.GetDirectories(@gelenDizin); //Seçilen dizinin alt dizinleri.

                //foreach (string dizin in dizinler) // Dizin sayaısı kadar döngüye giriliyor.
                //{
                //    ListViewItem item = new ListViewItem();
                //    item.Text = linkSplit(dizin)[linkSplit(dizin).Length - 1];
                //    listView_dizinler.Items.Add(item);
                //}
                secilenDizin = gelenDizin;
            }
            catch (Exception)
            {
                secilenDizin = @"C:\";
            }
        }

        private void mpButon_klasorEkle2_Enter(object sender, EventArgs e)
        {
            frm1.ses.SpeakAsyncCancelAll();
            frm1.SesliUyari.Oynat(5, frm1.seslendirmeUyariveHataAcikmi, frm1.seslendirmeUyariveHataSesi);
        }

        private void mpButon_klasorEkle2_Leave(object sender, EventArgs e)
        {
            frm1.SesliUyari.Durdur();
        }

        private void mpButon_klasorEkle2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void mpButon_iptal_Enter(object sender, EventArgs e)
        {
            frm1.ses.SpeakAsyncCancelAll();
            frm1.SesliUyari.Oynat(20, frm1.seslendirmeUyariveHataAcikmi, frm1.seslendirmeUyariveHataSesi);
        }

        private void mpButon_iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DizinYonetici_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm1.seslendir.Durdur();
            frm1.SesliUyari.Durdur();
            frm1.ses.SpeakAsyncCancelAll();
        }
    }
}
