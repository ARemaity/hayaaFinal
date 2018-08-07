using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hayaaFinal
{
    public partial class Form2 : DevExpress.XtraEditors.XtraForm
    {
#pragma warning disable CS0169 // The field 'Form2.peast' is never used
        int peast;
#pragma warning restore CS0169 // The field 'Form2.peast' is never used


        returning r1 = new returning();
        public Form2()
        {
            InitializeComponent();
            
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            headerbar.Width = this.Width +100;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }
    }
}
