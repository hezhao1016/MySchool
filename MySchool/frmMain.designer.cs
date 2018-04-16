namespace MySchool
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditPwd = new System.Windows.Forms.ToolStripMenuItem();
            this.注销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGetStuByGrade = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGetStuByName = new System.Windows.Forms.ToolStripMenuItem();
            this.学生信息列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.科目列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAddStu = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统ToolStripMenuItem,
            this.查询ToolStripMenuItem,
            this.管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(792, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统ToolStripMenuItem
            // 
            this.系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditPwd,
            this.注销ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            this.系统ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.系统ToolStripMenuItem.Text = "系统";
            // 
            // tsmiEditPwd
            // 
            this.tsmiEditPwd.Name = "tsmiEditPwd";
            this.tsmiEditPwd.Size = new System.Drawing.Size(124, 22);
            this.tsmiEditPwd.Text = "修改密码";
            this.tsmiEditPwd.Click += new System.EventHandler(this.tsmiEditPwd_Click);
            // 
            // 注销ToolStripMenuItem
            // 
            this.注销ToolStripMenuItem.Name = "注销ToolStripMenuItem";
            this.注销ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.注销ToolStripMenuItem.Text = "注销";
            this.注销ToolStripMenuItem.Click += new System.EventHandler(this.注销ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 查询ToolStripMenuItem
            // 
            this.查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiGetStuByGrade,
            this.tsmiGetStuByName,
            this.学生信息列表ToolStripMenuItem,
            this.科目列表ToolStripMenuItem});
            this.查询ToolStripMenuItem.Name = "查询ToolStripMenuItem";
            this.查询ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.查询ToolStripMenuItem.Text = "查询";
            // 
            // tsmiGetStuByGrade
            // 
            this.tsmiGetStuByGrade.Name = "tsmiGetStuByGrade";
            this.tsmiGetStuByGrade.Size = new System.Drawing.Size(184, 22);
            this.tsmiGetStuByGrade.Text = "按年级查询学生信息";
            this.tsmiGetStuByGrade.Click += new System.EventHandler(this.tsmiGetStuByGrade_Click);
            // 
            // tsmiGetStuByName
            // 
            this.tsmiGetStuByName.Name = "tsmiGetStuByName";
            this.tsmiGetStuByName.Size = new System.Drawing.Size(184, 22);
            this.tsmiGetStuByName.Text = "按姓名查询学生信息";
            this.tsmiGetStuByName.Click += new System.EventHandler(this.tsmiGetStuByName_Click);
            // 
            // 学生信息列表ToolStripMenuItem
            // 
            this.学生信息列表ToolStripMenuItem.Name = "学生信息列表ToolStripMenuItem";
            this.学生信息列表ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.学生信息列表ToolStripMenuItem.Text = "学生信息列表";
            this.学生信息列表ToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // 科目列表ToolStripMenuItem
            // 
            this.科目列表ToolStripMenuItem.Name = "科目列表ToolStripMenuItem";
            this.科目列表ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.科目列表ToolStripMenuItem.Text = "科目列表";
            this.科目列表ToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // 管理ToolStripMenuItem
            // 
            this.管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增学生信息ToolStripMenuItem});
            this.管理ToolStripMenuItem.Name = "管理ToolStripMenuItem";
            this.管理ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.管理ToolStripMenuItem.Text = "管理";
            // 
            // 新增学生信息ToolStripMenuItem
            // 
            this.新增学生信息ToolStripMenuItem.Name = "新增学生信息ToolStripMenuItem";
            this.新增学生信息ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.新增学生信息ToolStripMenuItem.Text = "新增学生信息";
            this.新增学生信息ToolStripMenuItem.Click += new System.EventHandler(this.新增学生信息ToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddStu,
            this.toolStripButton2,
            this.toolStripButton4,
            this.toolStripButton3,
            this.toolStripButton5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(792, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAddStu
            // 
            this.tsbAddStu.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddStu.Image")));
            this.tsbAddStu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbAddStu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddStu.Name = "tsbAddStu";
            this.tsbAddStu.Size = new System.Drawing.Size(116, 36);
            this.tsbAddStu.Text = "新增学生信息";
            this.tsbAddStu.Click += new System.EventHandler(this.新增学生信息ToolStripMenuItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(152, 36);
            this.toolStripButton2.Text = "按姓名查询学生信息";
            this.toolStripButton2.Click += new System.EventHandler(this.tsmiGetStuByName_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(164, 36);
            this.toolStripButton4.Text = "根据年级查询学生信息";
            this.toolStripButton4.Click += new System.EventHandler(this.tsmiGetStuByGrade_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(92, 36);
            this.toolStripButton3.Text = "科目列表";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(116, 36);
            this.toolStripButton5.Text = "学生信息列表";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 514);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(500, 350);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生信息管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditPwd;
        private System.Windows.Forms.ToolStripMenuItem 查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiGetStuByGrade;
        private System.Windows.Forms.ToolStripMenuItem tsmiGetStuByName;
        private System.Windows.Forms.ToolStripMenuItem 管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAddStu;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripMenuItem 注销ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增学生信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生信息列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 科目列表ToolStripMenuItem;

    }
}