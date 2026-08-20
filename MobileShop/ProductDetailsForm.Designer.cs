namespace MobileShop
{
    partial class ProductDetailsForm
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
            btnBack = new Button();
            picPhone = new PictureBox();
            lblName = new Label();
            lblPrice = new Label();
            lblSpecs = new Label();
            btnAdd = new Button();
            btnBuy = new Button();
            ((System.ComponentModel.ISupportInitialize)picPhone).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(20, 20);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(90, 30);
            btnBack.TabIndex = 0;
            btnBack.Text = "< Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // picPhone
            // 
            picPhone.BorderStyle = BorderStyle.FixedSingle;
            picPhone.Location = new Point(20, 70);
            picPhone.Name = "picPhone";
            picPhone.Size = new Size(200, 250);
            picPhone.SizeMode = PictureBoxSizeMode.Zoom;
            picPhone.TabIndex = 1;
            picPhone.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(240, 70);
            lblName.Name = "lblName";
            lblName.Size = new Size(206, 38);
            lblName.TabIndex = 2;
            lblName.Text = "Product Name";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = Color.Green;
            lblPrice.Location = new Point(240, 115);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(91, 31);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "$999.99";
            // 
            // lblSpecs
            // 
            lblSpecs.Location = new Point(240, 160);
            lblSpecs.Name = "lblSpecs";
            lblSpecs.Size = new Size(320, 120);
            lblSpecs.TabIndex = 4;
            lblSpecs.Text = "Specifications will appear here...";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(240, 280);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 40);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add to Cart";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnBuy
            // 
            btnBuy.BackColor = SystemColors.Highlight;
            btnBuy.ForeColor = Color.White;
            btnBuy.Location = new Point(380, 280);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(120, 40);
            btnBuy.TabIndex = 6;
            btnBuy.Text = "Buy Now";
            btnBuy.UseVisualStyleBackColor = false;
            // 
            // ProductDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 360);
            Controls.Add(btnBuy);
            Controls.Add(btnAdd);
            Controls.Add(lblSpecs);
            Controls.Add(lblPrice);
            Controls.Add(lblName);
            Controls.Add(picPhone);
            Controls.Add(btnBack);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "ProductDetailsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Details";
            Load += ProductDetailsForm_Load;
            ((System.ComponentModel.ISupportInitialize)picPhone).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox picPhone;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblSpecs;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBuy;
    }
}