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




        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new intro());
        }
    }
}
