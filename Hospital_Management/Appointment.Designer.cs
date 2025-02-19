namespace Hospital_Management
{
    partial class Appointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appointment));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbboxPatients = new System.Windows.Forms.ComboBox();
            this.cbboxDoctorSpecialization = new System.Windows.Forms.ComboBox();
            this.cbboxDoctors = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.btnCreateAppoinment = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(155, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Patients:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(731, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doctor Specialization:";
            // 
            // cbboxPatients
            // 
            this.cbboxPatients.FormattingEnabled = true;
            this.cbboxPatients.Location = new System.Drawing.Point(12, 70);
            this.cbboxPatients.Name = "cbboxPatients";
            this.cbboxPatients.Size = new System.Drawing.Size(459, 24);
            this.cbboxPatients.TabIndex = 5;
            this.cbboxPatients.SelectedIndexChanged += new System.EventHandler(this.cbboxPatients_SelectedIndexChanged);
            // 
            // cbboxDoctorSpecialization
            // 
            this.cbboxDoctorSpecialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbboxDoctorSpecialization.FormattingEnabled = true;
            this.cbboxDoctorSpecialization.Location = new System.Drawing.Point(736, 70);
            this.cbboxDoctorSpecialization.Name = "cbboxDoctorSpecialization";
            this.cbboxDoctorSpecialization.Size = new System.Drawing.Size(195, 30);
            this.cbboxDoctorSpecialization.TabIndex = 6;
            // 
            // cbboxDoctors
            // 
            this.cbboxDoctors.FormattingEnabled = true;
            this.cbboxDoctors.Location = new System.Drawing.Point(995, 76);
            this.cbboxDoctors.Name = "cbboxDoctors";
            this.cbboxDoctors.Size = new System.Drawing.Size(459, 24);
            this.cbboxDoctors.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(990, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Doctors:";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(23, 332);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(308, 268);
            this.guna2PictureBox1.TabIndex = 13;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.ImageOptions.Image")));
            this.btnSearch.Location = new System.Drawing.Point(1149, 284);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(244, 93);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // btnCreateAppoinment
            // 
            this.btnCreateAppoinment.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCreateAppoinment.ImageOptions.SvgImage")));
            this.btnCreateAppoinment.Location = new System.Drawing.Point(1149, 422);
            this.btnCreateAppoinment.Name = "btnCreateAppoinment";
            this.btnCreateAppoinment.Size = new System.Drawing.Size(244, 93);
            this.btnCreateAppoinment.TabIndex = 15;
            this.btnCreateAppoinment.Text = "Create Appoinment";
            this.btnCreateAppoinment.Click += new System.EventHandler(this.btnCreateAppoinment_Click_1);
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(146)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(1569, 739);
            this.Controls.Add(this.btnCreateAppoinment);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbboxDoctors);
            this.Controls.Add(this.cbboxDoctorSpecialization);
            this.Controls.Add(this.cbboxPatients);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Appointment";
            this.Text = "Appointment";
            this.Load += new System.EventHandler(this.Appointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbboxPatients;
        private System.Windows.Forms.ComboBox cbboxDoctorSpecialization;
        private System.Windows.Forms.ComboBox cbboxDoctors;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.SimpleButton btnCreateAppoinment;
    }
}