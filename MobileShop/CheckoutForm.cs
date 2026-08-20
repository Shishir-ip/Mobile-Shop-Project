using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MobileShop
{
    public partial class CheckoutForm : Form
    {
        string conString = @"Data Source=.\SQLEXPRESS;Initial Catalog=MobileShop;Integrated Security=True";
        decimal totalAmount = 0;

        public CheckoutForm()
        {
            InitializeComponent();

            btnPlaceOrder.Click += btnPlaceOrder_Click;
            btnCopy.Click += btnCopy_Click;
            rbOnline.CheckedChanged += rbOnline_CheckedChanged;
        }

        private void CheckoutForm_Load(object sender, EventArgs e)
        {
            // Pre-fill user info
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string q = "SELECT * FROM Users WHERE Id = " + Session.UserId;
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataReader r = cmd.ExecuteReader();
            if (r.Read())
            {
                txtName.Text = r["Name"].ToString();
                txtPhone.Text = r["Phone"].ToString();
            }
            r.Close();

            // Load cart summary
            string query = @"SELECT p.Name, c.Quantity, p.Price, (p.Price * c.Quantity) as Total 
                             FROM Cart c JOIN Products p ON c.ProductId = p.Id 
                             WHERE c.UserId = " + Session.UserId;
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvSummary.DataSource = dt;

            string totalQ = "SELECT SUM(p.Price * c.Quantity) FROM Cart c JOIN Products p ON c.ProductId = p.Id WHERE c.UserId = " + Session.UserId;
            SqlCommand cmdTotal = new SqlCommand(totalQ, con);
            object result = cmdTotal.ExecuteScalar();
            totalAmount = result == DBNull.Value ? 0 : Convert.ToDecimal(result);
            lblOrderTotal.Text = "Total Amount: ৳" + totalAmount.ToString();
            con.Close();

            rbCOD.Checked = true;
        }

        private void rbOnline_CheckedChanged(object sender, EventArgs e)
        {
            panelBkash.Visible = rbOnline.Checked;
            if (rbOnline.Checked)
            {
                lblBkashNumber.Text = "+8801676220935";
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("+8801676220935");
            MessageBox.Show("Number copied to clipboard!");
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPhone.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("Please fill all info first!");
                return;
            }

            string payment = rbCOD.Checked ? "COD" : "Online";
            string transId = "";

            if (rbOnline.Checked)
            {
                if (txtBkashNum.Text == "" || txtTransId.Text == "")
                {
                    MessageBox.Show("Please enter bKash number and Transaction ID!");
                    return;
                }
                transId = txtTransId.Text;
            }

            using SqlConnection con = new SqlConnection(conString);
            con.Open();

            string orderQ = "INSERT INTO Orders (UserId, CustomerName, Phone, Address, TotalAmount, PaymentMethod, TransactionId) OUTPUT INSERTED.Id VALUES ("
                + Session.UserId + ", '" + txtName.Text + "', '" + txtPhone.Text + "', '" + txtAddress.Text + "', "
                + totalAmount + ", '" + payment + "', '" + transId + "')";
            using SqlCommand cmdOrder = new SqlCommand(orderQ, con);
            int orderId = (int)cmdOrder.ExecuteScalar();

            DataTable cartTable = new DataTable();
            string cartQ = "SELECT ProductId, Quantity FROM Cart WHERE UserId = " + Session.UserId;
            using (SqlCommand cmdCart = new SqlCommand(cartQ, con))
            using (SqlDataReader reader = cmdCart.ExecuteReader())
            {
                cartTable.Load(reader);
            }

            foreach (DataRow row in cartTable.Rows)
            {
                int pid = Convert.ToInt32(row["ProductId"]);
                int qty = Convert.ToInt32(row["Quantity"]);

                string itemQ = "INSERT INTO OrderItems (OrderId, ProductId, Quantity, Price) VALUES ("
                    + orderId + ", " + pid + ", " + qty + ", (SELECT Price FROM Products WHERE Id = " + pid + "))";
                using SqlCommand cmdItem = new SqlCommand(itemQ, con);
                cmdItem.ExecuteNonQuery();

                string stockQ = "UPDATE Products SET Stock = Stock - " + qty + " WHERE Id = " + pid;
                using SqlCommand cmdStock = new SqlCommand(stockQ, con);
                cmdStock.ExecuteNonQuery();
            }

            string delQ = "DELETE FROM Cart WHERE UserId = " + Session.UserId;
            using SqlCommand cmdDel = new SqlCommand(delQ, con);
            cmdDel.ExecuteNonQuery();

            MessageBox.Show("Order placed successfully!");
            OrderSuccessForm success = new OrderSuccessForm();
            success.ShowDialog();
            Close();
        }
    }
}