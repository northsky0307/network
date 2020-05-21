﻿using System;
using System.Collections;
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
    public partial class user_query : Form
    {

        public user_query()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        string RES;
        string WKTP;
        int RESnum = 0;
        int WKTPnum = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            //界面替换  点击查询历史按钮 进入历史界面
            user_history form = new user_history();
            form.Show();
            this.Dispose();
            

        }
            //关闭子窗口，同时结束父窗口
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            Application.Exit(e);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //界面替换 点击退出登录按钮  回到登陆界面
            Sign_in sign_In = new Sign_in();
            sign_In.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e) //查询
        {
            //string user_name = Static.name;
            //string user_name = Static.;
            RES = comboBox1.Text.Trim();
            int.TryParse(comboBox1.Text, out RESnum);
            //RESnum = int.Parse(RES);         //输入的int转换
            int.TryParse(comboBox2.Text, out WKTPnum);
            WKTP = comboBox2.Text.Trim();
            //WKTPnum = int.Parse(WKTP);
            if (RESnum != 0 && WKTPnum != 0)
            {
                Rule_operation search_rules = new Rule_operation();

                string result = search_rules.Find(/*comboBox1.Text*/RESnum, -1, -1, -1, -1, -1, -1, -1, -1/*用户名称*/, -1, WKTPnum/*comboBox2.Text*/, -1);

                if (result == "add_access")
                {
                    user_do_search user_Do_Search = new user_do_search();
                    user_Do_Search.Show();
                    this.Dispose();
                    //增加访问记录
                }
                else if (result == "remove_access")
                {
                    user_no_limit error_tip = new user_no_limit();
                    error_tip.Show();
                }
                else if (result == "hang")
                {
                    user_no_rule error_tip = new user_no_rule();
                    error_tip.Show();
                    //增加一条挂起访问记录 arraylist
                }
                else if (result == "no_resource")
                {
                    user_no_resource error_tip = new user_no_resource();
                    error_tip.Show();
                }

            }
            else
            {
                user_input_error form = new user_input_error();
                form.Show();
            }
            
            
            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //RES = comboBox1.Text.Trim();
            //resource = comboBox1.Text;
            //RESnum = int.Parse(RES);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //worktype = comboBox2.Text;
            //WKTP = comboBox2.Text.Trim();
            //resource = comboBox1.Text;
            //WKTPnum = int.Parse(WKTP);
        }
    }
}
