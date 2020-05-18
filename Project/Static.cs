using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Project
{
    public static class Static
    {
        public static string name;
        public static ArrayList rule_index = new ArrayList(); //规则
        public static ArrayList query_history_index = new ArrayList(); //访问历史
        public static ArrayList hang = new ArrayList();//挂起访问
    }
}
