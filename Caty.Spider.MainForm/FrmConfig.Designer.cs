namespace Caty.Spider.MainForm
{
    partial class FrmConfig
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkIsSql = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.numMinute2 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.numMinute = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numHour = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtnHour = new System.Windows.Forms.RadioButton();
            this.rbtnDay = new System.Windows.Forms.RadioButton();
            this.checkSetModified = new System.Windows.Forms.CheckBox();
            this.btnSetClose = new System.Windows.Forms.Button();
            this.btnSetSave = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkSqlModified = new System.Windows.Forms.CheckBox();
            this.btnSqlClose = new System.Windows.Forms.Button();
            this.btnSqlSave = new System.Windows.Forms.Button();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinute2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHour)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(334, 414);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkIsSql);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.checkSetModified);
            this.tabPage2.Controls.Add(this.btnSetClose);
            this.tabPage2.Controls.Add(this.btnSetSave);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(326, 384);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "爬虫设置";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkIsSql
            // 
            this.checkIsSql.AutoSize = true;
            this.checkIsSql.Location = new System.Drawing.Point(65, 287);
            this.checkIsSql.Name = "checkIsSql";
            this.checkIsSql.Size = new System.Drawing.Size(111, 21);
            this.checkIsSql.TabIndex = 26;
            this.checkIsSql.Text = "是否启用数据库";
            this.checkIsSql.UseVisualStyleBackColor = true;
            this.checkIsSql.CheckedChanged += new System.EventHandler(this.checkIsSql_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.rbtnHour);
            this.groupBox1.Controls.Add(this.rbtnDay);
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 258);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.numMinute2);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(57, 163);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 81);
            this.panel2.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Location = new System.Drawing.Point(98, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "分自动执行";
            // 
            // numMinute2
            // 
            this.numMinute2.Dock = System.Windows.Forms.DockStyle.Left;
            this.numMinute2.Location = new System.Drawing.Point(56, 0);
            this.numMinute2.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numMinute2.Name = "numMinute2";
            this.numMinute2.Size = new System.Drawing.Size(42, 23);
            this.numMinute2.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Left;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "每小时的";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.numMinute);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.numHour);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(57, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 77);
            this.panel1.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Left;
            this.label7.Location = new System.Drawing.Point(143, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "分自动执行";
            // 
            // numMinute
            // 
            this.numMinute.Dock = System.Windows.Forms.DockStyle.Left;
            this.numMinute.Location = new System.Drawing.Point(105, 0);
            this.numMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numMinute.Name = "numMinute";
            this.numMinute.Size = new System.Drawing.Size(38, 23);
            this.numMinute.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Location = new System.Drawing.Point(85, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "时";
            // 
            // numHour
            // 
            this.numHour.Dock = System.Windows.Forms.DockStyle.Left;
            this.numHour.Location = new System.Drawing.Point(44, 0);
            this.numHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numHour.Name = "numHour";
            this.numHour.Size = new System.Drawing.Size(41, 23);
            this.numHour.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "每天的";
            // 
            // rbtnHour
            // 
            this.rbtnHour.AutoSize = true;
            this.rbtnHour.Location = new System.Drawing.Point(57, 135);
            this.rbtnHour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnHour.Name = "rbtnHour";
            this.rbtnHour.Size = new System.Drawing.Size(110, 21);
            this.rbtnHour.TabIndex = 9;
            this.rbtnHour.TabStop = true;
            this.rbtnHour.Text = "每小时运行一次";
            this.rbtnHour.UseVisualStyleBackColor = true;
            // 
            // rbtnDay
            // 
            this.rbtnDay.AutoSize = true;
            this.rbtnDay.Location = new System.Drawing.Point(57, 15);
            this.rbtnDay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnDay.Name = "rbtnDay";
            this.rbtnDay.Size = new System.Drawing.Size(98, 21);
            this.rbtnDay.TabIndex = 8;
            this.rbtnDay.TabStop = true;
            this.rbtnDay.Text = "每天运行一次";
            this.rbtnDay.UseVisualStyleBackColor = true;
            // 
            // checkSetModified
            // 
            this.checkSetModified.AutoSize = true;
            this.checkSetModified.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkSetModified.Location = new System.Drawing.Point(65, 349);
            this.checkSetModified.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkSetModified.Name = "checkSetModified";
            this.checkSetModified.Size = new System.Drawing.Size(51, 21);
            this.checkSetModified.TabIndex = 24;
            this.checkSetModified.Text = "修改";
            this.checkSetModified.UseVisualStyleBackColor = true;
            this.checkSetModified.CheckedChanged += new System.EventHandler(this.checkSetModified_CheckedChanged);
            // 
            // btnSetClose
            // 
            this.btnSetClose.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSetClose.Location = new System.Drawing.Point(195, 342);
            this.btnSetClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSetClose.Name = "btnSetClose";
            this.btnSetClose.Size = new System.Drawing.Size(61, 33);
            this.btnSetClose.TabIndex = 23;
            this.btnSetClose.Text = "关闭";
            this.btnSetClose.UseVisualStyleBackColor = true;
            this.btnSetClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSetSave
            // 
            this.btnSetSave.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSetSave.Location = new System.Drawing.Point(122, 342);
            this.btnSetSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSetSave.Name = "btnSetSave";
            this.btnSetSave.Size = new System.Drawing.Size(58, 33);
            this.btnSetSave.TabIndex = 22;
            this.btnSetSave.Text = "保存";
            this.btnSetSave.UseVisualStyleBackColor = true;
            this.btnSetSave.Click += new System.EventHandler(this.btnSetSave_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkSqlModified);
            this.tabPage1.Controls.Add(this.btnSqlClose);
            this.tabPage1.Controls.Add(this.btnSqlSave);
            this.tabPage1.Controls.Add(this.txtPwd);
            this.tabPage1.Controls.Add(this.txtUser);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.txtAddress);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(326, 384);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "数据库设置";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkSqlModified
            // 
            this.checkSqlModified.AutoSize = true;
            this.checkSqlModified.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkSqlModified.Location = new System.Drawing.Point(41, 310);
            this.checkSqlModified.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkSqlModified.Name = "checkSqlModified";
            this.checkSqlModified.Size = new System.Drawing.Size(51, 21);
            this.checkSqlModified.TabIndex = 21;
            this.checkSqlModified.Text = "修改";
            this.checkSqlModified.UseVisualStyleBackColor = true;
            this.checkSqlModified.CheckedChanged += new System.EventHandler(this.checkSqlModified_CheckedChanged);
            // 
            // btnSqlClose
            // 
            this.btnSqlClose.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSqlClose.Location = new System.Drawing.Point(211, 307);
            this.btnSqlClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSqlClose.Name = "btnSqlClose";
            this.btnSqlClose.Size = new System.Drawing.Size(61, 33);
            this.btnSqlClose.TabIndex = 20;
            this.btnSqlClose.Text = "关闭";
            this.btnSqlClose.UseVisualStyleBackColor = true;
            this.btnSqlClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSqlSave
            // 
            this.btnSqlSave.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSqlSave.Location = new System.Drawing.Point(134, 307);
            this.btnSqlSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSqlSave.Name = "btnSqlSave";
            this.btnSqlSave.Size = new System.Drawing.Size(58, 33);
            this.btnSqlSave.TabIndex = 19;
            this.btnSqlSave.Text = "保存";
            this.btnSqlSave.UseVisualStyleBackColor = true;
            this.btnSqlSave.Click += new System.EventHandler(this.btnSqlSave_Click);
            // 
            // txtPwd
            // 
            this.txtPwd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPwd.Location = new System.Drawing.Point(122, 237);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(164, 23);
            this.txtPwd.TabIndex = 18;
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUser.Location = new System.Drawing.Point(122, 167);
            this.txtUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(164, 23);
            this.txtUser.TabIndex = 17;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName.Location = new System.Drawing.Point(122, 106);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(164, 23);
            this.txtName.TabIndex = 16;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAddress.Location = new System.Drawing.Point(122, 38);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(164, 23);
            this.txtAddress.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(37, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(37, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(37, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "数据库名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(37, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "服务器地址：";
            // 
            // FrmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 414);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "数据库连接设置";
            this.Load += new System.EventHandler(this.FrmComfig_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinute2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHour)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox checkSqlModified;
        private System.Windows.Forms.Button btnSqlClose;
        private System.Windows.Forms.Button btnSqlSave;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkSetModified;
        private System.Windows.Forms.Button btnSetClose;
        private System.Windows.Forms.Button btnSetSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numMinute2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numMinute;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numHour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbtnHour;
        private System.Windows.Forms.RadioButton rbtnDay;
        private System.Windows.Forms.CheckBox checkIsSql;
    }
}