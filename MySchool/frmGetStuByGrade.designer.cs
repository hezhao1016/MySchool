namespace MySchool
{
    partial class frmGetStuByGrade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGetStuByGrade));
            this.label1 = new System.Windows.Forms.Label();
            this.cboGrade = new System.Windows.Forms.ComboBox();
            this.dgvStu = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.编辑学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加成绩ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStu)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "年级";
            // 
            // cboGrade
            // 
            this.cboGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrade.FormattingEnabled = true;
            this.cboGrade.Location = new System.Drawing.Point(69, 20);
            this.cboGrade.Name = "cboGrade";
            this.cboGrade.Size = new System.Drawing.Size(138, 20);
            this.cboGrade.TabIndex = 1;
            this.cboGrade.SelectedIndexChanged += new System.EventHandler(this.cboGrade_SelectedIndexChanged);
            // 
            // dgvStu
            // 
            this.dgvStu.AllowUserToAddRows = false;
            this.dgvStu.AllowUserToDeleteRows = false;
            this.dgvStu.AllowUserToResizeRows = false;
            this.dgvStu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStu.BackgroundColor = System.Drawing.Color.White;
            this.dgvStu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.colGender,
            this.Column4});
            this.dgvStu.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvStu.Location = new System.Drawing.Point(13, 58);
            this.dgvStu.Name = "dgvStu";
            this.dgvStu.ReadOnly = true;
            this.dgvStu.RowHeadersVisible = false;
            this.dgvStu.RowTemplate.Height = 23;
            this.dgvStu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStu.Size = new System.Drawing.Size(588, 343);
            this.dgvStu.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "StudentNo";
            this.Column1.FillWeight = 79.18781F;
            this.Column1.HeaderText = "学生学号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "StudentName";
            this.Column2.FillWeight = 79.18781F;
            this.Column2.HeaderText = "学生姓名";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // colGender
            // 
            this.colGender.DataPropertyName = "Gender";
            this.colGender.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colGender.FillWeight = 40F;
            this.colGender.HeaderText = "性别";
            this.colGender.Items.AddRange(new object[] {
            "男",
            "女"});
            this.colGender.Name = "colGender";
            this.colGender.ReadOnly = true;
            this.colGender.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colGender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "BornDate";
            this.Column4.FillWeight = 79.18781F;
            this.Column4.HeaderText = "出生年月日";
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
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(513, 410);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "确定";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmGetStuByGrade
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 438);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvStu);
            this.Controls.Add(this.cboGrade);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(629, 250);
            this.Name = "frmGetStuByGrade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生列表";
            this.Load += new System.EventHandler(this.FrmGetStuByGrade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStu)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboGrade;
        private System.Windows.Forms.DataGridView dgvStu;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 编辑学生信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加成绩ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewComboBoxColumn colGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}