using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Rule
    {
        public string name; //用户名
        public string resource_name; //资源名称
        public int query_type; //访问类型

        public Rule(string n, string rn, int q)
        {
            this.name = n;
            this.resource_name = rn;
            this.query_type = q;
        }
    }
}
