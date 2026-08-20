namespace MobileShop
{
    partial class ForgotPasswordForm
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
            txtEmail = new TextBox();
            btnVerifyEmail = new Button();
            txtPhone = new TextBox();
            btnVerifyPhone = new Button();
            txtNewPass = new TextBox();
            btnChangePass = new Button();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(50, 40);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Enter your Email";
            txtEmail.Size = new Size(200, 27);
            txtEmail.TabIndex = 0;
            // 
            // btnVerifyEmail
            // 
            btnVerifyEmail.Location = new Point(270, 40);
            btnVerifyEmail.Name = "btnVerifyEmail";
            btnVerifyEmail.Size = new Size(120, 29);
            btnVerifyEmail.TabIndex = 1;
            btnVerifyEmail.Text = "Verify Email";
            btnVerifyEmail.UseVisualStyleBackColor = true;
            // 
            // txtPhone
            // 
            txtPhone.Enabled = false;
            txtPhone.Location = new Point(50, 90);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Enter your Phone";
            txtPhone.Size = new Size(200, 27);
            txtPhone.TabIndex = 2;
            // 
            // btnVerifyPhone
            // 
            btnVerifyPhone.Enabled = false;
            btnVerifyPhone.Location = new Point(270, 90);
            btnVerifyPhone.Name = "btnVerifyPhone";
            btnVerifyPhone.Size = new Size(120, 29);
            btnVerifyPhone.TabIndex = 3;
            btnVerifyPhone.Text = "Verify Phone";
            btnVerifyPhone.UseVisualStyleBackColor = true;
            // 
            // txtNewPass
            // 
            txtNewPass.Enabled = false;
            txtNewPass.Location = new Point(50, 140);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.PasswordChar = '*';
            txtNewPass.PlaceholderText = "Enter New Password";
            txtNewPass.Size = new Size(200, 27);
            txtNewPass.TabIndex = 4;
            // 
            // btnChangePass
            // 
            btnChangePass.Enabled = false;
            btnChangePass.Location = new Point(270, 140);
            btnChangePass.Name = "btnChangePass";
            btnChangePass.Size = new Size(120, 29);
            btnChangePass.TabIndex = 5;
            btnChangePass.Text = "Change Password";
            btnChangePass.UseVisualStyleBackColor = true;
            // 
            // ForgotPasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 220);
            Controls.Add(btnChangePass);
            Controls.Add(txtNewPass);
            Controls.Add(btnVerifyPhone);
            Controls.Add(txtPhone);
            Controls.Add(btnVerifyEmail);
            Controls.Add(txtEmail);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "ForgotPasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forgot Password";
            Load += ForgotPasswordForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnVerifyEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnVerifyPhone;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Button btnChangePass;
    }
}