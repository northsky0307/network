using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class ad_rules_join : Form
    {
        public ad_rules_join()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;


            //DataGridViewButtonColumn btnMDF = new DataGridViewButtonColumn();
            //btnMDF.Name = "btnMDF";
            //btnMDF.HeaderText = "修改";
            //btnMDF.DefaultCellStyle.NullValue = "修改";
            //btnMDF.Width = 61;
            //dataGridView1.Columns.Add(btnMDF);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin_func_choose form = new admin_func_choose();
            form.Show();
            this.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ad_ch_success form = new ad_ch_success();
            form.Show();
        }

        private void ad_rules_join_Load(object sender, EventArgs e)
        {

        }
    }
}
