using System;
using System.Windows.Forms;
using System.Drawing;

namespace Project
{
    class HelloWord
    {
        
        public static void Main()
        {
            //Form1 用户窗口1  Form2  登陆界面
            //窗口2的引用
            Sign_in form1 = new Sign_in();
           // form1.Show();
            Application.Run(form1);
            /*Form frm = new Form();
           
            frm.Paint += new PaintEventHandler(frm_Paint); //注册Paint事件处理程序
            frm.Click += new System.EventHandler(frm_Click);//注册Click事件处理程序
            UserControl1 userControl1 = new UserControl1(); //新建按钮
            frm.Controls.Add(userControl1);//添加到窗口
            
            Application.Run(frm);*/
        }

        
        // Click事件处理程序
        /*static void frm_Click(object sender, EventArgs e)
        {
            Form frm = (Form)sender;
            //在标题栏显示鼠标单击的位置
            frm.Text = Cursor.Position.X.ToString() + ":" + Cursor.Position.Y.ToString();
        }

        //事件处理程序
        static void frm_Paint(object sender, PaintEventArgs e)
        {
            Form frm = (Form)sender;
            Graphics g = e.Graphics;
            //g.Clear(Color.Black);
            g.DrawString("Hello Word", frm.Font, Brushes.White, new Point(20, 20));

        }*/
    }
}