using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Query_history
    {
        /*
        private string name; //用户名
        private string resource_name; //资源名称
        private DateTime time; //访问时间
        private string query_type; //访问类型
        private int return_type; //访问结果
        private int is_hang; //是否挂起 0 否
        */
        public string name; //用户名
        public string resource_name; //资源名称
        public DateTime time; //访问时间
        public string query_type; //访问类型
        public int return_type; //访问结果
        public int is_hang; //是否挂起 0 否

        public Query_history(string name, string resource_name, string query_type, int return_type, int is_hang) //构造函数
        {
            time = System.DateTime.Now;
            this.name = name;
            this.resource_name = resource_name;
            this.query_type = query_type;
            this.return_type = return_type;
            this.is_hang = is_hang;
        }
        public Query_history() //构造函数
        {
        }
        public void ADD(string n, string r, string qt, int rt, int ih, DateTime t) //构造函数
        {
            this.time = t;
            this.name = n;
            this.resource_name = r;
            this.query_type = qt;
            this.return_type = rt;
            this.is_hang = ih;
        }
        /*
        public string Get_Name()
        {
            return this.name;
        }


        public string Get_resource_name()
        {
            return this.resource_name;
        }

        public DateTime Get_time()
        {
            return this.time;
        }

        public string Get_query_type()
        {
            return this.query_type;
        }

        public int Get_return_type()
        {
            return this.return_type;
        }

        public int Get_is_hang()
        {
            return this.is_hang;
        }
        */
    }

}
