using System;
using System.Windows.Forms;

namespace BankApplication
{
    public partial class AccountSummaryForm : Form
    {
        private Customer customer;

        public AccountSummaryForm(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;

            UserNameLabel.Text = customer.Name;
            BalanceLabel.Text = customer.Balance.ToString("C");
            LastAccessLabel.Text = customer.LastAccessDate.ToString("MM/dd/yyyy HH:mm:ss");

            foreach (var transaction in customer.GetLast5Transactions())
            {
                TransactionsListBox.Items.Add(transaction);
            }
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm(customer);
            changePasswordForm.ShowDialog();
        }

        private void MoneyTransferButton_Click(object sender, EventArgs e)
        {
            MoneyTransferForm moneyTransferForm = new MoneyTransferForm(customer);
            moneyTransferForm.Show();
            this.Hide();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}
