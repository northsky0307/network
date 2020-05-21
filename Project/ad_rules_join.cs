using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class ad_rules_join : Form
    {
        public ad_rules_join()
        {
            InitializeComponent();

            DataGridViewButtonColumn btnADD = new DataGridViewButtonColumn();
            btnADD.Name = "btnADD";
            btnADD.HeaderText = "增加";
            btnADD.DefaultCellStyle.NullValue = "增加";
            btnADD.Width = 61;
            dataGridView1.Columns.Add(btnADD);

            //DataGridViewButtonColumn btnMDF = new DataGridViewButtonColumn();
            //btnMDF.Name = "btnMDF";
            //btnMDF.HeaderText = "修改";
            //btnMDF.DefaultCellStyle.NullValue = "修改";
            //btnMDF.Width = 61;
            //dataGridView1.Columns.Add(btnMDF);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin_func_choose form = new admin_func_choose();
            form.Show();
            this.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnADD" && e.RowIndex >= 0)  //单击添加
            {
                ad_ad_success form = new ad_ad_success();
                form.Show();
            }
        }
    }
}
