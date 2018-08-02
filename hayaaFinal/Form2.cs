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
        int peast;
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
    }
}
