﻿using System;
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
            my_iostream.Get_query(); // 读取访问记录
            Sign_in sign_In = new Sign_in();
            Application.Run(sign_In);
        }
    }
}