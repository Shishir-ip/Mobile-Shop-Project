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

    string cartQ = "SELECT ProductId, Quantity FROM Cart WHERE UserId = " + Session.UserId;
    using SqlCommand cmdCart = new SqlCommand(cartQ, con);
    using SqlDataReader reader = cmdCart.ExecuteReader();

    DataTable cartTable = new DataTable();
    cartTable.Load(reader);

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
    this.Close();
}