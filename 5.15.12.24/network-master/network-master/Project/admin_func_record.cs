using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Project
{
    public partial class admin_func_record : Form
    {
        public admin_func_record()
        {
            InitializeComponent();

            Query_history_operation query_History_Operation = new Query_history_operation(); //查询操作类
            
            for (int i = 0; i < Static.query_history_index.Count; i++)
            {

                Query_history query_out_his = (Query_history)Static.query_history_index[i];

                int index = this.dataGridView1.Rows.Add();

                this.dataGridView1.Rows[index].Cells[0].Value = query_out_his.REQUEST_DATE;  //时间

                this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.TARGET_NAME;   //资源名称

                this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.PERSON_BUSINESS_TITLE;  //操作类型

                this.dataGridView1.Rows[index].Cells[3].Value = query_out_his.PERSON_BUSINESS_TITLE_DETAIL;  //授权结果

                this.dataGridView1.Rows[index].Cells[4].Value = query_out_his.PERSON_MGR_ID;   //用户名
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin_func_choose form = new admin_func_choose();
            form.Show();
            this.Hide();
        }

        private void admin_func_record_Load(object sender, EventArgs e)
        {

        }
        //关闭子窗口，同时结束父窗口
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            Application.Exit(e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)comboBox1.SelectedItem == "全部")
            {
                this.dataGridView1.Rows.Clear();
                Query_history_operation query_History_Operation = new Query_history_operation(); //查询操作类
                //ArrayList query = query_History_Operation.return_query_history("9670"); // 需要重写的那个查询函数
                for (int i = 0; i < Static.query_history_index.Count; i++)
                {
                    Query_history query_out_his = (Query_history)Static.query_history_index[i];

                    int index = this.dataGridView1.Rows.Add();

                    this.dataGridView1.Rows[index].Cells[0].Value = query_out_his.REQUEST_DATE;  //时间

                    this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.PERSON_DEPTNAME;   //资源名称

                    this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.PERSON_JOB_CODE;  //操作类型

                    this.dataGridView1.Rows[index].Cells[3].Value = query_out_his.ACTION;  //授权结果
                }
            }
            if ((string)comboBox1.SelectedItem == "半年内")
            {
                this.dataGridView1.Rows.Clear();
                Query_history_operation query_History_Operation = new Query_history_operation(); //查询操作类
                //ArrayList query = query_History_Operation.return_query_history("9670"); // 需要重写的那个查询函数
                for (int i = 0; i < Static.query_history_index.Count; i++)
                {
                    Query_history query_out_his = (Query_history)Static.query_history_index[i];
                    TimeSpan time_dis = DateTime.Now - query_out_his.REQUEST_DATE;
                    double time_ = time_dis.TotalDays;
                    if (time_ <= 180)
                    {

                        int index = this.dataGridView1.Rows.Add();

                        this.dataGridView1.Rows[index].Cells[0].Value = query_out_his.REQUEST_DATE;  //时间

                        this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.TARGET_NAME;   //资源名称

                        this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.PERSON_BUSINESS_TITLE;  //操作类型

                        this.dataGridView1.Rows[index].Cells[3].Value = query_out_his.ACTION;  //授权结果

                    }

                }
            }
            if ((string)comboBox1.SelectedItem == "三天内")
            {
                this.dataGridView1.Rows.Clear();
                Query_history_operation query_History_Operation = new Query_history_operation(); //查询操作类
                //ArrayList query = query_History_Operation.return_query_history("9670"); // 需要重写的那个查询函数
                for (int i = 0; i < Static.query_history_index.Count; i++)
                {
                    Query_history query_out_his = (Query_history)Static.query_history_index[i];
                    TimeSpan time_dis = DateTime.Now - query_out_his.REQUEST_DATE;
                    double time_ = time_dis.TotalDays;
                    if (time_ <= 3.0)
                    {

                        int index = this.dataGridView1.Rows.Add();

                        this.dataGridView1.Rows[index].Cells[0].Value = query_out_his.REQUEST_DATE;  //时间

                        this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.TARGET_NAME;   //资源名称

                        this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.PERSON_BUSINESS_TITLE;  //操作类型

                        this.dataGridView1.Rows[index].Cells[3].Value = query_out_his.ACTION;  //授权结果

                    }

                }
            }
            if ((string)comboBox1.SelectedItem == "一个月内")
            {
                this.dataGridView1.Rows.Clear();
                Query_history_operation query_History_Operation = new Query_history_operation(); //查询操作类
                //ArrayList query = query_History_Operation.return_query_history("9670"); // 需要重写的那个查询函数
                for (int i = 0; i < Static.query_history_index.Count; i++)
                {
                    Query_history query_out_his = (Query_history)Static.query_history_index[i];
                    TimeSpan time_dis = DateTime.Now - query_out_his.REQUEST_DATE;
                    double time_ = time_dis.TotalDays;
                    if (time_ <= 30.0)
                    {

                        int index = this.dataGridView1.Rows.Add();

                        this.dataGridView1.Rows[index].Cells[0].Value = query_out_his.REQUEST_DATE;  //时间

                        this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.TARGET_NAME;   //资源名称

                        this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.PERSON_BUSINESS_TITLE;  //操作类型

                        this.dataGridView1.Rows[index].Cells[3].Value = query_out_his.ACTION;  //授权结果

                    }

                }
            }
            if ((string)comboBox1.SelectedItem == "一周内")
            {
                this.dataGridView1.Rows.Clear();
                Query_history_operation query_History_Operation = new Query_history_operation(); //查询操作类
                //ArrayList query = query_History_Operation.return_query_history("9670"); // 需要重写的那个查询函数
                for (int i = 0; i < Static.query_history_index.Count; i++)
                {
                    Query_history query_out_his = (Query_history)Static.query_history_index[i];
                    TimeSpan time_dis = DateTime.Now - query_out_his.REQUEST_DATE;
                    double time_ = time_dis.TotalDays;
                    if (time_ <= 7.0)
                    {

                        int index = this.dataGridView1.Rows.Add();

                        this.dataGridView1.Rows[index].Cells[0].Value = query_out_his.REQUEST_DATE;  //时间

                        this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.TARGET_NAME;   //资源名称

                        this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.PERSON_BUSINESS_TITLE;  //操作类型

                        this.dataGridView1.Rows[index].Cells[3].Value = query_out_his.ACTION;  //授权结果

                    }

                }
            }
            if ((string)comboBox1.SelectedItem == "一天内")
            {
                this.dataGridView1.Rows.Clear();
                Query_history_operation query_History_Operation = new Query_history_operation(); //查询操作类
                //ArrayList query = query_History_Operation.return_query_history("9670"); // 需要重写的那个查询函数
                for (int i = 0; i < Static.query_history_index.Count; i++)
                {
                    Query_history query_out_his = (Query_history)Static.query_history_index[i];
                    TimeSpan time_dis = DateTime.Now - query_out_his.REQUEST_DATE;
                    double time_ = time_dis.TotalDays;
                    if (time_ <= 1.0)
                    {

                        int index = this.dataGridView1.Rows.Add();

                        this.dataGridView1.Rows[index].Cells[0].Value = query_out_his.REQUEST_DATE;  //时间

                        this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.TARGET_NAME;   //资源名称

                        this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.PERSON_BUSINESS_TITLE;  //操作类型

                        this.dataGridView1.Rows[index].Cells[3].Value = query_out_his.ACTION;  //授权结果

                    }

                }
            }

            if ((string)comboBox1.SelectedItem == "被挂起")
            {
                this.dataGridView1.Rows.Clear();
                Query_history_operation query_History_Operation = new Query_history_operation(); //查询操作类
                                                                                                 // ArrayList query = query_History_Operation.return_query_history("9670"); // 需要重写的那个查询函数
                for (int i = 0; i < Static.query_history_index.Count; i++)
                {
                    Query_history query_out_his = (Query_history)Static.query_history_index[i];
                    TimeSpan time_dis = DateTime.Now - query_out_his.REQUEST_DATE;
                    double time_ = time_dis.TotalDays;
                    if (query_out_his.ACTION == "被挂起")
                    {

                        int index = this.dataGridView1.Rows.Add();

                        this.dataGridView1.Rows[index].Cells[0].Value = query_out_his.REQUEST_DATE;  //时间

                        this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.TARGET_NAME;   //资源名称

                        this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.PERSON_BUSINESS_TITLE;  //操作类型

                        this.dataGridView1.Rows[index].Cells[3].Value = query_out_his.ACTION;  //授权结果

                    }

                }
            }
        }
    }
}
