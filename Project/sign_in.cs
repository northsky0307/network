using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    interface IMyForm
    {
        void MethodToImplement();
    }

    public partial class Sign_in : Form//,IMyForm
    {
        private User_datebase user_Datebase = new User_datebase();
        public static string name;
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
            //string name = textBox1.Text.Trim();
            name = textBox1.Text.Trim();
            System.Console.WriteLine("inter " + name);
            string pass = textBox2.Text.Trim();

            //User_Information user = new User_Information("1", "1");
            //string current_password = user_Datebase.Query_User_Information(name);///正常返回密码， 异常返回-1
            string current_password = user_Datebase.Query_User_password(name);///正常返回密码， 异常返回-1
            int user_num = user_Datebase.Query_User_type(name);
            //user_Datebase.Add_User_Information();
            System.Console.WriteLine("current_password" + current_password);
            if (current_password == "-1")
            {
                //用户不存在
                error_no_exist form = new error_no_exist();
                form.Show();
            }
            else
            {
                if (pass == current_password)
                {
                    /*
                     * //界面替换
                    user_query form = new user_query();
                    //Application.Run(form);
                    form.Show();
                    this.Hide();
                    */
                    if (user_num == 0) // 用户
                    {
                        //界面替换
                        user_query form = new user_query();
                        form.Show();
                        this.Hide();
                    }
                    if (user_num == 1)
                    {
                        //admin
                        admin_func_choose form = new admin_func_choose();
                        form.Show();
                        this.Hide();
                        System.Console.WriteLine("admin");
                    }

                }
                else
                {
                    //密码错误
                    error_password form = new error_password();
                    form.Show();
                }
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
