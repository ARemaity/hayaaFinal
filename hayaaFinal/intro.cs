﻿using System;
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
           
           
        }

        private void intro_Load(object sender, EventArgs e)
        {
            Thread.Sleep(6000);
        }

        private void adminTile_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
        
            sign a = new sign();
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

        private void tileItem2_ItemClick_1(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frm_main frm = new frm_main();
            frm.Show();
        }
    }
}
