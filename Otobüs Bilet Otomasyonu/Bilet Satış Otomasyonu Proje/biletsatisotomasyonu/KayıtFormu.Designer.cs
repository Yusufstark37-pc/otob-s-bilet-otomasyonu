namespace biletsatisotomasyonu
{
    partial class KayıtFormu
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
            label1 = new Label();
            txtad = new TextBox();
            label3 = new Label();
            txttel = new MaskedTextBox();
            rdrbay = new RadioButton();
            rdrbayan = new RadioButton();
            btntm = new Button();
            btniptal = new Button();
            txtsoyad = new TextBox();
            label2 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 97);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // txtad
            // 
            txtad.Location = new Point(146, 94);
            txtad.Name = "txtad";
            txtad.Size = new Size(100, 23);
            txtad.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 217);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 3;
            label3.Text = "Telefon";
            // 
            // txttel
            // 
            txttel.Location = new Point(146, 209);
            txttel.Mask = "(999) 000-0000";
            txttel.Name = "txttel";
            txttel.Size = new Size(100, 23);
            txttel.TabIndex = 5;
            // 
            // rdrbay
            // 
            rdrbay.AutoSize = true;
            rdrbay.Checked = true;
            rdrbay.Location = new Point(121, 266);
            rdrbay.Name = "rdrbay";
            rdrbay.Size = new Size(45, 19);
            rdrbay.TabIndex = 6;
            rdrbay.TabStop = true;
            rdrbay.Text = "Bay";
            rdrbay.UseVisualStyleBackColor = true;
            // 
            // rdrbayan
            // 
            rdrbayan.AutoSize = true;
            rdrbayan.Location = new Point(201, 266);
            rdrbayan.Name = "rdrbayan";
            rdrbayan.Size = new Size(58, 19);
            rdrbayan.TabIndex = 7;
            rdrbayan.Text = "Bayan";
            rdrbayan.UseVisualStyleBackColor = true;
            // 
            // btntm
            // 
            btntm.BackColor = Color.LightSkyBlue;
            btntm.Location = new Point(102, 306);
            btntm.Name = "btntm";
            btntm.Size = new Size(75, 43);
            btntm.TabIndex = 8;
            btntm.Text = "TAMAM";
            btntm.UseVisualStyleBackColor = false;
            btntm.Click += btntm_Click;
            // 
            // btniptal
            // 
            btniptal.BackColor = Color.LightSkyBlue;
            btniptal.Location = new Point(201, 306);
            btniptal.Name = "btniptal";
            btniptal.Size = new Size(75, 43);
            btniptal.TabIndex = 9;
            btniptal.Text = "İPTAL";
            btniptal.UseVisualStyleBackColor = false;
            btniptal.Click += btniptal_Click;
            // 
            // txtsoyad
            // 
            txtsoyad.Location = new Point(146, 148);
            txtsoyad.Name = "txtsoyad";
            txtsoyad.Size = new Size(100, 23);
            txtsoyad.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 156);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 13;
            label2.Text = "Soyad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(74, 21);
            label5.Name = "label5";
            label5.Size = new Size(233, 32);
            label5.TabIndex = 14;
            label5.Text = "MÜŞTERİ BİLGİLERİ";
            // 
            // KayıtFormu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(399, 487);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(txtsoyad);
            Controls.Add(btniptal);
            Controls.Add(btntm);
            Controls.Add(rdrbayan);
            Controls.Add(rdrbay);
            Controls.Add(txttel);
            Controls.Add(label3);
            Controls.Add(txtad);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "KayıtFormu";
            StartPosition = FormStartPosition.CenterParent;
            Text = "KayıtFormu";
            Load += KayıtFormu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        public TextBox txtad;
        public MaskedTextBox txttel;
        public RadioButton rdrbay;
        public RadioButton rdrbayan;
        public Button btntm;
        public Button btniptal;
        public TextBox txtsoyad;
        private Label label2;
        private Label label5;
    }
}