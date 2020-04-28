using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Query_history
    {
        private string name; //用户名
        private string resource_name; //资源名称
        private DateTime time; //访问时间
        private int query_type; //访问类型
        private int return_type; //访问结果
        private int is_hang; //是否挂起 0 否

        public Query_history(string n, string r, int qt, int rt, int ih) //构造函数
        {
            time = System.DateTime.Now;
            this.name = n;
            this.resource_name = r;
            this.query_type = qt;
            this.return_type = rt;
            this.is_hang = ih;
        }

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

        public int Get_query_type()
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
    }

}
