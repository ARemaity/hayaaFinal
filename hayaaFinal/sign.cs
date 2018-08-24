using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hayaaFinal
{
    public partial class sign : DevExpress.XtraEditors.XtraForm
    {
       
        public static SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-OAREN3E\ALI;Initial Catalog=haya;Integrated Security=True");
        public sign()
        {
            InitializeComponent();



        }

        private void usernametext_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void passwordtext_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            string query = "Select * from login Where username = '" + usernametext.Text.Trim() + "' and password = '" + passwordtext.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                frm_main objFrmMain = new frm_main();
                this.Hide();
                objFrmMain.Show();
            }

            else
            {
                MessageBox.Show("اسم المستخدم او كلمة المرور غير صحيحة ", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void sign_Load(object sender, EventArgs e)
        {

        }
    }
    }
