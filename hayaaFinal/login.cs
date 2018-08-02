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
    public partial class login : DevExpress.XtraEditors.XtraForm
    {
        public login()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 admin = new Form2();
            admin.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            this.Hide();

        }

        private void login_Load(object sender, EventArgs e)
        {
            /////////////////////                       FOR THE FORM 
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ///NOT VALID 
            ///
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                simpleButton1.PerformClick();
            }
        }

        private void simpleButton1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("الرجاء ادخال اسم المستخدم", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ///////////not valid 
        }
    }
}
