using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MobileShop
{
    public partial class RegisterForm : Form
    {
        string conString = @"Data Source=.\SQLEXPRESS;Initial Catalog=MobileShop;Integrated Security=True";

        public RegisterForm()
        {
            InitializeComponent();
            btnRegister.Click += btnRegister_Click;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtEmail.Text == "" || txtPhone.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                string query = "INSERT INTO Users (Name, Email, Phone, Password, Role) VALUES (@name, @email, @phone, @pass, 'Customer')";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", txtPassword.Text);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }

            MessageBox.Show("Registered Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }
    }
}