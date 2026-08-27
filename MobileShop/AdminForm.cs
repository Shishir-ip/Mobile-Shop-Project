using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MobileShop
{
    public partial class AdminForm : Form
    {
        string conString = @"Data Source=.\SQLEXPRESS;Initial Catalog=MobileShop;Integrated Security=True";

        public AdminForm()
        {
            InitializeComponent();
            Load += AdminForm_Load;
            btnBrowse.Click += btnBrowse_Click;
            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnClear.Click += btnClear_Click;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadOrders();
        }

        private void LoadProducts()
        {
            SqlConnection con = new SqlConnection(conString);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Products", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvProducts.DataSource = dt;
        }

        private void LoadOrders()
        {
            SqlConnection con = new SqlConnection(conString);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Orders", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvOrders.DataSource = dt;
        }

        private decimal ParseDiscount()
        {
            string d = txtDiscount.Text.Trim();
            if (string.IsNullOrWhiteSpace(d)) return 0;

            if (d.EndsWith("%"))
                d = d.Substring(0, d.Length - 1).Trim();

            return Convert.ToDecimal(d);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtImage.Text = ofd.FileName;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                string q = "INSERT INTO Products (Name, Brand, Model, Price, Discount, Stock, ImagePath, Specifications) VALUES (@name, @brand, @model, @price, @discount, @stock, @image, @specs)";
                using (SqlCommand cmd = new SqlCommand(q, con))
                {
                    cmd.Parameters.AddWithValue("@name", txtPName.Text.Trim());
                    cmd.Parameters.AddWithValue("@brand", txtBrand.Text.Trim());
                    cmd.Parameters.AddWithValue("@model", txtModel.Text.Trim());
                    cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(txtPrice.Text));
                    cmd.Parameters.AddWithValue("@discount", ParseDiscount());
                    cmd.Parameters.AddWithValue("@stock", Convert.ToInt32(txtStock.Text));
                    cmd.Parameters.AddWithValue("@image", txtImage.Text.Trim());
                    cmd.Parameters.AddWithValue("@specs", txtSpecs.Text.Trim());
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
            MessageBox.Show("Product Added!");
            LoadProducts();
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvProducts.CurrentRow.Cells["Id"].Value);

            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                string q = "UPDATE Products SET Name = @name, Brand = @brand, Model = @model, Price = @price, Discount = @discount, Stock = @stock, ImagePath = @image, Specifications = @specs WHERE Id = @id";
                using (SqlCommand cmd = new SqlCommand(q, con))
                {
                    cmd.Parameters.AddWithValue("@name", txtPName.Text.Trim());
                    cmd.Parameters.AddWithValue("@brand", txtBrand.Text.Trim());
                    cmd.Parameters.AddWithValue("@model", txtModel.Text.Trim());
                    cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(txtPrice.Text));
                    cmd.Parameters.AddWithValue("@discount", ParseDiscount());
                    cmd.Parameters.AddWithValue("@stock", Convert.ToInt32(txtStock.Text));
                    cmd.Parameters.AddWithValue("@image", txtImage.Text.Trim());
                    cmd.Parameters.AddWithValue("@specs", txtSpecs.Text.Trim());
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
            MessageBox.Show("Product Updated!");
            LoadProducts();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvProducts.CurrentRow.Cells["Id"].Value);

            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                string q = "DELETE FROM Products WHERE Id = @id";
                using (SqlCommand cmd = new SqlCommand(q, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
            MessageBox.Show("Product Deleted!");
            LoadProducts();
            ClearFields();
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            txtPName.Text = dgvProducts.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            txtBrand.Text = dgvProducts.Rows[e.RowIndex].Cells["Brand"].Value.ToString();
            txtModel.Text = dgvProducts.Rows[e.RowIndex].Cells["Model"].Value.ToString();
            txtPrice.Text = dgvProducts.Rows[e.RowIndex].Cells["Price"].Value.ToString();
            txtDiscount.Text = dgvProducts.Rows[e.RowIndex].Cells["Discount"].Value?.ToString() ?? "";
            txtStock.Text = dgvProducts.Rows[e.RowIndex].Cells["Stock"].Value.ToString();
            txtImage.Text = dgvProducts.Rows[e.RowIndex].Cells["ImagePath"].Value.ToString();
            txtSpecs.Text = dgvProducts.Rows[e.RowIndex].Cells["Specifications"].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtPName.Clear();
            txtBrand.Clear();
            txtModel.Clear();
            txtPrice.Clear();
            txtDiscount.Clear();
            txtStock.Clear();
            txtImage.Clear();
            txtSpecs.Clear();
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvProducts_CellClick(sender, e);
        }
    }
}