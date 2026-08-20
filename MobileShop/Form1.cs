using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace MobileShop
{
    public partial class Form1 : Form
    {
        string conString = @"Data Source=.\SQLEXPRESS;Initial Catalog=MobileShop;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();

            btnLogin.Click -= btnLogin_Click_1;
            btnLogin.Click += btnLogin_Click;

            btnCartBuyNow.Click += btnCartBuyNow_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbSort.Items.Add("Price: High to Low");
            cmbSort.Items.Add("Price: Low to High");
            cmbSort.SelectedIndexChanged += CmbSort_SelectedIndexChanged;
            txtSearch.TextChanged += TxtSearch_TextChanged;

            CheckLoginStatus();
            LoadPhones();
            LoadCart();
        }

        private void CheckLoginStatus()
        {
            if (Session.UserId > 0)
            {
                btnLogin.Text = "Hi, " + Session.UserName;
                lblWelcome.Text = "Welcome, " + Session.UserName;
            }
            else
            {
                btnLogin.Text = "Log In";
                lblWelcome.Text = "Welcome, Guest";
            }
        }

        private void LoadPhones()
        {
            flowPhones.Controls.Clear();

            using SqlConnection con = new SqlConnection(conString);
            con.Open();

            string query = "SELECT * FROM Products WHERE 1=1";
            if (!string.IsNullOrEmpty(txtSearch.Text))
                query += " AND Name LIKE '%" + txtSearch.Text + "%'";

            if (cmbSort.SelectedItem != null)
            {
                if (cmbSort.SelectedItem.ToString() == "Price: High to Low")
                    query += " ORDER BY Price DESC";
                else if (cmbSort.SelectedItem.ToString() == "Price: Low to High")
                    query += " ORDER BY Price ASC";
            }

            using SqlCommand cmd = new SqlCommand(query, con);
            using SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string productId = reader["Id"].ToString();
                int stock = Convert.ToInt32(reader["Stock"]);

                Button btnAdd = new Button();
                Button btnBuy = new Button();
                Button btnDetails = new Button();

                btnAdd.Click += (s, ev) => AddToCart(productId);
                btnBuy.Click += (s, ev) => BuyNow(productId);
                btnDetails.Click += (s, ev) => OpenDetails(productId);

                Panel card = new Panel();
                card.Width = 200;
                card.Height = 300;
                card.BorderStyle = BorderStyle.FixedSingle;
                card.Margin = new Padding(10);

                PictureBox pic = new PictureBox();
                pic.Width = 180;
                pic.Height = 150;
                pic.Location = new Point(10, 10);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                try { pic.Image = Image.FromFile(reader["ImagePath"].ToString()); }
                catch { pic.BackColor = Color.Gray; }
                pic.Click += (s, ev) => OpenDetails(productId);

                Label lblName = new Label();
                lblName.Text = reader["Name"].ToString();
                lblName.Location = new Point(10, 170);
                lblName.Width = 180;
                lblName.Font = new Font("Arial", 10, FontStyle.Bold);
                lblName.Click += (s, ev) => OpenDetails(productId);

                Label lblPrice = new Label();
                lblPrice.Text = stock == 0 ? "Out of Stock" : "৳" + reader["Price"].ToString();
                lblPrice.Location = new Point(10, 200);
                lblPrice.Width = 180;
                lblPrice.ForeColor = stock == 0 ? Color.Red : Color.Green;

                btnAdd.Text = "Add to Cart";
                btnAdd.Location = new Point(10, 230);
                btnAdd.Width = 85;
                btnAdd.Enabled = stock > 0;

                btnBuy.Text = "Buy Now";
                btnBuy.Location = new Point(105, 230);
                btnBuy.Width = 85;
                btnBuy.BackColor = Color.Orange;
                btnBuy.Enabled = stock > 0;

                btnDetails.Text = "Details";
                btnDetails.Location = new Point(10, 260);
                btnDetails.Width = 180;

                card.Controls.Add(pic);
                card.Controls.Add(lblName);
                card.Controls.Add(lblPrice);
                card.Controls.Add(btnAdd);
                card.Controls.Add(btnBuy);
                card.Controls.Add(btnDetails);

                flowPhones.Controls.Add(card);
            }
        }

        private void OpenDetails(string productId)
        {
            ProductDetailsForm details = new ProductDetailsForm(productId);
            details.ShowDialog();
            LoadPhones();
        }

        private void AddToCart(string productId)
        {
            if (Session.UserId == 0)
            {
                MessageBox.Show("You need to login first!", "Login Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoginForm login = new LoginForm();
                login.ShowDialog();
                CheckLoginStatus();
                return;
            }

            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string check = "SELECT * FROM Cart WHERE UserId = " + Session.UserId + " AND ProductId = " + productId;
            SqlCommand cmdCheck = new SqlCommand(check, con);
            SqlDataReader r = cmdCheck.ExecuteReader();

            if (r.Read())
            {
                r.Close();
                string update = "UPDATE Cart SET Quantity = Quantity + 1 WHERE UserId = " + Session.UserId + " AND ProductId = " + productId;
                SqlCommand cmdUp = new SqlCommand(update, con);
                cmdUp.ExecuteNonQuery();
            }
            else
            {
                r.Close();
                string insert = "INSERT INTO Cart (UserId, ProductId, Quantity) VALUES (" + Session.UserId + ", " + productId + ", 1)";
                SqlCommand cmdIn = new SqlCommand(insert, con);
                cmdIn.ExecuteNonQuery();
            }
            con.Close();
            MessageBox.Show("Added to Cart!");
            LoadCart();
        }

        private void BuyNow(string productId)
        {
            if (Session.UserId == 0)
            {
                MessageBox.Show("You need to login first!", "Login Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoginForm login = new LoginForm();
                login.ShowDialog();
                CheckLoginStatus();
                return;
            }

            AddToCart(productId);
            CheckoutForm checkout = new CheckoutForm();
            checkout.ShowDialog();
            LoadCart();
            LoadPhones();
        }

        private void LoadCart()
        {
            if (Session.UserId == 0)
            {
                dgvCart.DataSource = null;
                lblTotal.Text = "Total: ৳0";
                return;
            }

            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string query = @"SELECT p.Name, p.Price, c.Quantity, (p.Price * c.Quantity) as Total 
                             FROM Cart c JOIN Products p ON c.ProductId = p.Id 
                             WHERE c.UserId = " + Session.UserId;
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvCart.DataSource = dt;

            string totalQ = "SELECT SUM(p.Price * c.Quantity) FROM Cart c JOIN Products p ON c.ProductId = p.Id WHERE c.UserId = " + Session.UserId;
            SqlCommand cmd = new SqlCommand(totalQ, con);
            object result = cmd.ExecuteScalar();
            lblTotal.Text = "Total: ৳" + (result == DBNull.Value ? "0" : result.ToString());
            con.Close();
        }

        private void btnCartBuyNow_Click(object sender, EventArgs e)
        {
            if (Session.UserId == 0)
            {
                MessageBox.Show("Please login first!");
                return;
            }
            if (dgvCart.Rows.Count == 0)
            {
                MessageBox.Show("Cart is empty!");
                return;
            }
            CheckoutForm checkout = new CheckoutForm();
            checkout.ShowDialog();
            LoadCart();
            LoadPhones();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Session.UserId > 0)
            {
                // Logout option
                if (MessageBox.Show("Logout?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Session.UserId = 0;
                    Session.UserName = "";
                    Session.Role = "";
                    CheckLoginStatus();
                    LoadCart();
                }
            }
            else
            {
                LoginForm login = new LoginForm();
                login.ShowDialog();
                CheckLoginStatus();
                LoadCart();
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadPhones();
        }

        private void CmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPhones();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

        }

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCart_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    public static class Session
    {
        public static int UserId { get; set; }
        public static string UserName { get; set; } = "";
        public static string Role { get; set; } = "";
    }
}