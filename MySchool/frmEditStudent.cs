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
    public partial class frmEditStudent : Form
    {
        public frmEditStudent()
        {
            InitializeComponent();
        }
        public bool IsUpdate;
        public Student Stu;
        private void frmAddStudent_Load(object sender, EventArgs e)
        {
            try
            {
                this.cboGrade.DisplayMember = "GradeName";
                this.cboGrade.ValueMember = "GradeId";
                this.cboGrade.DataSource = GradeBLL.GetAllGrade();
            }
            catch (Exception ex)
            {
                MessageBox.Show("绑定年级列表出现异常\n" + ex.Message, "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (!IsUpdate)
            {
                this.rbtnMan.Checked = true;
            }
            else
            {
                this.Text = "编辑学生信息";
                this.btnSave.Text = "修改";
                this.txtNo.Text = Stu.StudentNo;
                this.txtNo.ReadOnly = true;
                this.txtNo.ForeColor = Color.Red;
                this.txtName.Text = Stu.StudentName;
                this.txtPhone.Text = Stu.Phone;
                this.txtAddress.Text = Stu.Address;
                this.txtCPwd.Text = Stu.LoginPwd;
                this.txtPwd.Text = Stu.LoginPwd;
                this.txtEmail.Text = Stu.Email;
                if (Stu.Gender == "男")
                    this.rbtnMan.Checked = true;
                else
                    this.rbtnWoMan.Checked = true;
                this.picBornDate.Value = Stu.BornDate;
                this.cboGrade.SelectedValue = Stu.Grade.GradeId;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string no = this.txtNo.Text.Trim();
            string name = this.txtName.Text.Trim();
            string address = this.txtAddress.Text.Trim();
            string email = this.txtEmail.Text.Trim();
            string phone = this.txtPhone.Text.Trim();
            string pwd = this.txtPwd.Text.Trim();
            string cPwd = this.txtCPwd.Text.Trim();
            DateTime bornDate = this.picBornDate.Value;
            string gender = this.rbtnMan.Checked ? "男" :"女";
            Grade grade = this.cboGrade.SelectedItem as Grade;
            if (name.Length == 0 ||pwd.Length == 0 )
            {
                MessageBox.Show("您填写的信息不完整！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!IsUpdate && no.Length == 0)
            {
                MessageBox.Show("请填写学号！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (pwd!=cPwd)
	        {
                MessageBox.Show("两次密码输入不一致！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
	        }
            Stu = new Student(
                no,pwd,name,gender,grade,phone,address,bornDate,email
                );
            if (!this.IsUpdate)
            {
                List<Student> stus = StudentBLL.GetAllStudentByStuIdAndGender();
                foreach (Student s in stus)
	            {
                    if (s.StudentNo == Stu.StudentNo)
                    {
                        MessageBox.Show("已有学号为" + Stu.StudentNo + "的学生", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
	            }
                try
                {
                    if (StudentBLL.AddStudent(Stu))
                    {
                        MessageBox.Show("添加学生成功", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearControls();
                    }
                    else
                    {
                        MessageBox.Show("添加学生失败", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("添加学生出现异常\n" + ex.Message, "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                try
                {
                    if (StudentBLL.UpdateStudent(Stu))
                    {
                        MessageBox.Show("修改学生信息成功", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("修改学生信息失败", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("修改学生信息出现异常\n" + ex.Message, "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
        public void ClearControls()
        {
            this.txtAddress.Clear();
            this.txtCPwd.Clear();
            this.txtEmail.Clear();
            this.txtName.Clear();
            this.txtNo.Clear();
            this.txtPhone.Clear();
            this.txtPwd.Clear();
            this.picBornDate.Value = DateTime.Now;
            this.cboGrade.SelectedIndex = 0;
            this.rbtnMan.Checked = true;
        }

        private void picBornDate_ValueChanged(object sender, EventArgs e)
        {
            if (this.picBornDate.Value > DateTime.Now)
            {
                MessageBox.Show("出生日期不能大于当前日期！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.picBornDate.Value = DateTime.Now;
                return;
            }
        }
    }
}
