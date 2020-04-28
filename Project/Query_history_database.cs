using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Project
{
    class Query_history_database
    {
        private ArrayList query_history_index = new ArrayList();

        public void Add_query_history(string n, string r, int qt, int rt, int ih) //添加
        {
            Query_history now_query = new Query_history(n, r, qt, rt, ih);
            query_history_index.Add(now_query);
        }
    }
}
