using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Iscilerr : Form
    {
        public Iscilerr()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=USER\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
        private void Iscilerr_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //txtBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //txtBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //txtBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //txtBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //txtBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            //txtBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            //txtBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            //txtBox8.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            //txtBox9.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            //txtBox10.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            //txtBox11.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            //txtBox12.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            //txtBox13.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            //txtBox14.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            //txtBox15.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();


        }

        private void txtBoxTevellud_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtBoxAd_TextChanged(object sender, EventArgs e)
        {
            //baglanti.Open();
            //SqlDataAdapter dtadptr = new SqlDataAdapter("select *from Isci Where Ad like '" + txtBoxAd.Text + "%' and Soyad like '" + txtBoxSoyad.Text + "%' and Cinsi like '" + txtBoxCins.Text + "%' and Yas like '" + txtBoxYas.Text + "%' and Tevellud like '" + txtBoxTevellud.Text + "%' and Doguldugu_yer like '" + txtBoxYer.Text + "%' and FİN like '" + txtBoxFin.Text + "%' and İse_Basladi like '" + txtBoxBasladi.Text + "%'  and İs_Veziyyeti like '" + txtBoxVeziyyet.Text + "%' and Vezife like '" + txtBoxVezife.Text + "%' and Maas like '" + txtBoxMaas.Text + "%' and Unvan like '" + txtBoxUnvan.Text + "%' and Email like '" + txtBoxMail.Text + "%' and Telefon like '" + txtBoxTelefon + "%'", baglanti);
            //DataTable dt = new DataTable();
            //dtadptr.Fill(dt);
            //dataGridView1.DataSource = dt;
            //baglanti.Close();
        }

        private void txtBoxSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxCins_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxYas_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxCixdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxVeziyyet_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxYer_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxFin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxBasladi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxTelefon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxVezife_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxMaas_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxUnvan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxMail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
