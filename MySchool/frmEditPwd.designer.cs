namespace MySchool
{
    partial class frmEditPwd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditPwd));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtOpwd = new System.Windows.Forms.TextBox();
            this.txtNpwd = new System.Windows.Forms.TextBox();
            this.txtCpwd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "原密码";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "新密码";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "确认密码";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(85, 183);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "修改";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(199, 183);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "返回";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtOpwd
            // 
            this.txtOpwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOpwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOpwd.Location = new System.Drawing.Point(125, 39);
            this.txtOpwd.Name = "txtOpwd";
            this.txtOpwd.PasswordChar = '*';
            this.txtOpwd.Size = new System.Drawing.Size(149, 21);
            this.txtOpwd.TabIndex = 1;
            // 
            // txtNpwd
            // 
            this.txtNpwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNpwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNpwd.Location = new System.Drawing.Point(125, 80);
            this.txtNpwd.Name = "txtNpwd";
            this.txtNpwd.PasswordChar = '*';
            this.txtNpwd.Size = new System.Drawing.Size(149, 21);
            this.txtNpwd.TabIndex = 2;
            // 
            // txtCpwd
            // 
            this.txtCpwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCpwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCpwd.Location = new System.Drawing.Point(125, 132);
            this.txtCpwd.Name = "txtCpwd";
            this.txtCpwd.PasswordChar = '*';
            this.txtCpwd.Size = new System.Drawing.Size(149, 21);
            this.txtCpwd.TabIndex = 3;
            // 
            // FrmEditPwd
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(341, 259);
            this.Controls.Add(this.txtCpwd);
            this.Controls.Add(this.txtNpwd);
            this.Controls.Add(this.txtOpwd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(357, 297);
            this.Name = "FrmEditPwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtOpwd;
        private System.Windows.Forms.TextBox txtNpwd;
        private System.Windows.Forms.TextBox txtCpwd;
    }
}