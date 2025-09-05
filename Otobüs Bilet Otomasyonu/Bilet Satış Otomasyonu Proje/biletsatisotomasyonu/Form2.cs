using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
namespace biletsatisotomasyonu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
         

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pdfcikar_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF dosyası|*.pdf";
                saveFileDialog.Title = "PDF dosyasını kaydet";
                saveFileDialog.FileName = "otobusbilet.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Bitmap panelImage = new Bitmap(panel1.Width, panel1.Height);
                    using (Graphics g = Graphics.FromImage(panelImage))
                    {

                      
                        foreach (Control control in panel1.Controls)
                        {
                            if (control is PictureBox pictureBox && pictureBox.Image != null)
                            {
                                g.DrawImage(pictureBox.Image, pictureBox.Bounds);
                            }
                        }

                       
                        foreach (Control control in panel1.Controls)
                        {
                            if (control is Label label)
                            {
                                using (SolidBrush brush = new SolidBrush(label.ForeColor))
                                {
                                    g.DrawString(label.Text, label.Font, brush, label.Location);
                                }
                            }
                        }
                    }

          
                    using (Document doc = new Document(new iTextSharp.text.Rectangle(panelImage.Width, panelImage.Height)))
                    {
                        PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(saveFileDialog.FileName, FileMode.Create));
                        doc.Open();

                        
                        using (MemoryStream ms = new MemoryStream())
                        {
                            panelImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                            iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(ms.ToArray());
                            pdfImage.SetAbsolutePosition(0, 0);
                            doc.Add(pdfImage);
                        }

                        doc.Close();
                    }

                    MessageBox.Show("PDF başarıyla oluşturuldu: " + saveFileDialog.FileName);
                }
            }
        }
    }
}

