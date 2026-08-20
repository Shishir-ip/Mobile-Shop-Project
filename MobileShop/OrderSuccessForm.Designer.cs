namespace MobileShop
{
    partial class OrderSuccessForm
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
            lblSuccess = new Label();
            btnHome = new Button();
            SuspendLayout();
            // 
            // lblSuccess
            // 
            lblSuccess.AutoSize = true;
            lblSuccess.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            lblSuccess.ForeColor = Color.Green;
            lblSuccess.Location = new Point(40, 50);
            lblSuccess.Name = "lblSuccess";
            lblSuccess.Size = new Size(397, 38);
            lblSuccess.TabIndex = 0;
            lblSuccess.Text = "Order Placed Successfully ✅";
            lblSuccess.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(165, 120);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(130, 40);
            btnHome.TabIndex = 1;
            btnHome.Text = "Go to Home";
            btnHome.UseVisualStyleBackColor = true;
            // 
            // OrderSuccessForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(460, 220);
            Controls.Add(btnHome);
            Controls.Add(lblSuccess);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "OrderSuccessForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Order Success";
            Load += OrderSuccessForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblSuccess;
        private System.Windows.Forms.Button btnHome;
    }
}