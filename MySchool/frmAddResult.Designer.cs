namespace MySchool
{
    partial class frmAddResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddResult));
            this.groupResult = new System.Windows.Forms.GroupBox();
            this.btnAddResult = new System.Windows.Forms.Button();
            this.picExamDate = new System.Windows.Forms.DateTimePicker();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.cboSub = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupResult
            // 
            this.groupResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupResult.Controls.Add(this.btnAddResult);
            this.groupResult.Controls.Add(this.picExamDate);
            this.groupResult.Controls.Add(this.txtResult);
            this.groupResult.Controls.Add(this.cboSub);
            this.groupResult.Controls.Add(this.label3);
            this.groupResult.Controls.Add(this.label2);
            this.groupResult.Controls.Add(this.lblSub);
            this.groupResult.Location = new System.Drawing.Point(13, 13);
            this.groupResult.Name = "groupResult";
            this.groupResult.Size = new System.Drawing.Size(505, 162);
            this.groupResult.TabIndex = 0;
            this.groupResult.TabStop = false;
            this.groupResult.Text = "输入成绩";
            // 
            // btnAddResult
            // 
            this.btnAddResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddResult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddResult.Location = new System.Drawing.Point(399, 116);
            this.btnAddResult.Name = "btnAddResult";
            this.btnAddResult.Size = new System.Drawing.Size(82, 23);
            this.btnAddResult.TabIndex = 4;
            this.btnAddResult.Text = "添加";
            this.btnAddResult.UseVisualStyleBackColor = true;
            this.btnAddResult.Click += new System.EventHandler(this.btnAddResult_Click);
            // 
            // picExamDate
            // 
            this.picExamDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picExamDate.Location = new System.Drawing.Point(97, 118);
            this.picExamDate.Name = "picExamDate";
            this.picExamDate.Size = new System.Drawing.Size(280, 21);
            this.picExamDate.TabIndex = 3;
            this.picExamDate.ValueChanged += new System.EventHandler(this.picExamDate_ValueChanged);
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResult.Location = new System.Drawing.Point(97, 74);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(280, 21);
            this.txtResult.TabIndex = 2;
            // 
            // cboSub
            // 
            this.cboSub.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSub.FormattingEnabled = true;
            this.cboSub.Location = new System.Drawing.Point(97, 30);
            this.cboSub.Name = "cboSub";
            this.cboSub.Size = new System.Drawing.Size(280, 20);
            this.cboSub.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "考试时间";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "成绩";
            // 
            // lblSub
            // 
            this.lblSub.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSub.AutoSize = true;
            this.lblSub.Location = new System.Drawing.Point(55, 32);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(29, 12);
            this.lblSub.TabIndex = 0;
            this.lblSub.Text = "科目";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 189);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(506, 280);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "学生姓名";
            this.columnHeader1.Width = 78;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "科目名称";
            this.columnHeader2.Width = 229;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "成绩";
            this.columnHeader3.Width = 65;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "考试时间";
            this.columnHeader4.Width = 127;
            // 
            // frmAddResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 483);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(546, 400);
            this.Name = "frmAddResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加学生成绩";
            this.Load += new System.EventHandler(this.frmAddResult_Load);
            this.groupResult.ResumeLayout(false);
            this.groupResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupResult;
        private System.Windows.Forms.Button btnAddResult;
        private System.Windows.Forms.DateTimePicker picExamDate;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.ComboBox cboSub;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}