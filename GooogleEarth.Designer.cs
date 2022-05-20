
namespace WindowsFormsApp1
{
    partial class GooogleEarth
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblGogle = new System.Windows.Forms.Label();
            this.icnGoogle = new FontAwesome.Sharp.IconButton();
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
            // dataGridView1
            // 
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
            this.dataGridView1.Location = new System.Drawing.Point(43, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 286);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // lblGogle
            // 
            this.lblGogle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGogle.AutoSize = true;
            this.lblGogle.Location = new System.Drawing.Point(139, 89);
            this.lblGogle.Name = "lblGogle";
            this.lblGogle.Size = new System.Drawing.Size(35, 13);
            this.lblGogle.TabIndex = 1;
            this.lblGogle.Text = "label1";
            // 
            // icnGoogle
            // 
            this.icnGoogle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.icnGoogle.FlatAppearance.BorderSize = 0;
            this.icnGoogle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnGoogle.IconChar = FontAwesome.Sharp.IconChar.Globe;
            this.icnGoogle.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.icnGoogle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icnGoogle.IconSize = 38;
            this.icnGoogle.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.icnGoogle.Location = new System.Drawing.Point(85, 71);
            this.icnGoogle.Name = "icnGoogle";
            this.icnGoogle.Size = new System.Drawing.Size(48, 48);
            this.icnGoogle.TabIndex = 3;
            this.icnGoogle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.icnGoogle.UseVisualStyleBackColor = true;
            this.icnGoogle.Click += new System.EventHandler(this.icnGoogle_Click);
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
            // GooogleEarth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.icnGoogle);
            this.Controls.Add(this.lblGogle);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GooogleEarth";
            this.Text = "GooogleEarth";
            this.Load += new System.EventHandler(this.GooogleEarth_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.naaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn adiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yerləşdiyiYerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıATADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıCAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn koordinatlarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uEZDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblGogle;
        public FontAwesome.Sharp.IconButton icnGoogle;
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