namespace MySchool
{
    partial class frmSeachSubject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeachSubject));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvGrade = new System.Windows.Forms.TreeView();
            this.dgvSubject = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubject)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.tvGrade);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvSubject);
            this.splitContainer1.Size = new System.Drawing.Size(682, 454);
            this.splitContainer1.SplitterDistance = 147;
            this.splitContainer1.TabIndex = 0;
            // 
            // tvGrade
            // 
            this.tvGrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvGrade.Location = new System.Drawing.Point(0, 0);
            this.tvGrade.Name = "tvGrade";
            this.tvGrade.Size = new System.Drawing.Size(147, 454);
            this.tvGrade.TabIndex = 0;
            this.tvGrade.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvGrade_AfterSelect);
            // 
            // dgvSubject
            // 
            this.dgvSubject.AllowUserToAddRows = false;
            this.dgvSubject.AllowUserToDeleteRows = false;
            this.dgvSubject.AllowUserToResizeRows = false;
            this.dgvSubject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubject.BackgroundColor = System.Drawing.Color.White;
            this.dgvSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSubject.Location = new System.Drawing.Point(0, 0);
            this.dgvSubject.Name = "dgvSubject";
            this.dgvSubject.ReadOnly = true;
            this.dgvSubject.RowHeadersVisible = false;
            this.dgvSubject.RowTemplate.Height = 23;
            this.dgvSubject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubject.Size = new System.Drawing.Size(531, 454);
            this.dgvSubject.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "SubjectName";
            this.Column1.FillWeight = 120F;
            this.Column1.HeaderText = "科目名称";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ClassHour";
            this.Column2.FillWeight = 70F;
            this.Column2.HeaderText = "课时";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Grade";
            this.Column3.FillWeight = 50F;
            this.Column3.HeaderText = "年级";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // frmSeachSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 454);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "frmSeachSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "科目列表";
            this.Load += new System.EventHandler(this.frmSeachSubject_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubject)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvGrade;
        private System.Windows.Forms.DataGridView dgvSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}