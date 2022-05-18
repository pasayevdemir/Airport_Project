
namespace WindowsFormsApp1
{
    partial class ICAO
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox4 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblICAO = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblIATA = new System.Windows.Forms.Label();
            this.lblHavaLiman = new System.Windows.Forms.Label();
            this.lblYer = new System.Windows.Forms.Label();
            this.txtBox5 = new System.Windows.Forms.TextBox();
            this.txtBox6 = new System.Windows.Forms.TextBox();
            this.txtBox7 = new System.Windows.Forms.TextBox();
            this.txtBox8 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.picBoxBayraq = new System.Windows.Forms.PictureBox();
            this.picBoxAeroport = new System.Windows.Forms.PictureBox();
            this.naaDataSet = new WindowsFormsApp1.naaDataSet();
            this.aeroportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aeroportTableAdapter = new WindowsFormsApp1.naaDataSetTableAdapters.AeroportTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBayraq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAeroport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.naaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtBox3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtBox4);
            this.panel1.Location = new System.Drawing.Point(27, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 184);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Koordinatlar";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(72, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(253, 20);
            this.textBox1.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "UEZ";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(72, 154);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(253, 20);
            this.textBox2.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ICAO";
            // 
            // txtBox1
            // 
            this.txtBox1.Enabled = false;
            this.txtBox1.Location = new System.Drawing.Point(72, 62);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(253, 20);
            this.txtBox1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "IATA";
            // 
            // txtBox2
            // 
            this.txtBox2.Enabled = false;
            this.txtBox2.Location = new System.Drawing.Point(72, 95);
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(253, 20);
            this.txtBox2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Hava Limanı";
            // 
            // txtBox3
            // 
            this.txtBox3.Enabled = false;
            this.txtBox3.Location = new System.Drawing.Point(72, 3);
            this.txtBox3.Name = "txtBox3";
            this.txtBox3.Size = new System.Drawing.Size(253, 20);
            this.txtBox3.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Yerləşdiyi Yer";
            // 
            // txtBox4
            // 
            this.txtBox4.Enabled = false;
            this.txtBox4.Location = new System.Drawing.Point(72, 36);
            this.txtBox4.Name = "txtBox4";
            this.txtBox4.Size = new System.Drawing.Size(253, 20);
            this.txtBox4.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.lblICAO);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.lblIATA);
            this.panel2.Controls.Add(this.lblHavaLiman);
            this.panel2.Controls.Add(this.lblYer);
            this.panel2.Controls.Add(this.txtBox5);
            this.panel2.Controls.Add(this.txtBox6);
            this.panel2.Controls.Add(this.txtBox7);
            this.panel2.Controls.Add(this.txtBox8);
            this.panel2.Location = new System.Drawing.Point(552, 275);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 187);
            this.panel2.TabIndex = 1;
            // 
            // lblICAO
            // 
            this.lblICAO.AutoSize = true;
            this.lblICAO.Location = new System.Drawing.Point(56, 48);
            this.lblICAO.Name = "lblICAO";
            this.lblICAO.Size = new System.Drawing.Size(32, 13);
            this.lblICAO.TabIndex = 16;
            this.lblICAO.Text = "ICAO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(178, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Axtarış";
            // 
            // lblIATA
            // 
            this.lblIATA.AutoSize = true;
            this.lblIATA.Location = new System.Drawing.Point(57, 81);
            this.lblIATA.Name = "lblIATA";
            this.lblIATA.Size = new System.Drawing.Size(31, 13);
            this.lblIATA.TabIndex = 17;
            this.lblIATA.Text = "IATA";
            // 
            // lblHavaLiman
            // 
            this.lblHavaLiman.AutoSize = true;
            this.lblHavaLiman.Location = new System.Drawing.Point(22, 114);
            this.lblHavaLiman.Name = "lblHavaLiman";
            this.lblHavaLiman.Size = new System.Drawing.Size(66, 13);
            this.lblHavaLiman.TabIndex = 18;
            this.lblHavaLiman.Text = "Hava Limanı";
            // 
            // lblYer
            // 
            this.lblYer.AutoSize = true;
            this.lblYer.Location = new System.Drawing.Point(18, 147);
            this.lblYer.Name = "lblYer";
            this.lblYer.Size = new System.Drawing.Size(70, 13);
            this.lblYer.TabIndex = 19;
            this.lblYer.Text = "Yerləşdiyi Yer";
            // 
            // txtBox5
            // 
            this.txtBox5.Location = new System.Drawing.Point(94, 45);
            this.txtBox5.Name = "txtBox5";
            this.txtBox5.Size = new System.Drawing.Size(242, 20);
            this.txtBox5.TabIndex = 9;
            this.txtBox5.TextChanged += new System.EventHandler(this.txtBox5_TextChanged_1);
            // 
            // txtBox6
            // 
            this.txtBox6.Location = new System.Drawing.Point(94, 78);
            this.txtBox6.Name = "txtBox6";
            this.txtBox6.Size = new System.Drawing.Size(242, 20);
            this.txtBox6.TabIndex = 11;
            this.txtBox6.TextChanged += new System.EventHandler(this.txtBox5_TextChanged_1);
            // 
            // txtBox7
            // 
            this.txtBox7.Location = new System.Drawing.Point(94, 111);
            this.txtBox7.Name = "txtBox7";
            this.txtBox7.Size = new System.Drawing.Size(242, 20);
            this.txtBox7.TabIndex = 13;
            this.txtBox7.TextChanged += new System.EventHandler(this.txtBox5_TextChanged_1);
            // 
            // txtBox8
            // 
            this.txtBox8.Location = new System.Drawing.Point(94, 144);
            this.txtBox8.Name = "txtBox8";
            this.txtBox8.Size = new System.Drawing.Size(242, 20);
            this.txtBox8.TabIndex = 15;
            this.txtBox8.TextChanged += new System.EventHandler(this.txtBox5_TextChanged_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dataGridView1.DataSource = this.aeroportBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(486, 276);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // picBoxBayraq
            // 
            this.picBoxBayraq.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBoxBayraq.Location = new System.Drawing.Point(361, 12);
            this.picBoxBayraq.Name = "picBoxBayraq";
            this.picBoxBayraq.Size = new System.Drawing.Size(208, 159);
            this.picBoxBayraq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxBayraq.TabIndex = 2;
            this.picBoxBayraq.TabStop = false;
            // 
            // picBoxAeroport
            // 
            this.picBoxAeroport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBoxAeroport.Location = new System.Drawing.Point(586, 12);
            this.picBoxAeroport.Name = "picBoxAeroport";
            this.picBoxAeroport.Size = new System.Drawing.Size(305, 257);
            this.picBoxAeroport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxAeroport.TabIndex = 5;
            this.picBoxAeroport.TabStop = false;
            // 
            // naaDataSet
            // 
            this.naaDataSet.DataSetName = "naaDataSet";
            this.naaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aeroportBindingSource
            // 
            this.aeroportBindingSource.DataMember = "Aeroport";
            this.aeroportBindingSource.DataSource = this.naaDataSet;
            // 
            // aeroportTableAdapter
            // 
            this.aeroportTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Adi";
            this.dataGridViewTextBoxColumn1.HeaderText = "Adi";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Yerləşdiyi_yer";
            this.dataGridViewTextBoxColumn2.HeaderText = "Yerləşdiyi_yer";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ICAO";
            this.dataGridViewTextBoxColumn4.HeaderText = "ICAO";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IATA";
            this.dataGridViewTextBoxColumn3.HeaderText = "IATA";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Koordinatlar";
            this.dataGridViewTextBoxColumn5.HeaderText = "Koordinatlar";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "UEZ";
            this.dataGridViewTextBoxColumn6.HeaderText = "UEZ";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Şəkil_Bayraq";
            this.dataGridViewTextBoxColumn7.HeaderText = "Şəkil_Bayraq";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Şəkil_Aeroport";
            this.dataGridViewTextBoxColumn8.HeaderText = "Şəkil_Aeroport";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // ICAO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 490);
            this.Controls.Add(this.picBoxAeroport);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.picBoxBayraq);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ICAO";
            this.Text = "ICAO";
            this.Load += new System.EventHandler(this.ICAO_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBayraq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAeroport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.naaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBox4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBox5;
        private System.Windows.Forms.TextBox txtBox6;
        private System.Windows.Forms.TextBox txtBox7;
        private System.Windows.Forms.TextBox txtBox8;
        private System.Windows.Forms.PictureBox picBoxBayraq;
        private System.Windows.Forms.Label lblICAO;
        private System.Windows.Forms.Label lblIATA;
        private System.Windows.Forms.Label lblHavaLiman;
        private System.Windows.Forms.Label lblYer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox picBoxAeroport;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn adiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yerləşdiyiYerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıATADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıCAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn koordinatlarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uEZDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn şəkilBayraqDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn şəkilAeroportDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private naaDataSet naaDataSet;
        private System.Windows.Forms.BindingSource aeroportBindingSource;
        private naaDataSetTableAdapters.AeroportTableAdapter aeroportTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}