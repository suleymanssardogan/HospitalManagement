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
using DevExpress.XtraGrid.Views.Base;

namespace Hospital_Management
{
    public partial class Receptionist : Form
    {
        DbHospitalEntities1 db = new DbHospitalEntities1();
        public Receptionist()
        {
            InitializeComponent();
        }


        public void List()
        {
            try
            {
                //List All receptionist
                var receptionists = db.TblReceptionist.ToList();
                gridControl1.DataSource = receptionists;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error List{ex}");
            }
        }
        public void Clear()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtReceptionistID.Text = "";
            txtSearch.Text = "";
            txtEmail.Text = "";
            cbboxShift.SelectedIndex = -1;
            cbboxStatu.SelectedIndex = -1;
        }

        //Update process
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            //take all properties 
            string id = txtReceptionistID.Text;
            string firs_name = txtFirstName.Text;
            string last_name = txtLastName.Text;
            string email = txtEmail.Text;
            string phone_number = txtPhoneNumber.Text;
            string shift = cbboxShift.SelectedItem.ToString();
            string statu = cbboxStatu.SelectedItem.ToString();


            try
            {
                var receptionist = db.TblReceptionist.FirstOrDefault(r => r.ReceptionistIdentityNumber == id);

                if(receptionist != null)
                {
                    //Assigned  the table
                    receptionist.FirstName = firs_name;
                    receptionist.LastName = last_name;
                    receptionist.Email = email;
                    receptionist.PhoneNumber = phone_number;
                    receptionist.Shift = shift;
                    receptionist.Status = statu;

                    //Save all of them
                    db.SaveChanges();
                    MessageBox.Show("Receptionist Updated Succesfully");
                    //And recall list function
                    List();
                }

                else
                {
                    MessageBox.Show("Receptionist not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }catch(Exception ex)
            {
                MessageBox.Show($"Error during update: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0; // İlk sekme (indeks 0)
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List(); 
        }

        private void Receptionist_Load(object sender, EventArgs e)
        {
            //I created gridView1
            gridView1.FocusedRowChanged += gridView1_FocusedRowChanged;

            txtSearch.Text = " ";
        }

        private void gridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            //Take choosen row          
            try
            {
                // Data transfer to textboxs
                txtFirstName.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "FirstName").ToString();
                txtLastName.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "LastName").ToString();
                txtReceptionistID.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ReceptionistIdentityNumber").ToString();
                txtPhoneNumber.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "PhoneNumber").ToString();
                txtEmail.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Email").ToString();

                // Data transfer to comboboxs
                cbboxShift.SelectedItem = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Shift").ToString();
                cbboxStatu.SelectedItem = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Status").ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = txtReceptionistID.Text;
            string first_name = txtFirstName.Text;
            string last_name = txtLastName.Text;
            string e_mail = txtEmail.Text;
            string shift = cbboxShift.SelectedItem.ToString();
            string statu = cbboxStatu.SelectedItem.ToString();
            string phone_number = txtPhoneNumber.Text;
            string password = txtPassword.Text;
            try
            {
                TblReceptionist new_receptionist = new TblReceptionist
                {
                    ReceptionistIdentityNumber = id,
                    FirstName = first_name,
                    LastName = last_name,
                    Email = e_mail,
                    Shift = shift,
                    Status = statu,
                    PhoneNumber = phone_number,
                    ReceptionistPassword =password,

                };


                db.TblReceptionist.Add(new_receptionist);

                MessageBox.Show("Recptionist Added Succesfully");
                db.SaveChanges();
                List();
                //Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error5555: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string id = txtSearch.Text.Trim();

          

            try
            {
                var receptionist = db.TblReceptionist.Where(r => r.ReceptionistIdentityNumber == id).Select(r => new
                {
                    r.ReceptionistIdentityNumber,
                    r.PhoneNumber,
                    r.Shift,
                    r.Status,
                    r.LastName,
                    r.FirstName,
                    r.Email,
                }).ToList();
                if (receptionist.Count == 0)
                {
                    MessageBox.Show("Colud Not Found Searched ID belong Receptionist.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                gridControl1.DataSource = receptionist;
            }catch(Exception ex)
            {
                MessageBox.Show($"Error333: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtReceptionistID.Text;

            try
            {
                //I control from database about related id Receptionist
                var receptionist = db.TblReceptionist.FirstOrDefault(r => r.ReceptionistIdentityNumber == id);
                if(receptionist != null)
                {
                    //Remove
                    db.TblReceptionist.Remove(receptionist);
                    //Save
                    db.SaveChanges();
                    MessageBox.Show("Receptionist Deleted Succesfully");
                    //Recall necesaary functions
                    List();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Receptionist not found ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error during delete: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridControl1_RowClick(object sender, EventArgs e)
        {

            //if I click the row related datas show related fields
            var selectedRow = gridView1.GetFocusedRow() as TblReceptionist;
            if (selectedRow != null)
            {
                txtReceptionistID.Text = selectedRow.ReceptionistIdentityNumber;
                txtFirstName.Text = selectedRow.FirstName;
                txtLastName.Text = selectedRow.LastName;
                txtEmail.Text = selectedRow.Email;
                txtPhoneNumber.Text = selectedRow.PhoneNumber;
              
                 cbboxShift.SelectedItem = selectedRow.Shift;
                 cbboxStatu.SelectedItem = selectedRow.Status;
            }
        }
    }
}
