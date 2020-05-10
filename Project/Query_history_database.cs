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
        //private ArrayList query_history_index = new ArrayList();
        /// <summary>
        /// 添加访问记录
        /// </summary>
        /// <param name="ACTION"></param>
        /// <param name="TARGET_NAME"></param>
        /// <param name="PERSON_BUSINESS_TITLE"></param>
        /// <param name="PERSON_BUSINESS_TITLE_DETAIL"></param>
        /// <param name="PERSON_COMPANY"></param>
        /// <param name="PERSON_DEPTNAME"></param>
        /// <param name="PERSON_JOB_CODE"></param>
        /// <param name="PERSON_JOB_FAMILY"></param>
        /// <param name="PERSON_LOCATION"></param>
        /// <param name="PERSON_MGR_ID"></param>
        /// <param name="PERSON_ROLLUP_1"></param>
        /// <param name="PERSON_ROLLUP_2"></param>
        /// <param name="PERSON_ROLLUP_3"></param>
        public void Add_query_history(string ACTION, int TARGET_NAME, int PERSON_BUSINESS_TITLE, int PERSON_BUSINESS_TITLE_DETAIL, int PERSON_COMPANY, int PERSON_DEPTNAME, int PERSON_JOB_CODE, int PERSON_JOB_FAMILY,
                                        int PERSON_LOCATION, int PERSON_MGR_ID, int PERSON_ROLLUP_1, int PERSON_ROLLUP_2, int PERSON_ROLLUP_3)  //添加
        {
            //Query_history now_query = new Query_history(n, r, qt, rt, ih);
            Query_history now_query = new Query_history();
            now_query.ADD(ACTION, TARGET_NAME, PERSON_BUSINESS_TITLE, PERSON_BUSINESS_TITLE_DETAIL, PERSON_COMPANY, PERSON_DEPTNAME, PERSON_JOB_CODE, PERSON_JOB_FAMILY,
                              PERSON_LOCATION, PERSON_MGR_ID, PERSON_ROLLUP_1, PERSON_ROLLUP_2, PERSON_ROLLUP_3);
            Static.query_history_index.Add(now_query);
            IOStream myst = new IOStream();
            myst.write_query(now_query);
        }
        public ArrayList return_query_history(string name) //获得用户的访问根据名称 重新写吧
        {
            ArrayList temp = new ArrayList();
            for(int i = 0; i < Static.query_history_index.Count; i ++)
            {
                Query_history temp_query = (Query_history)Static.query_history_index[i];
                //if(temp_query.name == name) 查询条件 这个已经不合适了
                {
                    temp.Add(temp_query);
                }
            }
            return temp;
        }
    }
}
