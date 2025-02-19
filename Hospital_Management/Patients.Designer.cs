namespace Hospital_Management
{
    partial class Patients
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
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tabPagePersonalInfo = new DevExpress.XtraTab.XtraTabPage();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.txtPatientHeight = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPatientWeight = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnNext0 = new Guna.UI2.WinForms.Guna2Button();
            this.cbbopatientGender = new System.Windows.Forms.ComboBox();
            this.txtPatientLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPatientFirstNmae = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPatientIdentityNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tabPageContactInfo = new DevExpress.XtraTab.XtraTabPage();
            this.txtPatientMail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPatientAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textEditPhoneNumber = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack0 = new Guna.UI2.WinForms.Guna2Button();
            this.btnNext1 = new Guna.UI2.WinForms.Guna2Button();
            this.tabPageHealtInfo = new DevExpress.XtraTab.XtraTabPage();
            this.dateEditDischargeDate = new DevExpress.XtraEditors.DateEdit();
            this.dateEditAdmissionDate = new DevExpress.XtraEditors.DateEdit();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.txtNotes = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbboxStatus = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cbboxBloodType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBack1 = new Guna.UI2.WinForms.Guna2Button();
            this.tabPageDataControl = new DevExpress.XtraTab.XtraTabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSearchIdentityNUnber = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.btnList = new Guna.UI2.WinForms.Guna2Button();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tabPagePersonalInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            this.tabPageContactInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPhoneNumber.Properties)).BeginInit();
            this.tabPageHealtInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDischargeDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDischargeDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditAdmissionDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditAdmissionDate.Properties)).BeginInit();
            this.tabPageDataControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.tabPagePersonalInfo;
            this.xtraTabControl1.Size = new System.Drawing.Size(1784, 699);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPagePersonalInfo,
            this.tabPageContactInfo,
            this.tabPageHealtInfo,
            this.tabPageDataControl});
            this.xtraTabControl1.Click += new System.EventHandler(this.xtraTabControl1_Click);
            // 
            // tabPagePersonalInfo
            // 
            this.tabPagePersonalInfo.Appearance.PageClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tabPagePersonalInfo.Appearance.PageClient.Options.UseBackColor = true;
            this.tabPagePersonalInfo.Controls.Add(this.dateEdit1);
            this.tabPagePersonalInfo.Controls.Add(this.txtPatientHeight);
            this.tabPagePersonalInfo.Controls.Add(this.txtPatientWeight);
            this.tabPagePersonalInfo.Controls.Add(this.labelControl8);
            this.tabPagePersonalInfo.Controls.Add(this.labelControl7);
            this.tabPagePersonalInfo.Controls.Add(this.btnNext0);
            this.tabPagePersonalInfo.Controls.Add(this.cbbopatientGender);
            this.tabPagePersonalInfo.Controls.Add(this.txtPatientLastName);
            this.tabPagePersonalInfo.Controls.Add(this.txtPatientFirstNmae);
            this.tabPagePersonalInfo.Controls.Add(this.txtPatientIdentityNumber);
            this.tabPagePersonalInfo.Controls.Add(this.labelControl5);
            this.tabPagePersonalInfo.Controls.Add(this.labelControl4);
            this.tabPagePersonalInfo.Controls.Add(this.labelControl3);
            this.tabPagePersonalInfo.Controls.Add(this.labelControl2);
            this.tabPagePersonalInfo.Controls.Add(this.labelControl1);
            this.tabPagePersonalInfo.Name = "tabPagePersonalInfo";
            this.tabPagePersonalInfo.Size = new System.Drawing.Size(1782, 669);
            this.tabPagePersonalInfo.Text = "Personal Information";
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(246, 277);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(229, 22);
            this.dateEdit1.TabIndex = 20;
            // 
            // txtPatientHeight
            // 
            this.txtPatientHeight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPatientHeight.DefaultText = "";
            this.txtPatientHeight.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPatientHeight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPatientHeight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPatientHeight.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPatientHeight.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPatientHeight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPatientHeight.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPatientHeight.Location = new System.Drawing.Point(817, 123);
            this.txtPatientHeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPatientHeight.Name = "txtPatientHeight";
            this.txtPatientHeight.PasswordChar = '\0';
            this.txtPatientHeight.PlaceholderText = "";
            this.txtPatientHeight.SelectedText = "";
            this.txtPatientHeight.Size = new System.Drawing.Size(229, 34);
            this.txtPatientHeight.TabIndex = 19;
            // 
            // txtPatientWeight
            // 
            this.txtPatientWeight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPatientWeight.DefaultText = "";
            this.txtPatientWeight.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPatientWeight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPatientWeight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPatientWeight.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPatientWeight.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPatientWeight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPatientWeight.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPatientWeight.Location = new System.Drawing.Point(817, 55);
            this.txtPatientWeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPatientWeight.Name = "txtPatientWeight";
            this.txtPatientWeight.PasswordChar = '\0';
            this.txtPatientWeight.PlaceholderText = "";
            this.txtPatientWeight.SelectedText = "";
            this.txtPatientWeight.Size = new System.Drawing.Size(229, 34);
            this.txtPatientWeight.TabIndex = 18;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(641, 123);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(130, 23);
            this.labelControl8.TabIndex = 17;
            this.labelControl8.Text = "Patient Height:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(641, 55);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(134, 23);
            this.labelControl7.TabIndex = 16;
            this.labelControl7.Text = "Patient Weight:";
            // 
            // btnNext0
            // 
            this.btnNext0.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext0.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext0.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext0.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext0.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNext0.ForeColor = System.Drawing.Color.White;
            this.btnNext0.Location = new System.Drawing.Point(1302, 541);
            this.btnNext0.Name = "btnNext0";
            this.btnNext0.Size = new System.Drawing.Size(180, 45);
            this.btnNext0.TabIndex = 10;
            this.btnNext0.Text = "Next";
            this.btnNext0.Click += new System.EventHandler(this.btnNext0_Click_1);
            // 
            // cbbopatientGender
            // 
            this.cbbopatientGender.FormattingEnabled = true;
            this.cbbopatientGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbbopatientGender.Location = new System.Drawing.Point(237, 353);
            this.cbbopatientGender.Name = "cbbopatientGender";
            this.cbbopatientGender.Size = new System.Drawing.Size(238, 24);
            this.cbbopatientGender.TabIndex = 9;
            // 
            // txtPatientLastName
            // 
            this.txtPatientLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPatientLastName.DefaultText = "";
            this.txtPatientLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPatientLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPatientLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPatientLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPatientLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPatientLastName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPatientLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPatientLastName.Location = new System.Drawing.Point(246, 191);
            this.txtPatientLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPatientLastName.Name = "txtPatientLastName";
            this.txtPatientLastName.PasswordChar = '\0';
            this.txtPatientLastName.PlaceholderText = "";
            this.txtPatientLastName.SelectedText = "";
            this.txtPatientLastName.Size = new System.Drawing.Size(229, 34);
            this.txtPatientLastName.TabIndex = 7;
            // 
            // txtPatientFirstNmae
            // 
            this.txtPatientFirstNmae.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPatientFirstNmae.DefaultText = "";
            this.txtPatientFirstNmae.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPatientFirstNmae.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPatientFirstNmae.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPatientFirstNmae.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPatientFirstNmae.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPatientFirstNmae.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPatientFirstNmae.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPatientFirstNmae.Location = new System.Drawing.Point(246, 123);
            this.txtPatientFirstNmae.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPatientFirstNmae.Name = "txtPatientFirstNmae";
            this.txtPatientFirstNmae.PasswordChar = '\0';
            this.txtPatientFirstNmae.PlaceholderText = "";
            this.txtPatientFirstNmae.SelectedText = "";
            this.txtPatientFirstNmae.Size = new System.Drawing.Size(229, 34);
            this.txtPatientFirstNmae.TabIndex = 6;
            // 
            // txtPatientIdentityNumber
            // 
            this.txtPatientIdentityNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPatientIdentityNumber.DefaultText = "";
            this.txtPatientIdentityNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPatientIdentityNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPatientIdentityNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPatientIdentityNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPatientIdentityNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPatientIdentityNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPatientIdentityNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPatientIdentityNumber.Location = new System.Drawing.Point(246, 44);
            this.txtPatientIdentityNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPatientIdentityNumber.Name = "txtPatientIdentityNumber";
            this.txtPatientIdentityNumber.PasswordChar = '\0';
            this.txtPatientIdentityNumber.PlaceholderText = "";
            this.txtPatientIdentityNumber.SelectedText = "";
            this.txtPatientIdentityNumber.Size = new System.Drawing.Size(229, 34);
            this.txtPatientIdentityNumber.TabIndex = 5;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(19, 354);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(137, 23);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Patient Gender:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(19, 280);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(184, 23);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Patient Date of Birth:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(19, 202);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(165, 23);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Patient Last Name:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(19, 123);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(166, 23);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Patient First Name:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(19, 55);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(211, 23);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Patient Identity Number:";
            // 
            // tabPageContactInfo
            // 
            this.tabPageContactInfo.Controls.Add(this.txtPatientMail);
            this.tabPageContactInfo.Controls.Add(this.label3);
            this.tabPageContactInfo.Controls.Add(this.txtPatientAddress);
            this.tabPageContactInfo.Controls.Add(this.label2);
            this.tabPageContactInfo.Controls.Add(this.textEditPhoneNumber);
            this.tabPageContactInfo.Controls.Add(this.label1);
            this.tabPageContactInfo.Controls.Add(this.btnBack0);
            this.tabPageContactInfo.Controls.Add(this.btnNext1);
            this.tabPageContactInfo.Name = "tabPageContactInfo";
            this.tabPageContactInfo.Size = new System.Drawing.Size(1782, 669);
            this.tabPageContactInfo.Text = "Contact Information";
            // 
            // txtPatientMail
            // 
            this.txtPatientMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPatientMail.DefaultText = "";
            this.txtPatientMail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPatientMail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPatientMail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPatientMail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPatientMail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPatientMail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPatientMail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPatientMail.Location = new System.Drawing.Point(239, 235);
            this.txtPatientMail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPatientMail.Name = "txtPatientMail";
            this.txtPatientMail.PasswordChar = '\0';
            this.txtPatientMail.PlaceholderText = "";
            this.txtPatientMail.SelectedText = "";
            this.txtPatientMail.Size = new System.Drawing.Size(229, 37);
            this.txtPatientMail.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(27, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Patient Mail:";
            // 
            // txtPatientAddress
            // 
            this.txtPatientAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPatientAddress.DefaultText = "";
            this.txtPatientAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPatientAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPatientAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPatientAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPatientAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPatientAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPatientAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPatientAddress.Location = new System.Drawing.Point(239, 147);
            this.txtPatientAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPatientAddress.Name = "txtPatientAddress";
            this.txtPatientAddress.PasswordChar = '\0';
            this.txtPatientAddress.PlaceholderText = "";
            this.txtPatientAddress.SelectedText = "";
            this.txtPatientAddress.Size = new System.Drawing.Size(229, 37);
            this.txtPatientAddress.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(17, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Patient Address:";
            // 
            // textEditPhoneNumber
            // 
            this.textEditPhoneNumber.Location = new System.Drawing.Point(239, 68);
            this.textEditPhoneNumber.Name = "textEditPhoneNumber";
            this.textEditPhoneNumber.Properties.Mask.EditMask = "(000) 000-0000";
            this.textEditPhoneNumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEditPhoneNumber.Size = new System.Drawing.Size(235, 22);
            this.textEditPhoneNumber.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Patient PhoneNumber";
            // 
            // btnBack0
            // 
            this.btnBack0.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack0.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack0.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack0.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack0.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBack0.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBack0.ForeColor = System.Drawing.Color.White;
            this.btnBack0.Location = new System.Drawing.Point(21, 531);
            this.btnBack0.Name = "btnBack0";
            this.btnBack0.Size = new System.Drawing.Size(180, 45);
            this.btnBack0.TabIndex = 3;
            this.btnBack0.Text = "Back";
            this.btnBack0.Click += new System.EventHandler(this.btnBack0_Click);
            // 
            // btnNext1
            // 
            this.btnNext1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNext1.ForeColor = System.Drawing.Color.White;
            this.btnNext1.Location = new System.Drawing.Point(1302, 531);
            this.btnNext1.Name = "btnNext1";
            this.btnNext1.Size = new System.Drawing.Size(180, 45);
            this.btnNext1.TabIndex = 2;
            this.btnNext1.Text = "Next";
            this.btnNext1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // tabPageHealtInfo
            // 
            this.tabPageHealtInfo.Controls.Add(this.dateEditDischargeDate);
            this.tabPageHealtInfo.Controls.Add(this.dateEditAdmissionDate);
            this.tabPageHealtInfo.Controls.Add(this.btnSave);
            this.tabPageHealtInfo.Controls.Add(this.txtNotes);
            this.tabPageHealtInfo.Controls.Add(this.label9);
            this.tabPageHealtInfo.Controls.Add(this.cbboxStatus);
            this.tabPageHealtInfo.Controls.Add(this.label8);
            this.tabPageHealtInfo.Controls.Add(this.label7);
            this.tabPageHealtInfo.Controls.Add(this.label6);
            this.tabPageHealtInfo.Controls.Add(this.radioButtonNo);
            this.tabPageHealtInfo.Controls.Add(this.radioButtonYes);
            this.tabPageHealtInfo.Controls.Add(this.label5);
            this.tabPageHealtInfo.Controls.Add(this.cbboxBloodType);
            this.tabPageHealtInfo.Controls.Add(this.label4);
            this.tabPageHealtInfo.Controls.Add(this.btnBack1);
            this.tabPageHealtInfo.Name = "tabPageHealtInfo";
            this.tabPageHealtInfo.Size = new System.Drawing.Size(1782, 669);
            this.tabPageHealtInfo.Text = "Health Information";
            // 
            // dateEditDischargeDate
            // 
            this.dateEditDischargeDate.EditValue = null;
            this.dateEditDischargeDate.Location = new System.Drawing.Point(317, 353);
            this.dateEditDischargeDate.Name = "dateEditDischargeDate";
            this.dateEditDischargeDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDischargeDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDischargeDate.Size = new System.Drawing.Size(207, 22);
            this.dateEditDischargeDate.TabIndex = 18;
            // 
            // dateEditAdmissionDate
            // 
            this.dateEditAdmissionDate.EditValue = null;
            this.dateEditAdmissionDate.Location = new System.Drawing.Point(317, 248);
            this.dateEditAdmissionDate.Name = "dateEditAdmissionDate";
            this.dateEditAdmissionDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditAdmissionDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditAdmissionDate.Size = new System.Drawing.Size(207, 22);
            this.dateEditAdmissionDate.TabIndex = 17;
            // 
            // btnSave
            // 
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(1293, 612);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 45);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNotes.Location = new System.Drawing.Point(696, 136);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(644, 347);
            this.txtNotes.TabIndex = 15;
            this.txtNotes.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(936, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 26);
            this.label9.TabIndex = 14;
            this.label9.Text = "Patient Notes";
            // 
            // cbboxStatus
            // 
            this.cbboxStatus.FormattingEnabled = true;
            this.cbboxStatus.Items.AddRange(new object[] {
            "Emergency",
            "OK",
            "Not Emergency"});
            this.cbboxStatus.Location = new System.Drawing.Point(317, 457);
            this.cbboxStatus.Name = "cbboxStatus";
            this.cbboxStatus.Size = new System.Drawing.Size(207, 24);
            this.cbboxStatus.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(13, 457);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 26);
            this.label8.TabIndex = 12;
            this.label8.Text = "Patient Status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(13, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(249, 26);
            this.label7.TabIndex = 9;
            this.label7.Text = "Patient Discharge Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(13, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(272, 26);
            this.label6.TabIndex = 8;
            this.label6.Text = "Patient Addmission Date:";
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Location = new System.Drawing.Point(412, 134);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(46, 21);
            this.radioButtonNo.TabIndex = 7;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "No";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.AutoSize = true;
            this.radioButtonYes.Location = new System.Drawing.Point(298, 134);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(50, 21);
            this.radioButtonYes.TabIndex = 6;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "Yes";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(13, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 26);
            this.label5.TabIndex = 3;
            this.label5.Text = "Patient Insurance:";
            // 
            // cbboxBloodType
            // 
            this.cbboxBloodType.FormattingEnabled = true;
            this.cbboxBloodType.Items.AddRange(new object[] {
            "A+",
            "B+",
            "A-",
            "B-",
            "AB+",
            "AB-",
            "0+",
            "0-"});
            this.cbboxBloodType.Location = new System.Drawing.Point(298, 43);
            this.cbboxBloodType.Name = "cbboxBloodType";
            this.cbboxBloodType.Size = new System.Drawing.Size(226, 24);
            this.cbboxBloodType.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(13, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Patient Blood Type:";
            // 
            // btnBack1
            // 
            this.btnBack1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBack1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBack1.ForeColor = System.Drawing.Color.White;
            this.btnBack1.Location = new System.Drawing.Point(3, 612);
            this.btnBack1.Name = "btnBack1";
            this.btnBack1.Size = new System.Drawing.Size(180, 45);
            this.btnBack1.TabIndex = 0;
            this.btnBack1.Text = "Back";
            this.btnBack1.Click += new System.EventHandler(this.btnBack1_Click);
            // 
            // tabPageDataControl
            // 
            this.tabPageDataControl.AllowTouchScroll = true;
            this.tabPageDataControl.AutoScroll = true;
            this.tabPageDataControl.Controls.Add(this.btnClear);
            this.tabPageDataControl.Controls.Add(this.btnDelete);
            this.tabPageDataControl.Controls.Add(this.label10);
            this.tabPageDataControl.Controls.Add(this.txtSearchIdentityNUnber);
            this.tabPageDataControl.Controls.Add(this.btnUpdate);
            this.tabPageDataControl.Controls.Add(this.btnSearch);
            this.tabPageDataControl.Controls.Add(this.btnList);
            this.tabPageDataControl.Controls.Add(this.gridControl1);
            this.tabPageDataControl.Name = "tabPageDataControl";
            this.tabPageDataControl.Size = new System.Drawing.Size(1782, 669);
            this.tabPageDataControl.Text = "DataControl";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(1509, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(257, 24);
            this.label10.TabIndex = 6;
            this.label10.Text = "Patient Identity Number";
            // 
            // txtSearchIdentityNUnber
            // 
            this.txtSearchIdentityNUnber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchIdentityNUnber.DefaultText = "";
            this.txtSearchIdentityNUnber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchIdentityNUnber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchIdentityNUnber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchIdentityNUnber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchIdentityNUnber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchIdentityNUnber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchIdentityNUnber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchIdentityNUnber.Location = new System.Drawing.Point(1509, 75);
            this.txtSearchIdentityNUnber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchIdentityNUnber.Name = "txtSearchIdentityNUnber";
            this.txtSearchIdentityNUnber.PasswordChar = '\0';
            this.txtSearchIdentityNUnber.PlaceholderText = "";
            this.txtSearchIdentityNUnber.SelectedText = "";
            this.txtSearchIdentityNUnber.Size = new System.Drawing.Size(229, 48);
            this.txtSearchIdentityNUnber.TabIndex = 5;
            // 
            // btnUpdate
            // 
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(1540, 238);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(180, 86);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1540, 130);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(180, 86);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnList
            // 
            this.btnList.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnList.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnList.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnList.ForeColor = System.Drawing.Color.White;
            this.btnList.Location = new System.Drawing.Point(1540, 348);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(180, 86);
            this.btnList.TabIndex = 2;
            this.btnList.Text = "List";
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1500, 706);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // btnDelete
            // 
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(1540, 455);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 86);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(1540, 563);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(180, 86);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Patients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(178)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(1801, 759);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "Patients";
            this.Text = "Patients";
            this.Load += new System.EventHandler(this.Patients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.tabPagePersonalInfo.ResumeLayout(false);
            this.tabPagePersonalInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            this.tabPageContactInfo.ResumeLayout(false);
            this.tabPageContactInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPhoneNumber.Properties)).EndInit();
            this.tabPageHealtInfo.ResumeLayout(false);
            this.tabPageHealtInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDischargeDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDischargeDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditAdmissionDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditAdmissionDate.Properties)).EndInit();
            this.tabPageDataControl.ResumeLayout(false);
            this.tabPageDataControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage tabPagePersonalInfo;
        private Guna.UI2.WinForms.Guna2TextBox txtPatientIdentityNumber;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraTab.XtraTabPage tabPageContactInfo;
        private DevExpress.XtraTab.XtraTabPage tabPageHealtInfo;
        private System.Windows.Forms.ComboBox cbbopatientGender;
        private Guna.UI2.WinForms.Guna2TextBox txtPatientLastName;
        private Guna.UI2.WinForms.Guna2TextBox txtPatientFirstNmae;
        private Guna.UI2.WinForms.Guna2Button btnNext1;
        private Guna.UI2.WinForms.Guna2Button btnNext0;
        private Guna.UI2.WinForms.Guna2Button btnBack0;
        private Guna.UI2.WinForms.Guna2Button btnBack1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtPatientHeight;
        private Guna.UI2.WinForms.Guna2TextBox txtPatientWeight;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private Guna.UI2.WinForms.Guna2TextBox txtPatientMail;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtPatientAddress;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit textEditPhoneNumber;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbboxStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.RadioButton radioButtonYes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbboxBloodType;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraTab.XtraTabPage tabPageDataControl;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnList;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.DateEdit dateEditDischargeDate;
        private DevExpress.XtraEditors.DateEdit dateEditAdmissionDate;
        internal System.Windows.Forms.RichTextBox txtNotes;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchIdentityNUnber;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnClear;
    }
}