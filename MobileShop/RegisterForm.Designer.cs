namespace MobileShop
{
    partial class RegisterForm
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
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtPassword = new TextBox();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(80, 40);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Full Name";
            txtName.Size = new Size(220, 27);
            txtName.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(80, 90);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email Address";
            txtEmail.Size = new Size(220, 27);
            txtEmail.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(80, 140);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Phone Number";
            txtPhone.Size = new Size(220, 27);
            txtPhone.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(80, 190);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(220, 27);
            txtPassword.TabIndex = 3;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(80, 240);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(220, 35);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 320);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnRegister;
    }
}