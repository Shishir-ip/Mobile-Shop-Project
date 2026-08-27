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

        private Label lblOriginalPrice;
        private Label lblDiscountBadge;

        public ProductDetailsForm(string pid)
        {
            InitializeComponent();
            productId = pid;

            lblOriginalPrice = new Label
            {
                AutoSize = true,
                Visible = false,
                Font = new Font(lblPrice.Font, FontStyle.Strikeout),
                ForeColor = Color.Gray
            };
            lblOriginalPrice.Location = new Point(lblPrice.Left, lblPrice.Top + 35);
            Controls.Add(lblOriginalPrice);

            lblDiscountBadge = new Label
            {
                AutoSize = true,
                Visible = false,
                BackColor = Color.Red,
                ForeColor = Color.White,
                Padding = new Padding(4)
            };
            lblDiscountBadge.Location = new Point(lblPrice.Left + 130, lblPrice.Top);
            Controls.Add(lblDiscountBadge);
        }

        private void ProductDetailsForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                string query = "SELECT * FROM Products WHERE Id = @id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", productId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblName.Text = reader["Name"].ToString();
                            lblSpecs.Text = reader["Specifications"].ToString();

                            decimal originalPrice = Convert.ToDecimal(reader["Price"]);
                            decimal discount = reader["Discount"] == System.DBNull.Value ? 0 : Convert.ToDecimal(reader["Discount"]);
                            decimal finalPrice = originalPrice * (1 - discount / 100m);

                            // Use Unicode codepoint for Taka sign
                            lblPrice.Text = "\u09F3" + finalPrice.ToString("N2");

                            if (discount > 0)
                            {
                                lblOriginalPrice.Text = "\u09F3" + originalPrice.ToString("N2");
                                lblOriginalPrice.Visible = true;

                                lblDiscountBadge.Text = $"-{discount:0}% OFF";
                                lblDiscountBadge.Visible = true;
                            }
                            else
                            {
                                lblOriginalPrice.Visible = false;
                                lblDiscountBadge.Visible = false;
                            }

                            try
                            {
                                picPhone.Image = Image.FromFile(reader["ImagePath"].ToString());
                            }
                            catch { }
                        }
                    }
                }
                con.Close();
            }
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

            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                
                // If item already in cart, increase quantity; otherwise insert new row
                string checkQ = "SELECT Quantity FROM Cart WHERE UserId = @uid AND ProductId = @pid";
                using (SqlCommand cmdCheck = new SqlCommand(checkQ, con))
                {
                    cmdCheck.Parameters.AddWithValue("@uid", Session.UserId);
                    cmdCheck.Parameters.AddWithValue("@pid", productId);
                    object existing = cmdCheck.ExecuteScalar();
                    if (existing != null)
                    {
                        string updQ = "UPDATE Cart SET Quantity = Quantity + 1 WHERE UserId = @uid AND ProductId = @pid";
                        using (SqlCommand cmdUpd = new SqlCommand(updQ, con))
                        {
                            cmdUpd.Parameters.AddWithValue("@uid", Session.UserId);
                            cmdUpd.Parameters.AddWithValue("@pid", productId);
                            cmdUpd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Cart updated!");
                    }
                    else
                    {
                        string q = "INSERT INTO Cart (UserId, ProductId, Quantity) VALUES (@uid, @pid, 1)";
                        using (SqlCommand cmd = new SqlCommand(q, con))
                        {
                            cmd.Parameters.AddWithValue("@uid", Session.UserId);
                            cmd.Parameters.AddWithValue("@pid", productId);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Added to Cart!");
                    }
                }

                con.Close();
            }
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