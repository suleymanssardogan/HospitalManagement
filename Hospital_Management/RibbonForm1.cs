using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;


namespace Hospital_Management
{
    public partial class RibbonForm1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        Doctors frmDoctor ;
        Nurse frmNurse;
        HospitalAdress frmadress;
        Patients patients;
        Statics statics;
        RadiologyImagesForm radio;
        E_Mail mail;
        Daily_Summary summary;
        Appointment app;
        Receptionist recep;
         
        public RibbonForm1()
        {
            InitializeComponent();
        }

        private void barbtnDoctors_ItemClick(object sender, ItemClickEventArgs e)
        {
            //I show my mdi form

           

            if(frmDoctor ==null || frmDoctor.IsDisposed)
            {
                frmDoctor = new Doctors();
                frmDoctor.MdiParent = this;
                frmDoctor.Show();
               
            }
        }
        

        private void barbtnNurses_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(frmNurse == null || frmNurse.IsDisposed)
            {
                frmNurse = new Nurse();
                frmNurse.MdiParent = this;
                frmNurse.Show();
            }

        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
           if(app == null || app.IsDisposed)
            {
                app = new Appointment();
                app.MdiParent = this;
                app.Show();
            }
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(frmadress == null || frmadress.IsDisposed)
            {
                frmadress = new HospitalAdress();
                frmadress.MdiParent = this;
                frmadress.Show();
            }
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            radio = new RadiologyImagesForm();
            radio.MdiParent = this;
            radio.Show();
        }

        private void barbtnPatients_ItemClick(object sender, ItemClickEventArgs e)
        {
            Patients frm = new Patients();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            E_Mail frm = new E_Mail();
            frm.MdiParent = this;
            frm.Show();
        }

        private void RibbonForm1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            Statics frm = new Statics();
            frm.MdiParent = this;
            frm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            Daily_Summary frm = new Daily_Summary();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barbtnReceptionist_ItemClick(object sender, ItemClickEventArgs e)
        {
            Receptionist recep = new Receptionist();
            recep.MdiParent = this;
            recep.Show();
        }
    }
}