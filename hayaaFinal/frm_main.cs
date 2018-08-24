using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace hayaaFinal
{
    public partial class frm_main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void test_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UserDBs frm = new UserDBs();
            frm.Name = "userDBs";
            viewChild(frm);

        }


        private void frm_main_Load(object sender, EventArgs e)
        {

        }
        private Boolean isActive(Form _child)
        {
            Boolean opened = false;
            if (MdiChildren.Count() > 0)
            {
                foreach (var item in MdiChildren)
                {
                    if (_child.Name == item.Name)
                    {
                        xtraTabbedMdiManager1.Pages[item].MdiChild.Activate();
                        opened = true;
                    }
                }
            }
            return opened;
        }
        private void viewChild(Form _child)
        {


            if (!isActive(_child))
            {
                _child.MdiParent = this;
                _child.Show();
            }

        }



    }
}