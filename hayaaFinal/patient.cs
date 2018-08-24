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
    public partial class patient : DevExpress.XtraEditors.XtraUserControl
    {
        public patient()
        {
            InitializeComponent();
        }

        private void patient_Load(object sender, EventArgs e)
        {
            Program.createAdapter("Select * From patient");
            Program.FillData("patient", gridControl1);
        }
    }
}
