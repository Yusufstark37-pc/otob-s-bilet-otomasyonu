using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace biletsatisotomasyonu
{
    public partial class KayıtFormu : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=biletsatisotomasyonu;Uid=root;Pwd=mysqlroot37;");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        Form1 form1;
        
        public string MusteriAd { get; set; }
        public string MusteriSoyad { get; set; }
        public string Telefon { get; set; }
        public string Cinsiyet { get; set; }
        public DateTime Tarih { get; set; }
        public decimal Fiyat { get; set; }

        public KayıtFormu(Form1 form)
        {
            InitializeComponent();
            this.form1 = form;
            
           
        }
       
        private void KayıtFormu_Load(object sender, EventArgs e)
        {
            
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            
            
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btntm_Click(object sender, EventArgs e)
        {
            
            MusteriAd = txtad.Text;
            MusteriSoyad = txtsoyad.Text;
            Telefon = txttel.Text;
            Cinsiyet = rdrbay.Checked ? "BAY" : "BAYAN";
            Tarih = form1.dtb.Value;
            Fiyat = form1.num.Value;
           

            this.DialogResult = DialogResult.OK;
            this.Close();
        }





    }
    }

