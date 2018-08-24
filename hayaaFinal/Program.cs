using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;

namespace hayaaFinal
{
    static class Program
    {
        public static SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-OAREN3E\ALI;Initial Catalog=haya;Integrated Security=True");
        public static SqlDataAdapter da = new SqlDataAdapter();
        public static DataSet ds = new DataSet();
        public static DataTable dt = new DataTable();
        public static void createAdapter(String sql)
        {
            da= new SqlDataAdapter(sql, sqlcon);
        }

        public static void FillData(string tables,GridControl dataGrid)
        {
        
            // Fill Dataset
            da.Fill(ds,tables);

            // Display data
            dataGrid.DataSource = ds.Tables[tables];
        }


/// <summary>
/// //user not allow to edt dirctly and delete form the gridview 
/// //add the borrow userconrtrol o use and return and add adding user uservcontrol
/// //after finish the user main form begin with admin form then use the asyc aswit 
/// then see what to make with he sq lconnection 
/// //after that see what to make to the wikzard installer 
/// after that finlaize to all design 
/// 
/// 
///
/// </summary>

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new intro());
        }
    }
}
