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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread.Sleep(6000);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exit_StyleChanged(object sender, EventArgs e)
        {
           
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void navBarControl1_Click(object sender, EventArgs e)
        {

        }
    }
    }

