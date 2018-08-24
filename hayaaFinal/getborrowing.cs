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
    public partial class getborrowing : DevExpress.XtraEditors.XtraUserControl
    {
        public getborrowing()
        {
            InitializeComponent();
        }

        private void getborrowing_Load(object sender, EventArgs e)
        {
            Program.createAdapter("Select * From borrowing ");
            Program.FillData("borrowing", borrowGrid);
        }
    }
}
