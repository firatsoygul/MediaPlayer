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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mpTabControl1 = new MediaPlayer.MPTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mpTabControl2 = new MediaPlayer.MPTabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.column_No = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_DosyaAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Sure = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Konum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mpButon3 = new MediaPlayer.MPButon();
            this.mpButon2 = new MediaPlayer.MPButon();
            this.mpButon1 = new MediaPlayer.MPButon();
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
            this.tabPage7.SuspendLayout();
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
            this.mpTabControl1.Size = new System.Drawing.Size(964, 561);
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
            this.tabPage1.Size = new System.Drawing.Size(956, 508);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Çalma Listeleri";
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
            this.mpTabControl2.Size = new System.Drawing.Size(950, 502);
            this.mpTabControl2.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.mpTabControl2.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.Transparent;
            this.tabPage7.BackgroundImage = global::MediaPlayer.Properties.Resources.ArkaplanListe;
            this.tabPage7.Controls.Add(this.listView1);
            this.tabPage7.Controls.Add(this.mpButon3);
            this.tabPage7.Controls.Add(this.mpButon2);
            this.tabPage7.Controls.Add(this.mpButon1);
            this.tabPage7.Location = new System.Drawing.Point(124, 4);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(822, 494);
            this.tabPage7.TabIndex = 0;
            this.tabPage7.Text = "Tüm Liste";
            // 
            // listView1
            // 
            this.listView1.BackgroundImage = global::MediaPlayer.Properties.Resources.CalmaListesiAP2;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_No,
            this.column_DosyaAdi,
            this.column_Sure,
            this.column_Konum});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(3, 55);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(816, 436);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // column_No
            // 
            this.column_No.Text = "No";
            this.column_No.Width = 50;
            // 
            // column_DosyaAdi
            // 
            this.column_DosyaAdi.Text = "Dosya Adı";
            this.column_DosyaAdi.Width = 400;
            // 
            // column_Sure
            // 
            this.column_Sure.Text = "Süre";
            this.column_Sure.Width = 100;
            // 
            // column_Konum
            // 
            this.column_Konum.Text = "Konum";
            this.column_Konum.Width = 400;
            // 
            // mpButon3
            // 
            this.mpButon3.BackColor = System.Drawing.Color.Transparent;
            this.mpButon3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mpButon3.BackgroundImage")));
            this.mpButon3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mpButon3.FlatAppearance.BorderSize = 0;
            this.mpButon3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.mpButon3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.mpButon3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mpButon3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mpButon3.ForeColor = System.Drawing.Color.Transparent;
            this.mpButon3.Location = new System.Drawing.Point(580, 3);
            this.mpButon3.Name = "mpButon3";
            this.mpButon3.Size = new System.Drawing.Size(240, 35);
            this.mpButon3.TabIndex = 0;
            this.mpButon3.Text = "Sil";
            this.mpButon3.UseVisualStyleBackColor = false;
            // 
            // mpButon2
            // 
            this.mpButon2.BackColor = System.Drawing.Color.Transparent;
            this.mpButon2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mpButon2.BackgroundImage")));
            this.mpButon2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mpButon2.FlatAppearance.BorderSize = 0;
            this.mpButon2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.mpButon2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.mpButon2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mpButon2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mpButon2.ForeColor = System.Drawing.Color.Transparent;
            this.mpButon2.Location = new System.Drawing.Point(290, 3);
            this.mpButon2.Name = "mpButon2";
            this.mpButon2.Size = new System.Drawing.Size(240, 35);
            this.mpButon2.TabIndex = 0;
            this.mpButon2.Text = "Klasör Ekle";
            this.mpButon2.UseVisualStyleBackColor = false;
            // 
            // mpButon1
            // 
            this.mpButon1.BackColor = System.Drawing.Color.Transparent;
            this.mpButon1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mpButon1.BackgroundImage")));
            this.mpButon1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mpButon1.FlatAppearance.BorderSize = 0;
            this.mpButon1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.mpButon1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.mpButon1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mpButon1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mpButon1.ForeColor = System.Drawing.Color.Transparent;
            this.mpButon1.Location = new System.Drawing.Point(0, 3);
            this.mpButon1.Name = "mpButon1";
            this.mpButon1.Size = new System.Drawing.Size(240, 35);
            this.mpButon1.TabIndex = 0;
            this.mpButon1.Text = "Dosya Ekle";
            this.mpButon1.UseVisualStyleBackColor = false;
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.Color.Transparent;
            this.tabPage8.BackgroundImage = global::MediaPlayer.Properties.Resources.ArkaplanListe;
            this.tabPage8.Location = new System.Drawing.Point(124, 4);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(822, 494);
            this.tabPage8.TabIndex = 1;
            this.tabPage8.Text = "Sanatçılar";
            // 
            // tabPage9
            // 
            this.tabPage9.BackColor = System.Drawing.Color.Transparent;
            this.tabPage9.BackgroundImage = global::MediaPlayer.Properties.Resources.ArkaplanListe;
            this.tabPage9.Location = new System.Drawing.Point(124, 4);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(822, 494);
            this.tabPage9.TabIndex = 2;
            this.tabPage9.Text = "Albüm";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.tabPage2.BackgroundImage = global::MediaPlayer.Properties.Resources.ArkaplanMuzik;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Location = new System.Drawing.Point(4, 49);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(956, 508);
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
            this.tabPage3.Size = new System.Drawing.Size(956, 508);
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
            this.tabPage4.Size = new System.Drawing.Size(956, 508);
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
            this.tabPage5.Size = new System.Drawing.Size(956, 508);
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
            this.tabPage6.Size = new System.Drawing.Size(956, 508);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Yardım";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(964, 561);
            this.Controls.Add(this.mpTabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mpTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.mpTabControl2.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
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
        private MPButon mpButon3;
        private MPButon mpButon2;
        private MPButon mpButon1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader column_No;
        private System.Windows.Forms.ColumnHeader column_DosyaAdi;
        private System.Windows.Forms.ColumnHeader column_Sure;
        private System.Windows.Forms.ColumnHeader column_Konum;
    }
}

