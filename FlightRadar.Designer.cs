
namespace WindowsFormsApp1
{
    partial class FlightRadar
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
            this.icnGoogle = new FontAwesome.Sharp.IconButton();
            this.lblGogle = new System.Windows.Forms.Label();
            this.naaDataSet = new WindowsFormsApp1.naaDataSet();
            this.aeroportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aeroportTableAdapter = new WindowsFormsApp1.naaDataSetTableAdapters.AeroportTableAdapter();
            this.adiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yerləşdiyiyerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıATADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıCAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.koordinatlarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uEZDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.adiDataGridViewTextBoxColumn,
            this.yerləşdiyiyerDataGridViewTextBoxColumn,
            this.ıATADataGridViewTextBoxColumn,
            this.ıCAODataGridViewTextBoxColumn,
            this.koordinatlarDataGridViewTextBoxColumn,
            this.uEZDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aeroportBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(62, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 248);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // icnGoogle
            // 
            this.icnGoogle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.icnGoogle.FlatAppearance.BorderSize = 0;
            this.icnGoogle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnGoogle.IconChar = FontAwesome.Sharp.IconChar.SatelliteDish;
            this.icnGoogle.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.icnGoogle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icnGoogle.IconSize = 38;
            this.icnGoogle.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.icnGoogle.Location = new System.Drawing.Point(85, 319);
            this.icnGoogle.Name = "icnGoogle";
            this.icnGoogle.Size = new System.Drawing.Size(48, 48);
            this.icnGoogle.TabIndex = 5;
            this.icnGoogle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.icnGoogle.UseVisualStyleBackColor = true;
            this.icnGoogle.Click += new System.EventHandler(this.icnGoogle_Click_1);
            // 
            // lblGogle
            // 
            this.lblGogle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGogle.AutoSize = true;
            this.lblGogle.Location = new System.Drawing.Point(139, 337);
            this.lblGogle.Name = "lblGogle";
            this.lblGogle.Size = new System.Drawing.Size(35, 13);
            this.lblGogle.TabIndex = 4;
            this.lblGogle.Text = "label1";
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
            // adiDataGridViewTextBoxColumn
            // 
            this.adiDataGridViewTextBoxColumn.DataPropertyName = "Adi";
            this.adiDataGridViewTextBoxColumn.HeaderText = "Adi";
            this.adiDataGridViewTextBoxColumn.Name = "adiDataGridViewTextBoxColumn";
            // 
            // yerləşdiyiyerDataGridViewTextBoxColumn
            // 
            this.yerləşdiyiyerDataGridViewTextBoxColumn.DataPropertyName = "Yerləşdiyi_yer";
            this.yerləşdiyiyerDataGridViewTextBoxColumn.HeaderText = "Yerləşdiyi_yer";
            this.yerləşdiyiyerDataGridViewTextBoxColumn.Name = "yerləşdiyiyerDataGridViewTextBoxColumn";
            // 
            // ıATADataGridViewTextBoxColumn
            // 
            this.ıATADataGridViewTextBoxColumn.DataPropertyName = "IATA";
            this.ıATADataGridViewTextBoxColumn.HeaderText = "IATA";
            this.ıATADataGridViewTextBoxColumn.Name = "ıATADataGridViewTextBoxColumn";
            // 
            // ıCAODataGridViewTextBoxColumn
            // 
            this.ıCAODataGridViewTextBoxColumn.DataPropertyName = "ICAO";
            this.ıCAODataGridViewTextBoxColumn.HeaderText = "ICAO";
            this.ıCAODataGridViewTextBoxColumn.Name = "ıCAODataGridViewTextBoxColumn";
            // 
            // koordinatlarDataGridViewTextBoxColumn
            // 
            this.koordinatlarDataGridViewTextBoxColumn.DataPropertyName = "Koordinatlar";
            this.koordinatlarDataGridViewTextBoxColumn.HeaderText = "Koordinatlar";
            this.koordinatlarDataGridViewTextBoxColumn.Name = "koordinatlarDataGridViewTextBoxColumn";
            // 
            // uEZDataGridViewTextBoxColumn
            // 
            this.uEZDataGridViewTextBoxColumn.DataPropertyName = "UEZ";
            this.uEZDataGridViewTextBoxColumn.HeaderText = "UEZ";
            this.uEZDataGridViewTextBoxColumn.Name = "uEZDataGridViewTextBoxColumn";
            // 
            // FlightRadar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.icnGoogle);
            this.Controls.Add(this.lblGogle);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FlightRadar";
            this.Text = "FlightRadar";
            this.Load += new System.EventHandler(this.FlightRadar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.naaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        public FontAwesome.Sharp.IconButton icnGoogle;
        private System.Windows.Forms.Label lblGogle;
        private naaDataSet naaDataSet;
        private System.Windows.Forms.BindingSource aeroportBindingSource;
        private naaDataSetTableAdapters.AeroportTableAdapter aeroportTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn adiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yerləşdiyiyerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıATADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıCAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn koordinatlarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uEZDataGridViewTextBoxColumn;
    }
}