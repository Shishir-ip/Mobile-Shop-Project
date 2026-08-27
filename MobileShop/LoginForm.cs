using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MobileShop
{
    public partial class LoginForm : Form
    {
        string conString = @"Data Source=.\SQLEXPRESS;Initial Catalog=MobileShop;Integrated Security=True";

        public LoginForm()
        {
            InitializeComponent();
            btnLogin.Click += btnLogin_Click;
            lnkRegister.LinkClicked += lnkRegister_LinkClicked;
            lnkForgot.LinkClicked += lnkForgot_LinkClicked;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                string query = "SELECT * FROM Users WHERE Email = @email AND Password = @pass";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", txtPassword.Text);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Session.UserId = Convert.ToInt32(reader["Id"]);
                            Session.UserName = reader["Name"].ToString();
                            Session.Role = reader["Role"].ToString();
                            MessageBox.Show("Successfully Logged in!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            con.Close();
                            this.Close();

                            if (Session.Role == "Admin")
                            {
                                AdminForm admin = new AdminForm();
                                admin.ShowDialog();
                            }
                            return;
                        }
                    }
                }
                con.Close();
            }
            MessageBox.Show("Username or Password not found or Wrong username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm reg = new RegisterForm();
            reg.ShowDialog();
        }

        private void lnkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPasswordForm fp = new ForgotPasswordForm();
            fp.ShowDialog();
        }
    }
}