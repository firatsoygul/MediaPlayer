using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer.Uyari
{

    #region MPUyari

    class MPUyari : Panel
    {
        Form1 frm1 = (Form1)Application.OpenForms["Form1"];

        private string turu, ayrinti, baslik;
        Label lbl_Baslik = new Label();
        Label lbl_Ayrinti = new Label();
        Timer tm = new Timer();

        private int sure;

        public MPUyari()
        {


            // panel_Uyari

            this.Controls.Add(lbl_Ayrinti);
            this.Controls.Add(lbl_Baslik);
            //this.Controls.Add(tm);
            this.Location = new System.Drawing.Point(-10, 412);
            this.Name = "panel_Uyari";
            this.Size = new System.Drawing.Size(982, 107);
            this.TabIndex = 1;
            this.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));

            // label_Baslık

            lbl_Baslik.AutoSize = true;
            lbl_Baslik.ForeColor = System.Drawing.Color.White;
            lbl_Baslik.Location = new System.Drawing.Point(425, 10);
            lbl_Baslik.Name = "label_Uyari_Baslık";
            lbl_Baslik.Size = new System.Drawing.Size(115, 41);
            lbl_Baslik.TabIndex = 0;
            lbl_Baslik.Text = "";
            lbl_Baslik.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom )));

            // label_Ayrinti

            lbl_Ayrinti.AutoSize = true;
            lbl_Ayrinti.ForeColor = System.Drawing.Color.White;
            lbl_Ayrinti.Location = new System.Drawing.Point(310, 52);
            lbl_Ayrinti.Name = "label_Uyari_Ayrinti";
            lbl_Ayrinti.Size = new System.Drawing.Size(223, 32);
            lbl_Ayrinti.TabIndex = 1;
            lbl_Ayrinti.Text = "";
            lbl_Ayrinti.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            lbl_Ayrinti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom )));
        }

        // Sırasıyla, Uyarı panelinin türü (Uyarı, Hata veya Onay olabilir), Uyarı ayrıntısı ve Uyarı başlığı.
        public void Goster(string uyari_turu="", string uyari_ayrintisi="", string uyari_basligi = "", int uyari_suresi=4000)
        {

            //turu = uyari_turu;
            ayrinti = uyari_ayrintisi;
            baslik = uyari_basligi;
            sure = uyari_suresi;

            //Uyarının türüne göre panel rengi ve başlık girilmemişse başlık oluşturuluyor.
            switch (uyari_turu)
            {
                case "Hata":
                    if (uyari_basligi == "")
                    {
                        baslik = "HATA !";
                    }
                    this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60))))); 
                    break;
                case "Uyarı":
                    if (uyari_basligi == "")
                    {
                        baslik = "UYARI !";
                    }
                    this.BackColor = System.Drawing.Color.DarkOrange;
                    break;
                case "Onay":
                    if (uyari_basligi == "")
                    {
                        baslik = "ONAY";
                    }
                    this.BackColor = System.Drawing.Color.LightSeaGreen;
                    break;
                default:
                    if (uyari_basligi == "")
                    {
                       // baslik = "Başlık";
                    }
                    this.BackColor = System.Drawing.Color.Black;
                    break;
            }
            //Başlık ve ayrıntı labellerinin fontları ayarlanıyor.
            lbl_Baslik.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            lbl_Ayrinti.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            //Başlık ve ayrıntı labellerinin textleri ayarlanıyor.
            lbl_Baslik.Text = baslik;
            lbl_Ayrinti.Text = ayrinti;

            frm1.Controls.Add(this); // Bu bileşen, Form1 e ait bir bileşen olarak tanımlanıyor

            this.Visible = true; // Bileşeni göster.
            this.BringToFront(); //Bileşeni en öne getir.
            lbl_Baslik.Visible = true; // Başlık labelini göster.
            lbl_Ayrinti.Visible = true; // Ayrıntı labelini göster.

            tm.Interval = uyari_suresi;
            tm.Enabled = true;
            tm.Tick += new EventHandler(tm_tick);



        }

        private void tm_tick (object sender, EventArgs e)
        {
            this.Visible = false; // Bileşeni göster.
            lbl_Baslik.Visible = false; // Başlık labelini göster.
            lbl_Ayrinti.Visible = false; // Ayrıntı labelini göster.
            tm.Enabled = false;
        }
    }
    #endregion MPUyari

}
