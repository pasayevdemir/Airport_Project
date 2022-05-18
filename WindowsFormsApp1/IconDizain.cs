using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class IconDizain
    {
        //Feilds
        private IconButton currentBtn = new IconButton();
        private Panel leftPnl = new Panel();

        //Methods
        public void ActiveButton(object senderBtn, Color color, Panel panelMenu)
        {
            leftPnl.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftPnl);
            if (senderBtn != null)
            {
                DisbandButton();
                //Button parametrlerinin verilmesi
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.White;
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //left panel 
                leftPnl.BackColor = color;
                leftPnl.Location = new Point(0, currentBtn.Location.Y);
                leftPnl.Visible = true;
                leftPnl.BringToFront();
            }
        }

        public void DisbandButton()//
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.Gainsboro;
                currentBtn.ForeColor = Color.DarkSlateGray;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.RoyalBlue;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
    }
}
