namespace MobileShop
{
    partial class AdminForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            tabControlAdmin = new TabControl();
            tabProducts = new TabPage();
            lblSpecs = new Label();
            lblImage = new Label();
            lblStock = new Label();
            lblPrice = new Label();
            lblModel = new Label();
            lblBrand = new Label();
            lblPName = new Label();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            btnBrowse = new Button();
            txtSpecs = new TextBox();
            txtImage = new TextBox();
            txtStock = new TextBox();
            txtPrice = new TextBox();
            txtModel = new TextBox();
            txtBrand = new TextBox();
            txtPName = new TextBox();
            dgvProducts = new DataGridView();
            tabOrders = new TabPage();
            dgvOrders = new DataGridView();
            tabControlAdmin.SuspendLayout();
            tabProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            tabOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // tabControlAdmin
            // 
            tabControlAdmin.Controls.Add(tabProducts);
            tabControlAdmin.Controls.Add(tabOrders);
            tabControlAdmin.Dock = DockStyle.Fill;
            tabControlAdmin.Location = new Point(0, 0);
            tabControlAdmin.Name = "tabControlAdmin";
            tabControlAdmin.SelectedIndex = 0;
            tabControlAdmin.Size = new Size(980, 600);
            tabControlAdmin.TabIndex = 0;
            // 
            // tabProducts
            // 
            tabProducts.Controls.Add(lblSpecs);
            tabProducts.Controls.Add(lblImage);
            tabProducts.Controls.Add(lblStock);
            tabProducts.Controls.Add(lblPrice);
            tabProducts.Controls.Add(lblModel);
            tabProducts.Controls.Add(lblBrand);
            tabProducts.Controls.Add(lblPName);
            tabProducts.Controls.Add(btnClear);
            tabProducts.Controls.Add(btnDelete);
            tabProducts.Controls.Add(btnUpdate);
            tabProducts.Controls.Add(btnAdd);
            tabProducts.Controls.Add(btnBrowse);
            tabProducts.Controls.Add(txtSpecs);
            tabProducts.Controls.Add(txtImage);
            tabProducts.Controls.Add(txtStock);
            tabProducts.Controls.Add(txtPrice);
            tabProducts.Controls.Add(txtModel);
            tabProducts.Controls.Add(txtBrand);
            tabProducts.Controls.Add(txtPName);
            tabProducts.Controls.Add(dgvProducts);
            tabProducts.Location = new Point(4, 29);
            tabProducts.Name = "tabProducts";
            tabProducts.Padding = new Padding(3);
            tabProducts.Size = new Size(972, 567);
            tabProducts.TabIndex = 0;
            tabProducts.Text = "Products";
            tabProducts.UseVisualStyleBackColor = true;
            // 
            // lblSpecs
            // 
            lblSpecs.AutoSize = true;
            lblSpecs.Location = new Point(20, 270);
            lblSpecs.Name = "lblSpecs";
            lblSpecs.Size = new Size(47, 20);
            lblSpecs.TabIndex = 19;
            lblSpecs.Text = "Specs";
            // 
            // lblImage
            // 
            lblImage.AutoSize = true;
            lblImage.Location = new Point(20, 230);
            lblImage.Name = "lblImage";
            lblImage.Size = new Size(51, 20);
            lblImage.TabIndex = 18;
            lblImage.Text = "Image";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(20, 190);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(45, 20);
            lblStock.TabIndex = 17;
            lblStock.Text = "Stock";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(20, 150);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(41, 20);
            lblPrice.TabIndex = 16;
            lblPrice.Text = "Price";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(20, 110);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(52, 20);
            lblModel.TabIndex = 15;
            lblModel.Text = "Model";
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Location = new Point(20, 70);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(48, 20);
            lblBrand.TabIndex = 14;
            lblBrand.Text = "Brand";
            // 
            // lblPName
            // 
            lblPName.AutoSize = true;
            lblPName.Location = new Point(20, 30);
            lblPName.Name = "lblPName";
            lblPName.Size = new Size(49, 20);
            lblPName.TabIndex = 13;
            lblPName.Text = "Name";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(180, 480);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(85, 30);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(90, 480);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(85, 30);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(180, 440);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(85, 30);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(90, 440);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(85, 30);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(275, 225);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(65, 29);
            btnBrowse.TabIndex = 8;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            // 
            // txtSpecs
            // 
            txtSpecs.Location = new Point(90, 265);
            txtSpecs.Multiline = true;
            txtSpecs.Name = "txtSpecs";
            txtSpecs.Size = new Size(250, 150);
            txtSpecs.TabIndex = 7;
            // 
            // txtImage
            // 
            txtImage.Location = new Point(90, 225);
            txtImage.Name = "txtImage";
            txtImage.Size = new Size(180, 27);
            txtImage.TabIndex = 6;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(90, 185);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(250, 27);
            txtStock.TabIndex = 5;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(90, 145);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(250, 27);
            txtPrice.TabIndex = 4;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(90, 105);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(250, 27);
            txtModel.TabIndex = 3;
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(90, 65);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(250, 27);
            txtBrand.TabIndex = 2;
            // 
            // txtPName
            // 
            txtPName.Location = new Point(90, 25);
            txtPName.Name = "txtPName";
            txtPName.Size = new Size(250, 27);
            txtPName.TabIndex = 1;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(365, 25);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(585, 520);
            dgvProducts.TabIndex = 0;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            // 
            // tabOrders
            // 
            tabOrders.Controls.Add(dgvOrders);
            tabOrders.Location = new Point(4, 29);
            tabOrders.Name = "tabOrders";
            tabOrders.Padding = new Padding(3);
            tabOrders.Size = new Size(972, 567);
            tabOrders.TabIndex = 1;
            tabOrders.Text = "Orders";
            tabOrders.UseVisualStyleBackColor = true;
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Dock = DockStyle.Fill;
            dgvOrders.Location = new Point(3, 3);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.Size = new Size(966, 561);
            dgvOrders.TabIndex = 0;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 600);
            Controls.Add(tabControlAdmin);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Dashboard";
            tabControlAdmin.ResumeLayout(false);
            tabProducts.ResumeLayout(false);
            tabProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            tabOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAdmin;
        private System.Windows.Forms.TabPage tabProducts;
        private System.Windows.Forms.TabPage tabOrders;
        
        // Product Page Controls
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.TextBox txtSpecs;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        
        private System.Windows.Forms.Label lblSpecs;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblPName;

        // Order Page Controls
        private System.Windows.Forms.DataGridView dgvOrders;
    }
}