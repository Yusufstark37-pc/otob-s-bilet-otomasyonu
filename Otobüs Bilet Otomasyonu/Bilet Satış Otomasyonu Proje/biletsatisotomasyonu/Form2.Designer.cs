namespace biletsatisotomasyonu
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel1 = new Panel();
            koltuklbl = new Label();
            label8 = new Label();
            tarihlbl = new Label();
            firmalbl = new Label();
            fiyatlbl = new Label();
            soyadlbl = new Label();
            label7 = new Label();
            adlbl = new Label();
            pictureBox5 = new PictureBox();
            pdfcikar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(koltuklbl);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(tarihlbl);
            panel1.Controls.Add(firmalbl);
            panel1.Controls.Add(fiyatlbl);
            panel1.Controls.Add(soyadlbl);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(adlbl);
            panel1.Controls.Add(pictureBox5);
            panel1.Location = new Point(92, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(420, 212);
            panel1.TabIndex = 32;
            // 
            // koltuklbl
            // 
            koltuklbl.AutoSize = true;
            koltuklbl.BackColor = Color.White;
            koltuklbl.Location = new Point(90, 138);
            koltuklbl.Name = "koltuklbl";
            koltuklbl.Size = new Size(57, 15);
            koltuklbl.TabIndex = 30;
            koltuklbl.Text = "koltukno";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Black;
            label8.ForeColor = Color.White;
            label8.Location = new Point(223, 164);
            label8.Name = "label8";
            label8.Size = new Size(46, 15);
            label8.TabIndex = 26;
            label8.Text = "nereye";
            // 
            // tarihlbl
            // 
            tarihlbl.AutoSize = true;
            tarihlbl.BackColor = Color.White;
            tarihlbl.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            tarihlbl.Location = new Point(90, 163);
            tarihlbl.Name = "tarihlbl";
            tarihlbl.Size = new Size(31, 13);
            tarihlbl.TabIndex = 22;
            tarihlbl.Text = "tarih";
            // 
            // firmalbl
            // 
            firmalbl.AutoSize = true;
            firmalbl.BackColor = Color.White;
            firmalbl.Location = new Point(90, 113);
            firmalbl.Name = "firmalbl";
            firmalbl.Size = new Size(37, 15);
            firmalbl.TabIndex = 29;
            firmalbl.Text = "firma";
            // 
            // fiyatlbl
            // 
            fiyatlbl.AutoSize = true;
            fiyatlbl.BackColor = Color.White;
            fiyatlbl.Location = new Point(90, 187);
            fiyatlbl.Name = "fiyatlbl";
            fiyatlbl.Size = new Size(32, 15);
            fiyatlbl.TabIndex = 24;
            fiyatlbl.Text = "fiyat";
            // 
            // soyadlbl
            // 
            soyadlbl.AutoSize = true;
            soyadlbl.BackColor = Color.White;
            soyadlbl.Location = new Point(90, 88);
            soyadlbl.Name = "soyadlbl";
            soyadlbl.Size = new Size(38, 15);
            soyadlbl.TabIndex = 28;
            soyadlbl.Text = "soyad";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Black;
            label7.ForeColor = Color.White;
            label7.Location = new Point(218, 78);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 25;
            label7.Text = "nereden";
            // 
            // adlbl
            // 
            adlbl.AutoSize = true;
            adlbl.BackColor = Color.White;
            adlbl.Location = new Point(90, 66);
            adlbl.Name = "adlbl";
            adlbl.Size = new Size(20, 15);
            adlbl.TabIndex = 20;
            adlbl.Text = "ad";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(0, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(423, 211);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 19;
            pictureBox5.TabStop = false;
            // 
            // pdfcikar
            // 
            pdfcikar.BackColor = Color.LightSkyBlue;
            pdfcikar.Location = new Point(237, 295);
            pdfcikar.Name = "pdfcikar";
            pdfcikar.Size = new Size(100, 70);
            pdfcikar.TabIndex = 33;
            pdfcikar.Text = "BİLET İNDİR";
            pdfcikar.UseVisualStyleBackColor = false;
            pdfcikar.Click += pdfcikar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(600, 409);
            Controls.Add(pdfcikar);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "E-Bilet Al";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Panel panel1;
        public Label koltuklbl;
        public Label label8;
        public Label tarihlbl;
        public Label firmalbl;
        public Label fiyatlbl;
        public Label soyadlbl;
        public Label label7;
        public Label adlbl;
        public PictureBox pictureBox5;
        public Button pdfcikar;
    }
}