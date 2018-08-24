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
    public partial class getborrowing : System.Windows.Forms.UserControl
    {

        private static getborrowing _inst;
        public static getborrowing Inst
        {

            get
            {
                if (_inst == null)
               

                    _inst = new getborrowing();
                    _inst.BringToFront();
                    return _inst;

               
              
            }
           
        }
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
