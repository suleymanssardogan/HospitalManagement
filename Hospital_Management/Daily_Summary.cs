using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Library for entity framework
using Hospital_Management.Models;
using System.Data.Entity;

//Library for pdf converter
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Hospital_Management
{
    public partial class Daily_Summary : Form
    {
        public Daily_Summary()
        {
            InitializeComponent();
        }
        //I created entity
        DbHospitalEntities1 db = new DbHospitalEntities1();

        private void Daily_Summary_Load(object sender, EventArgs e)
        {
            //Lazy sütunlardan kaçınmak istiyorum
            //db.Configuration.LazyLoadingEnabled = false;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            //  I show patient info and doctor info
            var appointments = db.Appointments
            .Include(a => a.TblPatient)  
            .Include(a => a.TblDoctor)  
            .Select(a => new
            {
                AppointmentID = a.AppoinmentID,
                PatientName = a.TblPatient.FirstName + " " + a.TblPatient.LastName,
                DoctorName = a.TblDoctor.FirstName + " " + a.TblDoctor.LastName,
                AppointmentDate = a.AppointmentDate,
                PatientMote = a.TblPatient.Notes,
                
                
            })
            .ToList();


            gridControl1.DataSource = appointments;



        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            /// gridControl1.ExportToPdf(@"E:\INDIRILENLER\Appointments.Pdf");
            string folderPath = @"E:\INDIRILENLER\AppointmentsPDFs";

            // Klasör var mı kontrol et, yoksa oluştur
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            // Dosya ismi oluştur (tarih ve saat ekleyerek)
            string fileName = $"Appointments_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
            string fullPath = Path.Combine(folderPath, fileName);

            // PDF'i belirtilen klasöre kaydet
            gridControl1.ExportToPdf(fullPath);

            MessageBox.Show($"PDF Saved and Created succesfully: {fullPath}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
          
                
        }
    }

