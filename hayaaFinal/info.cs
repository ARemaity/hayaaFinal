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


    public partial class info : System.Windows.Forms.UserControl
    {
        private static info _inst;
        public static info Inst
        {

            get
            {
                if (_inst == null)


                    _inst = new info();
                _inst.BringToFront();
                return _inst;

            }

            }
        public info()
        {
            InitializeComponent();
        }
    }
}
