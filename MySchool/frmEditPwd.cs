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
    public partial class frmEditPwd : Form
    {
        public frmEditPwd()
        {
            InitializeComponent();
        }
        public Admin admin;

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.txtOpwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入原密码！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (this.txtNpwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入新密码！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (this.txtCpwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("请再次输入新密码！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (this.txtOpwd.Text.Trim() != this.admin.LoginPwd)
            {
                MessageBox.Show("原密码输入错误！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (this.txtNpwd.Text.Trim() != this.txtCpwd.Text.Trim())
            {
                MessageBox.Show("两次密码输入不一致！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                if (AdminBLL.EditLoginPwd(new Admin(this.admin.LoginId,this.txtNpwd.Text.Trim())))
                {
                    this.admin.LoginPwd = this.txtNpwd.Text.Trim();
                    MessageBox.Show("密码修改成功！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("密码修改失败！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("修改密码出现异常：\n" + ex.Message, "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
         }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
