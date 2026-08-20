using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace MobileShop
{
    public partial class ProductDetailsForm : Form
    {
        string conString = @"Data Source=.\SQLEXPRESS;Initial Catalog=MobileShop;Integrated Security=True";
        string productId;

        public ProductDetailsForm(string pid)
        {
            InitializeComponent();
            productId = pid;
        }

        private void ProductDetailsForm_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string query = "SELECT * FROM Products WHERE Id = " + productId;
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                lblName.Text = reader["Name"].ToString();
                lblPrice.Text = "৳" + reader["Price"].ToString();
                lblSpecs.Text = reader["Specifications"].ToString();
                try
                {
                    picPhone.Image = Image.FromFile(reader["ImagePath"].ToString());
                }
                catch { }
            }
            con.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Session.UserId == 0)
            {
                MessageBox.Show("Please login first!");
                LoginForm login = new LoginForm();
                login.ShowDialog();
                return;
            }
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string q = "INSERT INTO Cart (UserId, ProductId, Quantity) VALUES (" + Session.UserId + ", " + productId + ", 1)";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Added to Cart!");
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (Session.UserId == 0)
            {
                MessageBox.Show("Please login first!");
                LoginForm login = new LoginForm();
                login.ShowDialog();
                return;
            }
            btnAdd_Click(sender, e);
            CheckoutForm co = new CheckoutForm();
            co.ShowDialog();
            this.Close();
        }
    }
}