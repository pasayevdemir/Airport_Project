using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome;
namespace WindowsFormsApp1
{
    public partial class GooogleEarth : Form
    {
        public GooogleEarth()
        {
            InitializeComponent();
        }
        private void GooogleEarth_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'naaDataSet.Aeroport' table. You can move, or remove it, as needed.
            this.aeroportTableAdapter.Fill(this.naaDataSet.Aeroport);

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            lblGogle.Text = "‪Google Earth " + dataGridView1.CurrentRow.Cells[0].Value.ToString() + " aç";
        }

        private void icnGoogle_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"E:\C#-təcürbə\Project\WindowsFormsApp1\Resources\" + dataGridView1.CurrentRow.Cells[3].Value.ToString() + ".kmz");
        }
    }
}
