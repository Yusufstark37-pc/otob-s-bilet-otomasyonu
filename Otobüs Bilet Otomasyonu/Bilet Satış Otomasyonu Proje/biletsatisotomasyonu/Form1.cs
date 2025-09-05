using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;

using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace biletsatisotomasyonu
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=biletsatisotomasyonu;Uid=root;Pwd=mysqlroot37;");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;

        public Button tiklanan;
        public string musteriAdi, musteriSoyad, telefon, cinsiyet, firmaAdi, seferBaslangic, seferBitis, koltukNo, tarih;
        public decimal fiyat;

        public Form1()
        {
            InitializeComponent();
        }

        public void verigetir()
        {
            dt = new DataTable();
            conn.Open();
            adapter = new MySqlDataAdapter("select * from seferbilgileri", conn);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            verigetir();
            FiyatGuncelle();
        }

        private Dictionary<int, string> GetDoluKoltuklar(string firmaAdi, string seferBaslangic, string seferBitis, DateTime tarih)
        {
            Dictionary<int, string> doluKoltuklar = new Dictionary<int, string>();

            string query = "SELECT KoltukNo, Cinsiyet FROM seferbilgileri WHERE FirmaAdi=@firma AND SeferBaslangic=@baslangic AND SeferBitis=@bitis AND Tarih=@tarih";
            cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@firma", firmaAdi);
            cmd.Parameters.AddWithValue("@baslangic", seferBaslangic);
            cmd.Parameters.AddWithValue("@bitis", seferBitis);
            cmd.Parameters.AddWithValue("@tarih", tarih);

            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int koltukNo = Convert.ToInt32(dr["KoltukNo"]);
                string cinsiyet = dr["Cinsiyet"].ToString();

                if (!doluKoltuklar.ContainsKey(koltukNo))
                    doluKoltuklar.Add(koltukNo, cinsiyet);
            }
            conn.Close();

            return doluKoltuklar;
        }

        private void FiyatGuncelle()
        {
            if (cmbNereden.SelectedIndex != -1 && cmbnereye.SelectedIndex != -1)
            {
                string rota = cmbNereden.Text + " -> " + cmbnereye.Text;
                Random rnd = new Random();

                switch (rota)
                {
                    case "Ýstanbul -> Ankara":
                        fiyat = rnd.Next(200, 301);
                        break;
                    case "Ýstanbul -> Ýzmir":
                        fiyat = rnd.Next(300, 401);
                        break;
                    case "Ankara -> Ýzmir":
                        fiyat = rnd.Next(250, 351);
                        break;
                    default:
                        fiyat = rnd.Next(200, 900);
                        break;
                }

                num.Value = fiyat;
            }
        }
        private void cmbfirma_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl1.Visible = false;
            lbl2.Visible = false;
            lbl3.Visible = false;
            lbl4.Visible = false;
            pictureBox5.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            DateTime tarih = dtb.Value;
            Dictionary<int, string> doluKoltuklar = GetDoluKoltuklar(cmbfirma.Text, cmbNereden.Text, cmbnereye.Text, tarih);


            switch (cmbfirma.Text)
            {
                case "Kamil Koç":
                    pictureBox5.Visible = false;
                    pictureBox1.Visible = true;
                    lbl1.Visible = true;
                    koltukdoldur(pictureBox1, 12, true, doluKoltuklar);
                    break;

                case "Metro Turizm":
                    pictureBox5.Visible = false;
                    pictureBox2.Visible = true;
                    lbl2.Visible = true;
                    koltukdoldur(pictureBox2, 10, true, doluKoltuklar);
                    break;

                case "Sinop Birlik":
                    pictureBox5.Visible = false;
                    pictureBox3.Visible = true;
                    lbl3.Visible = true;
                    koltukdoldur(pictureBox3, 8, true, doluKoltuklar);
                    break;
                case "Lüks Artvin":
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = true;
                    lbl4.Visible = true;
                    koltukdoldur(pictureBox4, 12, true, doluKoltuklar);
                    break;

            }
        }

        void koltukdoldur(PictureBox hedefpicturebox, int sira, bool arkabeslimi, Dictionary<int, string> doluKoltuklar)
        {

            hedefpicturebox.Controls.Clear();

            int koltukNo = 1;
            for (int i = 0; i < sira; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (arkabeslimi && i != sira - 1 && j == 2) continue;
                    if (!arkabeslimi && j == 2) continue;

                    Button koltuk = new Button();
                    koltuk.Size = new Size(40, 40);
                    koltuk.Location = new Point(12 + (j * 45), 90 + (i * 45));
                    koltuk.Text = koltukNo.ToString();


                    if (doluKoltuklar.TryGetValue(koltukNo, out string cinsiyet))
                    {
                        koltuk.BackColor = cinsiyet == "BAY" ? Color.Blue : Color.Pink;
                        koltuk.Enabled = false;
                    }
                    else
                    {
                        koltuk.BackColor = Color.LightSkyBlue;
                    }

                    koltuk.ForeColor = Color.White;
                    koltuk.ContextMenuStrip = contextMenuStrip1;
                    koltuk.MouseDown += Koltuk_MouseDown;

                    hedefpicturebox.Controls.Add(koltuk);
                    koltuk.BringToFront();
                    koltukNo++;
                }
            }
        }

        private void Koltuk_MouseDown(object sender, MouseEventArgs e)
        {
            tiklanan = sender as Button;
            if (tiklanan.BackColor == Color.Blue || tiklanan.BackColor == Color.Pink)
            {
                MessageBox.Show($"Koltuk No: {tiklanan.Text}\nBu koltuk dolu!", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }


        private void kaydetbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(musteriAdi) || string.IsNullOrEmpty(telefon) || string.IsNullOrEmpty(cinsiyet) ||
                string.IsNullOrEmpty(firmaAdi) || string.IsNullOrEmpty(seferBaslangic) || string.IsNullOrEmpty(seferBitis) ||
                string.IsNullOrEmpty(koltukNo) || string.IsNullOrEmpty(tarih))
            {
                MessageBox.Show("Lütfen tüm bilgileri doldurun!");
                return;
            }
            string kontrolQuery = @"SELECT COUNT(*) FROM seferbilgileri 
                        WHERE FirmaAdi = @firma 
                          AND SeferBaslangic = @nereden 
                          AND SeferBitis = @nereye 
                          AND KoltukNo = @koltuk 
                          AND Tarih = @tarih";

            cmd = new MySqlCommand(kontrolQuery, conn);
            cmd.Parameters.AddWithValue("@firma", firmaAdi);
            cmd.Parameters.AddWithValue("@nereden", seferBaslangic);
            cmd.Parameters.AddWithValue("@nereye", seferBitis);
            cmd.Parameters.AddWithValue("@koltuk", koltukNo);
            cmd.Parameters.AddWithValue("@tarih", Convert.ToDateTime(tarih).ToString("yyyy-MM-dd HH:mm"));

            conn.Open();
            int kontrol = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();

            if (kontrol > 0)
            {
                MessageBox.Show($"Bu koltuk ({koltukNo}) bu seferde zaten satýlmýþ! Lütfen baþka bir koltuk seçin.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            string sql = "INSERT INTO seferbilgileri(MusteriAd,MusteriSoyad,Telefon,Cinsiyet,FirmaAdi,SeferBaslangic,SeferBitis,KoltukNo,Tarih,Fiyat)"
                        + " VALUES(@musteriad,@musterisoyad,@tel,@cinsiyet,@firma,@baslangic,@bitis,@koltukno,@tarih,@fiyat)";
            cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@musteriad", musteriAdi);
            cmd.Parameters.AddWithValue("@musterisoyad", musteriSoyad);
            cmd.Parameters.AddWithValue("@tel", telefon);
            cmd.Parameters.AddWithValue("@cinsiyet", cinsiyet);
            cmd.Parameters.AddWithValue("@firma", firmaAdi);
            cmd.Parameters.AddWithValue("@baslangic", seferBaslangic);
            cmd.Parameters.AddWithValue("@bitis", seferBitis);
            cmd.Parameters.AddWithValue("@koltukno", koltukNo);
            cmd.Parameters.AddWithValue("@tarih", tarih);
            cmd.Parameters.AddWithValue("@fiyat", fiyat);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
          
            MessageBox.Show("Bilet Satýþ Bilgileri baþarýyla kaydedildi!");

            DataRow newRow = dt.NewRow();

            newRow["MusteriAd"] = musteriAdi;
            newRow["MusteriSoyad"] = musteriSoyad;
            newRow["Telefon"] = telefon;
            newRow["Cinsiyet"] = cinsiyet;
            newRow["FirmaAdi"] = firmaAdi;
            newRow["SeferBaslangic"] = seferBaslangic;
            newRow["SeferBitis"] = seferBitis;
            newRow["KoltukNo"] = koltukNo;
            newRow["Tarih"] = tarih;
            newRow["Fiyat"] = fiyat;

            dt.Rows.Add(newRow);
            dataGridView1.DataSource = dt;


            Dictionary<int, string> doluKoltuklar = GetDoluKoltuklar(firmaAdi, seferBaslangic, seferBitis, Convert.ToDateTime(tarih));
            switch (cmbfirma.Text)
            {
                case "Kamil Koç":
                    koltukdoldur(pictureBox1, 12, true, doluKoltuklar);
                    break;
                case "Metro Turizm":
                    koltukdoldur(pictureBox2, 10, true, doluKoltuklar);
                    break;
                case "Sinop Birlik":
                    koltukdoldur(pictureBox3, 8, true, doluKoltuklar);
                    break;
                case "Lüks Artvin":
                    koltukdoldur(pictureBox4, 12, true, doluKoltuklar);
                    break;
            }
        }


        private void rezerveEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cmbfirma.SelectedIndex == -1 || cmbNereden.SelectedIndex == -1 || cmbnereye.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen önce sefer bilgilerini doldurunuz");
                return;
            }

            KayýtFormu kf = new KayýtFormu(this);
            DialogResult sonuc = kf.ShowDialog();

            if (sonuc == DialogResult.OK)
            {

                musteriAdi = kf.txtad.Text;
                musteriSoyad = kf.txtsoyad.Text;
                telefon = kf.txttel.Text;
                cinsiyet = kf.rdrbay.Checked ? "BAY" : "BAYAN";
                firmaAdi = cmbfirma.Text;
                seferBaslangic = cmbNereden.Text;
                seferBitis = cmbnereye.Text;
                koltukNo = tiklanan.Text;
                tarih = dtb.Value.ToString("yyyy-MM-dd HH:mm");
                fiyat = num.Value;

                if (kf.rdrbay.Checked)
                    tiklanan.BackColor = Color.Blue;
                else if (kf.rdrbayan.Checked)
                    tiklanan.BackColor = Color.Pink;


                MessageBox.Show("Bilgiler alýndý.");
            }
        }

        private void yazdir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                Form2 biletFormu = new Form2(); 
                biletFormu.Show();

                biletFormu.adlbl.Text = selectedRow.Cells["MusteriAd"].Value.ToString();
                biletFormu.soyadlbl.Text = selectedRow.Cells["MusteriSoyad"].Value.ToString();
                biletFormu.firmalbl.Text = selectedRow.Cells["FirmaAdi"].Value.ToString();
                biletFormu.koltuklbl.Text = selectedRow.Cells["KoltukNo"].Value.ToString();
                biletFormu.tarihlbl.Text = Convert.ToDateTime(selectedRow.Cells["Tarih"].Value).ToString("dd.MM.yyyy HH:mm");
                biletFormu.fiyatlbl.Text = selectedRow.Cells["Fiyat"].Value.ToString();
                biletFormu.label7.Text = selectedRow.Cells["SeferBaslangic"].Value.ToString();
                biletFormu.label8.Text = selectedRow.Cells["SeferBitis"].Value.ToString();






            }
        }

        private void cmbNereden_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiyatGuncelle();

        }

        private void cmbnereye_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiyatGuncelle();
        }

        private void dtb_ValueChanged(object sender, EventArgs e)
        {

        }



        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {

                txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silinecek bir sefer seçin!", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult sonuc = MessageBox.Show("Seçili seferi silmek istediðinizden emin misiniz?",
                                                 "Sefer Silme Onayý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sonuc == DialogResult.Yes)
            {
                int seferID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Sefer_Id"].Value);

                string query = "DELETE FROM seferbilgileri WHERE Sefer_Id=@seferid";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@seferid", seferID);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

               

                verigetir(); 
            }
        }
    }
        }
    
    


                



            
      
        

       
    
    
