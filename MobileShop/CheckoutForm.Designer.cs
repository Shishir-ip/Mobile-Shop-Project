namespace MobileShop
{
    partial class CheckoutForm
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
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            dgvSummary = new DataGridView();
            lblOrderTotal = new Label();
            rbCOD = new RadioButton();
            rbOnline = new RadioButton();
            panelBkash = new Panel();
            lblBkashPrompt = new Label();
            lblBkashNumber = new Label();
            btnCopy = new Button();
            lblBkashNote = new Label();
            txtBkashNum = new TextBox();
            txtTransId = new TextBox();
            btnPlaceOrder = new Button();
            lblDeliveryDetails = new Label();
            lblPaymentMethod = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSummary).BeginInit();
            panelBkash.SuspendLayout();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(20, 50);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Full Name";
            txtName.Size = new Size(250, 27);
            txtName.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(290, 50);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Phone Number";
            txtPhone.Size = new Size(250, 27);
            txtPhone.TabIndex = 2;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(20, 90);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Full Delivery Address";
            txtAddress.Size = new Size(520, 60);
            txtAddress.TabIndex = 3;
            // 
            // dgvSummary
            // 
            dgvSummary.AllowUserToAddRows = false;
            dgvSummary.AllowUserToDeleteRows = false;
            dgvSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSummary.Location = new Point(20, 170);
            dgvSummary.Name = "dgvSummary";
            dgvSummary.ReadOnly = true;
            dgvSummary.RowHeadersWidth = 51;
            dgvSummary.Size = new Size(520, 150);
            dgvSummary.TabIndex = 4;
            // 
            // lblOrderTotal
            // 
            lblOrderTotal.AutoSize = true;
            lblOrderTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblOrderTotal.Location = new Point(20, 335);
            lblOrderTotal.Name = "lblOrderTotal";
            lblOrderTotal.Size = new Size(130, 28);
            lblOrderTotal.TabIndex = 5;
            lblOrderTotal.Text = "Order Total: ";
            // 
            // rbCOD
            // 
            rbCOD.AutoSize = true;
            rbCOD.Checked = true;
            rbCOD.Location = new Point(20, 420);
            rbCOD.Name = "rbCOD";
            rbCOD.Size = new Size(140, 24);
            rbCOD.TabIndex = 7;
            rbCOD.TabStop = true;
            rbCOD.Text = "Cash on Delivery";
            rbCOD.UseVisualStyleBackColor = true;
            // 
            // rbOnline
            // 
            rbOnline.AutoSize = true;
            rbOnline.Location = new Point(180, 420);
            rbOnline.Name = "rbOnline";
            rbOnline.Size = new Size(251, 24);
            rbOnline.TabIndex = 8;
            rbOnline.Text = "Online Payment / Mobile Banking";
            rbOnline.UseVisualStyleBackColor = true;
            // 
            // panelBkash
            // 
            panelBkash.BorderStyle = BorderStyle.FixedSingle;
            panelBkash.Controls.Add(lblBkashPrompt);
            panelBkash.Controls.Add(lblBkashNumber);
            panelBkash.Controls.Add(btnCopy);
            panelBkash.Controls.Add(lblBkashNote);
            panelBkash.Controls.Add(txtBkashNum);
            panelBkash.Controls.Add(txtTransId);
            panelBkash.Location = new Point(20, 460);
            panelBkash.Name = "panelBkash";
            panelBkash.Size = new Size(520, 160);
            panelBkash.TabIndex = 9;
            panelBkash.Visible = false;
            // 
            // lblBkashPrompt
            // 
            lblBkashPrompt.AutoSize = true;
            lblBkashPrompt.Location = new Point(10, 15);
            lblBkashPrompt.Name = "lblBkashPrompt";
            lblBkashPrompt.Size = new Size(212, 20);
            lblBkashPrompt.TabIndex = 0;
            lblBkashPrompt.Text = "Send ৳X to this bKash number:";
            // 
            // lblBkashNumber
            // 
            lblBkashNumber.AutoSize = true;
            lblBkashNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBkashNumber.Location = new Point(220, 15);
            lblBkashNumber.Name = "lblBkashNumber";
            lblBkashNumber.Size = new Size(137, 20);
            lblBkashNumber.TabIndex = 1;
            lblBkashNumber.Text = "+8801676220935";
            // 
            // btnCopy
            // 
            btnCopy.Location = new Point(360, 10);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(70, 30);
            btnCopy.TabIndex = 2;
            btnCopy.Text = "Copy";
            btnCopy.UseVisualStyleBackColor = true;
            // 
            // lblBkashNote
            // 
            lblBkashNote.Location = new Point(10, 50);
            lblBkashNote.Name = "lblBkashNote";
            lblBkashNote.Size = new Size(500, 40);
            lblBkashNote.TabIndex = 3;
            lblBkashNote.Text = "Note: Pay the amount from your bKash using Send Money, then enter your number and Transaction ID below.";
            // 
            // txtBkashNum
            // 
            txtBkashNum.Location = new Point(10, 110);
            txtBkashNum.Name = "txtBkashNum";
            txtBkashNum.PlaceholderText = "Your bKash Number";
            txtBkashNum.Size = new Size(200, 27);
            txtBkashNum.TabIndex = 4;
            // 
            // txtTransId
            // 
            txtTransId.Location = new Point(220, 110);
            txtTransId.Name = "txtTransId";
            txtTransId.PlaceholderText = "Transaction ID (TrxID)";
            txtTransId.Size = new Size(280, 27);
            txtTransId.TabIndex = 5;
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.BackColor = SystemColors.Highlight;
            btnPlaceOrder.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnPlaceOrder.ForeColor = Color.White;
            btnPlaceOrder.Location = new Point(160, 640);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(240, 50);
            btnPlaceOrder.TabIndex = 10;
            btnPlaceOrder.Text = "Complete Order";
            btnPlaceOrder.UseVisualStyleBackColor = false;
            // 
            // lblDeliveryDetails
            // 
            lblDeliveryDetails.AutoSize = true;
            lblDeliveryDetails.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblDeliveryDetails.Location = new Point(20, 15);
            lblDeliveryDetails.Name = "lblDeliveryDetails";
            lblDeliveryDetails.Size = new Size(137, 23);
            lblDeliveryDetails.TabIndex = 0;
            lblDeliveryDetails.Text = "Delivery Details";
            // 
            // lblPaymentMethod
            // 
            lblPaymentMethod.AutoSize = true;
            lblPaymentMethod.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblPaymentMethod.Location = new Point(20, 385);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new Size(148, 23);
            lblPaymentMethod.TabIndex = 6;
            lblPaymentMethod.Text = "Payment Method";
            // 
            // CheckoutForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 710);
            Controls.Add(btnPlaceOrder);
            Controls.Add(panelBkash);
            Controls.Add(rbOnline);
            Controls.Add(rbCOD);
            Controls.Add(lblPaymentMethod);
            Controls.Add(lblOrderTotal);
            Controls.Add(dgvSummary);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtName);
            Controls.Add(lblDeliveryDetails);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "CheckoutForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Secure Checkout";
            Load += CheckoutForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSummary).EndInit();
            panelBkash.ResumeLayout(false);
            panelBkash.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblDeliveryDetails;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DataGridView dgvSummary;
        private System.Windows.Forms.Label lblOrderTotal;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.RadioButton rbCOD;
        private System.Windows.Forms.RadioButton rbOnline;
        private System.Windows.Forms.Panel panelBkash;
        private System.Windows.Forms.Label lblBkashPrompt;
        private System.Windows.Forms.Label lblBkashNumber;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Label lblBkashNote;
        private System.Windows.Forms.TextBox txtBkashNum;
        private System.Windows.Forms.TextBox txtTransId;
        private System.Windows.Forms.Button btnPlaceOrder;
    }
}