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
    public partial class XtraForm1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public XtraForm1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// here we should use method to call methods in list array of int there multiple methods to calls
        /// 
        private void getreturn()
        {
            if (!panel1.Controls.Contains(getreturning.Inst))
            {
                panel1.Controls.Add(getreturning.Inst);
                getreturning.Inst.Dock = DockStyle.Fill;
                getreturning.Inst.BringToFront();

            }
            else
            {
                getreturning.Inst.BringToFront();
            }
        }
        private void getPatient()
        {
            if (!panel1.Controls.Contains(patient.Inst))
            {
                panel1.Controls.Add(patient.Inst);
                patient.Inst.Dock = DockStyle.Fill;
                patient.Inst.BringToFront();

            }
            else
            {
                patient.Inst.BringToFront();
            }
        }
        private void getInfo()
        {
            if (!panel1.Controls.Contains(info.Inst))
            {
                panel1.Controls.Add(info.Inst);
                info.Inst.Dock = DockStyle.Fill;
                info.Inst.BringToFront();

            }
            else
            {
                info.Inst.BringToFront();
            }
        }
        private void getborrow()
        {
            if (!panel1.Controls.Contains(getborrowing.Inst))
            {
                panel1.Controls.Add(getborrowing.Inst);
                getborrowing.Inst.Dock = DockStyle.Fill;
                getborrowing.Inst.BringToFront();

            }
            else
            {
                getborrowing.Inst.BringToFront();
            }
        }

        /// <summary>
        /// ////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

       

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.getInfo();
        }

        private void barButtonItem2_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.getPatient();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.getreturn();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.getPatient();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.getreturn();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
             this.getInfo();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.getborrow();
        }
    }
}