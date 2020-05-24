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
    public partial class ad_rules_ch_3 : Form
    {
        public ad_rules_ch_3()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            for (int i = 6001; i < 9000/*Static.rule_index.Count*/; i++)
            {
                Rule query_out_his = (Rule)Static.rule_index[i];

                int index = this.dataGridView1.Rows.Add();

                this.dataGridView1.Rows[index].Cells[0].Value = query_out_his.TARGET_NAME;  //资源类型

                this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.PERSON_MGR_ID;   //用户类型

                this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.PERSON_ROLLUP_2;  //操作类型

                this.dataGridView1.Rows[index].Cells[3].Value = query_out_his.ACTION;  //返回结果

                this.dataGridView1.Rows[index].Cells[4].Value = query_out_his.PERSON_BUSINESS_TITLE;
                this.dataGridView1.Rows[index].Cells[5].Value = query_out_his.PERSON_BUSINESS_TITLE_DETAIL;
                this.dataGridView1.Rows[index].Cells[6].Value = query_out_his.PERSON_COMPANY;
                this.dataGridView1.Rows[index].Cells[7].Value = query_out_his.PERSON_DEPTNAME;
                this.dataGridView1.Rows[index].Cells[8].Value = query_out_his.PERSON_JOB_FAMILY;
                this.dataGridView1.Rows[index].Cells[9].Value = query_out_his.PERSON_LOCATION;
                this.dataGridView1.Rows[index].Cells[10].Value = query_out_his.PERSON_JOB_CODE;
                this.dataGridView1.Rows[index].Cells[11].Value = query_out_his.PERSON_ROLLUP_1;
                this.dataGridView1.Rows[index].Cells[12].Value = query_out_his.PERSON_ROLLUP_3;


            }

            DataGridViewButtonColumn btnDELETE = new DataGridViewButtonColumn();
            btnDELETE.Name = "btnDELETE";
            btnDELETE.HeaderText = "删除";
            btnDELETE.DefaultCellStyle.NullValue = "删除";
            btnDELETE.Width = 61;
            dataGridView1.Columns.Add(btnDELETE);

            DataGridViewButtonColumn btnMDF = new DataGridViewButtonColumn();
            btnMDF.Name = "btnMDF";
            btnMDF.HeaderText = "修改";
            btnMDF.DefaultCellStyle.NullValue = "修改";
            btnMDF.Width = 61;
            dataGridView1.Columns.Add(btnMDF);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin_func_choose form = new admin_func_choose();
            form.Show();
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ad_rules_ch_4 form = new ad_rules_ch_4();
            form.Show();
            this.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ad_rules_ch_2 form = new ad_rules_ch_2();
            form.Show();
            this.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnMDF" && e.RowIndex >= 0)  //单击修改
            {
                ad_ch_success form = new ad_ch_success();
                form.Show();
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnDELETE" && e.RowIndex >= 0)  //单击删除
            {
                dataGridView1.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void ad_rules_ch_3_Load(object sender, EventArgs e)
        {

        }
    }
}
