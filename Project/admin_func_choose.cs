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
    public partial class admin_func_choose : Form
    {
        public admin_func_choose()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sign_in form = new Sign_in();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            admin_func_record form = new admin_func_record();
            form.Show();
            this.Hide();
        }
    }
}
