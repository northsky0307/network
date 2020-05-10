using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class IOStream
    {
        /// <summary>
        /// 读取规则
        /// </summary>
        public void Get_rule()
        {
            string filepath = "..\\..\\rule.csv";
            StreamReader mysr = new StreamReader(filepath, System.Text.Encoding.Default);
            string str; //文件行
            Rule rule; //插入rule

            string[] now_string; //每一列
            string name; //用户名
            string resource_name; //资源名称
            int query_type;//访问类型
            while ((str = mysr.ReadLine()) != null)
            {

                now_string = str.Split(',');
                name = now_string[0];
                resource_name = now_string[1];
                query_type = Convert.ToInt32(now_string[2]);

                rule = new Rule(name, resource_name, query_type);
                Static.rule_index.Add(rule);//写入ArrayList

            }
            mysr.Close();
        }

        /// <summary>
        /// 追加规则
        /// </summary>
        public void write_rule(Rule rule)
        {
            string filepath = "..\\..\\rule.csv"; // 文件路径
            FileStream fs = new FileStream(filepath, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);

            sw.WriteLine(rule.name + "," + rule.resource_name + "," + rule.query_type.ToString());

            sw.Close();
        }
        /// <summary>
        /// 读取访问记录
        /// </summary>
        public void Get_query()
        {
            string filepath = "..\\..\\query.csv";
            StreamReader mysr = new StreamReader(filepath, System.Text.Encoding.Default);
            string str; //文件行
            Query_history query_History = new Query_history();
            string[] now_string; //每一列

            string ACTION;
            int TARGET_NAME;
            int PERSON_BUSINESS_TITLE;
            int PERSON_BUSINESS_TITLE_DETAIL;
            int PERSON_COMPANY;
            int PERSON_DEPTNAME;
            int PERSON_JOB_CODE;
            int PERSON_JOB_FAMILY;
            int PERSON_LOCATION;
            int PERSON_MGR_ID;
            int PERSON_ROLLUP_1;
            int PERSON_ROLLUP_2;
            int PERSON_ROLLUP_3;
            DateTime REQUEST_DATE;
            mysr.ReadLine(); // 读取title

            while ((str = mysr.ReadLine()) != null)
            {
                System.Console.WriteLine(str);
                now_string = str.Split(',');
                ACTION = now_string[0];
                TARGET_NAME = Convert.ToInt32(now_string[1]);
                PERSON_BUSINESS_TITLE = Convert.ToInt32(now_string[2]);
                PERSON_BUSINESS_TITLE_DETAIL = Convert.ToInt32(now_string[3]);
                PERSON_COMPANY = Convert.ToInt32(now_string[4]);
                PERSON_DEPTNAME = Convert.ToInt32(now_string[5]);
                PERSON_JOB_CODE = Convert.ToInt32(now_string[6]);
                PERSON_JOB_FAMILY = Convert.ToInt32(now_string[7]);
                PERSON_LOCATION = Convert.ToInt32(now_string[8]);
                PERSON_MGR_ID = Convert.ToInt32(now_string[9]);
                PERSON_ROLLUP_1 = Convert.ToInt32(now_string[10]);
                PERSON_ROLLUP_2 = Convert.ToInt32(now_string[11]);
                PERSON_ROLLUP_3 = Convert.ToInt32(now_string[12]);
                REQUEST_DATE = Convert.ToDateTime(now_string[13]);

                query_History = new Query_history(ACTION, TARGET_NAME, PERSON_BUSINESS_TITLE, PERSON_BUSINESS_TITLE_DETAIL, PERSON_COMPANY, PERSON_DEPTNAME, PERSON_JOB_CODE, PERSON_JOB_FAMILY,
                              PERSON_LOCATION, PERSON_MGR_ID, PERSON_ROLLUP_1, PERSON_ROLLUP_2, PERSON_ROLLUP_3, REQUEST_DATE);

                Static.query_history_index.Add(query_History);//写入ArrayList

            }
            mysr.Close();
        }
        /// <summary>
        /// 追加访问记录
        /// </summary>
        public void write_query(Query_history query_History)
        {
            string filepath = "..\\..\\query.csv"; // 文件路径
            FileStream fs = new FileStream(filepath, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);

            sw.Write(query_History.ACTION + ",");
            sw.Write(query_History.TARGET_NAME.ToString() + ",");
            sw.Write(query_History.PERSON_BUSINESS_TITLE.ToString() + ",");
            sw.Write(query_History.PERSON_BUSINESS_TITLE_DETAIL.ToString() + ",");
            sw.Write(query_History.PERSON_COMPANY.ToString() + ",");
            sw.Write(query_History.PERSON_DEPTNAME.ToString() + ",");
            sw.Write(query_History.PERSON_JOB_CODE.ToString() + ",");
            sw.Write(query_History.PERSON_JOB_FAMILY.ToString() + ",");
            sw.Write(query_History.PERSON_LOCATION.ToString() + ",");
            sw.Write(query_History.PERSON_MGR_ID.ToString() + ",");
            sw.Write(query_History.PERSON_ROLLUP_1.ToString() + ",");
            sw.Write(query_History.PERSON_ROLLUP_2.ToString() + ",");
            sw.Write(query_History.PERSON_ROLLUP_3.ToString() + ",");
            sw.WriteLine(query_History.REQUEST_DATE.ToString());

            sw.Close();
        }


    }
}
