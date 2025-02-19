namespace Hospital_Management
{
    partial class HospitalAdress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HospitalAdress));
            this.miniMapImageTilesLayer1 = new DevExpress.XtraMap.MiniMapImageTilesLayer();
            this.bingMapDataProvider1 = new DevExpress.XtraMap.BingMapDataProvider();
            this.miniMapVectorItemsLayer1 = new DevExpress.XtraMap.MiniMapVectorItemsLayer();
            this.mapItemStorage1 = new DevExpress.XtraMap.MapItemStorage();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.txtLocation = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblair = new System.Windows.Forms.Label();
            this.lblsituation = new System.Windows.Forms.Label();
            this.pictureBoxGunesli = new System.Windows.Forms.PictureBox();
            this.pictureBoxbulutlu = new System.Windows.Forms.PictureBox();
            this.btnLocation = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGunesli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxbulutlu)).BeginInit();
            this.SuspendLayout();
            this.bingMapDataProvider1.BingKey = "YOUR BING MAPS KEY";
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(2, 2);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(1429, 711);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            // 
            // txtLocation
            // 
            this.txtLocation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLocation.DefaultText = "";
            this.txtLocation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLocation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLocation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLocation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLocation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLocation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLocation.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLocation.Location = new System.Drawing.Point(1497, 345);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.PasswordChar = '\0';
            this.txtLocation.PlaceholderText = "";
            this.txtLocation.SelectedText = "";
            this.txtLocation.Size = new System.Drawing.Size(229, 48);
            this.txtLocation.TabIndex = 2;
            // 
            // lblair
            // 
            this.lblair.AutoSize = true;
            this.lblair.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblair.Location = new System.Drawing.Point(1491, 69);
            this.lblair.Name = "lblair";
            this.lblair.Size = new System.Drawing.Size(99, 32);
            this.lblair.TabIndex = 3;
            this.lblair.Text = "label1";
            // 
            // lblsituation
            // 
            this.lblsituation.AutoSize = true;
            this.lblsituation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsituation.Location = new System.Drawing.Point(1491, 132);
            this.lblsituation.Name = "lblsituation";
            this.lblsituation.Size = new System.Drawing.Size(99, 32);
            this.lblsituation.TabIndex = 4;
            this.lblsituation.Text = "label1";
            this.lblsituation.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBoxGunesli
            // 
            this.pictureBoxGunesli.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGunesli.Image")));
            this.pictureBoxGunesli.Location = new System.Drawing.Point(1790, 114);
            this.pictureBoxGunesli.Name = "pictureBoxGunesli";
            this.pictureBoxGunesli.Size = new System.Drawing.Size(100, 63);
            this.pictureBoxGunesli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGunesli.TabIndex = 5;
            this.pictureBoxGunesli.TabStop = false;
            // 
            // pictureBoxbulutlu
            // 
            this.pictureBoxbulutlu.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxbulutlu.Image")));
            this.pictureBoxbulutlu.Location = new System.Drawing.Point(1790, 114);
            this.pictureBoxbulutlu.Name = "pictureBoxbulutlu";
            this.pictureBoxbulutlu.Size = new System.Drawing.Size(100, 63);
            this.pictureBoxbulutlu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxbulutlu.TabIndex = 6;
            this.pictureBoxbulutlu.TabStop = false;
            // 
            // btnLocation
            // 
            this.btnLocation.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLocation.ImageOptions.SvgImage")));
            this.btnLocation.Location = new System.Drawing.Point(1497, 439);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(254, 128);
            this.btnLocation.TabIndex = 7;
            this.btnLocation.Text = "Get Location";
            this.btnLocation.Click += new System.EventHandler(this.btnLocation_Click);
            // 
            // HospitalAdress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1888, 739);
            this.Controls.Add(this.btnLocation);
            this.Controls.Add(this.pictureBoxbulutlu);
            this.Controls.Add(this.pictureBoxGunesli);
            this.Controls.Add(this.lblsituation);
            this.Controls.Add(this.lblair);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.gMapControl1);
            this.Name = "HospitalAdress";
            this.Text = "HospitalAdress";
            this.Load += new System.EventHandler(this.HospitalAdress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGunesli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxbulutlu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraMap.BingMapDataProvider bingMapDataProvider1;
        private DevExpress.XtraMap.MapItemStorage mapItemStorage1;
        private DevExpress.XtraMap.MiniMapImageTilesLayer miniMapImageTilesLayer1;
        private DevExpress.XtraMap.MiniMapVectorItemsLayer miniMapVectorItemsLayer1;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private Guna.UI2.WinForms.Guna2TextBox txtLocation;
        private System.Windows.Forms.Label lblair;
        private System.Windows.Forms.Label lblsituation;
        private System.Windows.Forms.PictureBox pictureBoxGunesli;
        private System.Windows.Forms.PictureBox pictureBoxbulutlu;
        private DevExpress.XtraEditors.SimpleButton btnLocation;
    }
}