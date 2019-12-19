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

        private void TBZeit_TextChanged(object sender, EventArgs e)
        {

        }

        private void CBStart_DropDown(object sender, EventArgs e)
        {
            CBStart.Items.Clear();
            String Start = CBStart.Text;
            List<Station> Start1 = transport.GetStations(Start).StationList;
            foreach(var Station in Start1 )
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
    }
}
