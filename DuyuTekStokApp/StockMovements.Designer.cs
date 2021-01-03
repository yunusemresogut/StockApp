namespace DuyuTekStokApp
{
    partial class StockMovements
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockMovements));
            this.panelMove = new System.Windows.Forms.Panel();
            this.dataGridViewStok = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridViewMove = new System.Windows.Forms.DataGridView();
            this.groupBoxMove = new System.Windows.Forms.GroupBox();
            this.comboBoxSinif = new System.Windows.Forms.ComboBox();
            this.siniflarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.dateTimePickerGuncel = new System.Windows.Forms.DateTimePicker();
            this.btnDuzen = new System.Windows.Forms.Button();
            this.textBoxAdetS = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.textBoxMevcut = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBoxUrun = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.richTextAciklama = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCins = new System.Windows.Forms.TextBox();
            this.dateTimeTarih = new System.Windows.Forms.DateTimePicker();
            this.textBoxKod = new System.Windows.Forms.TextBox();
            this.textBoxBarkod = new System.Windows.Forms.TextBox();
            this.textBoxBirim = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxGrup = new System.Windows.Forms.TextBox();
            this.groupBoxResim = new System.Windows.Forms.GroupBox();
            this.pictureBoxResim = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.siniflarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockControlDataSet1 = new DuyuTekStokApp.StockControlDataSet1();
            this.siniflarBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.siniflarTableAdapter = new DuyuTekStokApp.StockControlDataSet1TableAdapters.SiniflarTableAdapter();
            this.panelMove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMove)).BeginInit();
            this.groupBoxMove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siniflarBindingSource1)).BeginInit();
            this.groupBoxUrun.SuspendLayout();
            this.groupBoxResim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siniflarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockControlDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siniflarBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMove
            // 
            this.panelMove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panelMove.Controls.Add(this.dataGridViewStok);
            this.panelMove.Controls.Add(this.btnClose);
            this.panelMove.Controls.Add(this.dataGridViewMove);
            this.panelMove.Controls.Add(this.groupBoxMove);
            this.panelMove.Controls.Add(this.groupBoxUrun);
            this.panelMove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMove.Location = new System.Drawing.Point(0, 0);
            this.panelMove.Name = "panelMove";
            this.panelMove.Size = new System.Drawing.Size(1354, 943);
            this.panelMove.TabIndex = 0;
            // 
            // dataGridViewStok
            // 
            this.dataGridViewStok.AllowUserToAddRows = false;
            this.dataGridViewStok.AllowUserToDeleteRows = false;
            this.dataGridViewStok.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStok.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStok.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStok.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewStok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewStok.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewStok.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewStok.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewStok.Name = "dataGridViewStok";
            this.dataGridViewStok.ReadOnly = true;
            this.dataGridViewStok.RowTemplate.Height = 60;
            this.dataGridViewStok.Size = new System.Drawing.Size(1178, 280);
            this.dataGridViewStok.TabIndex = 30;
            this.dataGridViewStok.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStok_CellClick);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(1301, 18);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 29;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridViewMove
            // 
            this.dataGridViewMove.AllowUserToAddRows = false;
            this.dataGridViewMove.AllowUserToDeleteRows = false;
            this.dataGridViewMove.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMove.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMove.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMove.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewMove.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMove.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewMove.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewMove.Location = new System.Drawing.Point(12, 724);
            this.dataGridViewMove.Name = "dataGridViewMove";
            this.dataGridViewMove.ReadOnly = true;
            this.dataGridViewMove.RowTemplate.Height = 60;
            this.dataGridViewMove.Size = new System.Drawing.Size(1335, 207);
            this.dataGridViewMove.TabIndex = 25;
            this.dataGridViewMove.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMove_CellClick);
            // 
            // groupBoxMove
            // 
            this.groupBoxMove.Controls.Add(this.comboBoxSinif);
            this.groupBoxMove.Controls.Add(this.label2);
            this.groupBoxMove.Controls.Add(this.btnSil);
            this.groupBoxMove.Controls.Add(this.dateTimePickerGuncel);
            this.groupBoxMove.Controls.Add(this.btnDuzen);
            this.groupBoxMove.Controls.Add(this.textBoxAdetS);
            this.groupBoxMove.Controls.Add(this.btnEkle);
            this.groupBoxMove.Controls.Add(this.textBoxMevcut);
            this.groupBoxMove.Controls.Add(this.label8);
            this.groupBoxMove.Controls.Add(this.label9);
            this.groupBoxMove.Controls.Add(this.label10);
            this.groupBoxMove.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBoxMove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.groupBoxMove.Location = new System.Drawing.Point(722, 310);
            this.groupBoxMove.Name = "groupBoxMove";
            this.groupBoxMove.Size = new System.Drawing.Size(468, 408);
            this.groupBoxMove.TabIndex = 20;
            this.groupBoxMove.TabStop = false;
            this.groupBoxMove.Text = "Hareket İşlemi";
            // 
            // comboBoxSinif
            // 
            this.comboBoxSinif.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.siniflarBindingSource2, "SinifAdi", true));
            this.comboBoxSinif.DataSource = this.siniflarBindingSource2;
            this.comboBoxSinif.DisplayMember = "SinifAdi";
            this.comboBoxSinif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSinif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.comboBoxSinif.FormattingEnabled = true;
            this.comboBoxSinif.Location = new System.Drawing.Point(138, 142);
            this.comboBoxSinif.Name = "comboBoxSinif";
            this.comboBoxSinif.Size = new System.Drawing.Size(288, 22);
            this.comboBoxSinif.TabIndex = 30;
            this.comboBoxSinif.ValueMember = "SinifID";
            // 
            // siniflarBindingSource1
            // 
            this.siniflarBindingSource1.DataMember = "Siniflar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 14);
            this.label2.TabIndex = 26;
            this.label2.Text = "Son Değişim Tarihi";
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnSil.Location = new System.Drawing.Point(306, 277);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 40);
            this.btnSil.TabIndex = 28;
            this.btnSil.Text = "Stok Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerGuncel
            // 
            this.dateTimePickerGuncel.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dateTimePickerGuncel.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dateTimePickerGuncel.Location = new System.Drawing.Point(138, 184);
            this.dateTimePickerGuncel.Name = "dateTimePickerGuncel";
            this.dateTimePickerGuncel.Size = new System.Drawing.Size(288, 20);
            this.dateTimePickerGuncel.TabIndex = 25;
            // 
            // btnDuzen
            // 
            this.btnDuzen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDuzen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuzen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnDuzen.Location = new System.Drawing.Point(184, 277);
            this.btnDuzen.Name = "btnDuzen";
            this.btnDuzen.Size = new System.Drawing.Size(100, 40);
            this.btnDuzen.TabIndex = 27;
            this.btnDuzen.Text = "Stok Düzenle";
            this.btnDuzen.UseVisualStyleBackColor = true;
            // 
            // textBoxAdetS
            // 
            this.textBoxAdetS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.textBoxAdetS.Location = new System.Drawing.Point(138, 60);
            this.textBoxAdetS.Name = "textBoxAdetS";
            this.textBoxAdetS.Size = new System.Drawing.Size(288, 20);
            this.textBoxAdetS.TabIndex = 2;
            this.textBoxAdetS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAdetS_KeyPress);
            // 
            // btnEkle
            // 
            this.btnEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnEkle.Location = new System.Drawing.Point(62, 277);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 40);
            this.btnEkle.TabIndex = 26;
            this.btnEkle.Text = "Stok Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // textBoxMevcut
            // 
            this.textBoxMevcut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.textBoxMevcut.Location = new System.Drawing.Point(138, 100);
            this.textBoxMevcut.Name = "textBoxMevcut";
            this.textBoxMevcut.ReadOnly = true;
            this.textBoxMevcut.Size = new System.Drawing.Size(288, 20);
            this.textBoxMevcut.TabIndex = 4;
            this.textBoxMevcut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMevcut_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 14);
            this.label8.TabIndex = 8;
            this.label8.Text = "Adet Sayısı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 14);
            this.label9.TabIndex = 11;
            this.label9.Text = "Sınıf";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 14);
            this.label10.TabIndex = 10;
            this.label10.Text = "Mevcut Adet";
            // 
            // groupBoxUrun
            // 
            this.groupBoxUrun.Controls.Add(this.label11);
            this.groupBoxUrun.Controls.Add(this.richTextAciklama);
            this.groupBoxUrun.Controls.Add(this.label7);
            this.groupBoxUrun.Controls.Add(this.textBoxCins);
            this.groupBoxUrun.Controls.Add(this.dateTimeTarih);
            this.groupBoxUrun.Controls.Add(this.textBoxKod);
            this.groupBoxUrun.Controls.Add(this.textBoxBarkod);
            this.groupBoxUrun.Controls.Add(this.textBoxBirim);
            this.groupBoxUrun.Controls.Add(this.label6);
            this.groupBoxUrun.Controls.Add(this.textBoxGrup);
            this.groupBoxUrun.Controls.Add(this.groupBoxResim);
            this.groupBoxUrun.Controls.Add(this.label5);
            this.groupBoxUrun.Controls.Add(this.label1);
            this.groupBoxUrun.Controls.Add(this.label4);
            this.groupBoxUrun.Controls.Add(this.label3);
            this.groupBoxUrun.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBoxUrun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.groupBoxUrun.Location = new System.Drawing.Point(12, 310);
            this.groupBoxUrun.Name = "groupBoxUrun";
            this.groupBoxUrun.Size = new System.Drawing.Size(704, 408);
            this.groupBoxUrun.TabIndex = 19;
            this.groupBoxUrun.TabStop = false;
            this.groupBoxUrun.Text = "Ürün Bilgileri";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(296, 290);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 14);
            this.label11.TabIndex = 28;
            this.label11.Text = "Açıklama";
            // 
            // richTextAciklama
            // 
            this.richTextAciklama.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextAciklama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.richTextAciklama.Location = new System.Drawing.Point(400, 277);
            this.richTextAciklama.Name = "richTextAciklama";
            this.richTextAciklama.ReadOnly = true;
            this.richTextAciklama.Size = new System.Drawing.Size(288, 120);
            this.richTextAciklama.TabIndex = 27;
            this.richTextAciklama.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(297, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 14);
            this.label7.TabIndex = 26;
            this.label7.Text = "Cinsi";
            // 
            // textBoxCins
            // 
            this.textBoxCins.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxCins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.textBoxCins.Location = new System.Drawing.Point(400, 77);
            this.textBoxCins.Name = "textBoxCins";
            this.textBoxCins.ReadOnly = true;
            this.textBoxCins.Size = new System.Drawing.Size(288, 20);
            this.textBoxCins.TabIndex = 25;
            // 
            // dateTimeTarih
            // 
            this.dateTimeTarih.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dateTimeTarih.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dateTimeTarih.Location = new System.Drawing.Point(400, 241);
            this.dateTimeTarih.Name = "dateTimeTarih";
            this.dateTimeTarih.Size = new System.Drawing.Size(288, 20);
            this.dateTimeTarih.TabIndex = 23;
            // 
            // textBoxKod
            // 
            this.textBoxKod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.textBoxKod.Location = new System.Drawing.Point(400, 35);
            this.textBoxKod.Name = "textBoxKod";
            this.textBoxKod.ReadOnly = true;
            this.textBoxKod.Size = new System.Drawing.Size(288, 20);
            this.textBoxKod.TabIndex = 2;
            // 
            // textBoxBarkod
            // 
            this.textBoxBarkod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.textBoxBarkod.Location = new System.Drawing.Point(400, 119);
            this.textBoxBarkod.Name = "textBoxBarkod";
            this.textBoxBarkod.ReadOnly = true;
            this.textBoxBarkod.Size = new System.Drawing.Size(288, 20);
            this.textBoxBarkod.TabIndex = 4;
            // 
            // textBoxBirim
            // 
            this.textBoxBirim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.textBoxBirim.Location = new System.Drawing.Point(400, 157);
            this.textBoxBirim.Name = "textBoxBirim";
            this.textBoxBirim.ReadOnly = true;
            this.textBoxBirim.Size = new System.Drawing.Size(288, 20);
            this.textBoxBirim.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(301, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 14);
            this.label6.TabIndex = 13;
            this.label6.Text = "Grubu";
            // 
            // textBoxGrup
            // 
            this.textBoxGrup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.textBoxGrup.Location = new System.Drawing.Point(400, 201);
            this.textBoxGrup.Name = "textBoxGrup";
            this.textBoxGrup.ReadOnly = true;
            this.textBoxGrup.Size = new System.Drawing.Size(288, 20);
            this.textBoxGrup.TabIndex = 7;
            // 
            // groupBoxResim
            // 
            this.groupBoxResim.Controls.Add(this.pictureBoxResim);
            this.groupBoxResim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.groupBoxResim.Location = new System.Drawing.Point(13, 19);
            this.groupBoxResim.Name = "groupBoxResim";
            this.groupBoxResim.Size = new System.Drawing.Size(263, 310);
            this.groupBoxResim.TabIndex = 24;
            this.groupBoxResim.TabStop = false;
            this.groupBoxResim.Text = "Ürün Resmi";
            // 
            // pictureBoxResim
            // 
            this.pictureBoxResim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxResim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxResim.Location = new System.Drawing.Point(3, 16);
            this.pictureBoxResim.Name = "pictureBoxResim";
            this.pictureBoxResim.Size = new System.Drawing.Size(257, 291);
            this.pictureBoxResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxResim.TabIndex = 20;
            this.pictureBoxResim.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(301, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 14);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tarih";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(296, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kodu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(301, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 14);
            this.label4.TabIndex = 11;
            this.label4.Text = "Birimi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(297, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 14);
            this.label3.TabIndex = 10;
            this.label3.Text = "Barkod Numarası";
            // 
            // siniflarBindingSource
            // 
            this.siniflarBindingSource.DataMember = "Siniflar";
            // 
            // stockControlDataSet1
            // 
            this.stockControlDataSet1.DataSetName = "StockControlDataSet1";
            this.stockControlDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // siniflarBindingSource2
            // 
            this.siniflarBindingSource2.DataMember = "Siniflar";
            this.siniflarBindingSource2.DataSource = this.stockControlDataSet1;
            // 
            // siniflarTableAdapter
            // 
            this.siniflarTableAdapter.ClearBeforeFill = true;
            // 
            // StockMovements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 943);
            this.Controls.Add(this.panelMove);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StockMovements";
            this.Text = "Stok Hareketleri";
            this.Load += new System.EventHandler(this.StockMovements_Load);
            this.panelMove.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMove)).EndInit();
            this.groupBoxMove.ResumeLayout(false);
            this.groupBoxMove.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siniflarBindingSource1)).EndInit();
            this.groupBoxUrun.ResumeLayout(false);
            this.groupBoxUrun.PerformLayout();
            this.groupBoxResim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siniflarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockControlDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siniflarBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMove;
        private System.Windows.Forms.GroupBox groupBoxUrun;
        private System.Windows.Forms.DateTimePicker dateTimeTarih;
        private System.Windows.Forms.TextBox textBoxKod;
        private System.Windows.Forms.TextBox textBoxBarkod;
        private System.Windows.Forms.TextBox textBoxBirim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxGrup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxMove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerGuncel;
        private System.Windows.Forms.TextBox textBoxAdetS;
        private System.Windows.Forms.TextBox textBoxMevcut;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBoxResim;
        private System.Windows.Forms.PictureBox pictureBoxResim;
        private System.Windows.Forms.DataGridView dataGridViewMove;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDuzen;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ComboBox comboBoxSinif;
        private System.Windows.Forms.DataGridView dataGridViewStok;
        private System.Windows.Forms.BindingSource siniflarBindingSource;
        private System.Windows.Forms.TextBox textBoxCins;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextAciklama;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource siniflarBindingSource1;
        private StockControlDataSet1 stockControlDataSet1;
        private System.Windows.Forms.BindingSource siniflarBindingSource2;
        private StockControlDataSet1TableAdapters.SiniflarTableAdapter siniflarTableAdapter;
    }
}