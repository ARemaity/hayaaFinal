using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hayaaFinal
{
    public partial class Form2 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
#pragma warning disable CS0169 // The field 'Form2.peast' is never used
        int peast;
#pragma warning restore CS0169 // The field 'Form2.peast' is never used

        public Form2()
        {
            InitializeComponent();
            
        }

        
        

       // private void Form2_Resize(object sender, EventArgs e)
      //  {
      //      headerbar.Width = this.Width +100;
       //     panel1.Width = this.Width - navBarControl1.Width;
      //  }

        private void Form2_Load(object sender, EventArgs e)
        {
            //panel1.Controls.Add(getborrowing.Inst);
            // getborrowing.Inst.Dock = DockStyle.Fill;
            //  getborrowing.Inst.BringToFront();
            this.getborrow();
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

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.getPatient();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.getborrow();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.getreturn();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.getPatient();
        }

        /// 
        /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <param name=""></param>
        /// <param name=""></param>


    }
}
