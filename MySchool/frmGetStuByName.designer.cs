namespace MySchool
{
    partial class frmGetStuByName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGetStuByName));
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.编辑学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加成绩ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Location = new System.Drawing.Point(245, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "姓名";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(71, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(136, 21);
            this.txtName.TabIndex = 1;
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToDeleteRows = false;
            this.dgvStudent.AllowUserToResizeRows = false;
            this.dgvStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudent.BackgroundColor = System.Drawing.Color.White;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvStudent.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvStudent.Location = new System.Drawing.Point(12, 50);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            this.dgvStudent.RowHeadersVisible = false;
            this.dgvStudent.RowTemplate.Height = 23;
            this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudent.Size = new System.Drawing.Size(560, 341);
            this.dgvStudent.TabIndex = 8;
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
            this.Column3.FillWeight = 40F;
            this.Column3.HeaderText = "性别";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "GradeName";
            this.Column4.FillWeight = 50F;
            this.Column4.HeaderText = "年级";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.编辑学生信息ToolStripMenuItem,
            this.添加成绩ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 48);
            // 
            // 编辑学生信息ToolStripMenuItem
            // 
            this.编辑学生信息ToolStripMenuItem.Name = "编辑学生信息ToolStripMenuItem";
            this.编辑学生信息ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.编辑学生信息ToolStripMenuItem.Text = "编辑学生信息";
            this.编辑学生信息ToolStripMenuItem.Click += new System.EventHandler(this.编辑学生信息ToolStripMenuItem_Click);
            // 
            // 添加成绩ToolStripMenuItem
            // 
            this.添加成绩ToolStripMenuItem.Name = "添加成绩ToolStripMenuItem";
            this.添加成绩ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.添加成绩ToolStripMenuItem.Text = "添加成绩";
            this.添加成绩ToolStripMenuItem.Click += new System.EventHandler(this.添加成绩ToolStripMenuItem_Click);
            // 
            // frmGetStuByName
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 403);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(601, 250);
            this.Name = "frmGetStuByName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查询学生信息";
            this.Load += new System.EventHandler(this.FrmGetStuByName_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 编辑学生信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加成绩ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}