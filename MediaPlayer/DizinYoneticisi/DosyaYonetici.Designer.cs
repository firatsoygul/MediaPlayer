namespace MediaPlayer.DizinYoneticisi
{
    partial class DosyaYonetici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DosyaYonetici));
            this.listView_dizinler = new System.Windows.Forms.ListView();
            this.columnHeader_klasorler = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mpButon_iptal = new MediaPlayer.MPButon();
            this.mpButon_klasorEkle2 = new MediaPlayer.MPButon();
            this.SuspendLayout();
            // 
            // listView_dizinler
            // 
            this.listView_dizinler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_dizinler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_klasorler});
            this.listView_dizinler.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView_dizinler.FullRowSelect = true;
            this.listView_dizinler.GridLines = true;
            this.listView_dizinler.Location = new System.Drawing.Point(0, 0);
            this.listView_dizinler.Name = "listView_dizinler";
            this.listView_dizinler.Size = new System.Drawing.Size(660, 452);
            this.listView_dizinler.TabIndex = 0;
            this.listView_dizinler.UseCompatibleStateImageBehavior = false;
            this.listView_dizinler.View = System.Windows.Forms.View.Details;
            this.listView_dizinler.SelectedIndexChanged += new System.EventHandler(this.listView_dizinler_SelectedIndexChanged);
            this.listView_dizinler.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView_dizinler_KeyDown);
            this.listView_dizinler.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_dizinler_MouseDoubleClick);
            // 
            // columnHeader_klasorler
            // 
            this.columnHeader_klasorler.Text = "Dosya Seçiniz";
            this.columnHeader_klasorler.Width = 800;
            // 
            // mpButon_iptal
            // 
            this.mpButon_iptal.BackColor = System.Drawing.Color.Transparent;
            this.mpButon_iptal.BackgroundImage = global::MediaPlayer.Properties.Resources._1_780x35;
            this.mpButon_iptal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mpButon_iptal.FlatAppearance.BorderSize = 0;
            this.mpButon_iptal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.mpButon_iptal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.mpButon_iptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mpButon_iptal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mpButon_iptal.ForeColor = System.Drawing.Color.Transparent;
            this.mpButon_iptal.Location = new System.Drawing.Point(582, 459);
            this.mpButon_iptal.Name = "mpButon_iptal";
            this.mpButon_iptal.Size = new System.Drawing.Size(72, 35);
            this.mpButon_iptal.TabIndex = 2;
            this.mpButon_iptal.Text = "Çık";
            this.mpButon_iptal.UseVisualStyleBackColor = false;
            this.mpButon_iptal.Click += new System.EventHandler(this.mpButon_iptal_Click);
            this.mpButon_iptal.Enter += new System.EventHandler(this.mpButon_iptal_Enter);
            // 
            // mpButon_klasorEkle2
            // 
            this.mpButon_klasorEkle2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mpButon_klasorEkle2.BackColor = System.Drawing.Color.Transparent;
            this.mpButon_klasorEkle2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mpButon_klasorEkle2.BackgroundImage")));
            this.mpButon_klasorEkle2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mpButon_klasorEkle2.FlatAppearance.BorderSize = 0;
            this.mpButon_klasorEkle2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.mpButon_klasorEkle2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.mpButon_klasorEkle2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mpButon_klasorEkle2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mpButon_klasorEkle2.ForeColor = System.Drawing.Color.Transparent;
            this.mpButon_klasorEkle2.Location = new System.Drawing.Point(208, 459);
            this.mpButon_klasorEkle2.MinimumSize = new System.Drawing.Size(150, 35);
            this.mpButon_klasorEkle2.Name = "mpButon_klasorEkle2";
            this.mpButon_klasorEkle2.Size = new System.Drawing.Size(245, 35);
            this.mpButon_klasorEkle2.TabIndex = 1;
            this.mpButon_klasorEkle2.Text = "Dosya Ekle";
            this.mpButon_klasorEkle2.UseVisualStyleBackColor = false;
            this.mpButon_klasorEkle2.Click += new System.EventHandler(this.mpButon_klasorEkle2_Click);
            this.mpButon_klasorEkle2.Enter += new System.EventHandler(this.mpButon_klasorEkle2_Enter);
            this.mpButon_klasorEkle2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mpButon_klasorEkle2_KeyDown);
            this.mpButon_klasorEkle2.Leave += new System.EventHandler(this.mpButon_klasorEkle2_Leave);
            // 
            // DosyaYonetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(660, 500);
            this.Controls.Add(this.mpButon_iptal);
            this.Controls.Add(this.mpButon_klasorEkle2);
            this.Controls.Add(this.listView_dizinler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DosyaYonetici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DizinYonetici";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DosyaYonetici_FormClosing);
            this.Load += new System.EventHandler(this.DizinYonetici_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DizinYonetici_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion
        private MPButon mpButon_klasorEkle2;
        public System.Windows.Forms.ListView listView_dizinler;
        public System.Windows.Forms.ColumnHeader columnHeader_klasorler;
        private MPButon mpButon_iptal;
    }
}