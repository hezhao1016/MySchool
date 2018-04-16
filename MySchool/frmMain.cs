using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySchool.Models;

namespace MySchool
{
    public partial class frmMain : Form
    {
        /// <summary>
        /// 子窗体对象
        /// </summary>
        frmEditPwd frmEditPwd = null;
        frmEditStudent frmEditStudent = null;
        frmGetStuByGrade frmGetStudentByGrade = null;
        frmGetStuByName frmGetStudentByName = null;
        frmSeachStudentList frmSeachStudentList = null;
        frmSeachSubject frmSeachSubject = null;

        public frmMain()
        {
            InitializeComponent();
        }
        //当前登录的管理员用户对象
        public Admin admin;
        //登录窗体对象
        public frmLogin fl;
        //是否退出或注销（默认是退出）
        public bool IsExit = true;

        private void tsmiEditPwd_Click(object sender, EventArgs e)
        {
            if (frmEditPwd == null || frmEditPwd.IsDisposed)//是否被释放
            {
                frmEditPwd = new frmEditPwd();
                frmEditPwd.admin = this.admin;
                frmEditPwd.MdiParent = this;
                frmEditPwd.Show();
            }
            frmEditPwd.Activate();//激活窗体并给予焦点
        }

        private void tsmiGetStuByGrade_Click(object sender, EventArgs e)
        {
            if (frmGetStudentByGrade == null || frmGetStudentByGrade.IsDisposed)
            {
                frmGetStudentByGrade = new frmGetStuByGrade();
                frmGetStudentByGrade.MdiParent = this;
                frmGetStudentByGrade.Show();
            }
            frmGetStudentByGrade.Activate();
        }

        private void tsmiGetStuByName_Click(object sender, EventArgs e)
        {
            if (frmGetStudentByName == null || frmGetStudentByName.IsDisposed)
            {
                frmGetStudentByName = new frmGetStuByName();
                frmGetStudentByName.MdiParent = this;
                frmGetStudentByName.Show();
            }
            frmGetStudentByName.Activate();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (frmSeachSubject == null || frmSeachSubject.IsDisposed)
            {
                frmSeachSubject = new frmSeachSubject();
                frmSeachSubject.MdiParent = this;
                frmSeachSubject.Show();
            }
            frmSeachSubject.Activate();
        }
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (frmSeachStudentList == null || frmSeachStudentList.IsDisposed)
            {
                frmSeachStudentList = new frmSeachStudentList();
                frmSeachStudentList.MdiParent = this;
                frmSeachStudentList.Show();
            }
            frmSeachStudentList.Activate();
        }

        private void 注销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要注销当前用户吗？", "注销", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return;
            }
            this.IsExit = false;
            fl.Show();
            this.Hide();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsExit)
            {
                if (MessageBox.Show("确定要退出学生管理系统吗？", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (IsExit)
            {
                Application.Exit();
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 新增学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmEditStudent == null || frmEditStudent.IsDisposed)
            {
                frmEditStudent = new frmEditStudent();
                frmEditStudent.MdiParent = this;
                frmEditStudent.Show();
            }
            frmEditStudent.Activate();
        }
    }
}
