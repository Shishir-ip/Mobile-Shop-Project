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
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string q = "INSERT INTO Products (Name, Brand, Model, Price, Stock, ImagePath, Specifications) VALUES ('"
                + txtPName.Text + "', '" + txtBrand.Text + "', '" + txtModel.Text + "', " + txtPrice.Text + ", "
                + txtStock.Text + ", '" + txtImage.Text + "', '" + txtSpecs.Text + "')";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Product Added!");
            LoadProducts();
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvProducts.CurrentRow.Cells["Id"].Value);

            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string q = "UPDATE Products SET Name = '" + txtPName.Text + "', Brand = '" + txtBrand.Text
                + "', Model = '" + txtModel.Text + "', Price = " + txtPrice.Text + ", Stock = " + txtStock.Text
                + ", ImagePath = '" + txtImage.Text + "', Specifications = '" + txtSpecs.Text + "' WHERE Id = " + id;
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Product Updated!");
            LoadProducts();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvProducts.CurrentRow.Cells["Id"].Value);

            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string q = "DELETE FROM Products WHERE Id = " + id;
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            con.Close();
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