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
            this.backgroundWorker_UyariSesleriOlustur = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker_Seslendirme = new System.ComponentModel.BackgroundWorker();
            this.timer_OynatmaZamani = new System.Windows.Forms.Timer(this.components);
            this.mpTabControl_Ana_Menu = new MediaPlayer.MPTabControl();
            this.tabPage_CalmaListeleri = new System.Windows.Forms.TabPage();
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
            this.tabPage_Muzik = new System.Windows.Forms.TabPage();
            this.listView_Muzik = new System.Windows.Forms.ListView();
            this.column_Muzik_Turu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Muzik_DosyaAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Muzik_Sure = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Muzik_Sanatci = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Muzik_Album = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Muzik_Konum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage_Video = new System.Windows.Forms.TabPage();
            this.listView_Video = new System.Windows.Forms.ListView();
            this.column_Video_Turu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Video_DosyaAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Video_Sure = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Video_Konum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage_Oynat = new System.Windows.Forms.TabPage();
            this.trackBar_Ses = new System.Windows.Forms.TrackBar();
            this.button_KontrolDur = new System.Windows.Forms.Button();
            this.button_KontrolDurdur = new System.Windows.Forms.Button();
            this.label_Zaman = new System.Windows.Forms.Label();
            this.label_ParcaAdi = new System.Windows.Forms.Label();
            this.label_SanatciAdi = new System.Windows.Forms.Label();
            this.button_KontrolGeri = new System.Windows.Forms.Button();
            this.button_Kontrolileri = new System.Windows.Forms.Button();
            this.button_KontrolOynat = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.trackBar_Oynat = new System.Windows.Forms.TrackBar();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.tabPage_Ayarlar = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trackBar_SeslendirmeUyariveHata = new System.Windows.Forms.TrackBar();
            this.trackBar_SeslendirmeAciklama = new System.Windows.Forms.TrackBar();
            this.trackBar_SeslendirmeBaslik = new System.Windows.Forms.TrackBar();
            this.label_UyariveHataSesleri = new System.Windows.Forms.Label();
            this.checkBox_UyariveHataSesleri = new System.Windows.Forms.CheckBox();
            this.label_AciklamaSesleri = new System.Windows.Forms.Label();
            this.checkBox_AciklamaSesleri = new System.Windows.Forms.CheckBox();
            this.checkBox_BaslikSesleri = new System.Windows.Forms.CheckBox();
            this.label_BaslikSesleri = new System.Windows.Forms.Label();
            this.tabPage_Yardim = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mpTabControl_Ana_Menu.SuspendLayout();
            this.tabPage_CalmaListeleri.SuspendLayout();
            this.mpTabControl_Listeler.SuspendLayout();
            this.tabPage_Tum_Listeler.SuspendLayout();
            this.tabPage_Album.SuspendLayout();
            this.tabPage_Sanatcilar.SuspendLayout();
            this.tabPage_Muzik.SuspendLayout();
            this.tabPage_Video.SuspendLayout();
            this.tabPage_Oynat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Ses)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Oynat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.tabPage_Ayarlar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_SeslendirmeUyariveHata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_SeslendirmeAciklama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_SeslendirmeBaslik)).BeginInit();
            this.tabPage_Yardim.SuspendLayout();
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
            // backgroundWorker_UyariSesleriOlustur
            // 
            this.backgroundWorker_UyariSesleriOlustur.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_UyariSesleriOlustur_DoWork);
            // 
            // backgroundWorker_Seslendirme
            // 
            this.backgroundWorker_Seslendirme.WorkerSupportsCancellation = true;
            this.backgroundWorker_Seslendirme.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_Seslendirme_DoWork);
            // 
            // timer_OynatmaZamani
            // 
            this.timer_OynatmaZamani.Interval = 1000;
            this.timer_OynatmaZamani.Tick += new System.EventHandler(this.timer_OynatmaZamani_Tick);
            // 
            // mpTabControl_Ana_Menu
            // 
            this.mpTabControl_Ana_Menu.Controls.Add(this.tabPage_CalmaListeleri);
            this.mpTabControl_Ana_Menu.Controls.Add(this.tabPage_Muzik);
            this.mpTabControl_Ana_Menu.Controls.Add(this.tabPage_Video);
            this.mpTabControl_Ana_Menu.Controls.Add(this.tabPage_Oynat);
            this.mpTabControl_Ana_Menu.Controls.Add(this.tabPage_Ayarlar);
            this.mpTabControl_Ana_Menu.Controls.Add(this.tabPage_Yardim);
            this.mpTabControl_Ana_Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mpTabControl_Ana_Menu.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.mpTabControl_Ana_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mpTabControl_Ana_Menu.ItemSize = new System.Drawing.Size(160, 45);
            this.mpTabControl_Ana_Menu.Location = new System.Drawing.Point(0, 0);
            this.mpTabControl_Ana_Menu.Margin = new System.Windows.Forms.Padding(0);
            this.mpTabControl_Ana_Menu.Name = "mpTabControl_Ana_Menu";
            this.mpTabControl_Ana_Menu.Padding = new System.Drawing.Point(0, 0);
            this.mpTabControl_Ana_Menu.SelectedIndex = 0;
            this.mpTabControl_Ana_Menu.Size = new System.Drawing.Size(965, 576);
            this.mpTabControl_Ana_Menu.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.mpTabControl_Ana_Menu.TabIndex = 0;
            this.mpTabControl_Ana_Menu.Tag = "";
            this.mpTabControl_Ana_Menu.SelectedIndexChanged += new System.EventHandler(this.mpTabControl_Ana_Menu_SelectedIndexChanged);
            this.mpTabControl_Ana_Menu.Selected += new System.Windows.Forms.TabControlEventHandler(this.mpTabControl_Ana_Menu_Selected);
            this.mpTabControl_Ana_Menu.Enter += new System.EventHandler(this.mpTabControl_Ana_Menu_Enter);
            this.mpTabControl_Ana_Menu.Leave += new System.EventHandler(this.mpTabControl_Ana_Menu_Leave);
            // 
            // tabPage_CalmaListeleri
            // 
            this.tabPage_CalmaListeleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.tabPage_CalmaListeleri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage_CalmaListeleri.Controls.Add(this.mpTabControl_Listeler);
            this.tabPage_CalmaListeleri.Location = new System.Drawing.Point(4, 49);
            this.tabPage_CalmaListeleri.Name = "tabPage_CalmaListeleri";
            this.tabPage_CalmaListeleri.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_CalmaListeleri.Size = new System.Drawing.Size(957, 523);
            this.tabPage_CalmaListeleri.TabIndex = 0;
            this.tabPage_CalmaListeleri.Text = "Çalma Listeleri";
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
            this.mpTabControl_Listeler.Size = new System.Drawing.Size(951, 517);
            this.mpTabControl_Listeler.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.mpTabControl_Listeler.TabIndex = 0;
            this.mpTabControl_Listeler.SelectedIndexChanged += new System.EventHandler(this.mpTabControl_Listeler_SelectedIndexChanged);
            this.mpTabControl_Listeler.Selected += new System.Windows.Forms.TabControlEventHandler(this.mpTabControl_Listeler_Selected);
            this.mpTabControl_Listeler.Enter += new System.EventHandler(this.mpTabControl_Listeler_Enter);
            this.mpTabControl_Listeler.Leave += new System.EventHandler(this.mpTabControl_Listeler_Leave);
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
            this.tabPage_Tum_Listeler.Size = new System.Drawing.Size(823, 509);
            this.tabPage_Tum_Listeler.TabIndex = 0;
            this.tabPage_Tum_Listeler.Text = "Tüm Liste";
            this.tabPage_Tum_Listeler.Leave += new System.EventHandler(this.tabPage_Tum_Listeler_Leave);
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
            this.listView_Tum_Liste.HideSelection = false;
            this.listView_Tum_Liste.Location = new System.Drawing.Point(3, 55);
            this.listView_Tum_Liste.MultiSelect = false;
            this.listView_Tum_Liste.Name = "listView_Tum_Liste";
            this.listView_Tum_Liste.Size = new System.Drawing.Size(817, 451);
            this.listView_Tum_Liste.TabIndex = 4;
            this.listView_Tum_Liste.UseCompatibleStateImageBehavior = false;
            this.listView_Tum_Liste.View = System.Windows.Forms.View.Details;
            this.listView_Tum_Liste.SelectedIndexChanged += new System.EventHandler(this.listView_Tum_Liste_SelectedIndexChanged);
            this.listView_Tum_Liste.Enter += new System.EventHandler(this.listView_Tum_Liste_Enter);
            this.listView_Tum_Liste.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView_Tum_Liste_KeyDown);
            this.listView_Tum_Liste.Leave += new System.EventHandler(this.listView_Tum_Liste_Leave);
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
            this.mpButon_Sil.TabIndex = 3;
            this.mpButon_Sil.TabStop = false;
            this.mpButon_Sil.Tag = "sil";
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
            this.mpButon_Klasor_Ekle.TabIndex = 2;
            this.mpButon_Klasor_Ekle.Tag = "klasor_ekle";
            this.mpButon_Klasor_Ekle.Text = "Klasör Ekle";
            this.mpButon_Klasor_Ekle.UseVisualStyleBackColor = false;
            this.mpButon_Klasor_Ekle.Click += new System.EventHandler(this.mpButon_Klasor_Ekle_Click);
            this.mpButon_Klasor_Ekle.Enter += new System.EventHandler(this.mpButon_Klasor_Ekle_Enter);
            this.mpButon_Klasor_Ekle.Leave += new System.EventHandler(this.mpButon_Klasor_Ekle_Leave);
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
            this.mpButon_Dosya_Ekle.TabIndex = 1;
            this.mpButon_Dosya_Ekle.Tag = "dosya_ekle";
            this.mpButon_Dosya_Ekle.Text = "Dosya Ekle";
            this.mpButon_Dosya_Ekle.UseVisualStyleBackColor = false;
            this.mpButon_Dosya_Ekle.Click += new System.EventHandler(this.mpButon_Dosya_Ekle_Click);
            this.mpButon_Dosya_Ekle.Enter += new System.EventHandler(this.mpButon_Dosya_Ekle_Enter);
            this.mpButon_Dosya_Ekle.Leave += new System.EventHandler(this.mpButon_Dosya_Ekle_Leave);
            // 
            // tabPage_Album
            // 
            this.tabPage_Album.BackColor = System.Drawing.Color.Transparent;
            this.tabPage_Album.Controls.Add(this.listView_Album);
            this.tabPage_Album.Location = new System.Drawing.Point(124, 4);
            this.tabPage_Album.Name = "tabPage_Album";
            this.tabPage_Album.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Album.Size = new System.Drawing.Size(823, 509);
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
            this.listView_Album.MultiSelect = false;
            this.listView_Album.Name = "listView_Album";
            this.listView_Album.Size = new System.Drawing.Size(817, 503);
            this.listView_Album.TabIndex = 0;
            this.listView_Album.UseCompatibleStateImageBehavior = false;
            this.listView_Album.View = System.Windows.Forms.View.Details;
            this.listView_Album.SelectedIndexChanged += new System.EventHandler(this.listView_Album_SelectedIndexChanged);
            this.listView_Album.Enter += new System.EventHandler(this.listView_Album_Enter);
            this.listView_Album.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView_Album_KeyDown);
            this.listView_Album.Leave += new System.EventHandler(this.listView_Album_Leave);
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
            this.tabPage_Sanatcilar.Size = new System.Drawing.Size(823, 509);
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
            this.listView_Sanatci.MultiSelect = false;
            this.listView_Sanatci.Name = "listView_Sanatci";
            this.listView_Sanatci.Size = new System.Drawing.Size(817, 503);
            this.listView_Sanatci.TabIndex = 0;
            this.listView_Sanatci.UseCompatibleStateImageBehavior = false;
            this.listView_Sanatci.View = System.Windows.Forms.View.Details;
            this.listView_Sanatci.SelectedIndexChanged += new System.EventHandler(this.listView_Sanatci_SelectedIndexChanged);
            this.listView_Sanatci.Enter += new System.EventHandler(this.listView_Sanatci_Enter);
            this.listView_Sanatci.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView_Sanatci_KeyDown);
            this.listView_Sanatci.Leave += new System.EventHandler(this.listView_Sanatci_Leave);
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
            // tabPage_Muzik
            // 
            this.tabPage_Muzik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.tabPage_Muzik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage_Muzik.Controls.Add(this.listView_Muzik);
            this.tabPage_Muzik.Location = new System.Drawing.Point(4, 49);
            this.tabPage_Muzik.Name = "tabPage_Muzik";
            this.tabPage_Muzik.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Muzik.Size = new System.Drawing.Size(957, 523);
            this.tabPage_Muzik.TabIndex = 1;
            this.tabPage_Muzik.Text = "Müzik";
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
            this.listView_Muzik.FullRowSelect = true;
            this.listView_Muzik.GridLines = true;
            this.listView_Muzik.LargeImageList = this.ımageList_Muzik;
            this.listView_Muzik.Location = new System.Drawing.Point(3, 3);
            this.listView_Muzik.Margin = new System.Windows.Forms.Padding(0);
            this.listView_Muzik.MultiSelect = false;
            this.listView_Muzik.Name = "listView_Muzik";
            this.listView_Muzik.Size = new System.Drawing.Size(951, 517);
            this.listView_Muzik.SmallImageList = this.ımageList_Muzik;
            this.listView_Muzik.TabIndex = 0;
            this.listView_Muzik.UseCompatibleStateImageBehavior = false;
            this.listView_Muzik.View = System.Windows.Forms.View.Details;
            this.listView_Muzik.SelectedIndexChanged += new System.EventHandler(this.listView_Muzik_SelectedIndexChanged);
            this.listView_Muzik.Enter += new System.EventHandler(this.listView_Muzik_Enter);
            this.listView_Muzik.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView_Muzik_KeyDown);
            this.listView_Muzik.Leave += new System.EventHandler(this.listView_Muzik_Leave);
            this.listView_Muzik.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_Muzik_MouseDoubleClick);
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
            // tabPage_Video
            // 
            this.tabPage_Video.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.tabPage_Video.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage_Video.Controls.Add(this.listView_Video);
            this.tabPage_Video.Location = new System.Drawing.Point(4, 49);
            this.tabPage_Video.Name = "tabPage_Video";
            this.tabPage_Video.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Video.Size = new System.Drawing.Size(957, 523);
            this.tabPage_Video.TabIndex = 2;
            this.tabPage_Video.Text = "Video";
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
            this.listView_Video.FullRowSelect = true;
            this.listView_Video.GridLines = true;
            this.listView_Video.LargeImageList = this.ımageList_Video;
            this.listView_Video.Location = new System.Drawing.Point(3, 3);
            this.listView_Video.MultiSelect = false;
            this.listView_Video.Name = "listView_Video";
            this.listView_Video.Size = new System.Drawing.Size(951, 517);
            this.listView_Video.SmallImageList = this.ımageList_Video;
            this.listView_Video.TabIndex = 0;
            this.listView_Video.UseCompatibleStateImageBehavior = false;
            this.listView_Video.View = System.Windows.Forms.View.Details;
            this.listView_Video.SelectedIndexChanged += new System.EventHandler(this.listView_Video_SelectedIndexChanged);
            this.listView_Video.Enter += new System.EventHandler(this.listView_Video_Enter);
            this.listView_Video.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView_Video_KeyDown);
            this.listView_Video.Leave += new System.EventHandler(this.listView_Video_Leave);
            this.listView_Video.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_Video_MouseDoubleClick);
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
            this.column_Video_Sure.Text = "Süre";
            this.column_Video_Sure.Width = 110;
            // 
            // column_Video_Konum
            // 
            this.column_Video_Konum.Text = "Konum";
            this.column_Video_Konum.Width = 400;
            // 
            // tabPage_Oynat
            // 
            this.tabPage_Oynat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.tabPage_Oynat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage_Oynat.Controls.Add(this.trackBar_Ses);
            this.tabPage_Oynat.Controls.Add(this.button_KontrolDur);
            this.tabPage_Oynat.Controls.Add(this.button_KontrolDurdur);
            this.tabPage_Oynat.Controls.Add(this.label_Zaman);
            this.tabPage_Oynat.Controls.Add(this.label_ParcaAdi);
            this.tabPage_Oynat.Controls.Add(this.label_SanatciAdi);
            this.tabPage_Oynat.Controls.Add(this.button_KontrolGeri);
            this.tabPage_Oynat.Controls.Add(this.button_Kontrolileri);
            this.tabPage_Oynat.Controls.Add(this.button_KontrolOynat);
            this.tabPage_Oynat.Controls.Add(this.tableLayoutPanel1);
            this.tabPage_Oynat.Location = new System.Drawing.Point(4, 49);
            this.tabPage_Oynat.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage_Oynat.Name = "tabPage_Oynat";
            this.tabPage_Oynat.Size = new System.Drawing.Size(957, 523);
            this.tabPage_Oynat.TabIndex = 3;
            this.tabPage_Oynat.Text = "Oynat";
            this.tabPage_Oynat.Enter += new System.EventHandler(this.tabPage_Oynat_Enter);
            // 
            // trackBar_Ses
            // 
            this.trackBar_Ses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar_Ses.Location = new System.Drawing.Point(854, 476);
            this.trackBar_Ses.Maximum = 100;
            this.trackBar_Ses.Name = "trackBar_Ses";
            this.trackBar_Ses.Size = new System.Drawing.Size(104, 45);
            this.trackBar_Ses.TabIndex = 7;
            this.trackBar_Ses.Tag = "kontrolSes";
            this.trackBar_Ses.TickFrequency = 10;
            this.trackBar_Ses.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_Ses.Scroll += new System.EventHandler(this.trackBar_Ses_Scroll);
            this.trackBar_Ses.Enter += new System.EventHandler(this.trackBar_Ses_Enter);
            this.trackBar_Ses.Leave += new System.EventHandler(this.trackBar_Ses_Leave);
            // 
            // button_KontrolDur
            // 
            this.button_KontrolDur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_KontrolDur.BackgroundImage = global::MediaPlayer.Properties.Resources.dur;
            this.button_KontrolDur.FlatAppearance.BorderSize = 0;
            this.button_KontrolDur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_KontrolDur.Location = new System.Drawing.Point(61, 477);
            this.button_KontrolDur.Name = "button_KontrolDur";
            this.button_KontrolDur.Size = new System.Drawing.Size(50, 40);
            this.button_KontrolDur.TabIndex = 2;
            this.button_KontrolDur.Tag = "kontrolDur";
            this.button_KontrolDur.UseVisualStyleBackColor = true;
            this.button_KontrolDur.Click += new System.EventHandler(this.button_KontrolDur_Click);
            this.button_KontrolDur.Enter += new System.EventHandler(this.button_KontrolDur_Enter);
            this.button_KontrolDur.MouseLeave += new System.EventHandler(this.button_KontrolDur_MouseLeave);
            this.button_KontrolDur.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_KontrolDur_MouseMove);
            // 
            // button_KontrolDurdur
            // 
            this.button_KontrolDurdur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_KontrolDurdur.BackgroundImage = global::MediaPlayer.Properties.Resources.durdur;
            this.button_KontrolDurdur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_KontrolDurdur.FlatAppearance.BorderSize = 0;
            this.button_KontrolDurdur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_KontrolDurdur.ForeColor = System.Drawing.Color.Transparent;
            this.button_KontrolDurdur.Location = new System.Drawing.Point(112, 477);
            this.button_KontrolDurdur.Name = "button_KontrolDurdur";
            this.button_KontrolDurdur.Size = new System.Drawing.Size(70, 40);
            this.button_KontrolDurdur.TabIndex = 3;
            this.button_KontrolDurdur.Tag = "kontrolDuraklat";
            this.button_KontrolDurdur.UseVisualStyleBackColor = true;
            this.button_KontrolDurdur.Visible = false;
            this.button_KontrolDurdur.Click += new System.EventHandler(this.button_KontrolDurdur_Click);
            this.button_KontrolDurdur.Enter += new System.EventHandler(this.button_KontrolDurdur_Enter);
            this.button_KontrolDurdur.MouseLeave += new System.EventHandler(this.button_KontrolDurdur_MouseLeave);
            this.button_KontrolDurdur.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_KontrolDurdur_MouseMove);
            // 
            // label_Zaman
            // 
            this.label_Zaman.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Zaman.AutoSize = true;
            this.label_Zaman.BackColor = System.Drawing.Color.Transparent;
            this.label_Zaman.Font = new System.Drawing.Font("Segoe UI Light", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Zaman.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label_Zaman.Location = new System.Drawing.Point(272, 472);
            this.label_Zaman.Name = "label_Zaman";
            this.label_Zaman.Size = new System.Drawing.Size(100, 46);
            this.label_Zaman.TabIndex = 0;
            this.label_Zaman.Text = "00:00";
            this.label_Zaman.Click += new System.EventHandler(this.label_Zaman_Click);
            // 
            // label_ParcaAdi
            // 
            this.label_ParcaAdi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_ParcaAdi.AutoSize = true;
            this.label_ParcaAdi.BackColor = System.Drawing.Color.Transparent;
            this.label_ParcaAdi.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_ParcaAdi.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label_ParcaAdi.Location = new System.Drawing.Point(412, 500);
            this.label_ParcaAdi.Name = "label_ParcaAdi";
            this.label_ParcaAdi.Size = new System.Drawing.Size(37, 14);
            this.label_ParcaAdi.TabIndex = 0;
            this.label_ParcaAdi.Text = "-   -   -";
            // 
            // label_SanatciAdi
            // 
            this.label_SanatciAdi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_SanatciAdi.AutoSize = true;
            this.label_SanatciAdi.BackColor = System.Drawing.Color.Transparent;
            this.label_SanatciAdi.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_SanatciAdi.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_SanatciAdi.Location = new System.Drawing.Point(410, 478);
            this.label_SanatciAdi.Name = "label_SanatciAdi";
            this.label_SanatciAdi.Size = new System.Drawing.Size(44, 23);
            this.label_SanatciAdi.TabIndex = 0;
            this.label_SanatciAdi.Text = "-  -  -";
            // 
            // button_KontrolGeri
            // 
            this.button_KontrolGeri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_KontrolGeri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_KontrolGeri.BackgroundImage")));
            this.button_KontrolGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_KontrolGeri.FlatAppearance.BorderSize = 0;
            this.button_KontrolGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_KontrolGeri.ForeColor = System.Drawing.Color.Transparent;
            this.button_KontrolGeri.Location = new System.Drawing.Point(8, 477);
            this.button_KontrolGeri.Name = "button_KontrolGeri";
            this.button_KontrolGeri.Size = new System.Drawing.Size(50, 40);
            this.button_KontrolGeri.TabIndex = 4;
            this.button_KontrolGeri.Tag = "kontrolGeri";
            this.button_KontrolGeri.UseVisualStyleBackColor = true;
            this.button_KontrolGeri.Click += new System.EventHandler(this.button_KontrolGeri_Click);
            this.button_KontrolGeri.Enter += new System.EventHandler(this.button_KontrolGeri_Enter);
            this.button_KontrolGeri.MouseLeave += new System.EventHandler(this.button_KontrolGeri_MouseLeave);
            this.button_KontrolGeri.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_KontrolGeri_MouseMove);
            // 
            // button_Kontrolileri
            // 
            this.button_Kontrolileri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Kontrolileri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Kontrolileri.BackgroundImage")));
            this.button_Kontrolileri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Kontrolileri.FlatAppearance.BorderSize = 0;
            this.button_Kontrolileri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Kontrolileri.ForeColor = System.Drawing.Color.Transparent;
            this.button_Kontrolileri.Location = new System.Drawing.Point(188, 477);
            this.button_Kontrolileri.Name = "button_Kontrolileri";
            this.button_Kontrolileri.Size = new System.Drawing.Size(50, 40);
            this.button_Kontrolileri.TabIndex = 5;
            this.button_Kontrolileri.Tag = "kontrolileri";
            this.button_Kontrolileri.UseVisualStyleBackColor = true;
            this.button_Kontrolileri.Click += new System.EventHandler(this.button_Kontrolileri_Click);
            this.button_Kontrolileri.Enter += new System.EventHandler(this.button_Kontrolileri_Enter);
            this.button_Kontrolileri.MouseLeave += new System.EventHandler(this.button_Kontrolileri_MouseLeave);
            this.button_Kontrolileri.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_Kontrolileri_MouseMove);
            // 
            // button_KontrolOynat
            // 
            this.button_KontrolOynat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_KontrolOynat.BackgroundImage = global::MediaPlayer.Properties.Resources.oynat;
            this.button_KontrolOynat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_KontrolOynat.FlatAppearance.BorderSize = 0;
            this.button_KontrolOynat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_KontrolOynat.ForeColor = System.Drawing.Color.Transparent;
            this.button_KontrolOynat.Location = new System.Drawing.Point(112, 477);
            this.button_KontrolOynat.Name = "button_KontrolOynat";
            this.button_KontrolOynat.Size = new System.Drawing.Size(70, 40);
            this.button_KontrolOynat.TabIndex = 1;
            this.button_KontrolOynat.Tag = "kontrolOynat";
            this.button_KontrolOynat.UseVisualStyleBackColor = true;
            this.button_KontrolOynat.Click += new System.EventHandler(this.button_KontrolOynat_Click);
            this.button_KontrolOynat.Enter += new System.EventHandler(this.button_KontrolOynat_Enter);
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
            this.tableLayoutPanel1.Controls.Add(this.trackBar_Oynat, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.axWindowsMediaPlayer1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(951, 468);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // trackBar_Oynat
            // 
            this.trackBar_Oynat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar_Oynat.Location = new System.Drawing.Point(0, 443);
            this.trackBar_Oynat.Margin = new System.Windows.Forms.Padding(0);
            this.trackBar_Oynat.Maximum = 100;
            this.trackBar_Oynat.Name = "trackBar_Oynat";
            this.trackBar_Oynat.Size = new System.Drawing.Size(951, 25);
            this.trackBar_Oynat.TabIndex = 6;
            this.trackBar_Oynat.Tag = "kontrolilerleme";
            this.trackBar_Oynat.TickFrequency = 5;
            this.trackBar_Oynat.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_Oynat.Enter += new System.EventHandler(this.trackBar_Oynat_Enter);
            this.trackBar_Oynat.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar_Oynat_MouseUp);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(951, 443);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.TabStop = false;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            this.axWindowsMediaPlayer1.PositionChange += new AxWMPLib._WMPOCXEvents_PositionChangeEventHandler(this.axWindowsMediaPlayer1_PositionChange);
            this.axWindowsMediaPlayer1.CurrentItemChange += new AxWMPLib._WMPOCXEvents_CurrentItemChangeEventHandler(this.axWindowsMediaPlayer1_CurrentItemChange);
            // 
            // tabPage_Ayarlar
            // 
            this.tabPage_Ayarlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.tabPage_Ayarlar.BackgroundImage = global::MediaPlayer.Properties.Resources.ArkaplanAyarlar;
            this.tabPage_Ayarlar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage_Ayarlar.Controls.Add(this.groupBox1);
            this.tabPage_Ayarlar.Location = new System.Drawing.Point(4, 49);
            this.tabPage_Ayarlar.Name = "tabPage_Ayarlar";
            this.tabPage_Ayarlar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Ayarlar.Size = new System.Drawing.Size(957, 523);
            this.tabPage_Ayarlar.TabIndex = 4;
            this.tabPage_Ayarlar.Text = "Ayarlar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trackBar_SeslendirmeUyariveHata);
            this.groupBox1.Controls.Add(this.trackBar_SeslendirmeAciklama);
            this.groupBox1.Controls.Add(this.trackBar_SeslendirmeBaslik);
            this.groupBox1.Controls.Add(this.label_UyariveHataSesleri);
            this.groupBox1.Controls.Add(this.checkBox_UyariveHataSesleri);
            this.groupBox1.Controls.Add(this.label_AciklamaSesleri);
            this.groupBox1.Controls.Add(this.checkBox_AciklamaSesleri);
            this.groupBox1.Controls.Add(this.checkBox_BaslikSesleri);
            this.groupBox1.Controls.Add(this.label_BaslikSesleri);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(19, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(919, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seslendirme";
            // 
            // trackBar_SeslendirmeUyariveHata
            // 
            this.trackBar_SeslendirmeUyariveHata.Location = new System.Drawing.Point(681, 71);
            this.trackBar_SeslendirmeUyariveHata.Maximum = 100;
            this.trackBar_SeslendirmeUyariveHata.Name = "trackBar_SeslendirmeUyariveHata";
            this.trackBar_SeslendirmeUyariveHata.Size = new System.Drawing.Size(200, 45);
            this.trackBar_SeslendirmeUyariveHata.SmallChange = 10;
            this.trackBar_SeslendirmeUyariveHata.TabIndex = 6;
            this.trackBar_SeslendirmeUyariveHata.Tag = "";
            this.trackBar_SeslendirmeUyariveHata.TickFrequency = 10;
            this.trackBar_SeslendirmeUyariveHata.Scroll += new System.EventHandler(this.trackBar_SeslendirmeUyariveHata_Scroll);
            this.trackBar_SeslendirmeUyariveHata.Enter += new System.EventHandler(this.trackBar_SeslendirmeUyariveHata_Enter);
            this.trackBar_SeslendirmeUyariveHata.Leave += new System.EventHandler(this.trackBar_SeslendirmeUyariveHata_Leave);
            // 
            // trackBar_SeslendirmeAciklama
            // 
            this.trackBar_SeslendirmeAciklama.Location = new System.Drawing.Point(339, 71);
            this.trackBar_SeslendirmeAciklama.Maximum = 100;
            this.trackBar_SeslendirmeAciklama.Name = "trackBar_SeslendirmeAciklama";
            this.trackBar_SeslendirmeAciklama.Size = new System.Drawing.Size(200, 45);
            this.trackBar_SeslendirmeAciklama.SmallChange = 10;
            this.trackBar_SeslendirmeAciklama.TabIndex = 4;
            this.trackBar_SeslendirmeAciklama.TickFrequency = 10;
            this.trackBar_SeslendirmeAciklama.Scroll += new System.EventHandler(this.trackBar_SeslendirmeAciklama_Scroll);
            this.trackBar_SeslendirmeAciklama.Enter += new System.EventHandler(this.trackBar_SeslendirmeAciklama_Enter);
            // 
            // trackBar_SeslendirmeBaslik
            // 
            this.trackBar_SeslendirmeBaslik.LargeChange = 1;
            this.trackBar_SeslendirmeBaslik.Location = new System.Drawing.Point(13, 71);
            this.trackBar_SeslendirmeBaslik.Maximum = 100;
            this.trackBar_SeslendirmeBaslik.Name = "trackBar_SeslendirmeBaslik";
            this.trackBar_SeslendirmeBaslik.Size = new System.Drawing.Size(200, 45);
            this.trackBar_SeslendirmeBaslik.SmallChange = 10;
            this.trackBar_SeslendirmeBaslik.TabIndex = 2;
            this.trackBar_SeslendirmeBaslik.TickFrequency = 10;
            this.trackBar_SeslendirmeBaslik.Scroll += new System.EventHandler(this.trackBar_SeslendirmeBaslik_Scroll);
            this.trackBar_SeslendirmeBaslik.Enter += new System.EventHandler(this.trackBar_SeslendirmeBaslik_Enter);
            // 
            // label_UyariveHataSesleri
            // 
            this.label_UyariveHataSesleri.AutoSize = true;
            this.label_UyariveHataSesleri.Location = new System.Drawing.Point(718, 34);
            this.label_UyariveHataSesleri.Name = "label_UyariveHataSesleri";
            this.label_UyariveHataSesleri.Size = new System.Drawing.Size(160, 24);
            this.label_UyariveHataSesleri.TabIndex = 5;
            this.label_UyariveHataSesleri.Text = "Uyarılar ve Hatalar";
            // 
            // checkBox_UyariveHataSesleri
            // 
            this.checkBox_UyariveHataSesleri.AutoSize = true;
            this.checkBox_UyariveHataSesleri.Location = new System.Drawing.Point(688, 40);
            this.checkBox_UyariveHataSesleri.Name = "checkBox_UyariveHataSesleri";
            this.checkBox_UyariveHataSesleri.Size = new System.Drawing.Size(15, 14);
            this.checkBox_UyariveHataSesleri.TabIndex = 5;
            this.checkBox_UyariveHataSesleri.UseVisualStyleBackColor = true;
            this.checkBox_UyariveHataSesleri.CheckedChanged += new System.EventHandler(this.checkBox_UyariveHataSesleri_CheckedChanged);
            this.checkBox_UyariveHataSesleri.Enter += new System.EventHandler(this.checkBox_UyariveHataSesleri_Enter);
            // 
            // label_AciklamaSesleri
            // 
            this.label_AciklamaSesleri.AutoSize = true;
            this.label_AciklamaSesleri.Location = new System.Drawing.Point(373, 34);
            this.label_AciklamaSesleri.Name = "label_AciklamaSesleri";
            this.label_AciklamaSesleri.Size = new System.Drawing.Size(106, 24);
            this.label_AciklamaSesleri.TabIndex = 3;
            this.label_AciklamaSesleri.Text = "Açıklamalar";
            // 
            // checkBox_AciklamaSesleri
            // 
            this.checkBox_AciklamaSesleri.AutoSize = true;
            this.checkBox_AciklamaSesleri.Location = new System.Drawing.Point(346, 42);
            this.checkBox_AciklamaSesleri.Name = "checkBox_AciklamaSesleri";
            this.checkBox_AciklamaSesleri.Size = new System.Drawing.Size(15, 14);
            this.checkBox_AciklamaSesleri.TabIndex = 3;
            this.checkBox_AciklamaSesleri.UseVisualStyleBackColor = true;
            this.checkBox_AciklamaSesleri.CheckedChanged += new System.EventHandler(this.checkBox_AciklamaSesleri_CheckedChanged);
            this.checkBox_AciklamaSesleri.Enter += new System.EventHandler(this.checkBox_AciklamaSesleri_Enter);
            // 
            // checkBox_BaslikSesleri
            // 
            this.checkBox_BaslikSesleri.AutoSize = true;
            this.checkBox_BaslikSesleri.Location = new System.Drawing.Point(21, 40);
            this.checkBox_BaslikSesleri.Name = "checkBox_BaslikSesleri";
            this.checkBox_BaslikSesleri.Size = new System.Drawing.Size(15, 14);
            this.checkBox_BaslikSesleri.TabIndex = 1;
            this.checkBox_BaslikSesleri.UseVisualStyleBackColor = true;
            this.checkBox_BaslikSesleri.CheckedChanged += new System.EventHandler(this.checkBox_BaslikSesleri_CheckedChanged);
            this.checkBox_BaslikSesleri.Enter += new System.EventHandler(this.checkBox_BaslikSesleri_Enter);
            this.checkBox_BaslikSesleri.Leave += new System.EventHandler(this.checkBox_BaslikSesleri_Leave);
            // 
            // label_BaslikSesleri
            // 
            this.label_BaslikSesleri.AutoSize = true;
            this.label_BaslikSesleri.Location = new System.Drawing.Point(48, 34);
            this.label_BaslikSesleri.Name = "label_BaslikSesleri";
            this.label_BaslikSesleri.Size = new System.Drawing.Size(78, 24);
            this.label_BaslikSesleri.TabIndex = 0;
            this.label_BaslikSesleri.Text = "Başlıklar";
            // 
            // tabPage_Yardim
            // 
            this.tabPage_Yardim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.tabPage_Yardim.BackgroundImage = global::MediaPlayer.Properties.Resources.ArkaplanYardim;
            this.tabPage_Yardim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage_Yardim.Controls.Add(this.linkLabel1);
            this.tabPage_Yardim.Controls.Add(this.label2);
            this.tabPage_Yardim.Controls.Add(this.label1);
            this.tabPage_Yardim.Location = new System.Drawing.Point(4, 49);
            this.tabPage_Yardim.Name = "tabPage_Yardim";
            this.tabPage_Yardim.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Yardim.Size = new System.Drawing.Size(957, 523);
            this.tabPage_Yardim.TabIndex = 5;
            this.tabPage_Yardim.Text = "Hakkında";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.linkLabel1.Location = new System.Drawing.Point(427, 383);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(104, 24);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "github.com";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(359, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Haziran 2016";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(287, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 97);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bu program Celal Bayar Üniversitesi, Turgutlu MYO. UZEM Öğrencileri tarafından, g" +
    "örme zorluğu yaşayanlar için tasarlanmıştır.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(965, 576);
            this.Controls.Add(this.mpTabControl_Ana_Menu);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(400, 350);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.mpTabControl_Ana_Menu.ResumeLayout(false);
            this.tabPage_CalmaListeleri.ResumeLayout(false);
            this.mpTabControl_Listeler.ResumeLayout(false);
            this.tabPage_Tum_Listeler.ResumeLayout(false);
            this.tabPage_Album.ResumeLayout(false);
            this.tabPage_Sanatcilar.ResumeLayout(false);
            this.tabPage_Muzik.ResumeLayout(false);
            this.tabPage_Video.ResumeLayout(false);
            this.tabPage_Oynat.ResumeLayout(false);
            this.tabPage_Oynat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Ses)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Oynat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.tabPage_Ayarlar.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_SeslendirmeUyariveHata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_SeslendirmeAciklama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_SeslendirmeBaslik)).EndInit();
            this.tabPage_Yardim.ResumeLayout(false);
            this.tabPage_Yardim.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage_Muzik;
        private System.Windows.Forms.TabPage tabPage_Video;
        private System.Windows.Forms.TabPage tabPage_Oynat;
        private System.Windows.Forms.TabPage tabPage_Ayarlar;
        private System.Windows.Forms.TabPage tabPage_Yardim;
        private System.Windows.Forms.ColumnHeader column_TumListe_No;
        private System.Windows.Forms.ColumnHeader column_TumListe_DosyaAdi;
        private System.Windows.Forms.ColumnHeader column_TumListe_Sure;
        private System.Windows.Forms.ColumnHeader column_TumListe_Konum;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog_Dosya_Ekle;
        private System.Windows.Forms.ColumnHeader column_AlbumListesi_Album;
        private System.Windows.Forms.ColumnHeader column_AlbumListesi_Sanatci;
        private System.Windows.Forms.ColumnHeader column_AlbumListesi_DosyaAdi;
        private System.Windows.Forms.ColumnHeader column_AlbumListesi_Sure;
        private System.Windows.Forms.ColumnHeader column_SanatciListesi_Sanatci;
        private System.Windows.Forms.ColumnHeader column_SanatciListesi_Dosya_Adi;
        private System.Windows.Forms.ColumnHeader column_SanatciListesi_Sure;
        private System.Windows.Forms.ColumnHeader column_AlbumListesi_Dizin;
        private System.Windows.Forms.ColumnHeader column_SanatciListesi_Dizin;
        private System.Windows.Forms.Label label_ParcaAdi;
        private System.Windows.Forms.Label label_SanatciAdi;
        private System.Windows.Forms.Label label_Zaman;
        private System.Windows.Forms.ColumnHeader column_Muzik_Turu;
        private System.Windows.Forms.ColumnHeader column_Muzik_DosyaAdi;
        private System.Windows.Forms.ColumnHeader column_Muzik_Sure;
        private System.Windows.Forms.ColumnHeader column_Muzik_Sanatci;
        private System.Windows.Forms.ColumnHeader column_Muzik_Album;
        private System.Windows.Forms.ColumnHeader column_Muzik_Konum;
        private System.Windows.Forms.ColumnHeader column_Video_Turu;
        private System.Windows.Forms.ColumnHeader column_Video_DosyaAdi;
        private System.Windows.Forms.ColumnHeader column_Video_Sure;
        private System.Windows.Forms.ColumnHeader column_Video_Konum;
        private System.ComponentModel.BackgroundWorker backgroundWorker_ListeOlustur;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_KlasorEkle;
        private System.ComponentModel.BackgroundWorker backgroundWorker_UyariSesleriOlustur;
        private System.ComponentModel.BackgroundWorker backgroundWorker_Seslendirme;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_AciklamaSesleri;
        private System.Windows.Forms.Label label_BaslikSesleri;
        private System.Windows.Forms.Label label_UyariveHataSesleri;
        private System.Windows.Forms.Timer timer_OynatmaZamani;
        public System.Windows.Forms.ListView listView_Tum_Liste;
        public MPTabControl mpTabControl_Ana_Menu;
        public System.Windows.Forms.Button button_KontrolDurdur;
        public System.Windows.Forms.Button button_KontrolGeri;
        public System.Windows.Forms.Button button_Kontrolileri;
        public System.Windows.Forms.Button button_KontrolOynat;
        public System.Windows.Forms.Button button_KontrolDur;
        public System.Windows.Forms.TrackBar trackBar_Oynat;
        public System.Windows.Forms.TrackBar trackBar_Ses;
        public System.Windows.Forms.ListView listView_Muzik;
        public System.Windows.Forms.ListView listView_Video;
        public System.Windows.Forms.CheckBox checkBox_AciklamaSesleri;
        public System.Windows.Forms.CheckBox checkBox_BaslikSesleri;
        public System.Windows.Forms.CheckBox checkBox_UyariveHataSesleri;
        public System.Windows.Forms.TrackBar trackBar_SeslendirmeUyariveHata;
        public System.Windows.Forms.TrackBar trackBar_SeslendirmeAciklama;
        public System.Windows.Forms.TrackBar trackBar_SeslendirmeBaslik;
        public MPTabControl mpTabControl_Listeler;
        public System.Windows.Forms.TabPage tabPage_Tum_Listeler;
        public System.Windows.Forms.TabPage tabPage_Album;
        public System.Windows.Forms.TabPage tabPage_Sanatcilar;
        public System.Windows.Forms.TabPage tabPage_CalmaListeleri;
        public MPButon mpButon_Sil;
        public MPButon mpButon_Klasor_Ekle;
        public MPButon mpButon_Dosya_Ekle;
        public System.Windows.Forms.ListView listView_Album;
        public System.Windows.Forms.ListView listView_Sanatci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ImageList ımageList_Muzik;
        public System.Windows.Forms.ImageList ımageList_Video;
    }
}

