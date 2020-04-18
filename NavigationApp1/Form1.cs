using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavigationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void procBtn_Click(object sender, EventArgs e)
        {
            string from = fromBox.Text.Replace(" ", "+");
            string to = toBox.Text.Replace(" ", "+");
            string url = @"https://maps.googleapis.com/maps/api/directions/json?origin="+from+"&destination="+to+"&key=AIzaSyBmmGT5RDAiOCTkCiN6nIu9zzqHjQDBJwU";
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream data = response.GetResponseStream();
            StreamReader reader = new StreamReader(data);
            // json-formatted string from maps api
            string responseFromServer = reader.ReadToEnd();
            response.Close();
            var ser = new System.Web.Script.Serialization.JavaScriptSerializer();
            var mapObjects = ser.Deserialize<MapObject>(responseFromServer);
            wbBox.Navigate("about:blank");
            
            string html = "";
            foreach (var route in mapObjects.routes)
            {
                foreach (var step in route.legs[0].steps)
                {
                    html += "</br>" + step.html_instructions;
                    
                }
            }
            wbBox.Document.Write(html);
            wbBox.Refresh();

        }
    }
}
