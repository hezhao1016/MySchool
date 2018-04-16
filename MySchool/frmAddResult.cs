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
    public partial class frmAddResult : Form
    {
        public frmAddResult()
        {
            InitializeComponent();
        }
        public Student Stu;
        private void frmAddResult_Load(object sender, EventArgs e)
        {
            this.cboSub.DisplayMember = "SubjectName";
            this.cboSub.ValueMember = "SubjectId";
            try
            {
                this.cboSub.DataSource = new BindingList<Subject>( SubjectBLL.GetSubject(this.Stu.Grade.GradeId));
            }
            catch (Exception ex)
            {
                MessageBox.Show("绑定科目下拉框出现异常\n" + ex.Message, "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            ShowStudentResultSeach();//使用扩展类显示

            //ShowStudentResult();//使用重写ToString（）实现
        }

        private void picExamDate_ValueChanged(object sender, EventArgs e)
        {
            if (this.picExamDate.Value > DateTime.Now)
            {
                MessageBox.Show("考试日期不能大于当前日期！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.picExamDate.Value = DateTime.Now;
                return;
            }
        }
        //使用重写ToString（）方法显示ListView
        public void ShowStudentResult()
        {
            this.listView1.Items.Clear();
            try
            {
                List<Result> results = ResultBLL.GetResultByStu(this.Stu.StudentNo);
                foreach (Result r in results)
                {
                   ListViewItem lv = new ListViewItem(r.Student.ToString());
                    lv.SubItems.AddRange(new string []{r.Subject.ToString(),r.StudentResult.ToString(),r.ExamDate.ToString()});
                    this.listView1.Items.Add(lv);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("查询学生成绩出现异常\n" + ex.Message, "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //使用扩展类显示ListView
        public void ShowStudentResultSeach()
        {
            //清空ListView时， this.listView1.Clear();不正确！
            //应该为listView1.Item.Clear();

            this.listView1.Items.Clear();
            try
            {
                List<ResultSeach> results = ResultBLL.SeachResultByStu(this.Stu.StudentNo);
                foreach (ResultSeach r in results)
                {
                    ListViewItem lv = new ListViewItem(r.StudentName);
                    lv.SubItems.AddRange(new string[] { r.SubjectName, r.StudentResult.ToString(), r.ExamDate.ToString() });
                    this.listView1.Items.Add(lv);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("查询学生成绩出现异常\n" + ex.Message, "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAddResult_Click(object sender, EventArgs e)
        {
            if (this.txtResult.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入成绩！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ResultInsert result = new ResultInsert( 
               this.Stu.StudentNo,Convert.ToInt32( this.cboSub.SelectedValue)
               ,Convert.ToInt32( this.txtResult.Text),this.picExamDate.Value
                );
            try
            {
                if (ResultBLL.AddResult(result))
                {
                    MessageBox.Show("添加成功！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowStudentResultSeach();
                }
                else
                {
                    MessageBox.Show("添加失败！", "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("添加出现异常\n" + ex.Message, "系统提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
