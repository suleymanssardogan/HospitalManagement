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
    public partial class Deneme : Form
    {
        Doctors frmDoctor;
        Nurse frmNurse;
        Patients frmpatietns;
        Receptionist frmreceptionist;
        Daily_Summary frmdaily_summary;
        RadiologyImagesForm frmradiologyımages;
        E_Mail frmmail;
        Statics frmstatics;
        HospitalAdress frmadress;
        Appointment frmappointment;
        Load frmLoad;


        private string userRole;

        public Deneme(string role)
        {
            InitializeComponent();
            //Taken role info
            userRole = role; 
        }

        private void Deneme_Load(object sender, EventArgs e)
        {
            //Start timer
            timer1.Start();

            //I have done false all butons
            barbtnCreateAppoinment.Enabled = false;
            barbtnDoctors.Enabled = false;
            barbtnHome.Enabled = false;
            barbtnHospitalAdress.Enabled = false;
            barbtnMailing.Enabled = false;
            barbtnNurses.Enabled = false;
            barbtnPatients.Enabled = false;
            barbtnRadiologyImages.Enabled = false;
            barbtnReceptionist.Enabled = false;
            barbtnStatics.Enabled = false;
            batbtnDailySummary.Enabled = false;


            switch (userRole)
            {
                case "Admin":
                    // Admin can access all buttons
                    barbtnCreateAppoinment.Enabled = true; // Enable Create Appointment button
                    barbtnDoctors.Enabled = true; // Enable Doctors button
                    barbtnHome.Enabled = true; // Enable Home button
                    barbtnHospitalAdress.Enabled = true; // Enable Hospital Address button
                    barbtnMailing.Enabled = true; // Enable Mailing button
                    barbtnNurses.Enabled = true; // Enable Nurses button
                    barbtnPatients.Enabled = true; // Enable Patients button
                    barbtnRadiologyImages.Enabled = true; // Enable Radiology Images button
                    barbtnReceptionist.Enabled = true; // Enable Receptionist button
                    barbtnStatics.Enabled = true; // Enable Statistics button
                    batbtnDailySummary.Enabled = true; // Enable Daily Summary button
                    break;

                case "Doctor":
                    // Doctor can access specific buttons
                    barbtnMailing.Enabled = true; // Enable Mailing button+2
                    barbtnStatics.Enabled = true; // Enable Statistics button
                    batbtnDailySummary.Enabled = true; // Enable Daily Summary button
                    barbtnRadiologyImages.Enabled = true; // Enable Radiology Images button
                    barbtnPatients.Enabled = true; // Enable Patients button
                    barbtnHospitalAdress.Enabled = true; // Enable Hospital Address button
                    barbtnCreateAppoinment.Enabled = true; // Enable Create Appointment button
                    break;

                case "Nurse":
                    // Nurse can access specific buttons
                    barbtnMailing.Enabled = true; // Enable Mailing button
                    barbtnStatics.Enabled = true; // Enable Statistics button
                    batbtnDailySummary.Enabled = true; // Enable Daily Summary button
                    barbtnCreateAppoinment.Enabled = true; // Enable Create Appointment button
                    barbtnRadiologyImages.Enabled = true; // Enable Radiology Images button
                    barbtnHospitalAdress.Enabled = true; // Enable Hospital Address button
                    break;

                case "Receptionist":
                    // Receptionist can access specific buttons
                    barbtnMailing.Enabled = true; // Enable Mailing button
                    barbtnStatics.Enabled = true; // Enable Statistics button
                    batbtnDailySummary.Enabled = true; // Enable Daily Summary button
                    barbtnPatients.Enabled = true; // Enable Patients button
                    barbtnCreateAppoinment.Enabled = true; // Enable Create Appointment button
                    barbtnNurses.Enabled = true;
                    barbtnReceptionist.Enabled = true;
                    barbtnHospitalAdress.Enabled = true; // Enable Hospital Address button
                    barbtnDoctors.Enabled = true; // Enable Doctors button
                    break;

                default:
                    // In case of an invalid role, disable all buttons
                    MessageBox.Show("Invalid role detected. Please contact system administrator."); // Show an error message
                    break;
            }


        }

        private void barbtnDoctors_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (frmDoctor == null || frmDoctor.IsDisposed)
            {
                frmDoctor = new Doctors();
                frmDoctor.MdiParent = this;
                frmDoctor.Show();

            }
        }

        private void barbtnNurses_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frmNurse == null || frmNurse.IsDisposed)
            {
                frmNurse = new Nurse();
                frmNurse.MdiParent = this;
                frmNurse.Show();
            }
        }

        private void barbtnReceptionist_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (frmreceptionist == null || frmNurse.IsDisposed)
                {
                    frmreceptionist = new Receptionist();
                    frmreceptionist.MdiParent = this;
                    frmreceptionist.Show();
                }
            }catch(Exception ex)
            {
                MessageBox.Show($"Errror{ex.Message}");
            }
        }

        private void barbtnPatients_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frmpatietns ==null || frmpatietns.IsDisposed)
            {
                frmpatietns = new Patients();
                frmpatietns.MdiParent = this;
                frmpatietns.Show();
            }
        }

        private void batbtnDailySummary_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frmdaily_summary == null || frmdaily_summary.IsDisposed)
            {
                frmdaily_summary = new Daily_Summary();
                frmdaily_summary.MdiParent = this;
                frmdaily_summary.Show();
            }
        }

        private void barbtnRadiologyImages_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frmradiologyımages == null|| frmradiologyımages.IsDisposed)
            {
                frmradiologyımages = new RadiologyImagesForm();
                frmradiologyımages.MdiParent = this;
                frmradiologyımages.Show();
            }
        }

        private void barbtnMailing_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frmmail==null || frmmail.IsDisposed)
            {
                frmmail = new E_Mail();
                frmmail.MdiParent = this;
                frmmail.Show();
            }
        }

        private void barbtnStatics_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frmstatics == null || frmstatics.IsDisposed)
            {
                frmstatics = new Statics();
                frmstatics.MdiParent = this;
                frmstatics.Show();
            }
        }

        private void barbtnHospitalAdress_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frmadress ==null || frmadress.IsDisposed)
            {
                frmadress = new HospitalAdress();
                frmadress.MdiParent = this;
                frmadress.Show();

            }
        }

        private void barbtnCreateAppoinment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frmappointment ==null || frmappointment.IsDisposed)
            {
                frmappointment = new Appointment();
                frmappointment.MdiParent = this;
                frmappointment.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frmLoad == null || frmLoad.IsDisposed)
            {
                frmLoad = new Load();
                frmLoad.MdiParent = this;
                frmLoad.Show();
            }
        }
    }
}
