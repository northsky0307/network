using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class user_do_search : Form
    {
        public user_do_search()
        {
            InitializeComponent();
        }

       
        public DataSet getData()

        {

            //打开文件

            OpenFileDialog file = new OpenFileDialog();

            file.Filter = "Excel(*.xls)| *.xls";

            file.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            file.Multiselect = false;

            if (file.ShowDialog() == DialogResult.Cancel)

                return null;

            //判断文件后缀

            var path = file.FileName;

            string filesuffix = System.IO.Path.GetExtension(path);

            if (string.IsNullOrEmpty(filesuffix))

                return null;

            using (DataSet ds = new DataSet())

            {

                //判断Excel文件时什么版本

                string connString = "";

                if (filesuffix == ".xls")

                    connString = "Provider = Microsoft.Jet.OLEDB.4.0;" + "Data Source =" + path + ";" + "; Extended Properties = \"Excel 8.0; HDR = YES; IMEX = 1 \"";

                else

                    connString = "Provider = Microsoft.ACE.OLEDB.12.0;" + "Data Source =" + path + ";" + "; Extended Properties = \"Excel 12.0; HDR = YES; IMEX = 1 \"";

                //读取文件

                string sql_select = "SELECT* FROM[Sheet1$]";

                using (OleDbConnection conn = new OleDbConnection(connString))

                using (OleDbDataAdapter cmd = new OleDbDataAdapter(sql_select, conn))

                {

                    NewMethod1(conn);

                    cmd.Fill(ds);

                }

                if (ds == null || ds.Tables.Count <= 0) return null;

                return ds;

            }

        }

        private static void NewMethod1(OleDbConnection conn)

        {

            conn.Open();

        }

        private void button1_Click(object sender, EventArgs e)

        {
            user_query return_user_query = new user_query();
            return_user_query.Show();
            this.Dispose();

            try

            {

                dataGridView1.DataSource = null; //每次打开清空内容

                dataGridView1.DataSource = NewMethod().Tables[0];

            }

            catch (Exception ex)

            {

            }

        }

        private DataSet NewMethod()

        {

            return getData();

        }

    }
}
