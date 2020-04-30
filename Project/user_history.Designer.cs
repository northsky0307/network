namespace Project
{
    partial class user_history
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.资源名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.操作类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.授权结果 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(400, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "查询历史";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "今天",
            "一周内",
            "一个月内",
            "三个月内",
            "半年内"});
            this.comboBox1.Location = new System.Drawing.Point(268, 155);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 23);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "半年内";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "允许",
            "拒绝",
            "待处理"});
            this.comboBox2.Location = new System.Drawing.Point(588, 155);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(160, 23);
            this.comboBox2.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(95, 159);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "条件筛选：";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.时间,
            this.资源名称,
            this.操作类型,
            this.授权结果});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(97, 212);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(844, 282);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // 时间
            // 
            this.时间.HeaderText = "时间";
            this.时间.Name = "时间";
            this.时间.Width = 150;
            // 
            // 资源名称
            // 
            this.资源名称.HeaderText = "资源名称";
            this.资源名称.Name = "资源名称";
            this.资源名称.Width = 150;
            // 
            // 操作类型
            // 
            this.操作类型.HeaderText = "操作类型";
            this.操作类型.Name = "操作类型";
            this.操作类型.Width = 150;
            // 
            // 授权结果
            // 
            this.授权结果.HeaderText = "授权结果";
            this.授权结果.Name = "授权结果";
            this.授权结果.Width = 150;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(945, 512);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "返回";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // user_history
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "user_history";
            this.Text = "查询历史";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /// <summary>
        /// 查询历史
        /// </summary>
        private System.Windows.Forms.Label label1;  //查询历史
        /// <summary>
        /// 时间阶段选择下拉框
        /// </summary>
        private System.Windows.Forms.ComboBox comboBox1; //时间阶段选择下拉框
        /// <summary>
        /// 查询结果选择下拉框
        /// </summary>
        private System.Windows.Forms.ComboBox comboBox2;  //查询结果选择下拉框
        /// <summary>
        /// 条件筛选文本
        /// </summary>
        private System.Windows.Forms.Label label6; //条件筛选文本
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 资源名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 操作类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 授权结果;
        /// <summary>
        /// 返回查询界面按钮
        /// </summary>
        private System.Windows.Forms.Button button1;  // 返回查询界面按钮
    }
}