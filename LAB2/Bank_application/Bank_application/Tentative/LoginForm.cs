using System;
using System.Windows.Forms;

namespace BankApplication
{
    public partial class LoginForm : Form
    {
        private Customer customer;

        public LoginForm()
        {
            InitializeComponent();
            customer = new Customer("John Doe", "johndoe", "password123", 123456, 1000.0m, DateTime.Now);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string enteredID = UserIDTextBox.Text;
            string enteredPassword = PasswordTextBox.Text;

            if (enteredID == customer.ID && enteredPassword == customer.Password)
            {
                AccountSummaryForm accountSummaryForm = new AccountSummaryForm(customer);
                accountSummaryForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials. Please try again.");
            }
        }
    }
}
