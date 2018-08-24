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
    public partial class UserDBs : DevExpress.XtraEditors.XtraForm
    {
        public UserDBs()
        {
            InitializeComponent();
        }
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

        private void getreturning1_Load(object sender, EventArgs e)
        {

        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this.getborrow();
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this.getreturn();
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
           this.getPatient();
        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }

        private void UserDBs_Load(object sender, EventArgs e)
        {
            panel1.Dock = DockStyle.Fill;
        }

        private void patient1_Load(object sender, EventArgs e)
        {

        }
    }
}