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
        //private ArrayList User_Information_Index = new ArrayList(10); //新建vector
        private ArrayList User_Information_Index = new ArrayList(); //新建vector
        private Dictionary<string, int> User_Number_Dictionary = new Dictionary<string, int>(); // name对应的num
        private int Database_Size = 0;
        /// <summary>
        /// 添加用户信息
        /// </summary>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public int Add_User_Information(string name, string password, int type = 0) //1 已经存在 0 成功 -1异常（user和admin冲突） -2 用户名为空
        {
            if(name == "")
            {
                return -2;
            }
            if (User_Number_Dictionary.ContainsKey(name))
            {
                int num = User_Number_Dictionary[name]; // 得到对应num

                User_Information now_user = (User_Information)User_Information_Index[num];
                if (type != now_user.Get_Type())
                {
                    System.Console.WriteLine("user and admin conflict");
                    return -1;
                }
                return 1;
            }
            else
            {
                User_Information now_user = new User_Information(name, password, type);
                //now_user.Set_Number = Database_Size
                //(User_Information)User_Information_Index[num];
                now_user.Set_Number(Database_Size);
                int num = Database_Size;
                //System.Console.WriteLine(num);
                User_Information_Index.Add(now_user);
                //User_Information_Index[num] = now_user;
                User_Number_Dictionary[name] = num;
                Database_Size++; ///后移一位
            }
            System.Console.WriteLine("now user size : " + Database_Size);
            return 0;
        }
        /// <summary>
        /// 查询用户密码
        /// </summary>
        //public string Query_User_Information(string name) ///正常返回密码， 异常返回-1
        public string Query_User_password(string name) ///正常返回密码， 异常返回-1
        {
            //System.Console.WriteLine("@" + name + "@");
            System.Console.WriteLine("query name : " + name);
            //System.Console.WriteLine(User_Number_Dictionary.ContainsKey(name));
            if (User_Number_Dictionary.ContainsKey(name))
            {
                User_Information now_user = (User_Information)User_Information_Index[User_Number_Dictionary[name]];
                return now_user.User_password;
            }
            else
                return "-1";
        }

        public int Query_User_type(string name) ///正常返回密码， 异常返回-1
        {
            //System.Console.WriteLine("@" + name + "@");
            System.Console.WriteLine("query name : " + name);
            //System.Console.WriteLine(User_Number_Dictionary.ContainsKey(name));
            if (User_Number_Dictionary.ContainsKey(name))
            {
                User_Information now_user = (User_Information)User_Information_Index[User_Number_Dictionary[name]];
                return now_user.Get_Type();
            }
            else
                return -1;
        }
        public void Init()
        {
            Add_User_Information("1", "1");
            Add_User_Information("ad", "ad", 1);
        }
    }
}
