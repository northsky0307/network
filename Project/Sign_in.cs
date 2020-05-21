using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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

    public partial class Sign_in : Form//,IMyForm
    {
        private User_datebase user_Datebase = new User_datebase();
        //public static string name;
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

            Static.PERSON_BUSINESS_TITLE = textBox4.Text.Trim();

            Static.PERSON_BUSINESS_TITLE_DETAIL = textBox6.Text.Trim();

            Static.PERSON_COMPANY = textBox8.Text.Trim();

            Static.PERSON_DEPTNAME = textBox3.Text.Trim();

            Static.PERSON_ROLLUP_2 = textBox1.Text.Trim();

            Static.PERSON_MGR_ID = textBox2.Text.Trim();

            Static.PERSON_JOB_CODE = textBox5.Text.Trim();

            Static.PERSON_JOB_FAMILY = textBox7.Text.Trim();

            Static.PERSON_LOCATION = textBox9.Text.Trim();

            Static.PERSON_ROLLUP_3 = textBox11.Text.Trim();

            Static.PERSON_ROLLUP_1 = textBox10.Text.Trim();
            /*

            //string name = textBox1.Text.Trim();
            //Static.PERSON_ROLLUP_2 = textBox1.Text.Trim();
            System.Console.WriteLine("user name : " + Static.name);
            //string pass = textBox2.Text.Trim();

            //User_Information user = new User_Information("1", "1");
            //string current_password = user_Datebase.Query_User_Information(name);///正常返回密码， 异常返回-1
            string current_password = user_Datebase.Query_User_password(Static.name);///正常返回密码， 异常返回-1
            int user_num = user_Datebase.Query_User_type(Static.name);
            //user_Datebase.Add_User_Information();
            System.Console.WriteLine("current_password : " + current_password);
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
                    
                    if (user_num == 0) // 用户
                    {
                        //界面替换
                        user_query form = new user_query();
                        form.Show();
                        this.Hide();

                        System.Console.WriteLine("type : user");
                    }
                    if (user_num == 1)
                    {
                        //admin
                        admin_func_choose form = new admin_func_choose();
                        form.Show();
                        this.Hide();
                        System.Console.WriteLine("type : admin");
                    }

                }
                else
                {
                    //密码错误
                    error_password form = new error_password();
                    form.Show();
                }
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
