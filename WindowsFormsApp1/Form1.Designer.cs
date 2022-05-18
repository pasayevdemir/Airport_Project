
namespace WindowsFormsApp1
{
    partial class Project
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
            this.btnMinimum = new FontAwesome.Sharp.IconButton();
            this.btnNormal = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnParametr = new FontAwesome.Sharp.IconButton();
            this.btnGooogleEarth = new FontAwesome.Sharp.IconButton();
            this.btnAirLive = new FontAwesome.Sharp.IconButton();
            this.brtnFlightRadar = new FontAwesome.Sharp.IconButton();
            this.btnMetarTaf = new FontAwesome.Sharp.IconButton();
            this.btnIACO = new FontAwesome.Sharp.IconButton();
            this.btnGemiler = new FontAwesome.Sharp.IconButton();
            this.btnİsciler = new FontAwesome.Sharp.IconButton();
            this.panelDekstop = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMinimum);
            this.panel1.Controls.Add(this.btnNormal);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(961, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(79, 28);
            this.panel1.TabIndex = 1;
            // 
            // btnMinimum
            // 
            this.btnMinimum.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimum.FlatAppearance.BorderSize = 0;
            this.btnMinimum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimum.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimum.IconColor = System.Drawing.Color.Gray;
            this.btnMinimum.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimum.IconSize = 20;
            this.btnMinimum.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinimum.Location = new System.Drawing.Point(1, 0);
            this.btnMinimum.Name = "btnMinimum";
            this.btnMinimum.Size = new System.Drawing.Size(26, 28);
            this.btnMinimum.TabIndex = 5;
            this.btnMinimum.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinimum.UseVisualStyleBackColor = true;
            this.btnMinimum.Click += new System.EventHandler(this.btnMinimum_Click_1);
            // 
            // btnNormal
            // 
            this.btnNormal.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNormal.FlatAppearance.BorderSize = 0;
            this.btnNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNormal.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btnNormal.IconColor = System.Drawing.Color.Gray;
            this.btnNormal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNormal.IconSize = 20;
            this.btnNormal.Location = new System.Drawing.Point(27, 0);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(26, 28);
            this.btnNormal.TabIndex = 4;
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnClose.IconColor = System.Drawing.Color.Red;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 20;
            this.btnClose.Location = new System.Drawing.Point(53, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 28);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.panelTitleBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelTitleBar.Controls.Add(this.panel1);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1040, 28);
            this.panelTitleBar.TabIndex = 2;
            this.panelTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitleBar_Paint);
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown_1);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Gainsboro;
            this.panelMenu.Controls.Add(this.btnParametr);
            this.panelMenu.Controls.Add(this.btnGooogleEarth);
            this.panelMenu.Controls.Add(this.btnAirLive);
            this.panelMenu.Controls.Add(this.brtnFlightRadar);
            this.panelMenu.Controls.Add(this.btnMetarTaf);
            this.panelMenu.Controls.Add(this.btnIACO);
            this.panelMenu.Controls.Add(this.btnGemiler);
            this.panelMenu.Controls.Add(this.btnİsciler);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 28);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 498);
            this.panelMenu.TabIndex = 3;
            // 
            // btnParametr
            // 
            this.btnParametr.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnParametr.FlatAppearance.BorderSize = 0;
            this.btnParametr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParametr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnParametr.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnParametr.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btnParametr.IconColor = System.Drawing.Color.MediumBlue;
            this.btnParametr.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnParametr.IconSize = 35;
            this.btnParametr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParametr.Location = new System.Drawing.Point(0, 420);
            this.btnParametr.Name = "btnParametr";
            this.btnParametr.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnParametr.Size = new System.Drawing.Size(200, 60);
            this.btnParametr.TabIndex = 11;
            this.btnParametr.Text = "Parametrlər";
            this.btnParametr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParametr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnParametr.UseVisualStyleBackColor = true;
            this.btnParametr.Click += new System.EventHandler(this.btnParametr_Click);
            // 
            // btnGooogleEarth
            // 
            this.btnGooogleEarth.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGooogleEarth.FlatAppearance.BorderSize = 0;
            this.btnGooogleEarth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGooogleEarth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGooogleEarth.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnGooogleEarth.IconChar = FontAwesome.Sharp.IconChar.Globe;
            this.btnGooogleEarth.IconColor = System.Drawing.Color.MediumBlue;
            this.btnGooogleEarth.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGooogleEarth.IconSize = 35;
            this.btnGooogleEarth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGooogleEarth.Location = new System.Drawing.Point(0, 360);
            this.btnGooogleEarth.Name = "btnGooogleEarth";
            this.btnGooogleEarth.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnGooogleEarth.Size = new System.Drawing.Size(200, 60);
            this.btnGooogleEarth.TabIndex = 10;
            this.btnGooogleEarth.Text = "Google Earth";
            this.btnGooogleEarth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGooogleEarth.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGooogleEarth.UseVisualStyleBackColor = true;
            this.btnGooogleEarth.Click += new System.EventHandler(this.btnGooogleEarth_Click);
            // 
            // btnAirLive
            // 
            this.btnAirLive.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAirLive.FlatAppearance.BorderSize = 0;
            this.btnAirLive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAirLive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAirLive.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnAirLive.IconChar = FontAwesome.Sharp.IconChar.Video;
            this.btnAirLive.IconColor = System.Drawing.Color.MediumBlue;
            this.btnAirLive.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAirLive.IconSize = 35;
            this.btnAirLive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAirLive.Location = new System.Drawing.Point(0, 300);
            this.btnAirLive.Name = "btnAirLive";
            this.btnAirLive.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAirLive.Size = new System.Drawing.Size(200, 60);
            this.btnAirLive.TabIndex = 9;
            this.btnAirLive.Text = "Air Live";
            this.btnAirLive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAirLive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAirLive.UseVisualStyleBackColor = true;
            this.btnAirLive.Click += new System.EventHandler(this.btnAirLive_Click);
            // 
            // brtnFlightRadar
            // 
            this.brtnFlightRadar.Dock = System.Windows.Forms.DockStyle.Top;
            this.brtnFlightRadar.FlatAppearance.BorderSize = 0;
            this.brtnFlightRadar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brtnFlightRadar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.brtnFlightRadar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.brtnFlightRadar.IconChar = FontAwesome.Sharp.IconChar.SatelliteDish;
            this.brtnFlightRadar.IconColor = System.Drawing.Color.MediumBlue;
            this.brtnFlightRadar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.brtnFlightRadar.IconSize = 35;
            this.brtnFlightRadar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brtnFlightRadar.Location = new System.Drawing.Point(0, 240);
            this.brtnFlightRadar.Name = "brtnFlightRadar";
            this.brtnFlightRadar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.brtnFlightRadar.Size = new System.Drawing.Size(200, 60);
            this.brtnFlightRadar.TabIndex = 8;
            this.brtnFlightRadar.Text = "Flight Radar";
            this.brtnFlightRadar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brtnFlightRadar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.brtnFlightRadar.UseVisualStyleBackColor = true;
            this.brtnFlightRadar.Click += new System.EventHandler(this.brtnFlightRadar_Click);
            // 
            // btnMetarTaf
            // 
            this.btnMetarTaf.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMetarTaf.FlatAppearance.BorderSize = 0;
            this.btnMetarTaf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMetarTaf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMetarTaf.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnMetarTaf.IconChar = FontAwesome.Sharp.IconChar.CloudSun;
            this.btnMetarTaf.IconColor = System.Drawing.Color.MediumBlue;
            this.btnMetarTaf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMetarTaf.IconSize = 35;
            this.btnMetarTaf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMetarTaf.Location = new System.Drawing.Point(0, 180);
            this.btnMetarTaf.Name = "btnMetarTaf";
            this.btnMetarTaf.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMetarTaf.Size = new System.Drawing.Size(200, 60);
            this.btnMetarTaf.TabIndex = 7;
            this.btnMetarTaf.Text = "Metar/Taf";
            this.btnMetarTaf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMetarTaf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMetarTaf.UseVisualStyleBackColor = true;
            this.btnMetarTaf.Click += new System.EventHandler(this.btnMetarTaf_Click);
            // 
            // btnIACO
            // 
            this.btnIACO.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIACO.FlatAppearance.BorderSize = 0;
            this.btnIACO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIACO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIACO.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnIACO.IconChar = FontAwesome.Sharp.IconChar.PlaneArrival;
            this.btnIACO.IconColor = System.Drawing.Color.MediumBlue;
            this.btnIACO.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIACO.IconSize = 35;
            this.btnIACO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIACO.Location = new System.Drawing.Point(0, 120);
            this.btnIACO.Name = "btnIACO";
            this.btnIACO.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnIACO.Size = new System.Drawing.Size(200, 60);
            this.btnIACO.TabIndex = 6;
            this.btnIACO.Text = "İCAO";
            this.btnIACO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIACO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIACO.UseVisualStyleBackColor = true;
            this.btnIACO.Click += new System.EventHandler(this.btnIACO_Click);
            // 
            // btnGemiler
            // 
            this.btnGemiler.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGemiler.FlatAppearance.BorderSize = 0;
            this.btnGemiler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGemiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGemiler.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnGemiler.IconChar = FontAwesome.Sharp.IconChar.Plane;
            this.btnGemiler.IconColor = System.Drawing.Color.MediumBlue;
            this.btnGemiler.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGemiler.IconSize = 35;
            this.btnGemiler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGemiler.Location = new System.Drawing.Point(0, 60);
            this.btnGemiler.Name = "btnGemiler";
            this.btnGemiler.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnGemiler.Size = new System.Drawing.Size(200, 60);
            this.btnGemiler.TabIndex = 5;
            this.btnGemiler.Text = "Hava Gəmiləri";
            this.btnGemiler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGemiler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGemiler.UseVisualStyleBackColor = true;
            this.btnGemiler.Click += new System.EventHandler(this.btnGemiler_Click);
            // 
            // btnİsciler
            // 
            this.btnİsciler.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnİsciler.FlatAppearance.BorderSize = 0;
            this.btnİsciler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnİsciler.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnİsciler.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnİsciler.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnİsciler.IconColor = System.Drawing.Color.MediumBlue;
            this.btnİsciler.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnİsciler.IconSize = 35;
            this.btnİsciler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnİsciler.Location = new System.Drawing.Point(0, 0);
            this.btnİsciler.Name = "btnİsciler";
            this.btnİsciler.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnİsciler.Size = new System.Drawing.Size(200, 60);
            this.btnİsciler.TabIndex = 4;
            this.btnİsciler.Text = "İşci Cədvəli";
            this.btnİsciler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnİsciler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnİsciler.UseVisualStyleBackColor = true;
            this.btnİsciler.Click += new System.EventHandler(this.btnİsciler_Click);
            // 
            // panelDekstop
            // 
            this.panelDekstop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDekstop.Location = new System.Drawing.Point(200, 28);
            this.panelDekstop.Name = "panelDekstop";
            this.panelDekstop.Size = new System.Drawing.Size(840, 498);
            this.panelDekstop.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1040, 526);
            this.ControlBox = false;
            this.Controls.Add(this.panelDekstop);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Project";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project";
            this.panel1.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnMinimum;
        private FontAwesome.Sharp.IconButton btnNormal;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnAirLive;
        private FontAwesome.Sharp.IconButton brtnFlightRadar;
        private FontAwesome.Sharp.IconButton btnMetarTaf;
        private FontAwesome.Sharp.IconButton btnIACO;
        private FontAwesome.Sharp.IconButton btnGemiler;
        private FontAwesome.Sharp.IconButton btnİsciler;
        private FontAwesome.Sharp.IconButton btnGooogleEarth;
        private FontAwesome.Sharp.IconButton btnParametr;
        private System.Windows.Forms.Panel panelDekstop;
        private System.Windows.Forms.Timer timer1;
    }
}

