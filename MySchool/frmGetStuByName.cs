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
    public partial class frmGetStuByName : Form
    {
        public frmGetStuByName()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ShowStu();
        }
        public void ShowStu()
        {
            this.dgvStudent.AutoGenerateColumns = false;
            try
            {
                this.dgvStudent.DataSource = new BindingList<StudentBuss>(StudentBLL.GetAllStudentByName(this.txtName.Text.Trim()));
            }
            catch (Exception ex)
            {
                MessageBox.Show("查询学生信息出现异常\n" + ex.Message, "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void FrmGetStuByName_Load(object sender, EventArgs e)
        {
            ShowStu();
        }

        private void 编辑学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgvStudent.SelectedRows.Count == 0)
            {
                return;
            }
            Student stu = this.dgvStudent.CurrentRow.DataBoundItem as Student;
            frmEditStudent fes = new frmEditStudent();
            fes.Stu = stu;
            fes.IsUpdate = true;
            fes.ShowDialog();
            ShowStu();
        }

        private void 添加成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgvStudent.SelectedRows.Count == 0)
            {
                return;
            }
            frmAddResult fa = new frmAddResult();
            fa.Stu = this.dgvStudent.CurrentRow.DataBoundItem as Student;
            fa.ShowDialog();
        }
    }
}
