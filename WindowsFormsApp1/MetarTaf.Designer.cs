
namespace WindowsFormsApp1
{
    partial class MetarTaf
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
            this.ricBoxHtml = new System.Windows.Forms.RichTextBox();
            this.btnMetar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtBoxMetar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ricBoxHtml1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxTaf = new System.Windows.Forms.RichTextBox();
            this.naaDataSet = new WindowsFormsApp1.naaDataSet();
            this.aeroportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aeroportTableAdapter = new WindowsFormsApp1.naaDataSetTableAdapters.AeroportTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.naaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ricBoxHtml
            // 
            this.ricBoxHtml.Location = new System.Drawing.Point(807, 2);
            this.ricBoxHtml.Name = "ricBoxHtml";
            this.ricBoxHtml.Size = new System.Drawing.Size(10, 10);
            this.ricBoxHtml.TabIndex = 0;
            this.ricBoxHtml.Text = "";
            this.ricBoxHtml.Visible = false;
            this.ricBoxHtml.TextChanged += new System.EventHandler(this.ricBoxHtml_TextChanged);
            // 
            // btnMetar
            // 
            this.btnMetar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMetar.Location = new System.Drawing.Point(652, 244);
            this.btnMetar.Name = "btnMetar";
            this.btnMetar.Size = new System.Drawing.Size(75, 23);
            this.btnMetar.TabIndex = 1;
            this.btnMetar.Text = "Metar Taf";
            this.btnMetar.UseVisualStyleBackColor = true;
            this.btnMetar.Click += new System.EventHandler(this.btnMetar_Click);
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
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView1.DataSource = this.aeroportBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(83, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtBoxMetar
            // 
            this.txtBoxMetar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxMetar.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxMetar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxMetar.Location = new System.Drawing.Point(146, 233);
            this.txtBoxMetar.Name = "txtBoxMetar";
            this.txtBoxMetar.Size = new System.Drawing.Size(500, 13);
            this.txtBoxMetar.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(88, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Metar :";
            // 
            // ricBoxHtml1
            // 
            this.ricBoxHtml1.Location = new System.Drawing.Point(807, 2);
            this.ricBoxHtml1.Name = "ricBoxHtml1";
            this.ricBoxHtml1.Size = new System.Drawing.Size(10, 10);
            this.ricBoxHtml1.TabIndex = 6;
            this.ricBoxHtml1.Text = "";
            this.ricBoxHtml1.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(103, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Taf :";
            // 
            // txtBoxTaf
            // 
            this.txtBoxTaf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxTaf.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxTaf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxTaf.Location = new System.Drawing.Point(146, 259);
            this.txtBoxTaf.Name = "txtBoxTaf";
            this.txtBoxTaf.Size = new System.Drawing.Size(500, 129);
            this.txtBoxTaf.TabIndex = 9;
            this.txtBoxTaf.Text = "";
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
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IATA";
            this.dataGridViewTextBoxColumn3.HeaderText = "IATA";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ICAO";
            this.dataGridViewTextBoxColumn4.HeaderText = "ICAO";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
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
            // MetarTaf
            // 
            this.ClientSize = new System.Drawing.Size(830, 503);
            this.Controls.Add(this.txtBoxTaf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ricBoxHtml1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxMetar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnMetar);
            this.Controls.Add(this.ricBoxHtml);
            this.Name = "MetarTaf";
            this.Load += new System.EventHandler(this.MetarTaf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.naaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.RichTextBox ricBoxHtml;
        private System.Windows.Forms.Button btnMetar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn adiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yerləşdiyiYerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıATADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıCAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn koordinatlarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uEZDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtBoxMetar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox ricBoxHtml1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtBoxTaf;
        private naaDataSet naaDataSet;
        private System.Windows.Forms.BindingSource aeroportBindingSource;
        private naaDataSetTableAdapters.AeroportTableAdapter aeroportTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}