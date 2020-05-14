﻿using System;
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
    public partial class user_history : Form
    {
        public user_history()
        {
            InitializeComponent();
            
            for (int i = 0; i < Static.query_history_index.Count ; i++ )
            {
                Query_history query_out_his = (Query_history)Static.query_history_index[i];
           
                int index = this.dataGridView1.Rows.Add();

                this.dataGridView1.Rows[index].Cells[0].Value = query_out_his.REQUEST_DATE;  //时间

                this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.TARGET_NAME;   //资源名称

                this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.PERSON_BUSINESS_TITLE;  //操作类型

                this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.PERSON_BUSINESS_TITLE_DETAIL;  //授权结果
            }

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

        }
    }
}
