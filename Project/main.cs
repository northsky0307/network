using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace Project
{
    class HelloWord
    {

        public static void Main()
        {
            //Form1 用户窗口1  Form2  登陆界面
            //窗口2的引用
            IOStream my_iostream = new IOStream(); //csv 读写
            my_iostream.Get_rule(); //读取规则
            /*
                FileStream fs = new FileStream(strpath, System.IO.FileMode.Create, System.IO.FileAccess.Write);

                StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.UTF8);
                sw.WriteLine("ADS,asd");
                sw.Close();
*/
            Sign_in sign_In = new Sign_in();
            Application.Run(sign_In);



        }

        
    }
}