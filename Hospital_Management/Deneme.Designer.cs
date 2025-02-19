namespace Hospital_Management
{
    partial class Deneme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deneme));
            this.label1 = new System.Windows.Forms.Label();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barbtnHome = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnDoctors = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnNurses = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnReceptionist = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnPatients = new DevExpress.XtraBars.BarButtonItem();
            this.batbtnDailySummary = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnRadiologyImages = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnMailing = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnStatics = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnHospitalAdress = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnCreateAppoinment = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup12 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barbtnLoad = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1086, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 900);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1889, 33);
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.barbtnHome,
            this.barbtnDoctors,
            this.barbtnNurses,
            this.barbtnReceptionist,
            this.barbtnPatients,
            this.batbtnDailySummary,
            this.barbtnRadiologyImages,
            this.barbtnMailing,
            this.barbtnStatics,
            this.barbtnHospitalAdress,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barbtnCreateAppoinment,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barbtnLoad});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 21;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1889, 183);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barbtnHome
            // 
            this.barbtnHome.Caption = "Home";
            this.barbtnHome.Id = 1;
            this.barbtnHome.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtnHome.ImageOptions.Image")));
            this.barbtnHome.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtnHome.ImageOptions.LargeImage")));
            this.barbtnHome.Name = "barbtnHome";
            // 
            // barbtnDoctors
            // 
            this.barbtnDoctors.Caption = "Doctors";
            this.barbtnDoctors.Id = 2;
            this.barbtnDoctors.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtnDoctors.ImageOptions.Image")));
            this.barbtnDoctors.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtnDoctors.ImageOptions.LargeImage")));
            this.barbtnDoctors.Name = "barbtnDoctors";
            this.barbtnDoctors.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnDoctors_ItemClick);
            // 
            // barbtnNurses
            // 
            this.barbtnNurses.Caption = "Nurses";
            this.barbtnNurses.Id = 3;
            this.barbtnNurses.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtnNurses.ImageOptions.Image")));
            this.barbtnNurses.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtnNurses.ImageOptions.LargeImage")));
            this.barbtnNurses.Name = "barbtnNurses";
            this.barbtnNurses.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnNurses_ItemClick);
            // 
            // barbtnReceptionist
            // 
            this.barbtnReceptionist.Caption = "Receptionists";
            this.barbtnReceptionist.Id = 4;
            this.barbtnReceptionist.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtnReceptionist.ImageOptions.Image")));
            this.barbtnReceptionist.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtnReceptionist.ImageOptions.LargeImage")));
            this.barbtnReceptionist.Name = "barbtnReceptionist";
            this.barbtnReceptionist.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnReceptionist_ItemClick);
            // 
            // barbtnPatients
            // 
            this.barbtnPatients.Caption = "Patients";
            this.barbtnPatients.Id = 5;
            this.barbtnPatients.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtnPatients.ImageOptions.Image")));
            this.barbtnPatients.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtnPatients.ImageOptions.LargeImage")));
            this.barbtnPatients.Name = "barbtnPatients";
            this.barbtnPatients.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnPatients_ItemClick);
            // 
            // batbtnDailySummary
            // 
            this.batbtnDailySummary.Caption = "Daily Summary";
            this.batbtnDailySummary.Id = 7;
            this.batbtnDailySummary.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("batbtnDailySummary.ImageOptions.Image")));
            this.batbtnDailySummary.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("batbtnDailySummary.ImageOptions.LargeImage")));
            this.batbtnDailySummary.Name = "batbtnDailySummary";
            this.batbtnDailySummary.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.batbtnDailySummary_ItemClick);
            // 
            // barbtnRadiologyImages
            // 
            this.barbtnRadiologyImages.Caption = "Radiogly Images";
            this.barbtnRadiologyImages.Id = 8;
            this.barbtnRadiologyImages.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barbtnRadiologyImages.ImageOptions.SvgImage")));
            this.barbtnRadiologyImages.Name = "barbtnRadiologyImages";
            this.barbtnRadiologyImages.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnRadiologyImages_ItemClick);
            // 
            // barbtnMailing
            // 
            this.barbtnMailing.Caption = "Mailing";
            this.barbtnMailing.Id = 9;
            this.barbtnMailing.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtnMailing.ImageOptions.Image")));
            this.barbtnMailing.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtnMailing.ImageOptions.LargeImage")));
            this.barbtnMailing.Name = "barbtnMailing";
            this.barbtnMailing.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnMailing_ItemClick);
            // 
            // barbtnStatics
            // 
            this.barbtnStatics.Caption = "Statics";
            this.barbtnStatics.Id = 10;
            this.barbtnStatics.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barbtnStatics.ImageOptions.SvgImage")));
            this.barbtnStatics.Name = "barbtnStatics";
            this.barbtnStatics.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnStatics_ItemClick);
            // 
            // barbtnHospitalAdress
            // 
            this.barbtnHospitalAdress.Caption = "Hospital Adress";
            this.barbtnHospitalAdress.Id = 11;
            this.barbtnHospitalAdress.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtnHospitalAdress.ImageOptions.Image")));
            this.barbtnHospitalAdress.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtnHospitalAdress.ImageOptions.LargeImage")));
            this.barbtnHospitalAdress.Name = "barbtnHospitalAdress";
            this.barbtnHospitalAdress.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnHospitalAdress_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 12;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Appointment";
            this.barButtonItem2.Id = 13;
            this.barButtonItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Create Appointment";
            this.barButtonItem3.Id = 14;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Create Appoinment";
            this.barButtonItem4.Id = 15;
            this.barButtonItem4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem4.ImageOptions.SvgImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barbtnCreateAppoinment
            // 
            this.barbtnCreateAppoinment.Caption = "Create Appointment";
            this.barbtnCreateAppoinment.Id = 16;
            this.barbtnCreateAppoinment.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barbtnCreateAppoinment.ImageOptions.SvgImage")));
            this.barbtnCreateAppoinment.Name = "barbtnCreateAppoinment";
            this.barbtnCreateAppoinment.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnCreateAppoinment_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "barButtonItem5";
            this.barButtonItem5.Id = 18;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "barButtonItem6";
            this.barButtonItem6.Id = 19;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6,
            this.ribbonPageGroup7,
            this.ribbonPageGroup8,
            this.ribbonPageGroup9,
            this.ribbonPageGroup10,
            this.ribbonPageGroup12,
            this.ribbonPageGroup11});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Main Control";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barbtnHome);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barbtnDoctors);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barbtnNurses);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barbtnReceptionist);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barbtnPatients);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageGroup6.ImageOptions.Image")));
            this.ribbonPageGroup6.ItemLinks.Add(this.batbtnDailySummary);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.barbtnRadiologyImages);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.barbtnMailing);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ItemLinks.Add(this.barbtnStatics);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            // 
            // ribbonPageGroup10
            // 
            this.ribbonPageGroup10.ItemLinks.Add(this.barbtnHospitalAdress);
            this.ribbonPageGroup10.Name = "ribbonPageGroup10";
            // 
            // ribbonPageGroup12
            // 
            this.ribbonPageGroup12.ItemLinks.Add(this.barbtnCreateAppoinment);
            this.ribbonPageGroup12.Name = "ribbonPageGroup12";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ribbonPageGroup11
            // 
            this.ribbonPageGroup11.ItemLinks.Add(this.barbtnLoad);
            this.ribbonPageGroup11.Name = "ribbonPageGroup11";
            // 
            // barbtnLoad
            // 
            this.barbtnLoad.Caption = "Load Image";
            this.barbtnLoad.Id = 20;
            this.barbtnLoad.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barbtnLoad.ImageOptions.SvgImage")));
            this.barbtnLoad.Name = "barbtnLoad";
            this.barbtnLoad.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem7_ItemClick);
            // 
            // Deneme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1889, 933);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "Deneme";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Deneme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarButtonItem barbtnHome;
        private DevExpress.XtraBars.BarButtonItem barbtnDoctors;
        private DevExpress.XtraBars.BarButtonItem barbtnNurses;
        private DevExpress.XtraBars.BarButtonItem barbtnReceptionist;
        private DevExpress.XtraBars.BarButtonItem barbtnPatients;
        private DevExpress.XtraBars.BarButtonItem batbtnDailySummary;
        private DevExpress.XtraBars.BarButtonItem barbtnRadiologyImages;
        private DevExpress.XtraBars.BarButtonItem barbtnMailing;
        private DevExpress.XtraBars.BarButtonItem barbtnStatics;
        private DevExpress.XtraBars.BarButtonItem barbtnHospitalAdress;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barbtnCreateAppoinment;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup12;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barbtnLoad;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
    }
}