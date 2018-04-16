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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin (this.txtLoginId.Text.Trim(),this.txtLoginPwd.Text.Trim());
            if (admin.LoginId.Length == 0)
            {
                MessageBox.Show("用户名不能为空！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (admin.LoginPwd.Length == 0)
            {
                MessageBox.Show("用户密码不能为空！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 return;
            }
            try
            {
                if (AdminBLL.CheckLogin(admin))
                {
                    frmMain fm = new frmMain();
                    fm.admin = admin;
                    fm.fl = this;
                    fm.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("用户名或密码错误，登录失败", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("登录出现异常：\n" + ex.Message, "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要取消登录吗？", "取消登录", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return;
            }
            this.Close();
        }
    }
}
