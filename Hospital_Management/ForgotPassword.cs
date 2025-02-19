using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// I added this models because they are my database
using Hospital_Management.Models;
using System.Data.Entity;

namespace Hospital_Management
{
    public partial class ForgotPassword : Form
    {

        //I cretaed entities
        DbHospitalEntities1 db = new DbHospitalEntities1();

        public ForgotPassword()
        {
            InitializeComponent();
        }

        //In properties about textboxPassword , there is a propertie its name is PasswordChar, I assigned the PasswordChar "*";
        private void checkShow_CheckedChanged(object sender, EventArgs e)
        {
            //İf there is any click the checkbox the textboxPassword.Text = * ;
            if (checkShow.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
                txtConfirmPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
                txtConfirmPassword.UseSystemPasswordChar = false;

            }
        }

        private void btnBackLogInPage_Click(object sender, EventArgs e)
        {
            //I wanna reopen LogIn form
            LogIn frm1 = new LogIn();
            frm1.Show();

            this.Close();

        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            //If user never choose title 
            if (comboboxTitle.SelectedItem == null)
            {
                MessageBox.Show("Please select a title before logging in.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Stop processing
            }

            string selected_item = comboboxTitle.SelectedItem.ToString();
            string identity = txtIdentityNumber.Text;
            string password = txtPassword.Text;

            //If there is any empty area
            if (string.IsNullOrEmpty(selected_item) || string.IsNullOrEmpty(identity) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please Select All of Them", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Confirm Password and Password are not same.Please enter correct");
            }

            else
            {
                try
                {
                    // Password Update Process
                    switch (selected_item)
                    {
                        case "Admin":
                            var admin = db.TblAdmin.FirstOrDefault(a => a.AdminIdentityNumber == identity);
                            if (admin != null)
                            {
                                admin.AdminPassword = password;
                                db.SaveChanges();
                                MessageBox.Show("Password update successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No admin could be found for the entered  ID Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;

                        case "Doctor":
                            var doctor = db.TblDoctor.FirstOrDefault(d => d.DoctorIdentityNumber == identity);
                            if (doctor != null)
                            {
                                doctor.DoctorPassword = password;
                                db.SaveChanges();
                                MessageBox.Show("Password update successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else
                            {
                                MessageBox.Show("No doctor could be found for the entered  ID Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;

                        case "Nurse":
                            var nurse = db.TblNurse.FirstOrDefault(n => n.NurseIdentityNumber == identity);
                            if (nurse != null)
                            {
                                nurse.NursePassword = password;
                                db.SaveChanges();
                                MessageBox.Show("Password update successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No nurse could be found for the entered  ID Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;

                        case "Receptionist":
                            var receptionist = db.TblReceptionist.FirstOrDefault(r => r.ReceptionistIdentityNumber == identity);
                            if (receptionist != null)
                            {
                                receptionist.ReceptionistPassword = password;
                                db.SaveChanges();
                                MessageBox.Show("Password update successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No receptionist could be found for the entered  ID Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show($"There is an error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        // I wanna make this function because I wanna show user choose any title ;
        private void comboboxTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected_item = comboboxTitle.SelectedItem.ToString();

            if (selected_item == "Admin")
            {
                MessageBox.Show("Selected Admin Title");
            }
            else if (selected_item == "Doctor")
            {
                MessageBox.Show("Selected Doctor Title");
            }
            else if (selected_item == "Nurse")
            {
                MessageBox.Show("Seleceted Nurse Title");
            }
            else
            {
                MessageBox.Show("Selected Receptionist Title");
            }
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {

        }
    }
}

