using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FlightRadar : Form
    {
        public FlightRadar()
        {
            InitializeComponent();
        }

        private void FlightRadar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'naaDataSet.Aeroport' table. You can move, or remove it, as needed.
            this.aeroportTableAdapter.Fill(this.naaDataSet.Aeroport);


        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            lblGogle.Text = "‪Filght Radarda " + dataGridView1.CurrentRow.Cells[0].Value.ToString() + " aç";
        }

        private void icnGoogle_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.flightradar24.com/airport/" + dataGridView1.CurrentRow.Cells[2].Value.ToString() + "");
        }
    }
}
