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
    public partial class Isciler : Form
    {
        bool yoxla = false;
        public Isciler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-5SN5VL1\SQLEXPRESS;Initial Catalog=naa;Integrated Security=True");
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtBox8.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtBox9.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtBox10.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtBox11.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            txtBox12.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            txtBox13.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            txtBox14.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            txtBox15.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            pictureBox1.Image = Image.FromFile(dataGridView1.CurrentRow.Cells[15].Value.ToString());
        }

        private void Isciler_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter dtadptr = new SqlDataAdapter("select *from İsci", baglanti);
            DataTable dt = new DataTable();
            dtadptr.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void btnElaveET_Click(object sender, EventArgs e)
        {
            if (yoxla == false)
            {
                txtBox1.Enabled = true; txtBox1.Text = "";
                txtBox2.Enabled = true; txtBox2.Text = "";
                txtBox3.Enabled = true; txtBox3.Text = "";
                txtBox4.Enabled = true; txtBox4.Text = "";
                txtBox5.Enabled = true; txtBox5.Text = "";
                txtBox6.Enabled = true; txtBox6.Text = "";
                txtBox7.Enabled = true; txtBox7.Text = "";
                txtBox8.Enabled = true; txtBox8.Text = "";
                txtBox9.Enabled = true; txtBox9.Text = "";
                txtBox10.Enabled = true; txtBox10.Text = "";
                txtBox11.Enabled = true; txtBox11.Text = "";
                txtBox12.Enabled = true; txtBox12.Text = "";
                txtBox13.Enabled = true; txtBox13.Text = "";
                txtBox14.Enabled = true; txtBox14.Text = "";
                txtBox15.Enabled = true; txtBox15.Text = "";
            }
            if (yoxla == true)
            {
                if (txtBox1.Text != "" && txtBox2.Text != "" && txtBox3.Text != "" && txtBox4.Text != "" && txtBox5.Text != "" && txtBox6.Text != "" && txtBox7.Text != "" && txtBox8.Text != "" && txtBox9.Text != "" && txtBox10.Text != "" && txtBox11.Text != "" && txtBox12.Text != "" && txtBox13.Text != "" && txtBox14.Text != "" && txtBox15.Text != "")
                {
                    MessageBox.Show(Text = "Məlumatlar bazaya əlavə olundu!");
                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand("Insert Into İsci( Ad,Soyad,Cinsi,Yas,Tevellud,Doguldugu_yer,FİN,İse_Basladi, İsden_Cix,İs_Veziyyeti,Vezife,Maas,Unvan,Email,Telefon,Sekil) Values('" + txtBox1.Text + "','" + txtBox2.Text + "','" + txtBox3.Text + "','" + txtBox4.Text + "','" + txtBox5.Text + "','" + txtBox6.Text + "','" + txtBox7.Text + "','" + txtBox8.Text + "','" + txtBox9.Text + "','" + txtBox10.Text + "','" + txtBox11.Text + "','" + txtBox12.Text + "','" + txtBox13.Text + "','" + txtBox14.Text + "','" + txtBox15.Text + "','D:\\C#-təcürbə\\Project\\oglan.jpg')", baglanti);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter dtadptr = new SqlDataAdapter("select *from İsci ", baglanti);
                    DataTable dt = new DataTable();
                    dtadptr.Fill(dt);
                    dataGridView1.DataSource = dt;
                    baglanti.Close();
                    yoxla = false;
                    txtBox1.Enabled = false;
                    txtBox2.Enabled = false;
                    txtBox3.Enabled = false;
                    txtBox4.Enabled = false;
                    txtBox5.Enabled = false;
                    txtBox6.Enabled = false;
                    txtBox7.Enabled = false;
                    txtBox8.Enabled = false;
                    txtBox9.Enabled = false;
                    txtBox10.Enabled = false;
                    txtBox11.Enabled = false;
                    txtBox12.Enabled = false;
                    txtBox13.Enabled = false;
                    txtBox14.Enabled = false;
                    txtBox15.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Sahələri tam doldur!");
                }
            }
            else
            {
                MessageBox.Show("Müvafiq xanalar aktivləşdirildi!\nMəlumatları daxil edə bilərsiz.");
            }
            yoxla = true;
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            yoxla = false;
            txtBox1.Enabled = false;
            txtBox2.Enabled = false;
            txtBox3.Enabled = false;
            txtBox4.Enabled = false;
            txtBox5.Enabled = false;
            txtBox6.Enabled = false;
            txtBox7.Enabled = false;
            txtBox8.Enabled = false;
            txtBox9.Enabled = false;
            txtBox10.Enabled = false;
            txtBox11.Enabled = false;
            txtBox12.Enabled = false;
            txtBox13.Enabled = false;
            txtBox14.Enabled = false;
            txtBox15.Enabled = false;
            txtBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtBox8.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtBox9.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtBox10.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtBox11.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            txtBox12.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            txtBox13.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            txtBox14.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            txtBox15.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            pictureBox1.Image = Image.FromFile(dataGridView1.CurrentRow.Cells[15].Value.ToString());

        }

        private void BZ_txtBox15_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter dtadptr = new SqlDataAdapter("select *from İsci where ad like '" + BZ_txtBox1.Text + "%' and soyad like '" + BZ_txtBox2.Text + "%' and cinsi like '" + BZ_txtBox3.Text + "%' and yas like '" + BZ_txtBox4.Text + "%' and tevellud like '" + BZ_txtBox5.Text + "%' and doguldugu_yer like '" + BZ_txtBox6.Text + "%' and FİN like '" + BZ_txtBox7.Text + "%' and İse_basladi like '" + BZ_txtBox8.Text + "%' and İsden_cix like '" + BZ_txtBox9.Text + "%' and İs_veziyyeti like '" + BZ_txtBox10.Text + "%' and vezife like '" + BZ_txtBox11.Text + "%' and maas like '" + BZ_txtBox12.Text + "%' and unvan like '" + BZ_txtBox13.Text + "%' and email like '" + BZ_txtBox14.Text + "%' and telefon like '" + BZ_txtBox15.Text + "%'", baglanti);
                DataTable dt = new DataTable();
                dtadptr.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                baglanti.Close();
            }
        }
    }
}
