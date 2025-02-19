using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Hospital_Management.Models;
using System.IO;
using static Hospital_Management.LogIn;

namespace Hospital_Management
{
    public partial class Load : Form
    {
        DbHospitalEntities1 db = new DbHospitalEntities1();
        
        public Load()
        {
            InitializeComponent();
        }
        private void LoadPatients()
        {

            //List patietns
            var patients = db.TblPatient
                .Select(p => new { p.PatientID, FullName = p.FirstName + " " + p.LastName })
                .ToList();

            cmbPatients.DataSource = patients;
            cmbPatients.DisplayMember = "FullName";
            cmbPatients.ValueMember = "PatientID";


        }



        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            /* if (cmbPatients.SelectedValue == null)
             {
                 MessageBox.Show("Lütfen bir hasta seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 return;
             }

             // OpenFileDialog ile dosya seçimi
             OpenFileDialog openFileDialog = new OpenFileDialog
             {
                 Filter = "Image Files (*.png;*.jpeg)|*.png;*.jpeg",
                 Title = "Bir Görüntü Dosyası Seçin"
             };

             if (openFileDialog.ShowDialog() == DialogResult.OK)
             {
                 string selectedFilePath = openFileDialog.FileName;

                 // 2.1. Dosyayı belirli bir klasöre kopyala
                  string uploadsFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "uploads/radiology");
               //string uploadsFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "uploads/radiology");
                 if (!Directory.Exists(uploadsFolder))
                     Directory.CreateDirectory(uploadsFolder);

                 string uniqueFileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(selectedFilePath);
                 string destinationPath = Path.Combine(uploadsFolder, uniqueFileName);
                 File.Copy(selectedFilePath, destinationPath);
                 string explain = txtExplain.Text;

                 // 2.2. Veritabanına kaydet
                 int patientId = (int)cmbPatients.SelectedValue;
                 var new_ımage = new RadiologyImages
                 {
                     PatientID = patientId,
                     ImagePath = destinationPath,
                     Description = explain,// Açıklama
                      UploadedBy = CurrentSession.Username, // Giriş yapan kullanıcı adı
                     UploadDate = DateTime.Now // Sistem saati
                 };

                 db.RadiologyImages.Add(new_ımage);
                 db.SaveChanges();

                 // Görüntüleri listeye yükle
                 LoadRadiologyImages(patientId);

                 MessageBox.Show("Görüntü başarıyla yüklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }*/



            try
            {
                if (cmbPatients.SelectedValue == null)
                {
                    MessageBox.Show("Lütfen bir hasta seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    InitialDirectory = @"E:\INDIRILENLER\RadiologyImages", // Varsayılan klasör
                    Filter = "Image Files (*.png;*.jpeg)|*.png;*.jpeg",
                    Title = "Bir Görüntü Dosyası Seçin"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;

                    // Dosya kopyalamak yerine, doğrudan dosya yolunu kaydedin
                    string explain = txtExplain.Text;

                    // Veritabanına kaydet
                    int patientId = (int)cmbPatients.SelectedValue;
                    var newImage = new RadiologyImages
                    {
                        PatientID = patientId,
                        ImagePath = selectedFilePath, // Resmin tam yolu
                        Description = explain, // Açıklama
                        UploadedBy = CurrentSession.Username, // Giriş yapan kullanıcı adı
                        UploadDate = DateTime.Now // Sistem saati
                    };

                    db.RadiologyImages.Add(newImage);
                    db.SaveChanges();

                    // Görüntüleri listele
                    LoadRadiologyImages(patientId);

                    MessageBox.Show("Görüntü başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }
    

        private void LoadRadiologyImages(int patientId)
        {
            var images = db.RadiologyImages
       .Where(img => img.PatientID == patientId)
       .Select(img => new
       {
           img.ImageID,
           img.ImagePath,
           img.Description,
           img.UploadDate,
           img.UploadedBy,
           PatientName = img.TblPatient.FirstName + " " + img.TblPatient.LastName // Hasta adı ve soyadı
        })
       .ToList();

            gridControl1.DataSource = images;
        }

        private void Load_Load(object sender, EventArgs e)
        {
            LoadPatients(); // Hasta listesini yükle
        }

        private void cmbPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ComboBox'ta bir hasta seçildiğinde tetiklenir
            if (cmbPatients.SelectedValue != null && int.TryParse(cmbPatients.SelectedValue.ToString(), out int patientId))
            {
                LoadRadiologyImages(patientId); // Hasta ID'sine göre görüntüleri yükle
            }
        }
    }
}
