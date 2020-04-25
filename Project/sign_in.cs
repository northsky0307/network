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
    interface IMyForm
    {
        void MethodToImplement();
    }
    public partial class sign_in : Form //,IMyForm
    {
        public sign_in()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = "test1";
            string pass = "123456";
            if (name == textBox1.Text.Trim() && pass == textBox2.Text.Trim()) //用户名密码验证
            {
                //界面替换
                user_query form = new user_query();
                form.Show();                
                this.Hide();
                //Application.Run(form);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit(); //点击退出
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label5.Text = comboBox1.SelectedItem.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
