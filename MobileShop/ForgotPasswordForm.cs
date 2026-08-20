using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MobileShop
{
    public partial class ForgotPasswordForm : Form
    {
        string conString = @"Data Source=.\SQLEXPRESS;Initial Catalog=MobileShop;Integrated Security=True";
        string verifiedEmail = "";

        public ForgotPasswordForm()
        {
            InitializeComponent();
            btnVerifyEmail.Click += btnVerifyEmail_Click;
            btnVerifyPhone.Click += btnVerifyPhone_Click;
            btnChangePass.Click += btnChangePass_Click;
        }

        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {
        }

        private void btnVerifyEmail_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string query = "SELECT * FROM Users WHERE Email = '" + txtEmail.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                verifiedEmail = txtEmail.Text;
                MessageBox.Show("Email found! Now enter your phone number.");
                txtPhone.Enabled = true;
                btnVerifyPhone.Enabled = true;
            }
            else
            {
                MessageBox.Show("Email not found!");
            }
            con.Close();
        }

        private void btnVerifyPhone_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string query = "SELECT * FROM Users WHERE Email = '" + verifiedEmail + "' AND Phone = '" + txtPhone.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Phone verified! Enter new password.");
                txtNewPass.Enabled = true;
                btnChangePass.Enabled = true;
            }
            else
            {
                MessageBox.Show("Phone number does not match!");
            }
            con.Close();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string query = "UPDATE Users SET Password = '" + txtNewPass.Text + "' WHERE Email = '" + verifiedEmail + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }
    }
}