﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class user_do_search : Form
    {
        public user_do_search()
        {
            InitializeComponent();
        }


        

        private void button1_Click(object sender, EventArgs e)

        {
            user_query return_user_query = new user_query();
            return_user_query.Show();
            this.Dispose();

        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
