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
    public partial class user_query : Form
    {
        public user_query()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

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
            Sign_in form = new Sign_in();
            form.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = "ad";
          Query_history  search    = new   Query_history(username, resource, worktype,1,0);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            resource = comboBox1.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            worktype = comboBox2.Text;
        }
    }
}
