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
            this.openFileDialog_Dosya_Ekle = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog_Klasor_Ekle = new System.Windows.Forms.FolderBrowserDialog();
            this.mpTabControl_Ana_Menu = new MediaPlayer.MPTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mpTabControl_Listeler = new MediaPlayer.MPTabControl();
            this.tabPage_Tum_Listeler = new System.Windows.Forms.TabPage();
            this.listView_Tum_Liste = new System.Windows.Forms.ListView();
            this.column_TumListe_No = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_TumListe_DosyaAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_TumListe_Sure = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_TumListe_Konum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mpButon_Sil = new MediaPlayer.MPButon();
            this.mpButon_Klasor_Ekle = new MediaPlayer.MPButon();
            this.mpButon_Dosya_Ekle = new MediaPlayer.MPButon();
            this.tabPage_Album = new System.Windows.Forms.TabPage();
            this.listView_Album = new System.Windows.Forms.ListView();
            this.column_AlbumListesi_Album = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_AlbumListesi_Sanatci = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_AlbumListesi_DosyaAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_AlbumListesi_Sure = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_AlbumListesi_Dizin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage_Sanatcilar = new System.Windows.Forms.TabPage();
            this.listView_Sanatci = new System.Windows.Forms.ListView();
            this.column_SanatciListesi_Sanatci = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_SanatciListesi_Dosya_Adi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_SanatciListesi_Sure = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_SanatciListesi_Dizin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView_Muzik = new System.Windows.Forms.ListView();
            this.column_Muzik_Turu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Muzik_DosyaAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Muzik_Sure = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Muzik_Sanatci = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Muzik_Album = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Muzik_Konum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listView_Video = new System.Windows.Forms.ListView();
            this.column_Video_Turu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Video_DosyaAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Video_Sure = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Video_Konum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label_Zaman = new System.Windows.Forms.Label();
            this.label_ParcaAdi = new System.Windows.Forms.Label();
            this.label_Sanatci = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.mpTabControl_Ana_Menu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.mpTabControl_Listeler.SuspendLayout();
            this.tabPage_Tum_Listeler.SuspendLayout();
            this.tabPage_Album.SuspendLayout();
            this.tabPage_Sanatcilar.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog_Dosya_Ekle
            // 
            this.openFileDialog_Dosya_Ekle.FileName = "openFileDialog1";
            this.openFileDialog_Dosya_Ekle.Filter = resources.GetString("openFileDialog_Dosya_Ekle.Filter");
            this.openFileDialog_Dosya_Ekle.Multiselect = true;
            // 
            // mpTabControl_Ana_Menu
            // 
            this.mpTabControl_Ana_Menu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mpTabControl_Ana_Menu.Controls.Add(this.tabPage1);
            this.mpTabControl_Ana_Menu.Controls.Add(this.tabPage2);
            this.mpTabControl_Ana_Menu.Controls.Add(this.tabPage3);
            this.mpTabControl_Ana_Menu.Controls.Add(this.tabPage4);
            this.mpTabControl_Ana_Menu.Controls.Add(this.tabPage5);
            this.mpTabControl_Ana_Menu.Controls.Add(this.tabPage6);
            this.mpTabControl_Ana_Menu.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.mpTabControl_Ana_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mpTabControl_Ana_Menu.ItemSize = new System.Drawing.Size(160, 45);
            this.mpTabControl_Ana_Menu.Location = new System.Drawing.Point(0, 0);
            this.mpTabControl_Ana_Menu.Margin = new System.Windows.Forms.Padding(0);
            this.mpTabControl_Ana_Menu.Name = "mpTabControl_Ana_Menu";
            this.mpTabControl_Ana_Menu.Padding = new System.Drawing.Point(0, 0);
            this.mpTabControl_Ana_Menu.SelectedIndex = 0;
            this.mpTabControl_Ana_Menu.Size = new System.Drawing.Size(964, 561);
            this.mpTabControl_Ana_Menu.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.mpTabControl_Ana_Menu.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.mpTabControl_Listeler);
            this.tabPage1.Location = new System.Drawing.Point(4, 49);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(956, 508);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Çalma Listeleri";
            // 
            // mpTabControl_Listeler
            // 
            this.mpTabControl_Listeler.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.mpTabControl_Listeler.Controls.Add(this.tabPage_Tum_Listeler);
            this.mpTabControl_Listeler.Controls.Add(this.tabPage_Album);
            this.mpTabControl_Listeler.Controls.Add(this.tabPage_Sanatcilar);
            this.mpTabControl_Listeler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mpTabControl_Listeler.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.mpTabControl_Listeler.ItemSize = new System.Drawing.Size(70, 120);
            this.mpTabControl_Listeler.Location = new System.Drawing.Point(3, 3);
            this.mpTabControl_Listeler.Multiline = true;
            this.mpTabControl_Listeler.Name = "mpTabControl_Listeler";
            this.mpTabControl_Listeler.SelectedIndex = 0;
            this.mpTabControl_Listeler.Size = new System.Drawing.Size(950, 502);
            this.mpTabControl_Listeler.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.mpTabControl_Listeler.TabIndex = 0;
            // 
            // tabPage_Tum_Listeler
            // 
            this.tabPage_Tum_Listeler.BackColor = System.Drawing.Color.Transparent;
            this.tabPage_Tum_Listeler.Controls.Add(this.listView_Tum_Liste);
            this.tabPage_Tum_Listeler.Controls.Add(this.mpButon_Sil);
            this.tabPage_Tum_Listeler.Controls.Add(this.mpButon_Klasor_Ekle);
            this.tabPage_Tum_Listeler.Controls.Add(this.mpButon_Dosya_Ekle);
            this.tabPage_Tum_Listeler.Location = new System.Drawing.Point(124, 4);
            this.tabPage_Tum_Listeler.Name = "tabPage_Tum_Listeler";
            this.tabPage_Tum_Listeler.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Tum_Listeler.Size = new System.Drawing.Size(822, 494);
            this.tabPage_Tum_Listeler.TabIndex = 0;
            this.tabPage_Tum_Listeler.Text = "Tüm Liste";
            // 
            // listView_Tum_Liste
            // 
            this.listView_Tum_Liste.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_Tum_Liste.BackColor = System.Drawing.SystemColors.Window;
            this.listView_Tum_Liste.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listView_Tum_Liste.BackgroundImage")));
            this.listView_Tum_Liste.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_TumListe_No,
            this.column_TumListe_DosyaAdi,
            this.column_TumListe_Sure,
            this.column_TumListe_Konum});
            this.listView_Tum_Liste.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView_Tum_Liste.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listView_Tum_Liste.FullRowSelect = true;
            this.listView_Tum_Liste.GridLines = true;
            this.listView_Tum_Liste.Location = new System.Drawing.Point(3, 55);
            this.listView_Tum_Liste.Name = "listView_Tum_Liste";
            this.listView_Tum_Liste.Size = new System.Drawing.Size(816, 436);
            this.listView_Tum_Liste.TabIndex = 1;
            this.listView_Tum_Liste.UseCompatibleStateImageBehavior = false;
            this.listView_Tum_Liste.View = System.Windows.Forms.View.Details;
            this.listView_Tum_Liste.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_Tum_Liste_MouseDoubleClick);
            // 
            // column_TumListe_No
            // 
            this.column_TumListe_No.Text = "No";
            this.column_TumListe_No.Width = 51;
            // 
            // column_TumListe_DosyaAdi
            // 
            this.column_TumListe_DosyaAdi.Text = "Dosya Adı";
            this.column_TumListe_DosyaAdi.Width = 400;
            // 
            // column_TumListe_Sure
            // 
            this.column_TumListe_Sure.Text = "Süre";
            this.column_TumListe_Sure.Width = 110;
            // 
            // column_TumListe_Konum
            // 
            this.column_TumListe_Konum.Text = "Konum";
            this.column_TumListe_Konum.Width = 400;
            // 
            // mpButon_Sil
            // 
            this.mpButon_Sil.BackColor = System.Drawing.Color.Transparent;
            this.mpButon_Sil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mpButon_Sil.BackgroundImage")));
            this.mpButon_Sil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mpButon_Sil.FlatAppearance.BorderSize = 0;
            this.mpButon_Sil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.mpButon_Sil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.mpButon_Sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mpButon_Sil.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mpButon_Sil.ForeColor = System.Drawing.Color.Transparent;
            this.mpButon_Sil.Location = new System.Drawing.Point(580, 3);
            this.mpButon_Sil.Name = "mpButon_Sil";
            this.mpButon_Sil.Size = new System.Drawing.Size(240, 35);
            this.mpButon_Sil.TabIndex = 0;
            this.mpButon_Sil.Text = "Sil";
            this.mpButon_Sil.UseVisualStyleBackColor = false;
            this.mpButon_Sil.Click += new System.EventHandler(this.mpButon_Sil_Click);
            // 
            // mpButon_Klasor_Ekle
            // 
            this.mpButon_Klasor_Ekle.BackColor = System.Drawing.Color.Transparent;
            this.mpButon_Klasor_Ekle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mpButon_Klasor_Ekle.BackgroundImage")));
            this.mpButon_Klasor_Ekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mpButon_Klasor_Ekle.FlatAppearance.BorderSize = 0;
            this.mpButon_Klasor_Ekle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.mpButon_Klasor_Ekle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.mpButon_Klasor_Ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mpButon_Klasor_Ekle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mpButon_Klasor_Ekle.ForeColor = System.Drawing.Color.Transparent;
            this.mpButon_Klasor_Ekle.Location = new System.Drawing.Point(290, 3);
            this.mpButon_Klasor_Ekle.Name = "mpButon_Klasor_Ekle";
            this.mpButon_Klasor_Ekle.Size = new System.Drawing.Size(240, 35);
            this.mpButon_Klasor_Ekle.TabIndex = 0;
            this.mpButon_Klasor_Ekle.Text = "Klasör Ekle";
            this.mpButon_Klasor_Ekle.UseVisualStyleBackColor = false;
            this.mpButon_Klasor_Ekle.Click += new System.EventHandler(this.mpButon_Klasor_Ekle_Click);
            // 
            // mpButon_Dosya_Ekle
            // 
            this.mpButon_Dosya_Ekle.BackColor = System.Drawing.Color.Transparent;
            this.mpButon_Dosya_Ekle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mpButon_Dosya_Ekle.BackgroundImage")));
            this.mpButon_Dosya_Ekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mpButon_Dosya_Ekle.FlatAppearance.BorderSize = 0;
            this.mpButon_Dosya_Ekle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.mpButon_Dosya_Ekle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.mpButon_Dosya_Ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mpButon_Dosya_Ekle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mpButon_Dosya_Ekle.ForeColor = System.Drawing.Color.Transparent;
            this.mpButon_Dosya_Ekle.Location = new System.Drawing.Point(0, 3);
            this.mpButon_Dosya_Ekle.Name = "mpButon_Dosya_Ekle";
            this.mpButon_Dosya_Ekle.Size = new System.Drawing.Size(240, 35);
            this.mpButon_Dosya_Ekle.TabIndex = 0;
            this.mpButon_Dosya_Ekle.Text = "Dosya Ekle";
            this.mpButon_Dosya_Ekle.UseVisualStyleBackColor = false;
            this.mpButon_Dosya_Ekle.Click += new System.EventHandler(this.mpButon_Dosya_Ekle_Click);
            // 
            // tabPage_Album
            // 
            this.tabPage_Album.BackColor = System.Drawing.Color.Transparent;
            this.tabPage_Album.Controls.Add(this.listView_Album);
            this.tabPage_Album.Location = new System.Drawing.Point(124, 4);
            this.tabPage_Album.Name = "tabPage_Album";
            this.tabPage_Album.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Album.Size = new System.Drawing.Size(822, 494);
            this.tabPage_Album.TabIndex = 1;
            this.tabPage_Album.Text = "Albüm";
            // 
            // listView_Album
            // 
            this.listView_Album.BackColor = System.Drawing.Color.White;
            this.listView_Album.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listView_Album.BackgroundImage")));
            this.listView_Album.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_AlbumListesi_Album,
            this.column_AlbumListesi_Sanatci,
            this.column_AlbumListesi_DosyaAdi,
            this.column_AlbumListesi_Sure,
            this.column_AlbumListesi_Dizin});
            this.listView_Album.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_Album.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView_Album.FullRowSelect = true;
            this.listView_Album.GridLines = true;
            this.listView_Album.Location = new System.Drawing.Point(3, 3);
            this.listView_Album.Name = "listView_Album";
            this.listView_Album.Size = new System.Drawing.Size(816, 488);
            this.listView_Album.TabIndex = 0;
            this.listView_Album.UseCompatibleStateImageBehavior = false;
            this.listView_Album.View = System.Windows.Forms.View.Details;
            this.listView_Album.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_Album_MouseDoubleClick);
            // 
            // column_AlbumListesi_Album
            // 
            this.column_AlbumListesi_Album.Text = "Albüm";
            this.column_AlbumListesi_Album.Width = 220;
            // 
            // column_AlbumListesi_Sanatci
            // 
            this.column_AlbumListesi_Sanatci.Text = "Sanatçı";
            this.column_AlbumListesi_Sanatci.Width = 250;
            // 
            // column_AlbumListesi_DosyaAdi
            // 
            this.column_AlbumListesi_DosyaAdi.Text = "Dosya Adı";
            this.column_AlbumListesi_DosyaAdi.Width = 250;
            // 
            // column_AlbumListesi_Sure
            // 
            this.column_AlbumListesi_Sure.Text = "Süre";
            this.column_AlbumListesi_Sure.Width = 90;
            // 
            // column_AlbumListesi_Dizin
            // 
            this.column_AlbumListesi_Dizin.Text = "Konum";
            this.column_AlbumListesi_Dizin.Width = 200;
            // 
            // tabPage_Sanatcilar
            // 
            this.tabPage_Sanatcilar.BackColor = System.Drawing.Color.Transparent;
            this.tabPage_Sanatcilar.Controls.Add(this.listView_Sanatci);
            this.tabPage_Sanatcilar.Location = new System.Drawing.Point(124, 4);
            this.tabPage_Sanatcilar.Name = "tabPage_Sanatcilar";
            this.tabPage_Sanatcilar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Sanatcilar.Size = new System.Drawing.Size(822, 494);
            this.tabPage_Sanatcilar.TabIndex = 2;
            this.tabPage_Sanatcilar.Text = "Sanatçılar";
            // 
            // listView_Sanatci
            // 
            this.listView_Sanatci.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listView_Sanatci.BackgroundImage")));
            this.listView_Sanatci.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_SanatciListesi_Sanatci,
            this.column_SanatciListesi_Dosya_Adi,
            this.column_SanatciListesi_Sure,
            this.column_SanatciListesi_Dizin});
            this.listView_Sanatci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_Sanatci.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView_Sanatci.FullRowSelect = true;
            this.listView_Sanatci.GridLines = true;
            this.listView_Sanatci.Location = new System.Drawing.Point(3, 3);
            this.listView_Sanatci.Name = "listView_Sanatci";
            this.listView_Sanatci.Size = new System.Drawing.Size(816, 488);
            this.listView_Sanatci.TabIndex = 0;
            this.listView_Sanatci.UseCompatibleStateImageBehavior = false;
            this.listView_Sanatci.View = System.Windows.Forms.View.Details;
            this.listView_Sanatci.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_Sanatci_MouseDoubleClick);
            // 
            // column_SanatciListesi_Sanatci
            // 
            this.column_SanatciListesi_Sanatci.Text = "Sanatçı";
            this.column_SanatciListesi_Sanatci.Width = 300;
            // 
            // column_SanatciListesi_Dosya_Adi
            // 
            this.column_SanatciListesi_Dosya_Adi.Text = "Dosya Adı";
            this.column_SanatciListesi_Dosya_Adi.Width = 400;
            // 
            // column_SanatciListesi_Sure
            // 
            this.column_SanatciListesi_Sure.Text = "Süre";
            this.column_SanatciListesi_Sure.Width = 110;
            // 
            // column_SanatciListesi_Dizin
            // 
            this.column_SanatciListesi_Dizin.Text = "Konum";
            this.column_SanatciListesi_Dizin.Width = 300;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.listView_Muzik);
            this.tabPage2.Location = new System.Drawing.Point(4, 49);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(956, 508);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Müzik";
            // 
            // listView_Muzik
            // 
            this.listView_Muzik.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listView_Muzik.BackgroundImage")));
            this.listView_Muzik.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_Muzik_Turu,
            this.column_Muzik_DosyaAdi,
            this.column_Muzik_Sure,
            this.column_Muzik_Sanatci,
            this.column_Muzik_Album,
            this.column_Muzik_Konum});
            this.listView_Muzik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_Muzik.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView_Muzik.GridLines = true;
            this.listView_Muzik.Location = new System.Drawing.Point(3, 3);
            this.listView_Muzik.Margin = new System.Windows.Forms.Padding(0);
            this.listView_Muzik.Name = "listView_Muzik";
            this.listView_Muzik.Size = new System.Drawing.Size(950, 502);
            this.listView_Muzik.TabIndex = 0;
            this.listView_Muzik.UseCompatibleStateImageBehavior = false;
            this.listView_Muzik.View = System.Windows.Forms.View.Details;
            // 
            // column_Muzik_Turu
            // 
            this.column_Muzik_Turu.Text = "";
            this.column_Muzik_Turu.Width = 80;
            // 
            // column_Muzik_DosyaAdi
            // 
            this.column_Muzik_DosyaAdi.Text = "Dosya Adı";
            this.column_Muzik_DosyaAdi.Width = 250;
            // 
            // column_Muzik_Sure
            // 
            this.column_Muzik_Sure.Text = "Süre";
            this.column_Muzik_Sure.Width = 110;
            // 
            // column_Muzik_Sanatci
            // 
            this.column_Muzik_Sanatci.Text = "Sanatçı";
            this.column_Muzik_Sanatci.Width = 250;
            // 
            // column_Muzik_Album
            // 
            this.column_Muzik_Album.Text = "Albüm";
            this.column_Muzik_Album.Width = 250;
            // 
            // column_Muzik_Konum
            // 
            this.column_Muzik_Konum.Text = "Konum";
            this.column_Muzik_Konum.Width = 300;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.listView_Video);
            this.tabPage3.Location = new System.Drawing.Point(4, 49);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(956, 508);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Video";
            // 
            // listView_Video
            // 
            this.listView_Video.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listView_Video.BackgroundImage")));
            this.listView_Video.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_Video_Turu,
            this.column_Video_DosyaAdi,
            this.column_Video_Sure,
            this.column_Video_Konum});
            this.listView_Video.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_Video.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView_Video.GridLines = true;
            this.listView_Video.Location = new System.Drawing.Point(3, 3);
            this.listView_Video.Name = "listView_Video";
            this.listView_Video.Size = new System.Drawing.Size(950, 502);
            this.listView_Video.TabIndex = 0;
            this.listView_Video.UseCompatibleStateImageBehavior = false;
            this.listView_Video.View = System.Windows.Forms.View.Details;
            // 
            // column_Video_Turu
            // 
            this.column_Video_Turu.Text = "";
            this.column_Video_Turu.Width = 80;
            // 
            // column_Video_DosyaAdi
            // 
            this.column_Video_DosyaAdi.Text = "Dosya Adı";
            this.column_Video_DosyaAdi.Width = 250;
            // 
            // column_Video_Sure
            // 
            this.column_Video_Sure.Text = "Sure";
            this.column_Video_Sure.Width = 100;
            // 
            // column_Video_Konum
            // 
            this.column_Video_Konum.Text = "Konum";
            this.column_Video_Konum.Width = 300;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.tabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage4.Controls.Add(this.label_Zaman);
            this.tabPage4.Controls.Add(this.label_ParcaAdi);
            this.tabPage4.Controls.Add(this.label_Sanatci);
            this.tabPage4.Controls.Add(this.button3);
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.tableLayoutPanel1);
            this.tabPage4.Location = new System.Drawing.Point(4, 49);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(956, 508);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Oynat";
            // 
            // label_Zaman
            // 
            this.label_Zaman.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Zaman.AutoSize = true;
            this.label_Zaman.BackColor = System.Drawing.Color.Transparent;
            this.label_Zaman.Font = new System.Drawing.Font("Calibri Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Zaman.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label_Zaman.Location = new System.Drawing.Point(214, 477);
            this.label_Zaman.Name = "label_Zaman";
            this.label_Zaman.Size = new System.Drawing.Size(55, 24);
            this.label_Zaman.TabIndex = 6;
            this.label_Zaman.Text = "00:00";
            // 
            // label_ParcaAdi
            // 
            this.label_ParcaAdi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_ParcaAdi.AutoSize = true;
            this.label_ParcaAdi.BackColor = System.Drawing.Color.Transparent;
            this.label_ParcaAdi.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_ParcaAdi.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label_ParcaAdi.Location = new System.Drawing.Point(293, 492);
            this.label_ParcaAdi.Name = "label_ParcaAdi";
            this.label_ParcaAdi.Size = new System.Drawing.Size(56, 14);
            this.label_ParcaAdi.TabIndex = 5;
            this.label_ParcaAdi.Text = "Parça adı";
            // 
            // label_Sanatci
            // 
            this.label_Sanatci.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Sanatci.AutoSize = true;
            this.label_Sanatci.BackColor = System.Drawing.Color.Transparent;
            this.label_Sanatci.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Sanatci.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_Sanatci.Location = new System.Drawing.Point(292, 470);
            this.label_Sanatci.Name = "label_Sanatci";
            this.label_Sanatci.Size = new System.Drawing.Size(65, 23);
            this.label_Sanatci.TabIndex = 4;
            this.label_Sanatci.Text = "Sanatçı";
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(8, 477);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 23);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(138, 477);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 23);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(73, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 23);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.axWindowsMediaPlayer1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 466F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(950, 466);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(950, 466);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.PositionChange += new AxWMPLib._WMPOCXEvents_PositionChangeEventHandler(this.axWindowsMediaPlayer1_PositionChange);
            this.axWindowsMediaPlayer1.CurrentItemChange += new AxWMPLib._WMPOCXEvents_CurrentItemChangeEventHandler(this.axWindowsMediaPlayer1_CurrentItemChange);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
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
            this.ClientSize = new System.Drawing.Size(962, 561);
            this.Controls.Add(this.mpTabControl_Ana_Menu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mpTabControl_Ana_Menu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.mpTabControl_Listeler.ResumeLayout(false);
            this.tabPage_Tum_Listeler.ResumeLayout(false);
            this.tabPage_Album.ResumeLayout(false);
            this.tabPage_Sanatcilar.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MPTabControl mpTabControl_Ana_Menu;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private MPTabControl mpTabControl_Listeler;
        private System.Windows.Forms.TabPage tabPage_Tum_Listeler;
        private System.Windows.Forms.TabPage tabPage_Album;
        private System.Windows.Forms.TabPage tabPage_Sanatcilar;
        private MPButon mpButon_Sil;
        private MPButon mpButon_Klasor_Ekle;
        private MPButon mpButon_Dosya_Ekle;
        private System.Windows.Forms.ListView listView_Tum_Liste;
        private System.Windows.Forms.ColumnHeader column_TumListe_No;
        private System.Windows.Forms.ColumnHeader column_TumListe_DosyaAdi;
        private System.Windows.Forms.ColumnHeader column_TumListe_Sure;
        private System.Windows.Forms.ColumnHeader column_TumListe_Konum;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog_Dosya_Ekle;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_Klasor_Ekle;
        private System.Windows.Forms.ListView listView_Album;
        private System.Windows.Forms.ColumnHeader column_AlbumListesi_Album;
        private System.Windows.Forms.ColumnHeader column_AlbumListesi_Sanatci;
        private System.Windows.Forms.ColumnHeader column_AlbumListesi_DosyaAdi;
        private System.Windows.Forms.ColumnHeader column_AlbumListesi_Sure;
        private System.Windows.Forms.ListView listView_Sanatci;
        private System.Windows.Forms.ColumnHeader column_SanatciListesi_Sanatci;
        private System.Windows.Forms.ColumnHeader column_SanatciListesi_Dosya_Adi;
        private System.Windows.Forms.ColumnHeader column_SanatciListesi_Sure;
        private System.Windows.Forms.ColumnHeader column_AlbumListesi_Dizin;
        private System.Windows.Forms.ColumnHeader column_SanatciListesi_Dizin;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_ParcaAdi;
        private System.Windows.Forms.Label label_Sanatci;
        private System.Windows.Forms.Label label_Zaman;
        private System.Windows.Forms.ListView listView_Muzik;
        private System.Windows.Forms.ColumnHeader column_Muzik_Turu;
        private System.Windows.Forms.ColumnHeader column_Muzik_DosyaAdi;
        private System.Windows.Forms.ColumnHeader column_Muzik_Sure;
        private System.Windows.Forms.ColumnHeader column_Muzik_Sanatci;
        private System.Windows.Forms.ColumnHeader column_Muzik_Album;
        private System.Windows.Forms.ListView listView_Video;
        private System.Windows.Forms.ColumnHeader column_Muzik_Konum;
        private System.Windows.Forms.ColumnHeader column_Video_Turu;
        private System.Windows.Forms.ColumnHeader column_Video_DosyaAdi;
        private System.Windows.Forms.ColumnHeader column_Video_Sure;
        private System.Windows.Forms.ColumnHeader column_Video_Konum;
    }
}

