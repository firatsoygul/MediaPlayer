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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog_Dosya_Ekle = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker_ListeOlustur = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog_KlasorEkle = new System.Windows.Forms.FolderBrowserDialog();
            this.ımageList_Muzik = new System.Windows.Forms.ImageList(this.components);
            this.ımageList_Video = new System.Windows.Forms.ImageList(this.components);
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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button_KontrolDur = new System.Windows.Forms.Button();
            this.button_KontrolDurdur = new System.Windows.Forms.Button();
            this.label_Zaman = new System.Windows.Forms.Label();
            this.label_ParcaAdi = new System.Windows.Forms.Label();
            this.label_SanatciAdi = new System.Windows.Forms.Label();
            this.button_KontrolGeri = new System.Windows.Forms.Button();
            this.button_Kontrolileri = new System.Windows.Forms.Button();
            this.button_KontrolOynat = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
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
            // backgroundWorker_ListeOlustur
            // 
            this.backgroundWorker_ListeOlustur.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_ListeOlustur_DoWork);
            this.backgroundWorker_ListeOlustur.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_ListeOlustur_RunWorkerCompleted);
            // 
            // ımageList_Muzik
            // 
            this.ımageList_Muzik.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList_Muzik.ImageStream")));
            this.ımageList_Muzik.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList_Muzik.Images.SetKeyName(0, "amr.png");
            this.ımageList_Muzik.Images.SetKeyName(1, "mp3.png");
            this.ımageList_Muzik.Images.SetKeyName(2, "wav.png");
            this.ımageList_Muzik.Images.SetKeyName(3, "wma.png");
            // 
            // ımageList_Video
            // 
            this.ımageList_Video.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList_Video.ImageStream")));
            this.ımageList_Video.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList_Video.Images.SetKeyName(0, "avi.png");
            this.ımageList_Video.Images.SetKeyName(1, "mp4.png");
            this.ımageList_Video.Images.SetKeyName(2, "mpeg.png");
            this.ımageList_Video.Images.SetKeyName(3, "mpg.png");
            this.ımageList_Video.Images.SetKeyName(4, "wmv.png");
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
            this.mpTabControl_Ana_Menu.Enter += new System.EventHandler(this.Durdur);
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
            this.listView_Muzik.LargeImageList = this.ımageList_Muzik;
            this.listView_Muzik.Location = new System.Drawing.Point(3, 3);
            this.listView_Muzik.Margin = new System.Windows.Forms.Padding(0);
            this.listView_Muzik.Name = "listView_Muzik";
            this.listView_Muzik.Size = new System.Drawing.Size(950, 502);
            this.listView_Muzik.SmallImageList = this.ımageList_Muzik;
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
            this.listView_Video.LargeImageList = this.ımageList_Video;
            this.listView_Video.Location = new System.Drawing.Point(3, 3);
            this.listView_Video.Name = "listView_Video";
            this.listView_Video.Size = new System.Drawing.Size(950, 502);
            this.listView_Video.SmallImageList = this.ımageList_Video;
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
            this.tabPage4.Controls.Add(this.trackBar1);
            this.tabPage4.Controls.Add(this.button_KontrolDur);
            this.tabPage4.Controls.Add(this.button_KontrolDurdur);
            this.tabPage4.Controls.Add(this.label_Zaman);
            this.tabPage4.Controls.Add(this.label_ParcaAdi);
            this.tabPage4.Controls.Add(this.label_SanatciAdi);
            this.tabPage4.Controls.Add(this.button_KontrolGeri);
            this.tabPage4.Controls.Add(this.button_Kontrolileri);
            this.tabPage4.Controls.Add(this.button_KontrolOynat);
            this.tabPage4.Controls.Add(this.tableLayoutPanel1);
            this.tabPage4.Location = new System.Drawing.Point(4, 49);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(956, 508);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Oynat";
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(471, 459);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(417, 45);
            this.trackBar1.TabIndex = 10;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // button_KontrolDur
            // 
            this.button_KontrolDur.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_KontrolDur.BackgroundImage = global::MediaPlayer.Properties.Resources.dur;
            this.button_KontrolDur.FlatAppearance.BorderSize = 0;
            this.button_KontrolDur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_KontrolDur.Location = new System.Drawing.Point(61, 462);
            this.button_KontrolDur.Name = "button_KontrolDur";
            this.button_KontrolDur.Size = new System.Drawing.Size(50, 40);
            this.button_KontrolDur.TabIndex = 9;
            this.button_KontrolDur.UseVisualStyleBackColor = true;
            this.button_KontrolDur.Click += new System.EventHandler(this.button_KontrolDur_Click);
            this.button_KontrolDur.MouseLeave += new System.EventHandler(this.button_KontrolDur_MouseLeave);
            this.button_KontrolDur.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_KontrolDur_MouseMove);
            // 
            // button_KontrolDurdur
            // 
            this.button_KontrolDurdur.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_KontrolDurdur.BackgroundImage = global::MediaPlayer.Properties.Resources.durdur;
            this.button_KontrolDurdur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_KontrolDurdur.FlatAppearance.BorderSize = 0;
            this.button_KontrolDurdur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_KontrolDurdur.ForeColor = System.Drawing.Color.Transparent;
            this.button_KontrolDurdur.Location = new System.Drawing.Point(112, 462);
            this.button_KontrolDurdur.Name = "button_KontrolDurdur";
            this.button_KontrolDurdur.Size = new System.Drawing.Size(70, 40);
            this.button_KontrolDurdur.TabIndex = 7;
            this.button_KontrolDurdur.UseVisualStyleBackColor = true;
            this.button_KontrolDurdur.Visible = false;
            this.button_KontrolDurdur.Click += new System.EventHandler(this.button_KontrolDurdur_Click);
            this.button_KontrolDurdur.MouseLeave += new System.EventHandler(this.button_KontrolDurdur_MouseLeave);
            this.button_KontrolDurdur.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_KontrolDurdur_MouseMove);
            // 
            // label_Zaman
            // 
            this.label_Zaman.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Zaman.AutoSize = true;
            this.label_Zaman.BackColor = System.Drawing.Color.Transparent;
            this.label_Zaman.Font = new System.Drawing.Font("Calibri Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Zaman.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label_Zaman.Location = new System.Drawing.Point(260, 478);
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
            this.label_ParcaAdi.Location = new System.Drawing.Point(334, 485);
            this.label_ParcaAdi.Name = "label_ParcaAdi";
            this.label_ParcaAdi.Size = new System.Drawing.Size(56, 14);
            this.label_ParcaAdi.TabIndex = 5;
            this.label_ParcaAdi.Text = "Parça adı";
            // 
            // label_SanatciAdi
            // 
            this.label_SanatciAdi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_SanatciAdi.AutoSize = true;
            this.label_SanatciAdi.BackColor = System.Drawing.Color.Transparent;
            this.label_SanatciAdi.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_SanatciAdi.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_SanatciAdi.Location = new System.Drawing.Point(332, 463);
            this.label_SanatciAdi.Name = "label_SanatciAdi";
            this.label_SanatciAdi.Size = new System.Drawing.Size(65, 23);
            this.label_SanatciAdi.TabIndex = 4;
            this.label_SanatciAdi.Text = "Sanatçı";
            // 
            // button_KontrolGeri
            // 
            this.button_KontrolGeri.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_KontrolGeri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_KontrolGeri.BackgroundImage")));
            this.button_KontrolGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_KontrolGeri.FlatAppearance.BorderSize = 0;
            this.button_KontrolGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_KontrolGeri.ForeColor = System.Drawing.Color.Transparent;
            this.button_KontrolGeri.Location = new System.Drawing.Point(8, 462);
            this.button_KontrolGeri.Name = "button_KontrolGeri";
            this.button_KontrolGeri.Size = new System.Drawing.Size(50, 40);
            this.button_KontrolGeri.TabIndex = 3;
            this.button_KontrolGeri.UseVisualStyleBackColor = true;
            this.button_KontrolGeri.Click += new System.EventHandler(this.button_KontrolGeri_Click);
            this.button_KontrolGeri.MouseLeave += new System.EventHandler(this.button_KontrolGeri_MouseLeave);
            this.button_KontrolGeri.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_KontrolGeri_MouseMove);
            // 
            // button_Kontrolileri
            // 
            this.button_Kontrolileri.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_Kontrolileri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Kontrolileri.BackgroundImage")));
            this.button_Kontrolileri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Kontrolileri.FlatAppearance.BorderSize = 0;
            this.button_Kontrolileri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Kontrolileri.ForeColor = System.Drawing.Color.Transparent;
            this.button_Kontrolileri.Location = new System.Drawing.Point(188, 462);
            this.button_Kontrolileri.Name = "button_Kontrolileri";
            this.button_Kontrolileri.Size = new System.Drawing.Size(50, 40);
            this.button_Kontrolileri.TabIndex = 2;
            this.button_Kontrolileri.UseVisualStyleBackColor = true;
            this.button_Kontrolileri.Click += new System.EventHandler(this.button_Kontrolileri_Click);
            this.button_Kontrolileri.MouseLeave += new System.EventHandler(this.button_Kontrolileri_MouseLeave);
            this.button_Kontrolileri.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_Kontrolileri_MouseMove);
            // 
            // button_KontrolOynat
            // 
            this.button_KontrolOynat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_KontrolOynat.BackgroundImage = global::MediaPlayer.Properties.Resources.oynat;
            this.button_KontrolOynat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_KontrolOynat.FlatAppearance.BorderSize = 0;
            this.button_KontrolOynat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_KontrolOynat.ForeColor = System.Drawing.Color.Transparent;
            this.button_KontrolOynat.Location = new System.Drawing.Point(112, 462);
            this.button_KontrolOynat.Name = "button_KontrolOynat";
            this.button_KontrolOynat.Size = new System.Drawing.Size(70, 40);
            this.button_KontrolOynat.TabIndex = 8;
            this.button_KontrolOynat.UseVisualStyleBackColor = true;
            this.button_KontrolOynat.Click += new System.EventHandler(this.button_KontrolOynat_Click);
            this.button_KontrolOynat.MouseLeave += new System.EventHandler(this.button_KontrolOynat_MouseLeave);
            this.button_KontrolOynat.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_KontrolOynat_MouseMove);
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(950, 450);
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
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(950, 450);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.OpenStateChange += new AxWMPLib._WMPOCXEvents_OpenStateChangeEventHandler(this.axWindowsMediaPlayer1_OpenStateChange);
            this.axWindowsMediaPlayer1.StatusChange += new System.EventHandler(this.axWindowsMediaPlayer1_StatusChange);
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
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
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
        private System.Windows.Forms.Button button_KontrolGeri;
        private System.Windows.Forms.Button button_Kontrolileri;
        private System.Windows.Forms.Button button_KontrolOynat;
        private System.Windows.Forms.Label label_ParcaAdi;
        private System.Windows.Forms.Label label_SanatciAdi;
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
        private System.ComponentModel.BackgroundWorker backgroundWorker_ListeOlustur;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_KlasorEkle;
        private System.Windows.Forms.ImageList ımageList_Muzik;
        private System.Windows.Forms.ImageList ımageList_Video;
        private System.Windows.Forms.Button button_KontrolDurdur;
        private System.Windows.Forms.Button button_KontrolDur;
        internal System.Windows.Forms.TrackBar trackBar1;
    }
}

