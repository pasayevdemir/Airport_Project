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
    public partial class HavaGemi : Form
    {
        public HavaGemi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-5SN5VL1\SQLEXPRESS;Initial Catalog=naa;Integrated Security=True");
        private void HavaGemi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'naaDataSet.Teyyare' table. You can move, or remove it, as needed.
            this.teyyareTableAdapter1.Fill(this.naaDataSet.Teyyare);
            // TODO: This line of code loads data into the 'naaDataSet.Teyyare' table. You can move, or remove it, as needed.
            this.teyyareTableAdapter1.Fill(this.naaDataSet.Teyyare);


        }

        private void dataGridView1_CellEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            txtBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString() + " m";
            txtBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString() + " m";
            txtBox8.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString() + " sərnişin";
            txtBox9.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString() + " kq";
            picBox.Image = Image.FromFile(dataGridView1.CurrentRow.Cells[9].Value.ToString());
        }

        private void AvtButton(object sendert, TextBox text)
        {
            //baglanti.Open();
            //   SqlDataAdapter dtadptr = new SqlDataAdapter("select *from Teyyare Where Adı like '"+AX_txtBox1.Text+"%' and Növü like '"+AX_txtBox2.Text+ "%' and Mənşə like '" + AX_txtBox3.Text + "%' and İstehsalçı like '" + AX_txtBox4.Text + "%' and Uçuş_Heyyəti like '" + AX_txtBox5.Text + "%' and Uzunluğu like '" + AX_txtBox6.Text + "%'and Hündürlüyü like '" + AX_txtBox7.Text + "%' and Sərnişin_Tutumu like '" + AX_txtBox8.Text + "%' and Qaldırdığı_Çəki like '" + AX_txtBox9.Text + "%'", baglanti);
            //    DataTable dt = new DataTable();
            //    dtadptr.Fill(dt);
            //    dataGridView1.DataSource = dt;
            //    baglanti.Close();
        }

        private void AX_txtBox9_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter dtadptr = new SqlDataAdapter("select *from Teyyare Where Adı like '" + AX_txtBox1.Text + "%' and Növü like '" + AX_txtBox2.Text + "%' and Mənşə like '" + AX_txtBox3.Text + "%' and İstehsalçı like '" + AX_txtBox4.Text + "%' and Uçuş_Heyyəti like '" + AX_txtBox5.Text + "%' and Uzunluğu like '" + AX_txtBox6.Text + "%'and Hündürlüyü like '" + AX_txtBox7.Text + "%' and Sərnişin_Tutumu like '" + AX_txtBox8.Text + "%' and Qaldırdığı_Çəki like '" + AX_txtBox9.Text + "%'", baglanti);
            DataTable dt = new DataTable();
            dtadptr.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
    }
}
