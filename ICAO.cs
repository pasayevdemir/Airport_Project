using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    public partial class ICAO : Form
    {
        public ICAO()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-5SN5VL1\SQLEXPRESS;Initial Catalog=naa;Integrated Security=True");
        private void ICAO_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'naaDataSet.Aeroport' table. You can move, or remove it, as needed.
            this.aeroportTableAdapter.Fill(this.naaDataSet.Aeroport);

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtBox3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtBox4.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            picBoxBayraq.Image = Image.FromFile(dataGridView1.CurrentRow.Cells[6].Value.ToString());
            picBoxAeroport.Image = Image.FromFile(dataGridView1.CurrentRow.Cells[7].Value.ToString());
        }

        private void txtBox5_TextChanged_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter dtadptr = new SqlDataAdapter("select *from Aeroport Where Adi like '" + txtBox7.Text + "%' and Yerləşdiyi_Yer like '" + txtBox8.Text + "%' and ICAO like '" + txtBox5.Text + "%' and IATA like '" + txtBox6.Text + "%' ", baglanti);
            DataTable dt = new DataTable();
            dtadptr.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
    }
}
