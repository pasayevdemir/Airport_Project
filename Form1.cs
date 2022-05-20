using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes;
using FontAwesome.Sharp;

namespace WindowsFormsApp1
{
    public partial class Project : Form
    {
        //Saheler
        private IconDizain ıconDizain = new IconDizain();
        private ChildForm childForm = new ChildForm();
        public Project()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        //Struct
        private struct RNGColors
        {
            public static Color clr1 = Color.FromArgb(172, 126, 241);
            public static Color clr2 = Color.FromArgb(249, 118, 176);
            public static Color clr3 = Color.FromArgb(253, 138, 114);
            public static Color clr4 = Color.FromArgb(95, 77, 221);
            public static Color clr5 = Color.FromArgb(249, 88, 155);
            public static Color clr6 = Color.FromArgb(24, 161, 251);
        }

        //Metodlar
        
        //Control Box
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Button cixis
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.IconColor = Color.White;
            btnClose.BackColor = Color.Red;
        }
 
        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.IconColor = Color.Red;
            btnClose.BackColor = Color.White;
        }

        //Button Normal
        private void btnNormal_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                btnNormal.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                btnNormal.IconChar = FontAwesome.Sharp.IconChar.Square;
            }
        }

        private void btnMinimum_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        
        //icon Buttonlari ucun event
        private void btnİsciler_Click(object sender, EventArgs e)
        {
            ıconDizain.ActiveButton(sender, RNGColors.clr1, panelMenu);
            childForm.childForm(new Isciler(),panelDekstop);
        }

        private void btnGemiler_Click(object sender, EventArgs e)
        {
            this.Size = new Size(Size.Width, 545);
            ıconDizain.ActiveButton(sender, RNGColors.clr2, panelMenu);
            childForm.childForm(new HavaGemi(),panelDekstop);
            
        }

        private void btnIACO_Click(object sender, EventArgs e)
        {
            this.Size = new Size(this.Size.Width+100, 528);
            ıconDizain.ActiveButton(sender, RNGColors.clr3, panelMenu);
            childForm.childForm(new ICAO(),panelDekstop);
        }

        private void btnMetarTaf_Click(object sender, EventArgs e)
        {
            ıconDizain.ActiveButton(sender, RNGColors.clr4, panelMenu);
            childForm.childForm(new MetarTaf(),panelDekstop);
        }

        private void brtnFlightRadar_Click(object sender, EventArgs e)
        {
            ıconDizain.ActiveButton(sender, RNGColors.clr5, panelMenu);
            childForm.childForm(new FlightRadar(),panelDekstop);
        }

        private void btnAirLive_Click(object sender, EventArgs e)
        {
            ıconDizain.ActiveButton(sender, RNGColors.clr6, panelMenu);
            childForm.childForm(new AirLive(),panelDekstop);
        }

        private void btnGooogleEarth_Click(object sender, EventArgs e)
        {
            ıconDizain.ActiveButton(sender, RNGColors.clr4, panelMenu);
            childForm.childForm(new GooogleEarth(),panelDekstop);
        }

        private void btnParametr_Click(object sender, EventArgs e)
        {
            ıconDizain.ActiveButton(sender, RNGColors.clr3, panelMenu);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
