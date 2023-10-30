namespace QuanLyQuanCafe
{
    partial class ChangePassword
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChangePass = new Guna.UI2.WinForms.Guna2Button();
            this.btnExitChange = new Guna.UI2.WinForms.Guna2Button();
            this.txtNewPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRepassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtUserName1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtNewPassword);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(12, 111);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(447, 62);
            this.panel3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu mới :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtRepassword);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 62);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mời nhập lại :";
            // 
            // btnChangePass
            // 
            this.btnChangePass.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChangePass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChangePass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChangePass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChangePass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnChangePass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChangePass.ForeColor = System.Drawing.Color.White;
            this.btnChangePass.Location = new System.Drawing.Point(63, 279);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(148, 45);
            this.btnChangePass.TabIndex = 7;
            this.btnChangePass.Text = "Xác nhận";
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // btnExitChange
            // 
            this.btnExitChange.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExitChange.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExitChange.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExitChange.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExitChange.FillColor = System.Drawing.Color.Red;
            this.btnExitChange.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExitChange.ForeColor = System.Drawing.Color.White;
            this.btnExitChange.Location = new System.Drawing.Point(284, 279);
            this.btnExitChange.Name = "btnExitChange";
            this.btnExitChange.Size = new System.Drawing.Size(148, 45);
            this.btnExitChange.TabIndex = 8;
            this.btnExitChange.Text = "Thoát";
            this.btnExitChange.Click += new System.EventHandler(this.btnThoatDoi_Click);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPassword.DefaultText = "";
            this.txtNewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPassword.Location = new System.Drawing.Point(194, 15);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '\0';
            this.txtNewPassword.PlaceholderText = "";
            this.txtNewPassword.SelectedText = "";
            this.txtNewPassword.Size = new System.Drawing.Size(236, 36);
            this.txtNewPassword.TabIndex = 9;
            // 
            // txtRepassword
            // 
            this.txtRepassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRepassword.DefaultText = "";
            this.txtRepassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRepassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRepassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRepassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRepassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRepassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRepassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRepassword.Location = new System.Drawing.Point(194, 17);
            this.txtRepassword.Name = "txtRepassword";
            this.txtRepassword.PasswordChar = '\0';
            this.txtRepassword.PlaceholderText = "";
            this.txtRepassword.SelectedText = "";
            this.txtRepassword.Size = new System.Drawing.Size(236, 36);
            this.txtRepassword.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtUserName1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(447, 62);
            this.panel2.TabIndex = 10;
            // 
            // txtUserName1
            // 
            this.txtUserName1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName1.DefaultText = "";
            this.txtUserName1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserName1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserName1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUserName1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName1.Location = new System.Drawing.Point(194, 15);
            this.txtUserName1.Name = "txtUserName1";
            this.txtUserName1.PasswordChar = '\0';
            this.txtUserName1.PlaceholderText = "";
            this.txtUserName1.SelectedText = "";
            this.txtUserName1.Size = new System.Drawing.Size(236, 36);
            this.txtUserName1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Username :";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(496, 389);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnExitChange);
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi Mật Khẩu";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtNewPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtRepassword;
        private Guna.UI2.WinForms.Guna2Button btnChangePass;
        private Guna.UI2.WinForms.Guna2Button btnExitChange;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtUserName1;
        private System.Windows.Forms.Label label3;
    }
}