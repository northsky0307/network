using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Project
{
    public partial class ad_rules_ch : Form
    {
        public ad_rules_ch()
        {
            InitializeComponent();

            /* for (int j = 1; j <= 1000; j++)
             {
                 for (int i = (j-1) * Static.rule_index.Count / 1000; i < j * Static.rule_index.Count / 1000; i++)
                 {
                     Rule query_out_his = (Rule)Static.rule_index[i];

                     int index = this.dataGridView1.Rows.Add();

                     this.dataGridView1.Rows[index].Cells[0].Value = query_out_his.PERSON_DEPTNAME;  //资源类型

                     this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.TARGET_NAME;   //用户类型

                     this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.PERSON_JOB_CODE;  //操作类型

                     this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.ACTION;  //返回结果
                 }
             }*/
            for (int i = 0; i < 3000/*Static.rule_index.Count*/; i++)
            {
                Rule query_out_his = (Rule)Static.rule_index[i];

                int index = this.dataGridView1.Rows.Add();

                this.dataGridView1.Rows[index].Cells[0].Value = query_out_his.PERSON_DEPTNAME;  //资源类型

                this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.TARGET_NAME;   //用户类型

               this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.ACTION;  //操作类型

                this.dataGridView1.Rows[index].Cells[3].Value = query_out_his.PERSON_JOB_CODE;  //返回结果

                
            }
            //         for (int i = 3001; i < 6000/*Static.rule_index.Count*/; i++)
            //      {
            //        Rule query_out_his = (Rule)Static.rule_index[i];
            //
            //      int index = this.dataGridView1.Rows.Add();
            //
            //      this.dataGridView1.Rows[index].Cells[0].Value = query_out_his.PERSON_DEPTNAME;  //资源类型

            //     this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.TARGET_NAME;   //用户类型

            //   this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.PERSON_JOB_CODE;  //操作类型

            //   this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.ACTION;  //返回结果
            // }
            // for (int i = 6001; i < 9001/*Static.rule_index.Count*/; i++)
            //{
            //  Rule query_out_his = (Rule)Static.rule_index[i];

            //int index = this.dataGridView1.Rows.Add();

            //                this.dataGridView1.Rows[index].Cells[0].Value = query_out_his.PERSON_DEPTNAME;  //资源类型
            //
            //              this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.TARGET_NAME;   //用户类型
            //
            //            this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.PERSON_JOB_CODE;  //操作类型
            //
            //          this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.ACTION;  //返回结果
            //    }
            //  for (int i = 9001; i < 12000/*Static.rule_index.Count*/; i++)
            //{
            //  Rule query_out_his = (Rule)Static.rule_index[i];

            //  int index = this.dataGridView1.Rows.Add();

            //   this.dataGridView1.Rows[index].Cells[0].Value = query_out_his.PERSON_DEPTNAME;  //资源类型

            //  this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.TARGET_NAME;   //用户类型

            //  this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.PERSON_JOB_CODE;  //操作类型

            //    this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.ACTION;  //返回结果
            // }
            //  for (int i = 12001; i < Static.rule_index.Count; i++)
            //    {
            //  Rule query_out_his = (Rule)Static.rule_index[i];

            //  int index = this.dataGridView1.Rows.Add();

            //this.dataGridView1.Rows[index].Cells[0].Value = query_out_his.PERSON_DEPTNAME;  //资源类型

            // this.dataGridView1.Rows[index].Cells[1].Value = query_out_his.TARGET_NAME;   //用户类型

            // this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.PERSON_JOB_CODE;  //操作类型

            //   this.dataGridView1.Rows[index].Cells[2].Value = query_out_his.ACTION;  //返回结果
            // }
            DataGridViewButtonColumn btnDELETE = new DataGridViewButtonColumn();
            btnDELETE.Name = "btnDELETE";
            btnDELETE.HeaderText = "删除";
            btnDELETE.DefaultCellStyle.NullValue = "删除";
            btnDELETE.Width = 61;
            dataGridView1.Columns.Add(btnDELETE);

            DataGridViewButtonColumn btnMDF = new DataGridViewButtonColumn();
            btnMDF.Name = "btnMDF";
            btnMDF.HeaderText = "修改";
            btnMDF.DefaultCellStyle.NullValue = "修改";
            btnMDF.Width = 61;
            dataGridView1.Columns.Add(btnMDF);

        }
     

        private void button1_Click(object sender, EventArgs e)
        {
            admin_func_choose form = new admin_func_choose();
            form.Show();
            this.Dispose();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnMDF" && e.RowIndex >= 0)  //单击修改
            {
                
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnDELETE" && e.RowIndex >= 0)  //单击删除
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ad_add_rules add_Rules = new ad_add_rules();
            add_Rules.Show();
            
        }
        /*private void DataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
{
   if (dataGridView1.CurrentCell != null && e.Control.GetType() == typeof(DataGridViewComboBoxEditingControl))
   {                //创建下拉列表框改变事件                
       (e.Control as ComboBox).SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);                //创建下拉列表框离开焦点事件 添加该事件是为了删除动态事件 以免多次调用                
       (e.Control as ComboBox).Leave += new EventHandler(ComboBox_Leave);
   }
}        //离开焦点事件  
private void ComboBox_Leave(object sender, EventArgs e)
{            //删除动态调用            
   (sender as ComboBox).SelectedIndexChanged -= new EventHandler(ComboBox_SelectedIndexChanged);
   (sender as ComboBox).Leave -= new EventHandler(ComboBox_Leave);
}        //下拉列表框改变事件   
private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
{
}  
*/
        /*  public void dgv_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
       {
           DataGridView dgv = sender as DataGridView;
           //判断相应的列
           if (dgv.CurrentCell.GetType().Name == "DataGridViewComboBoxCell" && dgv.CurrentCell.RowIndex != -1)
           {
               //给这个DataGridViewComboBoxCell加上下拉事件
               (e.Control as ComboBox).SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);

           }
       }

       public void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
       {
           ComboBox combox = sender as ComboBox;
           //这里比较重要
           combox.Leave += new EventHandler(combox_Leave);
           try
           {
               //在这里就可以做值是否改变判断
               if (combox.SelectedItem != null)
               {

               }
               Thread.Sleep(100);
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
           }
       }

       public void combox_Leave(object sender, EventArgs e)
       {
           ComboBox combox = sender as ComboBox;
           //做完处理，须撤销动态事件
           combox.SelectedIndexChanged -= new EventHandler(ComboBox_SelectedIndexChanged);
       }*/

    }
}
