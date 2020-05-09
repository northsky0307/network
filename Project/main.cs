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
            string strpath = "..\\..\\read.csv";
            StreamReader mysr = new StreamReader(strpath, System.Text.Encoding.Default);
            string str;
            while ((str = mysr.ReadLine()) != null)
            {
                Console.WriteLine(str);
                string[] now_string = str.Split(',');
                Rule rule = new Rule(now_string[0], now_string[1], Convert.ToInt32(now_string[2]));
                Static.rule_index.Add(rule);
                Rule ttry = (Rule)Static.rule_index[0];
                System.Console.WriteLine(ttry.query_type);

            }
            mysr.Close();
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