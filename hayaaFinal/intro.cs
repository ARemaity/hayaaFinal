using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hayaaFinal
{
    public partial class intro : DevExpress.XtraEditors.XtraForm
    {

        public intro()
        {
            InitializeComponent();
            login a = new login();
            Form2 form2 = new Form2();

        }

        private void intro_Load(object sender, EventArgs e)
        {
            Thread.Sleep(6000);
        }

        private void adminTile_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
        
            login a = new login();
            a.ShowDialog();

        }

        private void tileItem2_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {

        }

        private void tileControl1_Click(object sender, EventArgs e)
        {

        }

        private void tileItem8_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {

        }
    }
}
