using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySchool.BLL;
using MySchool.Models;

namespace MySchool
{
    public partial class frmSeachStudentList : Form
    {
        public frmSeachStudentList()
        {
            InitializeComponent();
        }

        private void frmSeachStudentList_Load(object sender, EventArgs e)
        {
            ShowTreeView();
        }
        public void ShowTreeView()
        {
            TreeNode tn = new TreeNode("全部");
            List<Grade> grades = null;
            try
            {
                 grades = GradeBLL.GetAllGrade();
            }
            catch (Exception ex)
            {
                MessageBox.Show("初始化信息出现异常\n" + ex.Message, "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            foreach ( Grade g in grades)
            {
                TreeNode tnGrade = new TreeNode(g.GradeName);
                tnGrade.Tag = g.GradeId;
                tnGrade.Nodes.Add("男");
                tnGrade.Nodes.Add("女");
                tn.Nodes.Add(tnGrade);
            }
            tn.ExpandAll();
            this.tvStu.Nodes.Add(tn);
        }

        private void tvStu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ShowStu();
        }
        public void ShowStu()
        {
            this.dgvStudent.AutoGenerateColumns = false;
            if (this.tvStu.SelectedNode.Level == 0)
            {
                try
                {
                    this.dgvStudent.DataSource = StudentBLL.GetAllStudentByStuIdAndGender();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("查询全部学生信息出现异常\n" + ex.Message, "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (this.tvStu.SelectedNode.Level == 1)
            {
                int gradeId = Convert.ToInt32(this.tvStu.SelectedNode.Tag);
                try
                {
                    this.dgvStudent.DataSource = StudentBLL.GetAllStudentByStuIdAndGender(gradeId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("根据年级查询学生信息出现异常\n" + ex.Message, "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                int gradeId = Convert.ToInt32(this.tvStu.SelectedNode.Parent.Tag);
                try
                {
                    this.dgvStudent.DataSource = StudentBLL.GetAllStudentByStuIdAndGender(gradeId, this.tvStu.SelectedNode.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("根据年级及性别查询学生信息出现异常\n" + ex.Message, "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void 删除学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ( MessageBox.Show("确定要删除该学生吗？同时会删除该学生的成绩！","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            string StuNo = (this.dgvStudent.CurrentRow.DataBoundItem as Student).StudentNo;
            try
            {
                if (StudentBLL.DelStudentByStuNo(StuNo))
                {
                    MessageBox.Show("删除学生信息成功！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowStu();
                }
                else
                {
                    MessageBox.Show("删除学生信息失败！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("删除学生信息出现异常\n！" + ex.Message, "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
