namespace biletsatisotomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            cmbfirma = new ComboBox();
            label3 = new Label();
            cmbnereye = new ComboBox();
            label4 = new Label();
            dtb = new DateTimePicker();
            label5 = new Label();
            num = new NumericUpDown();
            kaydetbtn = new Button();
            cmbNereden = new ComboBox();
            groupBox1 = new GroupBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            rezerveEtToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            yazdir = new Button();
            pictureBox5 = new PictureBox();
            txtid = new TextBox();
            lblsefer = new Label();
            lbl1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            lbl4 = new Label();
            label7 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num).BeginInit();
            groupBox1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.Azure;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.SkyBlue;
            dataGridView1.Location = new Point(440, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(790, 435);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellEnter += dataGridView1_CellEnter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(283, 107);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 1;
            label1.Text = "Firma Seçiniz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 31);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "Nereden";
            // 
            // cmbfirma
            // 
            cmbfirma.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbfirma.FormattingEnabled = true;
            cmbfirma.Items.AddRange(new object[] { "Kamil Koç", "Metro Turizm", "Sinop Birlik", "Lüks Artvin" });
            cmbfirma.Location = new Point(283, 125);
            cmbfirma.Name = "cmbfirma";
            cmbfirma.Size = new Size(121, 23);
            cmbfirma.TabIndex = 3;
            cmbfirma.SelectedIndexChanged += cmbfirma_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 90);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 5;
            label3.Text = "Nereye";
            // 
            // cmbnereye
            // 
            cmbnereye.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbnereye.FormattingEnabled = true;
            cmbnereye.Items.AddRange(new object[] { " Adana", " Adıyaman", " Afyonkarahisar", " Ağrı", " Aksaray", " Amasya", " Ankara", " Antalya", " Ardahan", " Artvin", " Aydın", " Balıkesir", " Bartın", " Batman", " Bayburt", " Bilecik", " Bingöl", " Bitlis", " Bolu", " Burdur", " Bursa", " Çanakkale", " Çankırı", " Çorum", " Denizli", " Diyarbakır", " Düzce", " Edirne", " Elazığ", " Erzincan", " Erzurum", " Eskişehir", " Gaziantep", " Giresun", " Gümüşhane", " Hakkâri", " Hatay", " Iğdır", " Isparta", " İstanbul", " İzmir", " Kahramanmaraş", " Karabük", " Karaman", " Kars", " Kastamonu", " Kayseri", " Kilis", " Kırıkkale", " Kırklareli", " Kırşehir", " Kocaeli", " Konya", " Kütahya", " Malatya", " Manisa", " Mardin", " Mersin", " Muğla", " Muş", " Nevşehir", " Niğde", " Ordu", " Osmaniye", " Rize", " Sakarya", " Samsun", " Şanlıurfa", " Siirt", " Sinop", " Sivas", " Şırnak", " Tekirdağ", " Tokat", " Trabzon", " Tunceli", " Uşak", " Van", " Yalova", " Yozgat", " Zonguldak" });
            cmbnereye.Location = new Point(6, 108);
            cmbnereye.Name = "cmbnereye";
            cmbnereye.Size = new Size(121, 23);
            cmbnereye.TabIndex = 6;
            cmbnereye.SelectedIndexChanged += cmbnereye_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(286, 297);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 7;
            label4.Text = "Tarih";
            // 
            // dtb
            // 
            dtb.CustomFormat = "yyyy-MM-dd HH:mm";
            dtb.Format = DateTimePickerFormat.Custom;
            dtb.Location = new Point(286, 315);
            dtb.Name = "dtb";
            dtb.ShowUpDown = true;
            dtb.Size = new Size(121, 23);
            dtb.TabIndex = 8;
            dtb.ValueChanged += dtb_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(286, 359);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 9;
            label5.Text = "Fiyat";
            // 
            // num
            // 
            num.Location = new Point(287, 385);
            num.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            num.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            num.Name = "num";
            num.Size = new Size(120, 23);
            num.TabIndex = 10;
            num.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // kaydetbtn
            // 
            kaydetbtn.BackColor = Color.LightSkyBlue;
            kaydetbtn.Location = new Point(295, 434);
            kaydetbtn.Name = "kaydetbtn";
            kaydetbtn.Size = new Size(100, 56);
            kaydetbtn.TabIndex = 11;
            kaydetbtn.Text = "BİLET EKLE";
            kaydetbtn.UseVisualStyleBackColor = false;
            kaydetbtn.Click += kaydetbtn_Click;
            // 
            // cmbNereden
            // 
            cmbNereden.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNereden.FormattingEnabled = true;
            cmbNereden.Items.AddRange(new object[] { " Adana", " Adıyaman", " Afyonkarahisar", " Ağrı", " Aksaray", " Amasya", " Ankara", " Antalya", " Ardahan", " Artvin", " Aydın", " Balıkesir", " Bartın", " Batman", " Bayburt", " Bilecik", " Bingöl", " Bitlis", " Bolu", " Burdur", " Bursa", " Çanakkale", " Çankırı", " Çorum", " Denizli", " Diyarbakır", " Düzce", " Edirne", " Elazığ", " Erzincan", " Erzurum", " Eskişehir", " Gaziantep", " Giresun", " Gümüşhane", " Hakkâri", " Hatay", " Iğdır", " Isparta", " İstanbul", " İzmir", " Kahramanmaraş", " Karabük", " Karaman", " Kars", " Kastamonu", " Kayseri", " Kilis", " Kırıkkale", " Kırklareli", " Kırşehir", " Kocaeli", " Konya", " Kütahya", " Malatya", " Manisa", " Mardin", " Mersin", " Muğla", " Muş", " Nevşehir", " Niğde", " Ordu", " Osmaniye", " Rize", " Sakarya", " Samsun", " Şanlıurfa", " Siirt", " Sinop", " Sivas", " Şırnak", " Tekirdağ", " Tokat", " Trabzon", " Tunceli", " Uşak", " Van", " Yalova", " Yozgat", " Zonguldak" });
            cmbNereden.Location = new Point(6, 49);
            cmbNereden.Name = "cmbNereden";
            cmbNereden.Size = new Size(121, 23);
            cmbNereden.TabIndex = 12;
            cmbNereden.SelectedIndexChanged += cmbNereden_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmbNereden);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cmbnereye);
            groupBox1.Location = new Point(277, 154);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(142, 137);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "İSTİKAMET";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { rezerveEtToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(130, 26);
            // 
            // rezerveEtToolStripMenuItem
            // 
            rezerveEtToolStripMenuItem.Name = "rezerveEtToolStripMenuItem";
            rezerveEtToolStripMenuItem.Size = new Size(129, 22);
            rezerveEtToolStripMenuItem.Text = "Koltuk Seç";
            rezerveEtToolStripMenuItem.Click += rezerveEtToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 642);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(440, 12);
            label6.Name = "label6";
            label6.Size = new Size(235, 40);
            label6.TabIndex = 15;
            label6.Text = "SEFER BİLGİLERİ";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(8, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(247, 547);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(8, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(247, 456);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            pictureBox3.Visible = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(8, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(247, 642);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 18;
            pictureBox4.TabStop = false;
            // 
            // yazdir
            // 
            yazdir.BackColor = Color.LightSkyBlue;
            yazdir.Location = new Point(598, 515);
            yazdir.Name = "yazdir";
            yazdir.Size = new Size(426, 70);
            yazdir.TabIndex = 27;
            yazdir.Text = "BİLET OLUŞTUR";
            yazdir.UseVisualStyleBackColor = false;
            yazdir.Click += yazdir_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(8, 12);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(247, 642);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 28;
            pictureBox5.TabStop = false;
            // 
            // txtid
            // 
            txtid.BackColor = SystemColors.ActiveBorder;
            txtid.Location = new Point(283, 64);
            txtid.Name = "txtid";
            txtid.ReadOnly = true;
            txtid.Size = new Size(124, 23);
            txtid.TabIndex = 31;
            // 
            // lblsefer
            // 
            lblsefer.AutoSize = true;
            lblsefer.Location = new Point(283, 46);
            lblsefer.Name = "lblsefer";
            lblsefer.Size = new Size(54, 15);
            lblsefer.TabIndex = 32;
            lblsefer.Text = "Sefer ID";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BackColor = Color.White;
            lbl1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbl1.Location = new Point(108, 35);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(69, 17);
            lbl1.TabIndex = 33;
            lbl1.Text = "Kamil Koç";
            lbl1.Visible = false;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.BackColor = Color.White;
            lbl2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbl2.Location = new Point(108, 35);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(91, 17);
            lbl2.TabIndex = 34;
            lbl2.Text = "Metro Turizm";
            lbl2.Visible = false;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.BackColor = Color.White;
            lbl3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbl3.Location = new Point(108, 35);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(79, 17);
            lbl3.TabIndex = 35;
            lbl3.Text = "Sinop Birlik";
            lbl3.Visible = false;
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.BackColor = Color.White;
            lbl4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbl4.Location = new Point(108, 35);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(78, 17);
            lbl4.TabIndex = 36;
            lbl4.Text = "Lüks Artvin";
            lbl4.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(108, 35);
            label7.Name = "label7";
            label7.Size = new Size(95, 21);
            label7.TabIndex = 37;
            label7.Text = "Lüks Artvin";
            label7.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSkyBlue;
            button1.Location = new Point(295, 515);
            button1.Name = "button1";
            button1.Size = new Size(100, 56);
            button1.TabIndex = 38;
            button1.Text = "BİLET SİL";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1242, 677);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(lbl4);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(lblsefer);
            Controls.Add(txtid);
            Controls.Add(pictureBox5);
            Controls.Add(yazdir);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(kaydetbtn);
            Controls.Add(num);
            Controls.Add(label5);
            Controls.Add(dtb);
            Controls.Add(label4);
            Controls.Add(cmbfirma);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "Form1";
            Text = "Otobüs Bilet Satış Otomasyonu";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)num).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private ToolStripMenuItem rezerveEtToolStripMenuItem;
        public DataGridView dataGridView1;
        public Button kaydetbtn;
        public ComboBox cmbfirma;
        public ComboBox cmbnereye;
        public DateTimePicker dtb;
        public NumericUpDown num;
        public ComboBox cmbNereden;
        private PictureBox pictureBox1;
        private Label label6;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        public ContextMenuStrip contextMenuStrip1;
        private PictureBox pictureBox4;
        public Button yazdir;
        private PictureBox pictureBox5;
        public TextBox txtid;
        private Label lblsefer;
        internal Label lbl1;
        internal Label lbl2;
        internal Label lbl3;
        internal Label lbl4;
        internal Label label7;
        public Button button1;
    }
}
