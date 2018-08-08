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
    public partial class getreturning : DevExpress.XtraEditors.XtraUserControl
    {

        private static   getreturning  _inst;
        public static getreturning Inst
        {

            get
            {
                if (_inst == null)


                    _inst = new getreturning();
                _inst.BringToFront();
                return _inst;



            }

        }
        public getreturning()
        {
            InitializeComponent();
        }

        private void getreturning_Load(object sender, EventArgs e)
        {
            Program.createAdapter("Select * From returning");
            Program.FillData("returning", gridControl1);
        }
    }
}
