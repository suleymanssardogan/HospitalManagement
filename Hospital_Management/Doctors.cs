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
    public partial class Doctors : Form
    {
        public Doctors()
        {
            InitializeComponent();
        }

        //I created new entites object
        DbHospitalEntities1 db = new DbHospitalEntities1();

        //Function for Table List
        public void List()
        {
            //I use try catch because I do not want cracj-up my program
            try
            {
                var values = db.TblDoctor.ToList();
                gridTableControl.DataSource = values;

            }

            catch (Exception ex)
            {
                MessageBox.Show($"There is an error {ex.Message}");
            }
        }


        //Function for Table Add
        public void Add()
        {
            //I take the values form textboxs
            string name = txtDoctorName.Text;
            string surname = txtDoctorSurname.Text;
            string salary = txtDoctorSalary.Text;
            string departmen = txtDoctorDepartment.Text;
            string id_number = txtDoctorIDNumber.Text;
            string e_mail = txtE_Mail.Text;
            string statu = cbboxStatus.SelectedItem.ToString();
            string password = txtPassword.Text;

           

            //I use try catch because I do not want crack-up my program
            try
            {
                TblDoctor new_doctor = new TblDoctor
                {
                    FirstName = name,
                    LastName = surname,
                    Salary = salary,
                    Department = departmen,
                    DoctorIdentityNumber = id_number,
                    Email = e_mail,
                    Status = statu,
                    DoctorPassword = password,

                };

                //I add new doctor
                db.TblDoctor.Add(new_doctor);
                MessageBox.Show("Added Doctor");

                //I save changes
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"There is an error{ex.Message}");
            }


            //I clear textboxs
            txtDoctorName.Text = "";
            txtDoctorSurname.Text = "";
            txtDoctorSalary.Text = "";
            txtDoctorIDNumber.Text = "";
            txtDoctorDepartment.Text = "";
            txtE_Mail.Text = " ";

            //And I recall list metod I wanna see changes
            List();
        }



        public void MySearch()
        {
            try
            {
                // TC numarasını TextBox'tan al
                string doctorTC = txtDoctorIDNumber.Text.Trim();

                // TC numarası boş mu kontrol et
                if (string.IsNullOrEmpty(doctorTC))
                {
                    MessageBox.Show("Please enter a valid Doctor TC number.");
                    return;
                }

                // TC numarasına göre doktoru veritabanında ara
                var doctorList = db.TblDoctor
                    .Where(d => d.DoctorIdentityNumber == doctorTC)
                    .ToList();

                // Doktor bulunduysa bilgileri tabloya yansıt
                if (doctorList.Any())
                {
                   gridTableControl.DataSource = doctorList;
                }
                else
                {
                    MessageBox.Show("No doctor found with the entered TC number.");
                   gridTableControl.DataSource = null; // Tabloyu temizle
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\nInner Exception: {ex.InnerException?.Message}");
            }

        }


        //Function for deleting process
        public void Delete()
        {

            try
            {
                // Take DoctorID from datagrid
                object selectedDoctorID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DoctorID");
                
                //If there is any choosen row occur error
                if (selectedDoctorID == null)
                {
                    MessageBox.Show("Please Choose Doctor");
                    return;
                }

                // Convert ID to int
                int doctorID = Convert.ToInt32(selectedDoctorID);

                // Find the doctor according DoctorID in Database
                var doctorToDelete = db.TblDoctor.FirstOrDefault(d => d.DoctorID == doctorID);

                if (doctorToDelete != null)
                {
                    //Delete doctor from database
                    db.TblDoctor.Remove(doctorToDelete);
                    db.SaveChanges();
                    MessageBox.Show("Choosen Doctor Deleted.");
                    List(); // Update list
                }
                else
                {
                    MessageBox.Show("Choosen Doctor Could Not Found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        //Funciton for update
        public void UpdatedFunction()
        {

            try
            {
                // Take DoctorID where choosen Gridview1
                object selectedDoctorID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DoctorID");

                // if there have not choosen row get error
                if (selectedDoctorID == null)
                {
                    MessageBox.Show("Please Choose any Doctor");
                    return;
                }

                // Convert DoctorID to int
                int doctorID = Convert.ToInt32(selectedDoctorID);
                
                //Find the doctor fronm DataBase
                var doctorToUpdate = db.TblDoctor.FirstOrDefault(d => d.DoctorID == doctorID);

                if (doctorToUpdate != null)
                {
                    // Textbox'lardaki yeni bilgileri al ve güncelle
                    doctorToUpdate.FirstName = txtDoctorName.Text;
                    doctorToUpdate.LastName = txtDoctorSurname.Text;
                    doctorToUpdate.Salary = txtDoctorSalary.Text;
                    doctorToUpdate.Department = txtDoctorDepartment.Text;
                    doctorToUpdate.DoctorIdentityNumber = txtDoctorIDNumber.Text;
                    doctorToUpdate.Email = txtE_Mail.Text;
                    doctorToUpdate.Status = cbboxStatus.SelectedItem.ToString();

                    // Save Changes
                    db.SaveChanges();
                    MessageBox.Show("Doctor's information updated succesfully.");

                    //Refresh List
                    List();
                }
                else
                {
                    MessageBox.Show("Güncellemek için bir doktor bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    
        //Funciton for listing
        private void btnList_Click(object sender, EventArgs e)
        {
            // ı call list function because I wanna see TblDoctor my grdicontrol
            List();
        }
        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //I call my add function
            Add();
        }

        private void Doctors_Load(object sender, EventArgs e)
        {
            //I created gridView1
            gridView1.FocusedRowChanged += gridView1_FocusedRowChanged;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //I call delete function
            Delete();
        }

        public void Clear()
        {
            txtDoctorDepartment.Text = "";
            txtDoctorIDNumber.Text = "";
            txtDoctorName.Text = "";
            txtDoctorSalary.Text = "";
            txtDoctorSurname.Text = "";
            txtE_Mail.Text = "";
            cbboxStatus.SelectedIndex = -1;
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var firstName = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "FirstName");
            var surname = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "LastName");
            var id_number = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DoctorIdentityNumber");
            var salary = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Salary");
            var department = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Department");
            var e_mail = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Email");
            var statu = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Status");

            //I use try catch block because I do not wanna crash my program
            try
            {
                //If  there is no missing properties about Doctor
                if (firstName != null)
                {
                    txtDoctorName.Text = firstName.ToString();
                    txtDoctorSurname.Text = surname.ToString();
                    txtDoctorIDNumber.Text = id_number.ToString();
                    txtDoctorSalary.Text = salary.ToString();
                    txtDoctorDepartment.Text = department.ToString();
                    txtE_Mail.Text = e_mail.ToString();
                    cbboxStatus.SelectedItem = statu.ToString();
                }
                else
                {
                    //if there is no data clear textbox
                    txtDoctorName.Text = "";
                    txtDoctorSurname.Text = "";
                    txtDoctorDepartment.Text = " ";
                    txtDoctorSalary.Text = " ";
                    txtDoctorIDNumber.Text = " ";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error{ex.Message}");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //I call my update function
            UpdatedFunction();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDoctorDepartment.Text = "";
            txtDoctorIDNumber.Text = "";
            txtDoctorSalary.Text = "";
            txtDoctorName.Text = "";
            txtDoctorSurname.Text = "";
            cbboxStatus.SelectedItem = -1;
            txtE_Mail.Text = "";
        }

        private void btnList_Click_1(object sender, EventArgs e)
        {
            List();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            Add();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            Delete();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            UpdatedFunction();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MySearch();
        }
    }
}
