using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Project
{
    class User_datebase //使用者信息数据库
    {
        private ArrayList User_Information_Index = new ArrayList(); //新建vector
        private Dictionary<string, int> User_Number_Dictionary = new Dictionary<string, int>(); // name对应的num
        private int Database_Size = 0;
        
        public int Add_User_Information(string name, string password, bool type = false) //1 已经存在 0 成功 -1异常（user和admin冲突）
        {

            if(User_Number_Dictionary.ContainsKey(name))
            {
                int num = User_Number_Dictionary[name]; // 得到对应num

                User_Information now_user = (User_Information)User_Information_Index[num];
                if(type != now_user.Get_Type())
                {
                    System.Console.WriteLine("user and admin conflict");
                    return -1;
                }
                return 1;
            }
            else
            {
                User_Information now_user = new User_Information(name, password,type);
                now_user.Set_Number = Database_Size
                (User_Information)User_Information_Index[num];
            }
            System.Console.WriteLine(Database_Size);
            return 0;
        }
    }
}
