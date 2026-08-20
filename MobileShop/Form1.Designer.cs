namespace MobileShop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelTop = new Panel();
            lblWelcome = new Label();
            btnLogin = new Button();
            cmbSort = new ComboBox();
            txtSearch = new TextBox();
            panelLeft = new Panel();
            btnCartBuyNow = new Button();
            lblTotal = new Label();
            dgvCart = new DataGridView();
            lblYourCart = new Label();
            panelRight = new Panel();
            flowPhones = new FlowLayoutPanel();
            panelTop.SuspendLayout();
            panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            panelRight.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(lblWelcome);
            panelTop.Controls.Add(btnLogin);
            panelTop.Controls.Add(cmbSort);
            panelTop.Controls.Add(txtSearch);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1000, 60);
            panelTop.TabIndex = 0;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(600, 20);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(71, 20);
            lblWelcome.TabIndex = 3;
            lblWelcome.Text = "Welcome";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(500, 15);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click_1;
            // 
            // cmbSort
            // 
            cmbSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSort.FormattingEnabled = true;
            cmbSort.Location = new Point(300, 16);
            cmbSort.Name = "cmbSort";
            cmbSort.Size = new Size(151, 28);
            cmbSort.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 16);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search phones...";
            txtSearch.Size = new Size(250, 27);
            txtSearch.TabIndex = 0;
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(btnCartBuyNow);
            panelLeft.Controls.Add(lblTotal);
            panelLeft.Controls.Add(dgvCart);
            panelLeft.Controls.Add(lblYourCart);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 60);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(250, 540);
            panelLeft.TabIndex = 1;
            // 
            // btnCartBuyNow
            // 
            btnCartBuyNow.Location = new Point(12, 499);
            btnCartBuyNow.Name = "btnCartBuyNow";
            btnCartBuyNow.Size = new Size(220, 29);
            btnCartBuyNow.TabIndex = 3;
            btnCartBuyNow.Text = "Buy Now";
            btnCartBuyNow.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(12, 467);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(45, 20);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Total:";
            // 
            // dgvCart
            // 
            dgvCart.AllowUserToAddRows = false;
            dgvCart.AllowUserToDeleteRows = false;
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Location = new Point(12, 45);
            dgvCart.Name = "dgvCart";
            dgvCart.ReadOnly = true;
            dgvCart.RowHeadersWidth = 51;
            dgvCart.Size = new Size(220, 400);
            dgvCart.TabIndex = 1;
            // 
            // lblYourCart
            // 
            lblYourCart.AutoSize = true;
            lblYourCart.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblYourCart.Location = new Point(12, 10);
            lblYourCart.Name = "lblYourCart";
            lblYourCart.Size = new Size(91, 25);
            lblYourCart.TabIndex = 0;
            lblYourCart.Text = "Your Cart";
            // 
            // panelRight
            // 
            panelRight.Controls.Add(flowPhones);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(250, 60);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(750, 540);
            panelRight.TabIndex = 2;
            // 
            // flowPhones
            // 
            flowPhones.AutoScroll = true;
            flowPhones.Dock = DockStyle.Fill;
            flowPhones.Location = new Point(0, 0);
            flowPhones.Name = "flowPhones";
            flowPhones.Size = new Size(750, 540);
            flowPhones.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 600);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            Controls.Add(panelTop);
            Name = "Form1";
            Text = "Mobile Shop";
            Load += Form1_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            panelRight.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Label lblYourCart;
        private System.Windows.Forms.Button btnCartBuyNow;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.FlowLayoutPanel flowPhones;
    }
}
