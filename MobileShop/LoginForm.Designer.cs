namespace MobileShop
{
    partial class LoginForm
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
            txtPassword = new TextBox();
            btnLogin = new Button();
            lnkRegister = new LinkLabel();
            lnkForgot = new LinkLabel();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(80, 50);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email Address";
            txtEmail.Size = new Size(220, 27);
            txtEmail.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(80, 100);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(220, 27);
            txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(80, 150);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(220, 35);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // lnkRegister
            // 
            lnkRegister.AutoSize = true;
            lnkRegister.Location = new Point(80, 200);
            lnkRegister.Name = "lnkRegister";
            lnkRegister.Size = new Size(168, 20);
            lnkRegister.TabIndex = 3;
            lnkRegister.TabStop = true;
            lnkRegister.Text = "New user? Register here";
            // 
            // lnkForgot
            // 
            lnkForgot.AutoSize = true;
            lnkForgot.Location = new Point(80, 230);
            lnkForgot.Name = "lnkForgot";
            lnkForgot.Size = new Size(125, 20);
            lnkForgot.TabIndex = 4;
            lnkForgot.TabStop = true;
            lnkForgot.Text = "Forgot Password?";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 320);
            Controls.Add(lnkForgot);
            Controls.Add(lnkRegister);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel lnkRegister;
        private System.Windows.Forms.LinkLabel lnkForgot;
    }
}