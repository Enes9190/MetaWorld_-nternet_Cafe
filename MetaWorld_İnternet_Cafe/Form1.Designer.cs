namespace MetaWorld_İnternet_Cafe
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yöneticiÇağırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sınırsızSüreliMasaAçmaİsteğiGönderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.süreliMasaAçmaİsteğiGönderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.masaDeğiştirmeİsteğiGönderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.HareketID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KullaniciID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MasaID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Masa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IstekTuru = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Aciklama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tBLSaatUcretiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.internetCafeDataSet = new MetaWorld_İnternet_Cafe.InternetCafeDataSet();
            this.comboBosMasalar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnMasaAc = new System.Windows.Forms.Button();
            this.tBLSaatUcretiTableAdapter = new MetaWorld_İnternet_Cafe.InternetCafeDataSetTableAdapters.TBLSaatUcretiTableAdapter();
            this.button12 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboSaatUcreti = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Masa_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Masa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AçılışSeçeneği = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BaslamaSaati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BitisSaati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hesapla = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MasaKapat = new System.Windows.Forms.DataGridViewButtonColumn();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSaatUcretiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetCafeDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yöneticiÇağırToolStripMenuItem,
            this.sınırsızSüreliMasaAçmaİsteğiGönderToolStripMenuItem,
            this.süreliMasaAçmaİsteğiGönderToolStripMenuItem,
            this.masaDeğiştirmeİsteğiGönderToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(340, 100);
            // 
            // yöneticiÇağırToolStripMenuItem
            // 
            this.yöneticiÇağırToolStripMenuItem.Name = "yöneticiÇağırToolStripMenuItem";
            this.yöneticiÇağırToolStripMenuItem.Size = new System.Drawing.Size(339, 24);
            this.yöneticiÇağırToolStripMenuItem.Text = "Yönetici Çağır";
            // 
            // sınırsızSüreliMasaAçmaİsteğiGönderToolStripMenuItem
            // 
            this.sınırsızSüreliMasaAçmaİsteğiGönderToolStripMenuItem.Name = "sınırsızSüreliMasaAçmaİsteğiGönderToolStripMenuItem";
            this.sınırsızSüreliMasaAçmaİsteğiGönderToolStripMenuItem.Size = new System.Drawing.Size(339, 24);
            this.sınırsızSüreliMasaAçmaİsteğiGönderToolStripMenuItem.Text = "Sınırsız Süreli Masa Açma İsteği Gönder";
            // 
            // süreliMasaAçmaİsteğiGönderToolStripMenuItem
            // 
            this.süreliMasaAçmaİsteğiGönderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9});
            this.süreliMasaAçmaİsteğiGönderToolStripMenuItem.Name = "süreliMasaAçmaİsteğiGönderToolStripMenuItem";
            this.süreliMasaAçmaİsteğiGönderToolStripMenuItem.Size = new System.Drawing.Size(339, 24);
            this.süreliMasaAçmaİsteğiGönderToolStripMenuItem.Text = "Süreli Masa Açma İsteği Gönder";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(116, 26);
            this.toolStripMenuItem2.Text = "30";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(116, 26);
            this.toolStripMenuItem3.Text = "60";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(116, 26);
            this.toolStripMenuItem4.Text = "90";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(116, 26);
            this.toolStripMenuItem5.Text = "120";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(116, 26);
            this.toolStripMenuItem6.Text = "150";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(116, 26);
            this.toolStripMenuItem7.Text = "180";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(116, 26);
            this.toolStripMenuItem8.Text = "240";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(116, 26);
            this.toolStripMenuItem9.Text = "270";
            // 
            // masaDeğiştirmeİsteğiGönderToolStripMenuItem
            // 
            this.masaDeğiştirmeİsteğiGönderToolStripMenuItem.Name = "masaDeğiştirmeİsteğiGönderToolStripMenuItem";
            this.masaDeğiştirmeİsteğiGönderToolStripMenuItem.Size = new System.Drawing.Size(339, 24);
            this.masaDeğiştirmeİsteğiGönderToolStripMenuItem.Text = "Masa Değiştirme İsteği Gönder";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "isometric-ga10407ef3_1280.png");
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HareketID,
            this.KullaniciID,
            this.MasaID,
            this.Masa,
            this.IstekTuru,
            this.Aciklama,
            this.Tarih});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 154);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1121, 183);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // HareketID
            // 
            this.HareketID.Text = "Hareket ID";
            this.HareketID.Width = 103;
            // 
            // KullaniciID
            // 
            this.KullaniciID.Text = "Kullanici ID";
            this.KullaniciID.Width = 102;
            // 
            // MasaID
            // 
            this.MasaID.Text = "Masa ID";
            this.MasaID.Width = 91;
            // 
            // Masa
            // 
            this.Masa.Text = "Masa";
            this.Masa.Width = 122;
            // 
            // IstekTuru
            // 
            this.IstekTuru.Text = "İstek Türü";
            this.IstekTuru.Width = 200;
            // 
            // Aciklama
            // 
            this.Aciklama.Text = "Aciklama";
            this.Aciklama.Width = 218;
            // 
            // Tarih
            // 
            this.Tarih.Text = "Tarih";
            this.Tarih.Width = 266;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Masa_ID,
            this._Masa,
            this.AçılışSeçeneği,
            this.BaslamaSaati,
            this.BitisSaati,
            this.Sure,
            this.Tutar,
            this._Tarih,
            this.Hesapla,
            this.MasaKapat});
            this.dataGridView1.Location = new System.Drawing.Point(12, 343);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1121, 221);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tBLSaatUcretiBindingSource
            // 
            this.tBLSaatUcretiBindingSource.DataMember = "TBLSaatUcreti";
            this.tBLSaatUcretiBindingSource.DataSource = this.internetCafeDataSet;
            // 
            // internetCafeDataSet
            // 
            this.internetCafeDataSet.DataSetName = "InternetCafeDataSet";
            this.internetCafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBosMasalar
            // 
            this.comboBosMasalar.FormattingEnabled = true;
            this.comboBosMasalar.Location = new System.Drawing.Point(1140, 154);
            this.comboBosMasalar.Name = "comboBosMasalar";
            this.comboBosMasalar.Size = new System.Drawing.Size(200, 24);
            this.comboBosMasalar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1183, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "BOŞ Masalar";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton10);
            this.panel1.Controls.Add(this.radioButton9);
            this.panel1.Controls.Add(this.radioButton8);
            this.panel1.Controls.Add(this.radioButton6);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton5);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton7);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(1138, 207);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 130);
            this.panel1.TabIndex = 6;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(132, 103);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(49, 20);
            this.radioButton10.TabIndex = 9;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "270";
            this.radioButton10.UseVisualStyleBackColor = true;
            this.radioButton10.CheckedChanged += new System.EventHandler(this.RadioButtonSeciliyeGore);
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(132, 80);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(49, 20);
            this.radioButton9.TabIndex = 9;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "240";
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.CheckedChanged += new System.EventHandler(this.RadioButtonSeciliyeGore);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(132, 54);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(49, 20);
            this.radioButton8.TabIndex = 9;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "210";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.RadioButtonSeciliyeGore);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(132, 29);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(49, 20);
            this.radioButton6.TabIndex = 9;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "180";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.RadioButtonSeciliyeGore);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(10, 77);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(42, 20);
            this.radioButton4.TabIndex = 9;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "90";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.RadioButtonSeciliyeGore);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(10, 103);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(49, 20);
            this.radioButton5.TabIndex = 9;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "120";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.RadioButtonSeciliyeGore);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(10, 54);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(42, 20);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "60";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.RadioButtonSeciliyeGore);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(132, 3);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(49, 20);
            this.radioButton7.TabIndex = 9;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "150";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.RadioButtonSeciliyeGore);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(10, 29);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(42, 20);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "30";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButtonSeciliyeGore);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(10, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(99, 20);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Sınırsız süre";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButtonSeciliyeGore);
            // 
            // btnMasaAc
            // 
            this.btnMasaAc.Location = new System.Drawing.Point(1140, 448);
            this.btnMasaAc.Name = "btnMasaAc";
            this.btnMasaAc.Size = new System.Drawing.Size(200, 116);
            this.btnMasaAc.TabIndex = 7;
            this.btnMasaAc.Text = "Yeni Masa Aç";
            this.btnMasaAc.UseVisualStyleBackColor = true;
            this.btnMasaAc.Click += new System.EventHandler(this.btnMasaAc_Click);
            // 
            // tBLSaatUcretiTableAdapter
            // 
            this.tBLSaatUcretiTableAdapter.ClearBeforeFill = true;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button12.ContextMenuStrip = this.contextMenuStrip1;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button12.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button12.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button12.ImageKey = "isometric-ga10407ef3_1280.png";
            this.button12.ImageList = this.ımageList1;
            this.button12.Location = new System.Drawing.Point(1139, 570);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(199, 110);
            this.button12.TabIndex = 1;
            this.button12.Text = "MASA-12";
            this.button12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGöre);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.ContextMenuStrip = this.contextMenuStrip1;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.ImageKey = "isometric-ga10407ef3_1280.png";
            this.button6.ImageList = this.ımageList1;
            this.button6.Location = new System.Drawing.Point(1140, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(199, 110);
            this.button6.TabIndex = 1;
            this.button6.Text = "MASA-6";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGöre);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button11.ContextMenuStrip = this.contextMenuStrip1;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button11.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button11.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button11.ImageKey = "isometric-ga10407ef3_1280.png";
            this.button11.ImageList = this.ımageList1;
            this.button11.Location = new System.Drawing.Point(916, 570);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(217, 110);
            this.button11.TabIndex = 1;
            this.button11.Text = "MASA-11";
            this.button11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGöre);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.ContextMenuStrip = this.contextMenuStrip1;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.ImageKey = "isometric-ga10407ef3_1280.png";
            this.button5.ImageList = this.ımageList1;
            this.button5.Location = new System.Drawing.Point(916, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(217, 110);
            this.button5.TabIndex = 1;
            this.button5.Text = "MASA-5";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGöre);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button10.ContextMenuStrip = this.contextMenuStrip1;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button10.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button10.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button10.ImageKey = "isometric-ga10407ef3_1280.png";
            this.button10.ImageList = this.ımageList1;
            this.button10.Location = new System.Drawing.Point(690, 570);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(220, 110);
            this.button10.TabIndex = 1;
            this.button10.Text = "MASA-10";
            this.button10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGöre);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.ContextMenuStrip = this.contextMenuStrip1;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.ImageKey = "isometric-ga10407ef3_1280.png";
            this.button4.ImageList = this.ımageList1;
            this.button4.Location = new System.Drawing.Point(690, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(220, 110);
            this.button4.TabIndex = 1;
            this.button4.Text = "MASA-4";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGöre);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button9.ContextMenuStrip = this.contextMenuStrip1;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button9.ImageKey = "isometric-ga10407ef3_1280.png";
            this.button9.ImageList = this.ımageList1;
            this.button9.Location = new System.Drawing.Point(464, 570);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(220, 110);
            this.button9.TabIndex = 1;
            this.button9.Text = "MASA-9";
            this.button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGöre);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button8.ContextMenuStrip = this.contextMenuStrip1;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button8.ImageKey = "isometric-ga10407ef3_1280.png";
            this.button8.ImageList = this.ımageList1;
            this.button8.Location = new System.Drawing.Point(238, 570);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(220, 110);
            this.button8.TabIndex = 1;
            this.button8.Text = "MASA-8";
            this.button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGöre);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.ContextMenuStrip = this.contextMenuStrip1;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.ImageKey = "isometric-ga10407ef3_1280.png";
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(464, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(220, 110);
            this.button3.TabIndex = 1;
            this.button3.Text = "MASA-3";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGöre);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button7.ContextMenuStrip = this.contextMenuStrip1;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button7.ImageKey = "isometric-ga10407ef3_1280.png";
            this.button7.ImageList = this.ımageList1;
            this.button7.Location = new System.Drawing.Point(12, 579);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(220, 110);
            this.button7.TabIndex = 0;
            this.button7.Text = "MASA-7";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGöre);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.ContextMenuStrip = this.contextMenuStrip1;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.ImageKey = "isometric-ga10407ef3_1280.png";
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(238, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 110);
            this.button2.TabIndex = 1;
            this.button2.Text = "MASA-2";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGöre);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.ContextMenuStrip = this.contextMenuStrip1;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.ImageKey = "isometric-ga10407ef3_1280.png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(12, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 110);
            this.button1.TabIndex = 0;
            this.button1.Text = "MASA-1";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGöre);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 8;
            // 
            // comboSaatUcreti
            // 
            this.comboSaatUcreti.DataSource = this.tBLSaatUcretiBindingSource;
            this.comboSaatUcreti.DisplayMember = "SaatUcreti";
            this.comboSaatUcreti.FormattingEnabled = true;
            this.comboSaatUcreti.Location = new System.Drawing.Point(1139, 393);
            this.comboSaatUcreti.Name = "comboSaatUcreti";
            this.comboSaatUcreti.Size = new System.Drawing.Size(199, 24);
            this.comboSaatUcreti.TabIndex = 9;
            this.comboSaatUcreti.ValueMember = "SaatUcretiID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(1136, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Saat Ücreti";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "SepetID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // Masa_ID
            // 
            this.Masa_ID.DataPropertyName = "MasaID";
            this.Masa_ID.HeaderText = "Masa ID";
            this.Masa_ID.MinimumWidth = 6;
            this.Masa_ID.Name = "Masa_ID";
            this.Masa_ID.ReadOnly = true;
            this.Masa_ID.Width = 125;
            // 
            // _Masa
            // 
            this._Masa.DataPropertyName = "Masa";
            this._Masa.HeaderText = "Masa";
            this._Masa.MinimumWidth = 6;
            this._Masa.Name = "_Masa";
            this._Masa.ReadOnly = true;
            this._Masa.Width = 125;
            // 
            // AçılışSeçeneği
            // 
            this.AçılışSeçeneği.DataPropertyName = "AcilisTuru";
            this.AçılışSeçeneği.HeaderText = "Açılış Seçeneği";
            this.AçılışSeçeneği.MinimumWidth = 6;
            this.AçılışSeçeneği.Name = "AçılışSeçeneği";
            this.AçılışSeçeneği.ReadOnly = true;
            this.AçılışSeçeneği.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AçılışSeçeneği.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.AçılışSeçeneği.Width = 125;
            // 
            // BaslamaSaati
            // 
            this.BaslamaSaati.DataPropertyName = "Baslangic";
            this.BaslamaSaati.HeaderText = "Başlama Saati";
            this.BaslamaSaati.MinimumWidth = 6;
            this.BaslamaSaati.Name = "BaslamaSaati";
            this.BaslamaSaati.ReadOnly = true;
            this.BaslamaSaati.Width = 125;
            // 
            // BitisSaati
            // 
            this.BitisSaati.DataPropertyName = "(none)";
            this.BitisSaati.HeaderText = "Bitiş Saati";
            this.BitisSaati.MinimumWidth = 6;
            this.BitisSaati.Name = "BitisSaati";
            this.BitisSaati.ReadOnly = true;
            this.BitisSaati.Width = 125;
            // 
            // Sure
            // 
            this.Sure.HeaderText = "Süre";
            this.Sure.MinimumWidth = 6;
            this.Sure.Name = "Sure";
            this.Sure.ReadOnly = true;
            this.Sure.Width = 125;
            // 
            // Tutar
            // 
            this.Tutar.HeaderText = "Tutar";
            this.Tutar.MinimumWidth = 6;
            this.Tutar.Name = "Tutar";
            this.Tutar.ReadOnly = true;
            this.Tutar.Width = 125;
            // 
            // _Tarih
            // 
            this._Tarih.DataPropertyName = "Tarih";
            this._Tarih.HeaderText = "Tarih";
            this._Tarih.MinimumWidth = 6;
            this._Tarih.Name = "_Tarih";
            this._Tarih.ReadOnly = true;
            this._Tarih.Width = 125;
            // 
            // Hesapla
            // 
            this.Hesapla.HeaderText = "Hesapla";
            this.Hesapla.MinimumWidth = 6;
            this.Hesapla.Name = "Hesapla";
            this.Hesapla.ReadOnly = true;
            this.Hesapla.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Hesapla.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Hesapla.Text = "Hesapla";
            this.Hesapla.ToolTipText = "Hesaplama yapar";
            this.Hesapla.UseColumnTextForButtonValue = true;
            this.Hesapla.Width = 125;
            // 
            // MasaKapat
            // 
            this.MasaKapat.HeaderText = "Masa Kapat";
            this.MasaKapat.MinimumWidth = 6;
            this.MasaKapat.Name = "MasaKapat";
            this.MasaKapat.ReadOnly = true;
            this.MasaKapat.Text = "Masa Kapat";
            this.MasaKapat.ToolTipText = "Masayı kapatır";
            this.MasaKapat.UseColumnTextForButtonValue = true;
            this.MasaKapat.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 701);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboSaatUcreti);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnMasaAc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBosMasalar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Yönetimi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSaatUcretiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetCafeDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBosMasalar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnMasaAc;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yöneticiÇağırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sınırsızSüreliMasaAçmaİsteğiGönderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem süreliMasaAçmaİsteğiGönderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem masaDeğiştirmeİsteğiGönderToolStripMenuItem;
        private InternetCafeDataSet internetCafeDataSet;
        private System.Windows.Forms.BindingSource tBLSaatUcretiBindingSource;
        private InternetCafeDataSetTableAdapters.TBLSaatUcretiTableAdapter tBLSaatUcretiTableAdapter;
        private System.Windows.Forms.ColumnHeader HareketID;
        private System.Windows.Forms.ColumnHeader KullaniciID;
        private System.Windows.Forms.ColumnHeader MasaID;
        private System.Windows.Forms.ColumnHeader Masa;
        private System.Windows.Forms.ColumnHeader IstekTuru;
        private System.Windows.Forms.ColumnHeader Aciklama;
        private System.Windows.Forms.ColumnHeader Tarih;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboSaatUcreti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masa_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Masa;
        private System.Windows.Forms.DataGridViewButtonColumn AçılışSeçeneği;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaslamaSaati;
        private System.Windows.Forms.DataGridViewTextBoxColumn BitisSaati;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Tarih;
        private System.Windows.Forms.DataGridViewButtonColumn Hesapla;
        private System.Windows.Forms.DataGridViewButtonColumn MasaKapat;
    }
}

