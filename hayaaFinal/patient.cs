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
    public partial class patient : System.Windows.Forms.UserControl
    {

        private static patient _inst;
        public static patient Inst
        {

            get
            {
                if (_inst == null)


                    _inst = new patient();
                _inst.BringToFront();
                return _inst;



            }

        }
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
