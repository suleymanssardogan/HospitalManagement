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
//Library for charcontrol
using DevExpress.XtraCharts;

namespace Hospital_Management
{
    public partial class Statics : Form
    {
        public Statics()
        {
            InitializeComponent();
        }
        DbHospitalEntities1 db = new DbHospitalEntities1();
        private void Statics_Load(object sender, EventArgs e)
        {
            //I take countes from my sql
            int doctorCount = db.TblDoctor.Count();
            int nurseCount = db.TblNurse.Count();
            int patietnCount = db.TblPatient.Count();
            int receptionistCount = db.TblReceptionist.Count();

            //I create bar's name
            Series series = new Series("Person Counts", ViewType.Bar);
            series.Points.Add(new SeriesPoint("Doctor", doctorCount));
            series.Points.Add(new SeriesPoint("Nurse", nurseCount));
            series.Points.Add(new SeriesPoint("Patient", patietnCount));
            series.Points.Add(new SeriesPoint("Receptionist", receptionistCount));

            chartControl1.Series.Clear();
            chartControl1.Series.Add(series);




            //This are for  Pie grafic, I have done grafic config,setup,update adn clear
            var doctorData = db.TblDoctor.Select(d => new { d.FirstName, d.Salary }).ToList();

            chartControl2.Series.Clear();
            Series seriesPie = new Series("Doctors' Salaries", ViewType.Pie);

            foreach (var doctor in doctorData)
            {
                seriesPie.Points.Add(new SeriesPoint(doctor.FirstName, doctor.Salary));
            }

            PieSeriesLabel pieLabel = seriesPie.Label as PieSeriesLabel;
            if (pieLabel != null)
            {
                pieLabel.TextPattern = "{A}: {VP:P1}";
            }

            PieSeriesView pieView = seriesPie.View as PieSeriesView;
            if (pieView != null)
            {
                pieView.Titles.Add(new SeriesTitle());
                pieView.Titles[0].Text = "Salary Distribution";
            }

            chartControl2.Series.Add(seriesPie);

            ChartTitle pieChartTitle = new ChartTitle();
            pieChartTitle.Text = "Doctors' Salary Distribution";
            chartControl2.Titles.Clear();
            chartControl2.Titles.Add(pieChartTitle);
        }
    }
}
