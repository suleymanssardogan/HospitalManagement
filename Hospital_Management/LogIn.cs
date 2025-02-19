using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//For entity framework
using Hospital_Management.Models;
using System.Data.Entity;

//Library for pdf converter
using iTextSharp.text;

namespace Hospital_Management
{
    public partial class LogIn : Form
    {
        // I created new entites its name is db
        DbHospitalEntities1 db = new DbHospitalEntities1();


        public LogIn()
        {
            InitializeComponent();
        }
        public static class CurrentSession
        {
            public static string Username { get; set; } // Kullanıcı adı
            public static string Role { get; set; } // Kullanıcı rolü
            public static string IdentityNumber { get; set; } // Kullanıcı TC Kimlik Numarası
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        //In properties about textboxPassword , there is a propertie its name is PasswordChar, I assigned the PasswordChar "*";
        private void checkShow_CheckedChanged(object sender, EventArgs e)
        {
            
            //İf there is any click the checkbox the Password = *;
            if (checkShow.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            //If click the forgotpassword opens ForgotPassword Form
            ForgotPassword frm = new ForgotPassword();
            frm.ShowDialog();


            
            

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            /*//If user never choose title 
            if (comboboxTitle.SelectedItem == null)
            {
                MessageBox.Show("Please select a title before logging in.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Stop processing
            }
            //I took combobx value whhich user click value
            string selected_item = comboboxTitle.SelectedItem.ToString();
            string identity = txtIdentityNumber.Text;
            string password = txtPassword.Text;

            if (selected_item != null)
            {
                switch (selected_item)
                {
                    //İf user choose admin
                    case "Admin":

                      

                        //I control ıdentitynumber and identity, adminpassword and password
                        var admin = db.TblAdmin.FirstOrDefault(a => a.AdminIdentityNumber == identity && a.AdminPassword == password);
                        try
                        {
                            //There is an admin
                            if (admin != null)
                            {
                                MessageBox.Show("Welcome To Hospital Management System");

                                Deneme frm = new Deneme();
                                frm.Show();
                            }

                            else
                            {
                                MessageBox.Show("Identity Number or Password is wrong");
                            }
                        }
                        //Posssible there is no admin like that or Program can not connect server
                        catch (Exception ex)
                        {
                            MessageBox.Show($"There is an error{ex.Message}");
                        }
                        break;

                    case "Doctor":

                        //I control ıdentitynumber and identity, doctorpassword and password
                        var doctor = db.TblDoctor.FirstOrDefault(a => a.DoctorIdentityNumber == identity && a.DoctorPassword == password);
                        try
                        {
                            //There is a doctor
                            if (doctor != null)
                            {
                                MessageBox.Show("Welcome to Hospital Management System");
                                Deneme frm = new Deneme();
                                frm.Show();

                            }
                            else
                            {
                                MessageBox.Show("Identity number or Password is wrong");
                            }


                        }
                        //Posssible there is no doctor like that or Program can not connect server
                        catch (Exception ex)
                        {
                            MessageBox.Show($"There is an error{ex.Message}");
                        }

                        break;


                    case "Nurse":

                        //I controll ıdentitiy number and password
                        var nurse = db.TblNurse.FirstOrDefault(n => n.NurseIdentityNumber == identity && n.NursePassword == password);
                        try
                        {
                            if (nurse != null)
                            {
                                MessageBox.Show("Welcome To Hospital Managemenet System");
                                Deneme frm = new Deneme();
                                frm.Show();
                            }


                            else
                            {
                                MessageBox.Show("Identitiy Number or Password is wrong");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error{ex.Message}");
                        }
                       
                        break;

                    //If choosen item is a receptionist
                    case "Recepti":

                        try
                        {
                            //I controll ıdentitiy number and password
                            var receptionist = db.TblReceptionist.FirstOrDefault(r => r.ReceptionistIdentityNumber == identity && r.ReceptionistPassword == password);
                            if (receptionist != null)
                            {
                                MessageBox.Show("Welcome To Hospital Management System");
                                Deneme frm = new Deneme();
                                frm.Show();
                            }
                            else
                            {
                                MessageBox.Show("Identity Number or Password is wrong");
                            }
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show($"Error{ex.Message}");
                        }
                        break;


                }
            }
            else
            {
                MessageBox.Show("Please Choose Your Title and Enter");
            }*/

            if (comboboxTitle.SelectedItem == null)
            {
                // If the user has not selected a title, show a warning message and stop further execution
                MessageBox.Show("Please select a title before logging in.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selected_item = comboboxTitle.SelectedItem.ToString(); // Get the selected title
            string identity = txtIdentityNumber.Text; // Get the entered identity number
            string password = txtPassword.Text; // Get the entered password

            switch (selected_item)
            {
                case "Admin":
                    // Check if the entered identity number and password match an admin record in the database
                    var admin = db.TblAdmin.FirstOrDefault(a => a.AdminIdentityNumber == identity && a.AdminPassword == password);
                    if (admin != null)
                    {
                        CurrentSession.Username = admin.AdminName; // Admin adını sakla
                        CurrentSession.Role = "Admin"; // Rolü sakla
                        CurrentSession.IdentityNumber = admin.AdminIdentityNumber;

                        MessageBox.Show("Welcome To Hospital Management System");
                        Deneme frm = new Deneme("Admin");
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Identity Number or Password is wrong");
                    }
                    break;

                case "Doctor":
                    // Query the database to find a doctor with the entered identity number and password
                    var doctor = db.TblDoctor.FirstOrDefault(d => d.DoctorIdentityNumber == identity && d.DoctorPassword == password);
                    if (doctor != null)
                    {
                        // If the doctor is found, store their details in the CurrentSession for global access
                        CurrentSession.Username = doctor.FirstName + " " + doctor.LastName; // Store the doctor's full name
                        CurrentSession.Role = "Doctor"; // Store the user's role
                        CurrentSession.IdentityNumber = doctor.DoctorIdentityNumber; // Store the user's identity number

                        // Display a welcome message and navigate to the main form
                        MessageBox.Show("Welcome to Hospital Management System");
                        Deneme frm = new Deneme("Doctor"); // Pass the role to the main form
                        frm.Show(); // Show the main form
                        this.Hide(); // Hide the login form
                    }
                    else
                    {
                        // If the credentials are incorrect, display an error message
                        MessageBox.Show("Identity Number or Password is wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "Nurse":
                    // Check if the entered identity number and password match a nurse record in the database
                    var nurse = db.TblNurse.FirstOrDefault(n => n.NurseIdentityNumber == identity && n.NursePassword == password);
                    if (nurse != null)
                    {
                        // If nurse credentials are correct, show success message and open the main form with nurse privileges
                        MessageBox.Show("Welcome To Hospital Management System");
                        Deneme frm = new Deneme("Nurse");
                        frm.Show();
                        this.Hide(); // Hide the login form
                    }
                    else
                    {
                        // If credentials are incorrect, show an error message
                        MessageBox.Show("Identity Number or Password is wrong");
                    }
                    break;

                case "Recepti":
                    // Check if the entered identity number and password match a receptionist record in the database
                    var receptionist = db.TblReceptionist.FirstOrDefault(r => r.ReceptionistIdentityNumber == identity && r.ReceptionistPassword == password);
                    if (receptionist != null)
                    {
                        // If receptionist credentials are correct, show success message and open the main form with receptionist privileges
                        MessageBox.Show("Welcome To Hospital Management System");
                        Deneme frm = new Deneme("Receptionist");
                        frm.Show();
                        this.Hide(); // Hide the login form
                    }
                    else
                    {
                        // If credentials are incorrect, show an error message
                        MessageBox.Show("Identity Number or Password is wrong");
                    }
                    break;

                default:
                    // If the selected title does not match any case, show a warning message
                    MessageBox.Show("Please Choose Your Title and Enter");
                    break;
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
            else if(selected_item == "Nurse")
            {
                MessageBox.Show("Seleceted Nurse Title");
            }
            else
            {
                MessageBox.Show("Selected Receptionist Title");            }
            }
    }
}

