using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using Microsoft.Win32;

namespace WindowsFormsApp1
{
    public partial class MetarTaf : Form
    {
        public MetarTaf()
        {
            InitializeComponent();
        }

        private void ricBoxHtml_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void btnMetar_Click(object sender, EventArgs e)
        {
            try
            {
                WebClient websehife = new WebClient();
                string a = "https://metar-taf.com/" + dataGridView1.CurrentRow.Cells[3].Value.ToString() + "";
                ricBoxHtml.Text = websehife.DownloadString(a);
                int evvel = ricBoxHtml.Text.IndexOf("d-block\">METAR");
                int son = ricBoxHtml.Text.LastIndexOf("row order-2 order-lg-1");
                txtBoxMetar.Text = ricBoxHtml.Text.Substring(evvel + 15, son - evvel - 188);
                string bb = "" + dataGridView1.CurrentRow.Cells[3].Value.ToString() + "";
                a = "https://ourairports.com/airports/"+dataGridView1.CurrentRow.Cells[3].Value.ToString().Trim()+ "/weather.html";
                ricBoxHtml1.Text = websehife.DownloadString(a);
                evvel = ricBoxHtml1.Text.IndexOf("class=\"report\">TAF ");
                son = ricBoxHtml1.Text.LastIndexOf("Facility data");
                txtBoxTaf.Text = ricBoxHtml1.Text.Substring(evvel + 18, son - evvel - 127);
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }

        private void MetarTaf_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'naaDataSet.Aeroport' table. You can move, or remove it, as needed.
            this.aeroportTableAdapter.Fill(this.naaDataSet.Aeroport);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
