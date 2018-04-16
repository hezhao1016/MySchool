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
using MySchool.BLL;

namespace MySchool
{
    public partial class frmSeachSubject : Form
    {
        public frmSeachSubject()
        {
            InitializeComponent();
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
            foreach (Grade g in grades)
            {
                TreeNode tnGrade = new TreeNode(g.GradeName);
                tnGrade.Tag = g.GradeId;
                tn.Nodes.Add(tnGrade);
            }
            tn.ExpandAll();
            this.tvGrade.Nodes.Add(tn);
        }

        private void frmSeachSubject_Load(object sender, EventArgs e)
        {
            ShowTreeView();
        }
        public void ShowSubject()
        {
            this.dgvSubject.AutoGenerateColumns = false;
            if (this.tvGrade.SelectedNode.Level == 0)
            {
                try
                {
                    this.dgvSubject.DataSource = SubjectBLL.GetSubject();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("查询全部科目信息出现异常\n" + ex.Message, "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (this.tvGrade.SelectedNode.Level == 1)
            {
                int gradeId = Convert.ToInt32(this.tvGrade.SelectedNode.Tag);
                try
                {
                    this.dgvSubject.DataSource = SubjectBLL.GetSubject(gradeId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("根据年级查询科目信息出现异常\n" + ex.Message, "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void tvGrade_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ShowSubject();
        }
    }
}
