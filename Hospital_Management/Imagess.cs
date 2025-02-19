using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management
{
    public partial class Imagess : Form
    {
        public Imagess()
        {
            InitializeComponent();
        }

        private void Imagess_Load(object sender, EventArgs e)
        {

        }
        public void LoadImage(string imagePath)
        {
            try
            {
                if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                {
                    picture1.Image = Image.FromFile(imagePath);
                    picture1.SizeMode = PictureBoxSizeMode.StretchImage;  // Resmi PictureBox'a sığdır
                }
                else
                {
                    MessageBox.Show("Resim bulunamadı veya geçersiz dosya yolu!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Resim yüklenirken bir hata oluştu: {ex.Message}");
            }
        }
    }
}
