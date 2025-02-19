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
    public partial class Nurse : Form
    {
        public Nurse()
        {
            InitializeComponent();
        }
        DbHospitalEntities1 db = new DbHospitalEntities1();

        public void Clear()
        {
            txtNurseDepartment.Text = "";
            txtNurseIDNumber.Text = "";
            txtNurseMail.Text = "";
            txtNurseName.Text = "";
            txtNurseSurname.Text = "";
        }
        public void List()
        {
            //I use try catch because I do not want cracj-up my program
            try
            {
                //Clear before that moment the data
                gridControl1.DataSource = null;
                var values = db.TblNurse.ToList();
                gridControl1.DataSource = values;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"There is an error {ex.Message}");
            }
        }

        //Function for Table Add
        public void Add()
        {
            //I take the values form textboxs
            string name = txtNurseName.Text;
            string surname = txtNurseName.Text;
            string mail = txtNurseMail.Text;
            string id_number = txtNurseIDNumber.Text;
            string department = txtNurseDepartment.Text;
            string shift = comboBoxNurseShift.SelectedItem.ToString();
            string password = txtPassword.Text;

            //I use try catch because I do not want crack-up my program

            try
            {
                TblNurse new_nurse = new TblNurse
                {
                    FirstName = name,
                    LastName = surname,
                    Email = mail,
                    NurseIdentityNumber = id_number,
                    Department = department,
                    Shift = shift,
                    NursePassword = password,
                };

                //I add new doctor
                db.TblNurse.Add(new_nurse);
                MessageBox.Show("Added Nurse");

                //I save changes
                db.SaveChanges();
            }

            catch(Exception ex)
            {
                MessageBox.Show($"There is an error{ex.Message}");
            }

            //I clear textboxs
            Clear();
            comboBoxNurseShift.SelectedValue = -1;

            //And I recall list metod I wanna see changes
            List();

        }


        //Function for deleting process
        public void Delete()
        {
            try
            {
                // Take NurseID from datagrid
                object selectedNurseID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NurseID");

                //If there is any choosen row occur error
                if (selectedNurseID== null)
                {
                    MessageBox.Show("Please Choose Nurse");
                    return;

                }

                int nurseID = Convert.ToInt32(selectedNurseID);

                // Find the doctor according NurseID in Database
                var delete_nurse = db.TblNurse.FirstOrDefault(n => n.NurseID == nurseID);

                if(delete_nurse != null)
                {

                    //Delete Nurse from database
                    db.TblNurse.Remove(delete_nurse);
                    db.SaveChanges();
                    MessageBox.Show("Choosen NUrse Deleted");
                    List();// Update list
                }
                else
                {
                    MessageBox.Show("Choosen Nurse Could Not Found");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}");
            }
        }

        //Funciton for update
        public void UpdatedFunciton()
        {
            try
            {
                // Take NurseID where choosen Gridview1
                object selectedNurseID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NurseID");

                if(selectedNurseID== null)
                {
                    MessageBox.Show("Please Choose any Nurse");
                    return;
                }

                int nurse_id = Convert.ToInt32(selectedNurseID);

                //Find the nurse fronm DataBase
                var update_nurse = db.TblNurse.FirstOrDefault(n => n.NurseID == nurse_id);

                if(update_nurse != null)
                {
                    update_nurse.FirstName = txtNurseName.Text;
                    update_nurse.LastName = txtNurseSurname.Text;
                    update_nurse.NurseIdentityNumber = txtNurseIDNumber.Text;
                    update_nurse.Email = txtNurseMail.Text;
                    update_nurse.Department = txtNurseDepartment.Text;
                    update_nurse.Shift = comboBoxNurseShift.SelectedItem.ToString();

                    // Save Changes
                    db.SaveChanges();
                    MessageBox.Show("Nurse's Informatşon updated succesfully");
                    //Refresh List
                    List();
                    Clear();

                }
                else
                {
                    MessageBox.Show("Could Not Found Nurse for Update");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error{ex.Message}");
            }

        }

        private void Nurse_Load(object sender, EventArgs e)
        {
            //I created gridView1
            gridView1.FocusedRowChanged += gridView1_FocusedRowChanged;
        }



        private void btnList_Click(object sender, EventArgs e)
        {
            //I call list funciton
            List();
        }

       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //I call Add function
            Add();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdatedFunciton();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var name = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "FirstName");
            var surname = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "LastName");
            var id_number = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NurseIdentityNumber");
            var department = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Department");
            var mail = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Email");
            var shift = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Shift");

            //I use try catch block because I do not wanna crash my program
            try
            {
                if(name != null)
                {
                    txtNurseName.Text = name.ToString();
                    txtNurseSurname.Text = surname.ToString();
                    txtNurseIDNumber.Text = id_number.ToString();
                    txtNurseMail.Text = mail.ToString();
                    txtNurseDepartment.Text = department.ToString();
                    comboBoxNurseShift.SelectedItem = shift.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error{ex.Message}");
            }
        }

        public void My_Search()
        {

            try
            {
                // TC numarasını TextBox'tan al
                string nurseTC = txtNurseIDNumber.Text.Trim();

                // TC numarası boş mu kontrol et
                if (string.IsNullOrEmpty(nurseTC))
                {
                    MessageBox.Show("Please enter a valid Nurse TC number.");
                    return;
                }

                // TC numarasına göre hemşireyi veritabanında ara
                var nurseList = db.TblNurse
                    .Where(n => n.NurseIdentityNumber == nurseTC)
                    .ToList();

                // Hemşire bulunduysa bilgileri tabloya yansıt
                if (nurseList.Any())
                {
                    gridControl1.DataSource = nurseList;
                }
                else
                {
                    MessageBox.Show("No nurse found with the entered TC number.");
                    gridControl1.DataSource = null; // Tabloyu temizle
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\nInner Exception: {ex.InnerException?.Message}");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            My_Search();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            UpdatedFunciton();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            Delete();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            Add();
        }

        private void btnList_Click_1(object sender, EventArgs e)
        {
            List();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
