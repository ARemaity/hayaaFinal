using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hayaaFinal
{
    public partial class sign : DevExpress.XtraEditors.XtraForm
    {
        private klmtmororDataContext klmtmoror = new klmtmororDataContext();
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
        { if (String.IsNullOrEmpty(usernametext.Text))
            {
                MessageBox.Show("الرجاء ادخال المعلومات", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernametext.Focus();
                return;
            }
            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-OAREN3E\\ALI;Initial Catalog=haya;Integrated Security=True");
                string query = "Select * from login Where username = '" + usernametext.Text.Trim() + "' and password = '" + passwordtext.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);////////////////////////there is wrong in code 
                //TODO:
                if (dtbl.Rows.Count == 1)
                {
                    Form2 objFrmMain = new Form2();
                    this.Hide();
                    objFrmMain.Show();
                }
                else
                {
                    MessageBox.Show("اسم المستخدم او كلمة المرور غير صحيحة ", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } 
            
            ///catch (Exception ex)
           /// {
            ///    MessageBox.Show(ex.Message);
           /// }
        }  

        private void sign_Load(object sender, EventArgs e)
        {

        }
    }
    }
