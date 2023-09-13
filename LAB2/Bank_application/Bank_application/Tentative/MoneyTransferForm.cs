using System;
using System.Windows.Forms;

namespace BankApplication
{
    public partial class MoneyTransferForm : Form
    {
        private Customer customer;

        public MoneyTransferForm(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
        }

        private void TransferButton_Click(object sender, EventArgs e)
        {

            decimal transferAmount = decimal.Parse(TransferAmountTextBox.Text);

            if (transferAmount > 0 && transferAmount <= customer.Balance)
            {
                customer.Balance -= transferAmount;

                customer.LastAccessDate = DateTime.Now;

                MessageBox.Show($"Amount transferred: {transferAmount:C}\nUpdated balance: {customer.Balance:C}");
            }
            else
            {
                MessageBox.Show("Invalid transfer amount or insufficient balance.");
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AccountSummaryForm accountSummaryForm = new AccountSummaryForm(customer);
            accountSummaryForm.Show();
            this.Hide();
        }
    }
}
