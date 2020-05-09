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
        /// 写入规则
        /// </summary>
        public void write_rule()
        {
            string filepath = "..\\..\\rule.csv"; // 文件路径
            FileStream fs = new FileStream(filepath, System.IO.FileMode.Create, System.IO.FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.UTF8);

            Rule rule;
            for (int i = 0; i < Static.rule_index.Count; i++)
            {
                rule = (Rule)Static.rule_index[i];
                sw.WriteLine(rule.name + "," + rule.resource_name + "," + rule.query_type.ToString());
            }
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

            string name; //用户名
            string resource_name; //资源名称
            DateTime time; //访问时间
            string query_type; //访问类型
            int return_type; //访问结果
            int is_hang; //是否挂起 0 否
            while ((str = mysr.ReadLine()) != null)
            {
                System.Console.WriteLine(str);
                now_string = str.Split(',');
                
                name = now_string[0];
                resource_name = now_string[1];
                query_type = now_string[2];
                return_type = Convert.ToInt32(now_string[3]);
                is_hang = Convert.ToInt32(now_string[4]);
                time = Convert.ToDateTime(now_string[5]);
                query_History.ADD(name, resource_name, query_type, return_type , is_hang, time);
                Static.rule_index.Add(query_History);//写入ArrayList
                
            }
            mysr.Close();
        }
        /// <summary>
        /// 写入访问记录
        /// </summary>
        public void write_query()
        {
            string filepath = "..\\..\\query.csv"; // 文件路径
            FileStream fs = new FileStream(filepath, System.IO.FileMode.Create, System.IO.FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.UTF8);

            Query_history query_History;
            for (int i = 0; i < Static.query_history_index.Count; i++)
            {
                query_History = (Query_history)Static.query_history_index[i];
                sw.Write(query_History.name + "," + query_History.resource_name + "," + query_History.query_type.ToString() + ",");
                sw.WriteLine(query_History.return_type.ToString() + "," + query_History.is_hang.ToString() + "," + query_History.time.ToString());
            }
            sw.Close();
        }

        public void write()
        {
            write_query();
            write_rule();
        }
    }
}
