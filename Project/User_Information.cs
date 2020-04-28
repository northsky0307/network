using System;
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
        private int User_type; //0 user 1 admins
        private int User_number; //数据库查询标号 

        public User_Information(string name, string password, int type = 0)
        {
            this.User_Name = name;
            this.User_password = password;
            if (type == 0)
            {
                this.User_type = 0;
            }
            else
            {
                this.User_type = 1;
            }
        }

        public int Get_Type()
        {
            return this.User_type;
        }
        

        public void Set_Number(int num)
        {
            this.User_number = num;
        }
        public int Get_Number()
        {
            return this.User_number;
        }
    }
}
