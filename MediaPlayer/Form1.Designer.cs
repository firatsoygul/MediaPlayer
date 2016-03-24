namespace MediaPlayer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mpTabControl1 = new MediaPlayer.MPTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mpTabControl2 = new MediaPlayer.MPTabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.mpTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.mpTabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mpTabControl1
            // 
            this.mpTabControl1.Controls.Add(this.tabPage1);
            this.mpTabControl1.Controls.Add(this.tabPage2);
            this.mpTabControl1.Controls.Add(this.tabPage3);
            this.mpTabControl1.Controls.Add(this.tabPage4);
            this.mpTabControl1.Controls.Add(this.tabPage5);
            this.mpTabControl1.Controls.Add(this.tabPage6);
            this.mpTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mpTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.mpTabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mpTabControl1.ItemSize = new System.Drawing.Size(160, 45);
            this.mpTabControl1.Location = new System.Drawing.Point(0, 0);
            this.mpTabControl1.Name = "mpTabControl1";
            this.mpTabControl1.SelectedIndex = 0;
            this.mpTabControl1.Size = new System.Drawing.Size(974, 506);
            this.mpTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.mpTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.mpTabControl2);
            this.tabPage1.Location = new System.Drawing.Point(4, 49);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(966, 453);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Çalma Listesi";
            // 
            // mpTabControl2
            // 
            this.mpTabControl2.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.mpTabControl2.Controls.Add(this.tabPage7);
            this.mpTabControl2.Controls.Add(this.tabPage8);
            this.mpTabControl2.Controls.Add(this.tabPage9);
            this.mpTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mpTabControl2.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.mpTabControl2.ItemSize = new System.Drawing.Size(70, 120);
            this.mpTabControl2.Location = new System.Drawing.Point(3, 3);
            this.mpTabControl2.Multiline = true;
            this.mpTabControl2.Name = "mpTabControl2";
            this.mpTabControl2.SelectedIndex = 0;
            this.mpTabControl2.Size = new System.Drawing.Size(960, 447);
            this.mpTabControl2.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.mpTabControl2.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.Transparent;
            this.tabPage7.BackgroundImage = global::MediaPlayer.Properties.Resources.ArkaplanListe;
            this.tabPage7.Location = new System.Drawing.Point(124, 4);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(832, 439);
            this.tabPage7.TabIndex = 0;
            this.tabPage7.Text = "Müzik Listeleri";
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.Color.Transparent;
            this.tabPage8.BackgroundImage = global::MediaPlayer.Properties.Resources.ArkaplanListe;
            this.tabPage8.Location = new System.Drawing.Point(124, 4);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(832, 439);
            this.tabPage8.TabIndex = 1;
            this.tabPage8.Text = "Video Listeleri";
            // 
            // tabPage9
            // 
            this.tabPage9.BackColor = System.Drawing.Color.Transparent;
            this.tabPage9.BackgroundImage = global::MediaPlayer.Properties.Resources.ArkaplanListe;
            this.tabPage9.Location = new System.Drawing.Point(124, 4);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(832, 439);
            this.tabPage9.TabIndex = 2;
            this.tabPage9.Text = "Düzenle";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.tabPage2.BackgroundImage = global::MediaPlayer.Properties.Resources.ArkaplanMuzik;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Location = new System.Drawing.Point(4, 49);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(966, 453);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Müzik";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.tabPage3.BackgroundImage = global::MediaPlayer.Properties.Resources.ArkaplanVideo;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Location = new System.Drawing.Point(4, 49);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(966, 453);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Video";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.tabPage4.BackgroundImage = global::MediaPlayer.Properties.Resources.ArkaplanOynat;
            this.tabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage4.Location = new System.Drawing.Point(4, 49);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(966, 453);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Oynat";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.tabPage5.BackgroundImage = global::MediaPlayer.Properties.Resources.ArkaplanAyarlar;
            this.tabPage5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage5.Location = new System.Drawing.Point(4, 49);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(966, 453);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Ayarlar";
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.tabPage6.BackgroundImage = global::MediaPlayer.Properties.Resources.ArkaplanYardim;
            this.tabPage6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage6.Location = new System.Drawing.Point(4, 49);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(966, 453);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Yardım";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(974, 506);
            this.Controls.Add(this.mpTabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mpTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.mpTabControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MPTabControl mpTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private MPTabControl mpTabControl2;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
    }
}

