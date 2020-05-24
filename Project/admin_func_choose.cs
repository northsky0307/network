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
    public partial class admin_func_choose : Form
    {
        public admin_func_choose()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sign_in form = new Sign_in();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            admin_func_record form = new admin_func_record();
            form.Show();
            this.Hide();
        }

        private void admin_func_choose_Load(object sender, EventArgs e)
        {

        }
        //关闭子窗口，同时结束父窗口
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            Application.Exit(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ad_rules_ch form = new ad_rules_ch();
            form.Show();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ad_rules_join form = new ad_rules_join();
            form.Show();
            this.Dispose();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
