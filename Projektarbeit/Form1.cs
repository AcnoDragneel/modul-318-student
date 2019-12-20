using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projektarbeit
{
    public partial class Form1 : Form
    {
        private Transport transport = new Transport();
        public Form1()
        {
            InitializeComponent();
        }


        //Bei einer angabe kann man dann mehrere Stationen auswählen
        private void CBStart_DropDown(object sender, EventArgs e)
        {
            CBStart.Items.Clear();
            String Start = CBStart.Text;
            List<Station> Start1 = transport.GetStations(Start).StationList;
            foreach (var Station in Start1)
            {
                CBStart.Items.Add(Station.Name);
            }

        }

        private void CBZiel_DropDown(object sender, EventArgs e)
        {
            CBZiel.Items.Clear();
            String Ziel = CBZiel.Text;
            List<Station> Ziel1 = transport.GetStations(Ziel).StationList;
            foreach (var Station in Ziel1)
            {
                CBZiel.Items.Add(Station.Name);
            }
        }

        // Der Such Knopf der die Suche auslöst
        private void BSuchen_Click(object sender, EventArgs e)
        {
            //Gibt die Gewünschten Verbindung an 

            List<Connection> LBMV1 = transport.GetConnections(CBStart.Text, CBZiel.Text).ConnectionList;

            LBMV.Items.Clear();

            foreach (var i in LBMV1)
            {
                if (i.Duration != null)
                {
                    var departureAb = DateTime.Parse(i.From.Departure);
                    var departureAn = DateTime.Parse(i.To.Arrival);
                    LBMV.Items.Add(i.From.Station.Name + " / " + departureAb + "  -->  " + i.To.Station.Name + " / " + departureAn);
                    LBMV.Items.Add("");
                }
            }

            //Zeigt Weitere Verbindungen deiner Start Station

            List<StationBoard> LBWV1 = transport.GetStationBoard(CBStart.Text, CBZiel.Text).Entries;

            LBWV.Items.Clear();

            foreach (var i in LBWV1)
            {
                if (i.Name != null)
                {
                
                    LBWV.Items.Add( CBStart.Text +"  -->  " + i.To);
                    LBWV.Items.Add("");
                }
            }
        }


        private void SBB_Click(object sender, EventArgs e)
        {
            SBB.Text = "Nur halt schlechter";
          
        }

           //zeigt die Zeit an
        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
   
        private void timer_Tick(object sender, EventArgs e)
        {
            labelZeit.Text = DateTime.Now.ToLongTimeString();
            timer.Start();
        }
    }
}
