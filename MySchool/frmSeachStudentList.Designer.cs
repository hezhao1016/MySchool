namespace MySchool
{
    partial class frmSeachStudentList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeachStudentList));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvStu = new System.Windows.Forms.TreeView();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvStu);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvStudent);
            this.splitContainer1.Size = new System.Drawing.Size(896, 533);
            this.splitContainer1.SplitterDistance = 178;
            this.splitContainer1.TabIndex = 0;
            // 
            // tvStu
            // 
            this.tvStu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvStu.Location = new System.Drawing.Point(0, 0);
            this.tvStu.Name = "tvStu";
            this.tvStu.Size = new System.Drawing.Size(178, 533);
            this.tvStu.TabIndex = 0;
            this.tvStu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvStu_AfterSelect);
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToDeleteRows = false;
            this.dgvStudent.AllowUserToResizeRows = false;
            this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudent.BackgroundColor = System.Drawing.Color.White;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvStudent.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudent.Location = new System.Drawing.Point(0, 0);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            this.dgvStudent.RowHeadersVisible = false;
            this.dgvStudent.RowTemplate.Height = 23;
            this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudent.Size = new System.Drawing.Size(714, 533);
            this.dgvStudent.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "StudentNo";
            this.Column1.HeaderText = "学号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "StudentName";
            this.Column2.HeaderText = "姓名";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Gender";
            this.Column3.FillWeight = 50F;
            this.Column3.HeaderText = "性别";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Grade";
            this.Column4.FillWeight = 50F;
            this.Column4.HeaderText = "年级";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Phone";
            this.Column5.FillWeight = 120F;
            this.Column5.HeaderText = "电话";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除学生信息ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 26);
            // 
            // 删除学生信息ToolStripMenuItem
            // 
            this.删除学生信息ToolStripMenuItem.Name = "删除学生信息ToolStripMenuItem";
            this.删除学生信息ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.删除学生信息ToolStripMenuItem.Text = "删除学生信息";
            this.删除学生信息ToolStripMenuItem.Click += new System.EventHandler(this.删除学生信息ToolStripMenuItem_Click);
            // 
            // frmSeachStudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 533);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "frmSeachStudentList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生信息列表";
            this.Load += new System.EventHandler(this.frmSeachStudentList_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvStu;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除学生信息ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}