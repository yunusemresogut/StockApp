namespace DuyuTekStokApp
{
    partial class StockCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockCard));
            this.panelStok = new System.Windows.Forms.Panel();
            this.textBoxAra = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.groupBoxResim = new System.Windows.Forms.GroupBox();
            this.pictureBoxResim = new System.Windows.Forms.PictureBox();
            this.btnResim = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDuzen = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.groupBoxUrun = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.maskedTextBoxKrit = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxGrup = new System.Windows.Forms.ComboBox();
            this.gruplarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxBirim = new System.Windows.Forms.ComboBox();
            this.birimlerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimeTarih = new System.Windows.Forms.DateTimePicker();
            this.richTextAciklama = new System.Windows.Forms.RichTextBox();
            this.textBoxKod = new System.Windows.Forms.TextBox();
            this.textBoxCins = new System.Windows.Forms.TextBox();
            this.textBoxBarkod = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewStok = new System.Windows.Forms.DataGridView();
            this.gruplarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.birimlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockCardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockCardBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stockCardBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.stockControlDataSet1 = new DuyuTekStokApp.StockControlDataSet1();
            this.birimlerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.birimlerTableAdapter = new DuyuTekStokApp.StockControlDataSet1TableAdapters.BirimlerTableAdapter();
            this.gruplarBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.gruplarTableAdapter = new DuyuTekStokApp.StockControlDataSet1TableAdapters.GruplarTableAdapter();
            this.birimlerBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.panelStok.SuspendLayout();
            this.groupBoxResim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResim)).BeginInit();
            this.groupBoxUrun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gruplarBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birimlerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruplarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birimlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockCardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockCardBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockCardBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockControlDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birimlerBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruplarBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birimlerBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelStok
            // 
            this.panelStok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panelStok.Controls.Add(this.textBoxAra);
            this.panelStok.Controls.Add(this.btnAra);
            this.panelStok.Controls.Add(this.groupBoxResim);
            this.panelStok.Controls.Add(this.btnClose);
            this.panelStok.Controls.Add(this.btnSil);
            this.panelStok.Controls.Add(this.btnDuzen);
            this.panelStok.Controls.Add(this.btnEkle);
            this.panelStok.Controls.Add(this.groupBoxUrun);
            this.panelStok.Controls.Add(this.dataGridViewStok);
            this.panelStok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStok.Location = new System.Drawing.Point(0, 0);
            this.panelStok.Name = "panelStok";
            this.panelStok.Size = new System.Drawing.Size(1108, 761);
            this.panelStok.TabIndex = 3;
            this.panelStok.Paint += new System.Windows.Forms.PaintEventHandler(this.panelStok_Paint);
            // 
            // textBoxAra
            // 
            this.textBoxAra.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxAra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.textBoxAra.Location = new System.Drawing.Point(946, 382);
            this.textBoxAra.Name = "textBoxAra";
            this.textBoxAra.Size = new System.Drawing.Size(154, 20);
            this.textBoxAra.TabIndex = 25;
            // 
            // btnAra
            // 
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnAra.Location = new System.Drawing.Point(965, 417);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(114, 40);
            this.btnAra.TabIndex = 24;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // groupBoxResim
            // 
            this.groupBoxResim.Controls.Add(this.pictureBoxResim);
            this.groupBoxResim.Controls.Add(this.btnResim);
            this.groupBoxResim.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxResim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.groupBoxResim.Location = new System.Drawing.Point(519, 12);
            this.groupBoxResim.Name = "groupBoxResim";
            this.groupBoxResim.Size = new System.Drawing.Size(421, 445);
            this.groupBoxResim.TabIndex = 23;
            this.groupBoxResim.TabStop = false;
            this.groupBoxResim.Text = "Ürün Resmi";
            // 
            // pictureBoxResim
            // 
            this.pictureBoxResim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxResim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxResim.Location = new System.Drawing.Point(35, 19);
            this.pictureBoxResim.Name = "pictureBoxResim";
            this.pictureBoxResim.Size = new System.Drawing.Size(348, 257);
            this.pictureBoxResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxResim.TabIndex = 20;
            this.pictureBoxResim.TabStop = false;
            // 
            // btnResim
            // 
            this.btnResim.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnResim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResim.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnResim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnResim.Location = new System.Drawing.Point(153, 341);
            this.btnResim.Name = "btnResim";
            this.btnResim.Size = new System.Drawing.Size(100, 40);
            this.btnResim.TabIndex = 9;
            this.btnResim.Text = "Resim Ekle";
            this.btnResim.UseVisualStyleBackColor = true;
            this.btnResim.Click += new System.EventHandler(this.btnResim_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(1066, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // btnSil
            // 
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnSil.Location = new System.Drawing.Point(982, 282);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(114, 40);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "Stok Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDuzen
            // 
            this.btnDuzen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuzen.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDuzen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnDuzen.Location = new System.Drawing.Point(982, 202);
            this.btnDuzen.Name = "btnDuzen";
            this.btnDuzen.Size = new System.Drawing.Size(114, 40);
            this.btnDuzen.TabIndex = 11;
            this.btnDuzen.Text = "Stok Düzenle";
            this.btnDuzen.UseVisualStyleBackColor = true;
            this.btnDuzen.Click += new System.EventHandler(this.btnDuzen_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnEkle.Location = new System.Drawing.Point(982, 122);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(114, 40);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Stok Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // groupBoxUrun
            // 
            this.groupBoxUrun.Controls.Add(this.label11);
            this.groupBoxUrun.Controls.Add(this.maskedTextBoxKrit);
            this.groupBoxUrun.Controls.Add(this.label10);
            this.groupBoxUrun.Controls.Add(this.label8);
            this.groupBoxUrun.Controls.Add(this.label9);
            this.groupBoxUrun.Controls.Add(this.comboBoxGrup);
            this.groupBoxUrun.Controls.Add(this.comboBoxBirim);
            this.groupBoxUrun.Controls.Add(this.dateTimeTarih);
            this.groupBoxUrun.Controls.Add(this.richTextAciklama);
            this.groupBoxUrun.Controls.Add(this.textBoxKod);
            this.groupBoxUrun.Controls.Add(this.textBoxCins);
            this.groupBoxUrun.Controls.Add(this.textBoxBarkod);
            this.groupBoxUrun.Controls.Add(this.label7);
            this.groupBoxUrun.Controls.Add(this.label6);
            this.groupBoxUrun.Controls.Add(this.label5);
            this.groupBoxUrun.Controls.Add(this.label1);
            this.groupBoxUrun.Controls.Add(this.label4);
            this.groupBoxUrun.Controls.Add(this.label2);
            this.groupBoxUrun.Controls.Add(this.label3);
            this.groupBoxUrun.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxUrun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.groupBoxUrun.Location = new System.Drawing.Point(12, 12);
            this.groupBoxUrun.Name = "groupBoxUrun";
            this.groupBoxUrun.Size = new System.Drawing.Size(464, 445);
            this.groupBoxUrun.TabIndex = 18;
            this.groupBoxUrun.TabStop = false;
            this.groupBoxUrun.Text = "Ürün Bilgileri";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(422, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 19);
            this.label11.TabIndex = 26;
            this.label11.Text = "*";
            // 
            // maskedTextBoxKrit
            // 
            this.maskedTextBoxKrit.BeepOnError = true;
            this.maskedTextBoxKrit.Location = new System.Drawing.Point(129, 230);
            this.maskedTextBoxKrit.Mask = "000";
            this.maskedTextBoxKrit.Name = "maskedTextBoxKrit";
            this.maskedTextBoxKrit.Size = new System.Drawing.Size(58, 22);
            this.maskedTextBoxKrit.TabIndex = 28;
            this.maskedTextBoxKrit.ValidatingType = typeof(int);
            this.maskedTextBoxKrit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBoxKrit_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(423, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 19);
            this.label10.TabIndex = 25;
            this.label10.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(25, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 14);
            this.label8.TabIndex = 27;
            this.label8.Text = "Kritik Miktar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(423, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 19);
            this.label9.TabIndex = 24;
            this.label9.Text = "*";
            // 
            // comboBoxGrup
            // 
            this.comboBoxGrup.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.gruplarBindingSource2, "GrupAdi", true));
            this.comboBoxGrup.DataSource = this.gruplarBindingSource2;
            this.comboBoxGrup.DisplayMember = "GrupAdi";
            this.comboBoxGrup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGrup.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxGrup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.comboBoxGrup.FormattingEnabled = true;
            this.comboBoxGrup.Location = new System.Drawing.Point(129, 190);
            this.comboBoxGrup.Name = "comboBoxGrup";
            this.comboBoxGrup.Size = new System.Drawing.Size(288, 22);
            this.comboBoxGrup.TabIndex = 5;
            this.comboBoxGrup.ValueMember = "GrupID";
            this.comboBoxGrup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxGrup_KeyDown);
            // 
            // gruplarBindingSource1
            // 
            this.gruplarBindingSource1.DataMember = "Gruplar";
            // 
            // comboBoxBirim
            // 
            this.comboBoxBirim.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.birimlerBindingSource3, "BirimAdi", true));
            this.comboBoxBirim.DataSource = this.birimlerBindingSource3;
            this.comboBoxBirim.DisplayMember = "BirimAdi";
            this.comboBoxBirim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBirim.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxBirim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.comboBoxBirim.FormattingEnabled = true;
            this.comboBoxBirim.Location = new System.Drawing.Point(129, 150);
            this.comboBoxBirim.Name = "comboBoxBirim";
            this.comboBoxBirim.Size = new System.Drawing.Size(288, 22);
            this.comboBoxBirim.TabIndex = 4;
            this.comboBoxBirim.ValueMember = "BirimID";
            this.comboBoxBirim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxBirim_KeyDown);
            // 
            // birimlerBindingSource1
            // 
            this.birimlerBindingSource1.DataMember = "Birimler";
            // 
            // dateTimeTarih
            // 
            this.dateTimeTarih.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dateTimeTarih.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dateTimeTarih.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimeTarih.Location = new System.Drawing.Point(129, 270);
            this.dateTimeTarih.Name = "dateTimeTarih";
            this.dateTimeTarih.Size = new System.Drawing.Size(288, 20);
            this.dateTimeTarih.TabIndex = 7;
            this.dateTimeTarih.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimeTarih_KeyDown);
            // 
            // richTextAciklama
            // 
            this.richTextAciklama.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextAciklama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.richTextAciklama.Location = new System.Drawing.Point(129, 307);
            this.richTextAciklama.Name = "richTextAciklama";
            this.richTextAciklama.Size = new System.Drawing.Size(288, 120);
            this.richTextAciklama.TabIndex = 8;
            this.richTextAciklama.Text = "";
            // 
            // textBoxKod
            // 
            this.textBoxKod.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxKod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.textBoxKod.Location = new System.Drawing.Point(129, 30);
            this.textBoxKod.Name = "textBoxKod";
            this.textBoxKod.Size = new System.Drawing.Size(288, 20);
            this.textBoxKod.TabIndex = 1;
            this.textBoxKod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxKod_KeyDown);
            // 
            // textBoxCins
            // 
            this.textBoxCins.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxCins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.textBoxCins.Location = new System.Drawing.Point(129, 70);
            this.textBoxCins.Name = "textBoxCins";
            this.textBoxCins.Size = new System.Drawing.Size(288, 20);
            this.textBoxCins.TabIndex = 2;
            this.textBoxCins.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCins_KeyDown);
            // 
            // textBoxBarkod
            // 
            this.textBoxBarkod.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxBarkod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.textBoxBarkod.Location = new System.Drawing.Point(129, 110);
            this.textBoxBarkod.Name = "textBoxBarkod";
            this.textBoxBarkod.Size = new System.Drawing.Size(288, 20);
            this.textBoxBarkod.TabIndex = 3;
            this.textBoxBarkod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxBarkod_KeyDown);
            this.textBoxBarkod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBarkod_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(25, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 14);
            this.label7.TabIndex = 14;
            this.label7.Text = "Açıklama";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(25, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 14);
            this.label6.TabIndex = 13;
            this.label6.Text = "Grubu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(25, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 14);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tarih";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kodu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(25, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 14);
            this.label4.TabIndex = 11;
            this.label4.Text = "Birimi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(25, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cinsi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(25, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 14);
            this.label3.TabIndex = 10;
            this.label3.Text = "Barkod Numarası";
            // 
            // dataGridViewStok
            // 
            this.dataGridViewStok.AllowUserToAddRows = false;
            this.dataGridViewStok.AllowUserToDeleteRows = false;
            this.dataGridViewStok.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
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
            this.dataGridViewStok.Location = new System.Drawing.Point(12, 463);
            this.dataGridViewStok.Name = "dataGridViewStok";
            this.dataGridViewStok.ReadOnly = true;
            this.dataGridViewStok.RowTemplate.Height = 60;
            this.dataGridViewStok.Size = new System.Drawing.Size(1084, 286);
            this.dataGridViewStok.TabIndex = 0;
            this.dataGridViewStok.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStok_CellClick);
            // 
            // gruplarBindingSource
            // 
            this.gruplarBindingSource.DataMember = "Gruplar";
            // 
            // birimlerBindingSource
            // 
            this.birimlerBindingSource.DataMember = "Birimler";
            // 
            // stockCardBindingSource
            // 
            this.stockCardBindingSource.DataMember = "StockCard";
            // 
            // stockCardBindingSource1
            // 
            this.stockCardBindingSource1.DataMember = "StockCard";
            // 
            // stockCardBindingSource2
            // 
            this.stockCardBindingSource2.DataMember = "StockCard";
            // 
            // stockControlDataSet1
            // 
            this.stockControlDataSet1.DataSetName = "StockControlDataSet1";
            this.stockControlDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // birimlerBindingSource2
            // 
            this.birimlerBindingSource2.DataMember = "Birimler";
            this.birimlerBindingSource2.DataSource = this.stockControlDataSet1;
            // 
            // birimlerTableAdapter
            // 
            this.birimlerTableAdapter.ClearBeforeFill = true;
            // 
            // gruplarBindingSource2
            // 
            this.gruplarBindingSource2.DataMember = "Gruplar";
            this.gruplarBindingSource2.DataSource = this.stockControlDataSet1;
            // 
            // gruplarTableAdapter
            // 
            this.gruplarTableAdapter.ClearBeforeFill = true;
            // 
            // birimlerBindingSource3
            // 
            this.birimlerBindingSource3.DataMember = "Birimler";
            this.birimlerBindingSource3.DataSource = this.stockControlDataSet1;
            // 
            // StockCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 761);
            this.Controls.Add(this.panelStok);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StockCard";
            this.Text = "Stok İşlemleri";
            this.Load += new System.EventHandler(this.StockCard_Load);
            this.panelStok.ResumeLayout(false);
            this.panelStok.PerformLayout();
            this.groupBoxResim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResim)).EndInit();
            this.groupBoxUrun.ResumeLayout(false);
            this.groupBoxUrun.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gruplarBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birimlerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruplarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birimlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockCardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockCardBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockCardBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockControlDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birimlerBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruplarBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birimlerBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelStok;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDuzen;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.GroupBox groupBoxUrun;
        private System.Windows.Forms.TextBox textBoxKod;
        private System.Windows.Forms.TextBox textBoxCins;
        private System.Windows.Forms.TextBox textBoxBarkod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewStok;
        private System.Windows.Forms.Button btnResim;
        private System.Windows.Forms.PictureBox pictureBoxResim;
        private System.Windows.Forms.DateTimePicker dateTimeTarih;
        private System.Windows.Forms.RichTextBox richTextAciklama;
        private System.Windows.Forms.BindingSource stockCardBindingSource;
        private System.Windows.Forms.BindingSource stockCardBindingSource1;
        private System.Windows.Forms.BindingSource stockCardBindingSource2;
        private System.Windows.Forms.GroupBox groupBoxResim;
        private System.Windows.Forms.ComboBox comboBoxGrup;
        private System.Windows.Forms.ComboBox comboBoxBirim;
        private System.Windows.Forms.BindingSource birimlerBindingSource;
        private System.Windows.Forms.BindingSource gruplarBindingSource;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxKrit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxAra;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.BindingSource birimlerBindingSource1;
        private System.Windows.Forms.BindingSource gruplarBindingSource1;
        private StockControlDataSet1 stockControlDataSet1;
        private System.Windows.Forms.BindingSource birimlerBindingSource2;
        private StockControlDataSet1TableAdapters.BirimlerTableAdapter birimlerTableAdapter;
        private System.Windows.Forms.BindingSource gruplarBindingSource2;
        private StockControlDataSet1TableAdapters.GruplarTableAdapter gruplarTableAdapter;
        private System.Windows.Forms.BindingSource birimlerBindingSource3;
    }
}