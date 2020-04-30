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

            Sign_in sign_In = new Sign_in();
            Application.Run(sign_In);

        }
    }
}