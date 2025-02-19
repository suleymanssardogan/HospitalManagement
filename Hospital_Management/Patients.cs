using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Library for entities
using Hospital_Management.Models;
using System.Data.Entity;

namespace Hospital_Management
{
    public partial class Patients : Form
    {
        //I created entites
        DbHospitalEntities1 db = new DbHospitalEntities1();

        public Patients()
        {
            InitializeComponent();
        }


        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            try
            {
            var id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "PatientIdentityNumber");
            var name = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "FirstName");
            var last_name = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "LastName");
            var date_birth = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DateOfBirth");
            var gender = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Gender");
            var blood_type = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "BloodType");
            var e_mail = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Email");
            var phone_number = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "PhoneNumber");
            var adres = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Address");
            //var MedicalHistory = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MedicalHistory");
            var insurance = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Insurance");
            var Admission = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "AdmissionDate");
            var Dischar = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Discharate");
            var statu = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Status");
            var height = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Height");
            var weight = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Weight");
            var Notes = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Notes");


                 if (id != null)
                 {
                     txtPatientIdentityNumber.Text = id.ToString();
                     txtPatientFirstNmae.Text = name.ToString();
                     txtPatientLastName.Text = last_name.ToString();
                     dateEdit1.DateTime = DateTime.Parse(date_birth.ToString());
                     cbbopatientGender.SelectedItem = gender;
                     cbboxBloodType.SelectedItem = blood_type;
                     txtPatientMail.Text = e_mail.ToString();
                     textEditPhoneNumber.Text = phone_number.ToString();
                     if (insurance != null)
                     {
                         if (Convert.ToBoolean(insurance))  // insurance 1 ise (true)
                         {
                             radioButtonYes.Checked = true;  // Yes için olan radio button'ı işaretle
                         }
                         else  // insurance 0 ise (false)
                         {
                             radioButtonNo.Checked = true;  // No için olan radio button'ı işaretle
                         }
                     }
                     dateEditAdmissionDate.DateTime = Convert.ToDateTime(Admission);
                     dateEditDischargeDate.DateTime = Convert.ToDateTime(Dischar);
                     cbboxStatus.SelectedItem = statu;
                     txtPatientHeight.Text = height.ToString();
                     txtPatientWeight.Text = weight.ToString();
                     txtNotes.Text = Notes.ToString();
                     txtPatientAddress.Text = adres.ToString();
                 }
                
                

            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}");
            }
        }


        //funciton for update
        public void UpdatePatients()
        {
            try
            {
                // Seçilen hastanın ID'sini al
                object selectedPatientID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "PatientID");

                // Seçili hasta yoksa hata mesajı göster
                if (selectedPatientID == null)
                {
                    MessageBox.Show("Please Choose any patient to update");
                    return;
                }

                // PatientID'yi int'e çevir
                int patientID = Convert.ToInt32(selectedPatientID);

                // Veritabanında hasta bilgilerini bul
                var patientUpdate = db.TblPatient.FirstOrDefault(p => p.PatientID == patientID);

                if (patientUpdate != null) // NULL kontrolü
                {
                    // TextBox'lardan ve ComboBox'lardan alınan bilgileri güncelle
                    patientUpdate.PatientIdentityNumber = txtPatientIdentityNumber.Text;
                    patientUpdate.FirstName = txtPatientFirstNmae.Text;
                    patientUpdate.LastName = txtPatientLastName.Text;

                    // Tarih alanlarını sadece geçerli bir değer varsa güncelle
                    if (dateEdit1.DateTime != null)
                        patientUpdate.DateOfBirth = dateEdit1.DateTime.ToString(); // Doğum tarihi

                    patientUpdate.Gender = cbbopatientGender.SelectedItem?.ToString(); // Cinsiyet
                    patientUpdate.BloodType = cbboxBloodType.SelectedItem?.ToString(); // Kan grubu
                    patientUpdate.Weight = txtPatientWeight.Text;
                    patientUpdate.Height = txtPatientHeight.Text;
                    patientUpdate.PhoneNumber = textEditPhoneNumber.Text;
                    patientUpdate.Email = txtPatientMail.Text;
                    patientUpdate.Insurance = radioButtonYes.Checked; // Sigorta durumu

                    // AdmissionDate ve DischarDate değerlerinin null olup olmadığını kontrol et
                    if (dateEditAdmissionDate.DateTime != null)
                        patientUpdate.AdmissionDate = dateEditAdmissionDate.DateTime; // Kabul tarihi

                    // DischarDate tarihini kontrol et ve geçerli olup olmadığını kontrol et
                    if (dateEditDischargeDate.DateTime != null && dateEditDischargeDate.DateTime > DateTime.MinValue)
                    {
                        patientUpdate.DischarDate = dateEditDischargeDate.DateTime; // Taburcu tarihi
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid discharge date.");
                        return; // Hata durumunda işlemi durdur
                    }

                    patientUpdate.Status = cbboxStatus.SelectedItem?.ToString(); // Durum
                    patientUpdate.Notes = txtNotes.Text;

                    // Değişiklikleri kaydet
                    db.SaveChanges();
                    MessageBox.Show("Patient's information updated successfully");
                    List(); // Listeyi yeniden yükle
                }
                else
                {
                    MessageBox.Show("No patient found to update");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\nInner Exception: {ex.InnerException?.Message}");
            }

        }

        public void Save()
            {
            bool hasInsurance = false;  //default

            // Take the ınsrurance situation from user
            if (radioButtonYes.Checked)  //User choosed "Yes"
            {
                hasInsurance = true;
            }
            else if (radioButtonNo.Checked)  // User choosed "No"
            {
                hasInsurance = false;
            }
            try
            {
                TblPatient new_patient = new TblPatient
                {

                    PatientIdentityNumber = txtPatientIdentityNumber.Text,
                    FirstName = txtPatientFirstNmae.Text,
                    LastName = txtPatientLastName.Text,
                    DateOfBirth = dateEdit1.DateTime.ToString(),
                    Gender = cbbopatientGender.SelectedItem.ToString(),
                    Weight = txtPatientWeight.Text,
                    Height = txtPatientHeight.Text,
                    PhoneNumber = textEditPhoneNumber.Text,
                    Address = txtPatientAddress.Text,
                    Email = txtPatientMail.Text,
                    BloodType = cbboxBloodType.SelectedItem.ToString(),
                    Insurance = hasInsurance,
                    AdmissionDate = dateEditAdmissionDate.DateTime,
                    DischarDate = dateEditDischargeDate.DateTime,
                    Status = cbboxStatus.SelectedItem.ToString(),
                    Notes = txtNotes.Text,
                };

                //Adding
                db.TblPatient.Add(new_patient);
                //Save
                db.SaveChanges();
                MessageBox.Show("Patient Added");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error{ex.Message}");
            }
        }

        //funciton for list
        public void List()
        {
            try
            {
                //I listed tblpatient
                var list = db.TblPatient.ToList();
                gridControl1.DataSource = list;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}");
            }
           
        }


        //Funciton for search
        public void MySearch()
        {
            //I take the identity number from txtbox
            string identity_number = txtSearchIdentityNUnber.Text;
            if (string.IsNullOrEmpty(identity_number) || identity_number.Length != 11)
            {
                MessageBox.Show("Please Enter Valid Identiy Number!!!");
                return;
            }

            try
            {
                //I controll patient related about identity number
                var patient = db.TblPatient.Where(p => p.PatientIdentityNumber == identity_number).ToList();

                //if there is a patient
                if (patient != null)
                {
                    //I show grid control
                    gridControl1.DataSource = patient;
                }


                else
                {
                    MessageBox.Show("No patient with this ID Number was found.");


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}");
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (xtraTabControl1.SelectedTabPageIndex < xtraTabControl1.TabPages.Count - 1)
            {
                xtraTabControl1.SelectedTabPageIndex += 1; //Pass afeter page
            }
            else
            {
                MessageBox.Show("Last Page!"); 
            }
        }

     
      

        private void btnBack0_Click(object sender, EventArgs e)
        {
            if (xtraTabControl1.SelectedTabPageIndex > 0)
            {
                xtraTabControl1.SelectedTabPageIndex -= 1; // Pass the before page
            }
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            if (xtraTabControl1.SelectedTabPageIndex > 0)
            {
                xtraTabControl1.SelectedTabPageIndex -= 1; //Pass the before page
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnNext0_Click_1(object sender, EventArgs e)
        {
            if (xtraTabControl1.SelectedTabPageIndex < xtraTabControl1.TabPages.Count - 1)
            {
                xtraTabControl1.SelectedTabPageIndex += 1; // Pass after page
            }
            else
            {
                MessageBox.Show("Last Page!");
            }
        }

      
        

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MySearch();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdatePatients();
        }

        private void Patients_Load(object sender, EventArgs e)
        {
            //EKSİKLERRRRRRRRRRRRRRRRR
            //Notlar kısmı büyük gözükebilirdi
            //medical history gözükebilirdi
            gridView1.FocusedRowChanged += gridView1_FocusedRowChanged;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Seçili hasta ID'sini al
                object selectedPatientID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "PatientID");

                // Seçili hasta yoksa hata mesajı göster
                if (selectedPatientID == null)
                {
                    MessageBox.Show("Please Choose any patient to delete");
                    return;
                }

                // PatientID'yi int'e çevir
                int patientID = Convert.ToInt32(selectedPatientID);

                // Veritabanında hastayı bul
                var patientToDelete = db.TblPatient.FirstOrDefault(p => p.PatientID == patientID);

                if (patientToDelete != null) // NULL kontrolü
                {
                    // Hastayı sil
                    db.TblPatient.Remove(patientToDelete);

                    // Değişiklikleri kaydet
                    db.SaveChanges();
                    MessageBox.Show("Patient's information deleted successfully");

                    // Listeyi yeniden yükle
                    List();
                }
                else
                {
                    MessageBox.Show("No patient found to delete");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\nInner Exception: {ex.InnerException?.Message}");
            }

        }

        public void My_Clear()
        {
            // TextBox'ları temizle
            txtPatientIdentityNumber.Clear();
            txtPatientFirstNmae.Clear();
            txtPatientLastName.Clear();
            txtPatientWeight.Clear();
            txtPatientHeight.Clear();
            textEditPhoneNumber.Text=" ";
            txtPatientMail.Clear();

            // ComboBox'ları sıfırla
            cbbopatientGender.SelectedIndex = -1; // Seçili öğeyi sıfırla
            cbboxBloodType.SelectedIndex = -1; // Kan grubu ComboBox'ını sıfırla

            // Tarih alanını sıfırla
            dateEdit1.EditValue = null; // Eğer `dateEdit1` nullable bir tarih ise null yap

            // RadioButton'ları sıfırla
            radioButtonYes.Checked = false; // Sigorta durumu
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            My_Clear();


        }
    }
}
