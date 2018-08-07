using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace hayaaFinal
{
    public partial class returning : System.Windows.Forms.UserControl
    {
        public returning()
        {
            InitializeComponent();
        }

        private void returningGrid_Click(object sender, EventArgs e)
        {

        }

        private void returning_Load(object sender, EventArgs e)
        {
            Program.createAdapter("select * From User");
            Program.FillData("User", returnGrid);
        }
    }
}
