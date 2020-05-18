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
    public partial class user_history : Form
    {
        public user_history()
        {
            InitializeComponent();

            Query_history_operation query_History_Operation = new Query_history_operation(); //查询操作类
            ArrayList query = query_History_Operation.return_query_history("9670"); // 需要重写的那个查询函数  9670应为用户名；
            for (int i = 0; i <query.Count ; i++ )
            {

                Query_history query_out_his = (Query_history)query[i];
           
                int index = this.dataGridView1.Rows.Add();

                this.dataGridView1.Rows[index].Cells[0].Value = query_out_his.REQUEST_DATE;  //时间

                this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.TARGET_NAME;   //资源名称

                this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.PERSON_BUSINESS_TITLE;  //操作类型

                this.dataGridView1.Rows[index].Cells[3].Value = query_out_his.PERSON_BUSINESS_TITLE_DETAIL;  //授权结果
            }
            // System.Console.WriteLine(Static.query_history_index.Count);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //界面替换 点击查询历史界面中的返回按钮  回到查询界面
            user_query form = new user_query();
            form.Show();
            this.Dispose();
        }
        //关闭子窗口，同时结束父窗口
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            Application.Exit(e);
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = true; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void user_history_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if((string)comboBox1.SelectedItem == "全部")
            {
                this.dataGridView1.Rows.Clear();
                Query_history_operation query_History_Operation = new Query_history_operation(); //查询操作类
                ArrayList query = query_History_Operation.return_query_history("9670"); // 需要重写的那个查询函数
                for (int i = 0; i < query.Count; i++)
                {
                    Query_history query_out_his = (Query_history)query[i];

                    int index = this.dataGridView1.Rows.Add();

                    this.dataGridView1.Rows[index].Cells[0].Value = query_out_his.REQUEST_DATE;  //时间

                    this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.TARGET_NAME;   //资源名称

                    this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.PERSON_BUSINESS_TITLE;  //操作类型

                    this.dataGridView1.Rows[index].Cells[3].Value = query_out_his.ACTION;  //授权结果
                }
            }
            if ((string)comboBox1.SelectedItem == "半年内")
            {
                this.dataGridView1.Rows.Clear();
                Query_history_operation query_History_Operation = new Query_history_operation(); //查询操作类
                ArrayList query = query_History_Operation.return_query_history("9670"); // 需要重写的那个查询函数
                for (int i = 0; i < query.Count; i++)
                {
                    Query_history query_out_his = (Query_history)query[i];
                    TimeSpan time_dis = DateTime.Now - query_out_his.REQUEST_DATE;
                    double time_ = time_dis.TotalDays;
                    if(time_ <= 180) { 

                        int index = this.dataGridView1.Rows.Add();

                        this.dataGridView1.Rows[index].Cells[0].Value = query_out_his.REQUEST_DATE;  //时间

                        this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.TARGET_NAME;   //资源名称

                        this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.PERSON_BUSINESS_TITLE;  //操作类型

                        this.dataGridView1.Rows[index].Cells[3].Value = query_out_his.ACTION;  //授权结果

                    }

                }
            }
            if ((string)comboBox1.SelectedItem == "三个月内")
            {
                this.dataGridView1.Rows.Clear();
                Query_history_operation query_History_Operation = new Query_history_operation(); //查询操作类
                ArrayList query = query_History_Operation.return_query_history("9670"); // 需要重写的那个查询函数
                for (int i = 0; i < query.Count; i++)
                {
                    Query_history query_out_his = (Query_history)query[i];
                    TimeSpan time_dis = DateTime.Now - query_out_his.REQUEST_DATE;
                    double time_ = time_dis.TotalDays;
                    if (time_ <= 90.0)
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
                ArrayList query = query_History_Operation.return_query_history("9670"); // 需要重写的那个查询函数
                for (int i = 0; i < query.Count; i++)
                {
                    Query_history query_out_his = (Query_history)query[i];
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
                ArrayList query = query_History_Operation.return_query_history("9670"); // 需要重写的那个查询函数
                for (int i = 0; i < query.Count; i++)
                {
                    Query_history query_out_his = (Query_history)query[i];
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
            if ((string)comboBox1.SelectedItem == "今天")
            {
                this.dataGridView1.Rows.Clear();
                Query_history_operation query_History_Operation = new Query_history_operation(); //查询操作类
                ArrayList query = query_History_Operation.return_query_history("9670"); // 需要重写的那个查询函数
                for (int i = 0; i < query.Count; i++)
                {
                    Query_history query_out_his = (Query_history)query[i];
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
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)comboBox2.SelectedItem == "允许")
            {
                this.dataGridView1.Rows.Clear();
                Query_history_operation query_History_Operation = new Query_history_operation(); //查询操作类
                ArrayList query = query_History_Operation.return_query_history("9670"); // 需要重写的那个查询函数
                for (int i = 0; i < query.Count; i++)
                {
                    Query_history query_out_his = (Query_history)query[i];
                    TimeSpan time_dis = DateTime.Now - query_out_his.REQUEST_DATE;
                    double time_ = time_dis.TotalDays;
                    if (query_out_his.ACTION == "允许")
                    {

                        int index = this.dataGridView1.Rows.Add();

                        this.dataGridView1.Rows[index].Cells[0].Value = query_out_his.REQUEST_DATE;  //时间

                        this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.TARGET_NAME;   //资源名称

                        this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.PERSON_BUSINESS_TITLE;  //操作类型

                        this.dataGridView1.Rows[index].Cells[3].Value = query_out_his.ACTION;  //授权结果

                    }

                }
            }
            if ((string)comboBox2.SelectedItem == "拒绝")
            {
                this.dataGridView1.Rows.Clear();
                Query_history_operation query_History_Operation = new Query_history_operation(); //查询操作类
                ArrayList query = query_History_Operation.return_query_history("9670"); // 需要重写的那个查询函数
                for (int i = 0; i < query.Count; i++)
                {
                    Query_history query_out_his = (Query_history)query[i];
                    TimeSpan time_dis = DateTime.Now - query_out_his.REQUEST_DATE;
                    double time_ = time_dis.TotalDays;
                    if (query_out_his.ACTION == "拒绝")
                    {

                        int index = this.dataGridView1.Rows.Add();

                        this.dataGridView1.Rows[index].Cells[0].Value = query_out_his.REQUEST_DATE;  //时间

                        this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.TARGET_NAME;   //资源名称

                        this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.PERSON_BUSINESS_TITLE;  //操作类型

                        this.dataGridView1.Rows[index].Cells[3].Value = query_out_his.ACTION;  //授权结果

                    }

                }
            }
            if ((string)comboBox2.SelectedItem == "待处理")
            {
                this.dataGridView1.Rows.Clear();
                Query_history_operation query_History_Operation = new Query_history_operation(); //查询操作类
                ArrayList query = query_History_Operation.return_query_history("9670"); // 需要重写的那个查询函数
                for (int i = 0; i < query.Count; i++)
                {
                    Query_history query_out_his = (Query_history)query[i];
                    TimeSpan time_dis = DateTime.Now - query_out_his.REQUEST_DATE;
                    double time_ = time_dis.TotalDays;
                    if (query_out_his.ACTION == "待处理")
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
