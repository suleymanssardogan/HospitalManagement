using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Library for XML data
using System.Xml.Linq;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;


namespace Hospital_Management
{
    public partial class HospitalAdress : Form
    {
        
   
        //6.35 BROKEN CLOUDS
        private const string connection = "http://api.openweathermap.org/data/2.5/weather?q=Istanbul,TR&mode=xml&units=metric&APPID=5d16f3ff8912e14e9ab6c19fab124fb3";

        private const string key = "5d16f3ff8912e14e9ab6c19fab124fb3";
       // private const string connection = "http://api.openweathermap.org/data/2.5/weather?q=Elazig,TR&mode=xml&units=metric&APPID=5d16f3ff8912e14e9ab6c19fab124fb3";
       // private const string connection = "http://api.openweathermap.org/data/2.5/weather?q=Elazig,TR&mode=xml&units=metric&APPID=5d16f3ff8912e14e9ab6c19fab124fb3&ts=" + DateTime.UtcNow.Ticks;


        private GMapMarker hospitalMarker;
        public HospitalAdress()
        {
            InitializeComponent();

            gMapControl1.DragButton = MouseButtons.Left; // Harita kaydırma için mouse butonu
            gMapControl1.CanDragMap = true; // Harita sürüklenebilir olsun
            gMapControl1.MapProvider = GMapProviders.GoogleMap; // Google Harita Sağlayıcısı
            gMapControl1.Position = new PointLatLng(41.0082, 28.9784); // Hastane konumu (örnek: İstanbul)
            gMapControl1.MinZoom = 2; // Minimum zoom seviyesi
            gMapControl1.MaxZoom = 18; // Maksimum zoom seviyesi
            gMapControl1.Zoom = 12; // Başlangıç zoom seviyesi
            gMapControl1.AutoScroll = true;

            // Marker (İşaretçi) ekleme
            GMapOverlay markers = new GMapOverlay("markers"); // Yeni bir overlay oluştur
                hospitalMarker = new GMarkerGoogle(
                new PointLatLng(41.0082, 28.9784), // Hastanenin koordinatları
                GMarkerGoogleType.red_dot); // Marker tipi: kırmızı nokta

            hospitalMarker.ToolTipText = "SS Hospital"; // Marker üzerine metin ekleme
            hospitalMarker.ToolTipMode = MarkerTooltipMode.Always; // Metin her zaman görünsün
            GMapMarker acibademMarker = new GMarkerGoogle(
               new PointLatLng(41.0106, 28.9797), // Acıbadem hastanesinin koordinatları
               GMarkerGoogleType.red_dot);
            acibademMarker.ToolTipText = "Acıbadem Hospital";
            acibademMarker.ToolTipMode = MarkerTooltipMode.Always;
            markers.Markers.Add(acibademMarker);

            // 2. Hastane - Medicana
            GMapMarker medicanMarker = new GMarkerGoogle(
                new PointLatLng(41.0290, 28.9640), // Medicana hastanesinin koordinatları
                GMarkerGoogleType.red_dot);
            medicanMarker.ToolTipText = "Medicana Hospital";
            medicanMarker.ToolTipMode = MarkerTooltipMode.Always;
            markers.Markers.Add(medicanMarker);

            // 3. Hastane - Florence Nightingale
            GMapMarker florenceMarker = new GMarkerGoogle(
                new PointLatLng(41.0285, 28.9573), // Florence Nightingale hastanesinin koordinatları
                GMarkerGoogleType.red_dot);
            florenceMarker.ToolTipText = "Florence Nightingale Hospital";
            florenceMarker.ToolTipMode = MarkerTooltipMode.Always;
            markers.Markers.Add(florenceMarker);

            // 4. Hastane - Memorial
            GMapMarker memorialMarker = new GMarkerGoogle(
                new PointLatLng(41.0348, 28.9962), // Memorial hastanesinin koordinatları
                GMarkerGoogleType.red_dot);
            memorialMarker.ToolTipText = "Memorial Hospital";
            memorialMarker.ToolTipMode = MarkerTooltipMode.Always;
            markers.Markers.Add(memorialMarker);

            // 5. Hastane - Acıbadem Bakırköy
            GMapMarker acibademBakirkoyMarker = new GMarkerGoogle(
                new PointLatLng(40.9775, 28.8734), // Acıbadem Bakırköy hastanesinin koordinatları
                GMarkerGoogleType.red_dot);
            acibademBakirkoyMarker.ToolTipText = "Acıbadem Bakırköy Hospital";
            acibademBakirkoyMarker.ToolTipMode = MarkerTooltipMode.Always;
            markers.Markers.Add(acibademBakirkoyMarker);

            GMapMarker nigdeDevletMarker = new GMarkerGoogle(
            new PointLatLng(37.9654, 34.6761), // Niğde Devlet Hastanesi koordinatları
             GMarkerGoogleType.red_dot);
            nigdeDevletMarker.ToolTipText = "Niğde Mutluluk Merkezi";
            nigdeDevletMarker.ToolTipMode = MarkerTooltipMode.Always;
            markers.Markers.Add(nigdeDevletMarker);



            markers.Markers.Add(hospitalMarker); // Marker'ı overlay'e ekle
            gMapControl1.Overlays.Add(markers); // Overlay'i haritaya ekle

        }

        private void HospitalAdress_Load(object sender, EventArgs e)
        {
            try
            {
                XDocument air = XDocument.Load(connection);
                var temprature = air.Descendants("temperature").ElementAt(0).Attribute("value").Value;
                var situation = air.Descendants("clouds").ElementAt(0).Attribute("name").Value;
                lblair.Text = temprature + "°";
                lblsituation.Text = situation.ToUpper();

                if(situation.Contains("clouds") == true)
                {
                    pictureBoxGunesli.Visible = false;
                    pictureBoxbulutlu.Visible = true;
                }

                else if (situation.Contains("sun") == true)
                {
                    pictureBoxbulutlu.Visible = false;

                    pictureBoxGunesli.Visible = true;
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show("API isteğinde hata oluştu: " + ex.Message);
            }



        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            if (txtLocation != null)
            {
                //Get Marker locarion
                double latitude = hospitalMarker.Position.Lat;
                double longitude = hospitalMarker.Position.Lng;

                //Create google maps link

                string googleMapsLink = $"https://www.google.com/maps?q=41.0082,28.9784&hl=tr";

                //Write the link to textbox
                txtLocation.Text = $"Konum: {latitude}, {longitude}\nLink: {googleMapsLink}";
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
