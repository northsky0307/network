﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class User_Information
    {
        public string User_Name;
        public string User_password;
        private bool User_type; //0 user 1 admins
        private int User_number; //数据库查询标号

        public User_Information(string name, string password)
        {
            this.User_Name = name;
            this.User_password = password;
        }
    }
}
