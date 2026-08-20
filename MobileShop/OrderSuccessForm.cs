using System;
using System.Windows.Forms;

namespace MobileShop
{
    public partial class OrderSuccessForm : Form
    {
        public OrderSuccessForm()
        {
            InitializeComponent();
            btnHome.Click += btnHome_Click;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OrderSuccessForm_Load(object sender, EventArgs e)
        {
        }
    }
}