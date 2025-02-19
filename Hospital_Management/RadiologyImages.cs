using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital_Management.Models;
using System.Data.Entity;

namespace Hospital_Management
{
    public partial class RadiologyImagesForm : Form
    {
        public RadiologyImagesForm()
        {
            InitializeComponent();
        }
        DbHospitalEntities1 db = new DbHospitalEntities1();

        public string ImagePath { get; private set; }

        private void RadiologyImages_Load(object sender, EventArgs e)
        {
            gridView1.Appearance.Row.Font = new Font("Tahoma", 12); // Satırların font büyüklüğü
            gridView1.Appearance.HeaderPanel.Font = new Font("Tahoma", 12, FontStyle.Bold); // Başlıkların font büyüklüğü
            gridView1.FocusedRowChanged += gridView1_FocusedRowChanged;
            try
            {
                    var allImages = db.RadiologyImages
                    .Select(img => new
                    {
                        img.ImageID,
                        img.ImagePath,
                        img.Description,
                        img.UploadDate,
                        img.UploadedBy,
                        img.TblPatient.PatientIdentityNumber,
                        PatientName = img.TblPatient.FirstName + " " + img.TblPatient.LastName
                    })
                    .ToList();

                gridControl1.DataSource = allImages;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken hata oluştu: " + ex.Message);
            }
        }

    
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var id_number = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "PatientIdentityNumber");
            var path = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ImagePath");

            try
            {
                if(id_number != null)
                {
                    txtPatient.Text = id_number.ToString();
                    if (!string.IsNullOrEmpty(path?.ToString()) && System.IO.File.Exists(path.ToString()))
                    {
                        guna2PictureBox1.Image = Image.FromFile(path.ToString());
                    }
                    else
                    {
                        guna2PictureBox1.Image = null; // Eğer resim yoksa PictureBox'ı temizle
                        MessageBox.Show("Resim bulunamadı veya geçersiz dosya yolu!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    btnPath.Text = path.ToString();
                }
            }catch(Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}");
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string id = txtPatient.Text;  // TxtPatient'ten ID'yi alıyoruz.

            try
            {
                // Hasta kimlik numarasına göre radyoloji görüntülerini alıyoruz
                var images = db.RadiologyImages.Where(x => x.PatientIdentityNumber.ToString() == id).ToList();

                // GridControl'e yükle
                gridControl1.DataSource = images;


                if (images.Count == 0)
                {
                    MessageBox.Show("Patient does not have radiology images");
                }
                else
                {
                    // Seçilen ilk resimle ilgili işlemleri gerçekleştirelim
                    var firstImage = images.FirstOrDefault();
                    if (firstImage != null)
                    {
                        string imagePath = firstImage.ImagePath;  // Resim yolunu al
                        if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                        {
                            // Resmi PictureBox'ta göster
                            guna2PictureBox1.Image = Image.FromFile(imagePath);
                            Imagess frm = new Imagess();
                            frm.LoadImage(imagePath);
                            frm.ShowDialog();
                        }
                        else
                        {
                            guna2PictureBox1.Image = null;
                            MessageBox.Show("Resim bulunamadı veya geçersiz dosya yolu!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
