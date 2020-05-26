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
        private User_operation user_Datebase = new User_operation();
        //public static string name;
        public Sign_in()
        {
            //user_Datebase.Init();
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string ID = textBox1.Text.Trim();
            /*

            //界面替换
            if (Static.PERSON_BUSINESS_TITLE != "-1") // MGR_ID 输入-1是admin
            {
                //界面替换
                user_query form = new user_query();
                form.Show();
                this.Hide();

                System.Console.WriteLine("type : user");
            }
            else
            {
                //admin
                admin_func_choose form = new admin_func_choose();
                form.Show();
                this.Hide();
                System.Console.WriteLine("type : admin");
            }
            */
            if (ID == "admin")
            {
                admin_func_choose form = new admin_func_choose();
                form.Show();
                this.Hide();
                System.Console.WriteLine("type : admin");
            }
            else
            {
                User_operation user_Operation = new User_operation();

                if (user_Operation.Query(ID))
                {
                    //界面替换
                    user_query form = new user_query();
                    form.Show();
                    this.Hide();
                    System.Console.WriteLine("type : user");

                }
                else
                {
                    //用户不存在
                    error_no_exist form = new error_no_exist();
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


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Sign_in_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
