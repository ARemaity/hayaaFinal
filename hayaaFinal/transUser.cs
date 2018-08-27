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
using System.Data.SqlClient;

namespace hayaaFinal
{
    public partial class text2 : DevExpress.XtraEditors.XtraForm
    {
        
public static SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-OAREN3E\ALI;Initial Catalog=haya;Integrated Security=True");

        public static SqlCommand comm = new SqlCommand();
        public text2()
        {
            InitializeComponent();
        }
       
        private void officeNavigationBar1_Click(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void transUser_Load(object sender, EventArgs e)
        {
            Program.createAdapter("Select * From Patient ");
            Program.FillData2("Patient", dataGridView1);
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void اضافة_Click(object sender, EventArgs e)
        {
            ////(اسم_المريض,رقم_الهاتف,العمر,السكن
            comm = new SqlCommand ("insert into Patient values ('" + textb1.Text + "','" + textb2.Text + "','" + textb3.Text + "','" + textb4.Text + "')", sqlcon);
            sqlcon.Open();
            try
            {
                comm.ExecuteNonQuery();
                MessageBox.Show("Saved...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"Not Saved");
            }
            finally
            {
                sqlcon.Close();
            }


        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
          
        }
    }
}