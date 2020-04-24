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
    public partial class Form2 : Form //,IMyForm
    {
        public Form2()
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
                Form1 form = new Form1();
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
    }
}
