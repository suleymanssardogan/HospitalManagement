using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Library for entites
using Hospital_Management.Models;
using System.Data.Entity;

namespace Hospital_Management
{
    public partial class Appointment : Form
    {
        //Data Source=DESKTOP-FM1C057\SQLEXPRESS;Initial Catalog=DbHospital;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework

        //I created entity
        DbHospitalEntities1 db = new DbHospitalEntities1();

        public Appointment()
        {
            InitializeComponent();
        }

        private void Appointment_Load(object sender, EventArgs e)
        {
            //ı call function about patient
            LoadPatient();
            //I addded all specialization to combobox
            cbboxDoctorSpecialization.Items.Add("Cardiology");       
            cbboxDoctorSpecialization.Items.Add("Dermatology");    
            cbboxDoctorSpecialization.Items.Add("Orthopedics");    
            cbboxDoctorSpecialization.Items.Add("Neurology");       
            cbboxDoctorSpecialization.Items.Add("Pediatrics");      
            cbboxDoctorSpecialization.Items.Add("Gynecology");     
            cbboxDoctorSpecialization.Items.Add("Urology");         
            cbboxDoctorSpecialization.Items.Add("Gastroenterology");
            cbboxDoctorSpecialization.Items.Add("Endocrinology");   
            cbboxDoctorSpecialization.Items.Add("Hematology");     
            cbboxDoctorSpecialization.Items.Add("Ophthalmology");  
            cbboxDoctorSpecialization.Items.Add("Psychiatry");      
            cbboxDoctorSpecialization.Items.Add("Oncology");
            cbboxDoctorSpecialization.Items.Add("Pulmonology");    
            cbboxDoctorSpecialization.Items.Add("Nephrology");     
            cbboxDoctorSpecialization.Items.Add("Rheumatology");    
            cbboxDoctorSpecialization.Items.Add("Otorhinolaryngology"); 
            cbboxDoctorSpecialization.Items.Add("Allergy");        
            cbboxDoctorSpecialization.Items.Add("Infectious Diseases");



        }


        private void LoadPatient()
        {
            //Take patietns from database
            var patietns = db.TblPatient.ToList();

            //Clear combobox
            cbboxPatients.Items.Clear();

            foreach(var patient in patietns)
            {
                cbboxPatients.Items.Add(new
                {
                    PatientName = patient.FirstName + " " + patient.LastName,
                    PatientID = patient.PatientID
                });
            }

            //ıf there is any patietns select first
            if (cbboxPatients.Items.Count > 0)
            {
                cbboxPatients.SelectedIndex = 0;
            }

            else
            {
                MessageBox.Show("Could NOT FOUND PATİENT");
            }

            cbboxPatients.DisplayMember = "PatientName";
            cbboxPatients.ValueMember = "PatietnID";


        }
        
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string selected_specialization;
            try
            {
                //I take choosen specialaztions
                selected_specialization = cbboxDoctorSpecialization.SelectedItem.ToString();



                // I wanna see just available doctors and matched specialization doctors
                var doctors = db.TblDoctor.Where(d => d.Department == selected_specialization && d.Status == "Available").ToList();


                //the first show ı wanna see empty box
                cbboxDoctors.Items.Clear();


                //I add doctor with forach loop
                foreach (var doctor in doctors)
                {
                    cbboxDoctors.Items.Add(new
                    {
                        DoctorName = doctor.FirstName + " " + doctor.LastName,
                        DoctorID = doctor.DoctorID
                    });
                }

                //I controlled doctor found or not found

                if (cbboxDoctors.Items.Count > 0)
                {
                    cbboxDoctors.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Could Not Found Available Doctors About Choose Specialization");
                }

                cbboxDoctors.DisplayMember = "DoctorText";
                cbboxDoctors.ValueMember = "DoctorID";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error{ex.Message}");
            }

        }

        private void btnCreateAppoinment_Click_1(object sender, EventArgs e)
        {
            /*  DateTime appointmentDate;
              //Choosen patient and doctor
              var selected_patient = cbboxPatients.SelectedItem as dynamic;
              var selected_doctor = cbboxDoctors.SelectedItem as dynamic;

              if (selected_patient != null && selected_doctor != null)
              {
                  int patientID = selected_patient.PatientID;
                  int doctorID = selected_doctor.DoctorID;

                  // Check if the patient has already taken an appointment
                  var appointment = db.Appointments.FirstOrDefault(a => a.PatientID == patientID);

                  if (appointment != null)
                  {
                      MessageBox.Show("This Patient HAS TAKEN AN APPOINTMENT, CAN NOT SELECT ANOTHER DOCTOR");
                  }
                  else
                  {
                      // Get the AdmissionDate from TblPatient table
                      var patient = db.TblPatient.FirstOrDefault(p => p.PatientID == patientID);
                      if (patient != null)
                      {
                          // Convert AdmissionDate to DateTime type
                          if (DateTime.TryParse(patient.AdmissionDate.ToString(), out appointmentDate))
                          {
                              // If conversion is successful, use the AdmissionDate value
                          }
                          else
                          {
                              // If conversion fails, use the current date as the appointment date
                              appointmentDate = DateTime.Now;
                          }

                          // Update the patient's DoctorID (since the patient is now assigned to this doctor)
                          patient.DoctorID = doctorID;
                          db.SaveChanges(); // Save the patient update to the database
                      }
                      else
                      {
                          // If patient not found, set appointmentDate to current date
                          appointmentDate = DateTime.Now;
                      }

                      // Create new appointment
                      var newAppointment = new Appointments
                      {
                          PatientID = patientID,
                          DoctorID = doctorID,
                          AppointmentDate = appointmentDate
                      };

                      // Add the new appointment to the database
                      db.Appointments.Add(newAppointment);
                      db.SaveChanges();
                      MessageBox.Show("Appointment Created Successfully");
                  }
              }
              else
              {
                  MessageBox.Show("Please select both a patient and a doctor.");
              }*/
            DateTime appointmentDate;
            // Seçilen hasta ve doktor
            var selected_patient = cbboxPatients.SelectedItem as dynamic;
            var selected_doctor = cbboxDoctors.SelectedItem as dynamic;

            if (selected_patient != null && selected_doctor != null)
            {
                int patientID = selected_patient.PatientID;
                int doctorID = selected_doctor.DoctorID;

                try
                {
                    // Kullanıcıdan alınan tarih (örneğin bir DatePicker kontrolünden)
                  
                    
                        appointmentDate = DateTime.Now; // Eğer tarih alınamazsa varsayılan olarak bugünün tarihi kullanılır.
                    

                    // Hasta aynı doktorla aynı tarihte bir randevu almış mı kontrolü
                    var appointment = db.Appointments.FirstOrDefault(a =>
                        a.PatientID == patientID &&
                        a.DoctorID == doctorID &&
                        DbFunctions.TruncateTime(a.AppointmentDate) == DbFunctions.TruncateTime(appointmentDate));

                    if (appointment != null)
                    {
                        MessageBox.Show("This Patient has already taken an appointment with this doctor on the same date.");
                    }
                    else
                    {
                        // Yeni randevu oluştur
                        var newAppointment = new Appointments
                        {
                            PatientID = patientID,
                            DoctorID = doctorID,
                            AppointmentDate = appointmentDate,
                            //Notes = txtNotes.Text, // Kullanıcıdan alınan notlar (varsa)
                            Status = "Scheduled"  // Varsayılan durum
                        };

                        db.Appointments.Add(newAppointment);
                        db.SaveChanges();

                        MessageBox.Show("Appointment Created Successfully");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please select both a patient and a doctor.");
            }

        }

        private void cbboxPatients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
