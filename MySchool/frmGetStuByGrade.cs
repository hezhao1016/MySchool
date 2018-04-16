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
    public partial class frmGetStuByGrade : Form
    {
        public frmGetStuByGrade()
        {
            InitializeComponent();
        }

        private void cboGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetStudent();
        }
        public void GetStudent()
        {
            int id = (int)this.cboGrade.SelectedValue;
            try
            {
                this.dgvStu.DataSource = new BindingList<Student>(StudentBLL.GetAllStudentByGrade(id));
            }
            catch (Exception ex)
            {
                MessageBox.Show("查询学生出现异常：\n" + ex.Message, "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void FrmGetStuByGrade_Load(object sender, EventArgs e)
        {
            this.dgvStu.AutoGenerateColumns = false;
            this.cboGrade.DisplayMember = "GradeName";
            this.cboGrade.ValueMember = "GradeId";
            try
            {
                List<Grade> grades = GradeBLL.GetAllGrade();
                //在集合第一个位置中插入请选择项
                grades.Insert(0,new Grade(-1, "请选择"));
                this.cboGrade.DataSource = new BindingList<Grade>(grades);
            }
            catch (Exception ex)
            {
                MessageBox.Show("绑定年级出现异常：\n" + ex.Message, "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 编辑学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgvStu.SelectedRows.Count == 0)
            {
                return;
            }
            Student stu = this.dgvStu.CurrentRow.DataBoundItem as Student;
            frmEditStudent fes = new frmEditStudent();
            fes.Stu = stu;
            fes.IsUpdate = true;
            fes.ShowDialog();
            GetStudent();
        }

        private void 添加成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgvStu.SelectedRows.Count == 0)
            {
                return;
            }
            frmAddResult fa = new frmAddResult();
            fa.Stu = this.dgvStu.CurrentRow.DataBoundItem as Student;
            fa.ShowDialog();
        }
    }
}
