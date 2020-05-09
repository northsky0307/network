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
            string filepath = "..\\..\\read.csv";
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
    }
}
