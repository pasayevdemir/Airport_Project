using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes
{
    class ChildForm
    {
        //Feilds
        private Form form=new Form();


        //Methods
        public void childForm(Form kicikForm,Panel panelDesktop)
        {
            if(form != null)
            {
                form.Close();
            }
            form = kicikForm;
            kicikForm.TopLevel = false;
            kicikForm.BackColor = Color.White;
            kicikForm.FormBorderStyle = FormBorderStyle.None;
            kicikForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(kicikForm);
            panelDesktop.Tag = kicikForm;
            kicikForm.BringToFront();
            kicikForm.Show();
        }
    }

}
