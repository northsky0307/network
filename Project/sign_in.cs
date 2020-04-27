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
    public partial class Sign_in : Form //,IMyForm
    {
        private User_datebase user_Datebase = new User_datebase();
        public Sign_in()
        {
            user_Datebase.Init();
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            string pass = textBox2.Text.Trim();
            /*string name = "test1";
            string pass = "123456";
            string name2 = "admin1";
            string pass2 = "654321";
            if (name == textBox1.Text.Trim() && pass == textBox2.Text.Trim()) //用户名密码验证*/
            ///数据库登陆

            //User_Information user = new User_Information("1", "1");
            string current_password = user_Datebase.Query_User_Information(name);///正常返回密码， 异常返回-1
            //user_Datebase.Add_User_Information();
            System.Console.WriteLine("current_password" + current_password);
            if (current_password == "-1")
            {
                //用户不存在
            }
            else
            {
                if (pass == current_password)
                {
                    //界面替换
                    user_query form = new user_query();
                    form.Show();
                    this.Hide();
                    //this.Dispose();
                    //Application.Run(form);
                }
                else
                {
                    //密码错误
                }
            }
            //if (name == user.User_Name && pass == user.User_password) //用户名密码验证
            /*
            if(pass == current_password)
            {
                //界面替换
                user_query form = new user_query();
                form.Show();
                this.Hide();
                System.Console.WriteLine("user's type = " + user.Get_Type());
                //this.Dispose();
                //Application.Run(form);
            }
            */
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
