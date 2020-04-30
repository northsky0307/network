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

        public void Add_query_history(string n, string r, string qt, int rt, int ih) //添加
        {
            Query_history now_query = new Query_history(n, r, qt, rt, ih);
            query_history_index.Add(now_query);
        }
        public ArrayList return_query_history(string name) //获得用户的访问根据名称
        {
            ArrayList temp = new ArrayList();
            for(int i = 0; i < query_history_index.Count; i ++)
            {
                Query_history temp_query = (Query_history)query_history_index[i];
                if(temp_query.Get_Name() == name)
                {
                    temp.Add(temp_query);
                }
            }
            return temp;
        }
    }
}
