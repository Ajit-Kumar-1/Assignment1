using System;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        double totalTransactionAmount = 0;
        int totalTicketsCount = 0;
        int totalTransactionsCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            optionButtonContainer.BorderStyle = BorderStyle.FixedSingle;
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Show();
            cashierNameInput.Focus();
            this.Text = "Purchase Tickets";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            panel1.Show();
            this.Text = "Welcome to Mega Cinema";
            ticketsCountSection.Show();
            cashierNameLabel.Show();
            panel2.Hide();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (calculateButton.Text == "")
                return;
            var adultCount = 0;
            var studentCount = 0;
            var childCount = 0;
            try
            {
                adultCount = int.Parse(adultCountInput.Text);
            }   
            catch
            {
                return;
            }
            try
            {
                studentCount = int.Parse(studentCountInput.Text);
            }
            catch
            {
                return;
            }
            try
            {
                childCount = int.Parse(childCountInput.Text);
            }
            catch
            {
                return;
            }
            this.Text = "Transaction Summary";
            informationDisplay.Show();
            var totalTickets = (adultCount + studentCount + childCount);
            totalTicketsSoldDisplay.Text = totalTickets.ToString();
            var totalAmount = adultCount * 7.99 + studentCount * 4.99 + childCount * 2.99;
            totalReceiptsDisplay.Text = totalAmount.ToString("C");
            cashierNameDisplay.Text = cashierNameInput.Text;
            summaryButton.Text = "&Summary";
            calculateButton.Text = "";
            ticketsCountSection.Enabled = false;
            cashierNameLabel.Enabled = false;
            cashierNameInput.Enabled = false;
            avgTransValueLabel.Hide();
            avgTransValueDisplay.Hide();
            totalTicketsCount += totalTickets;
            totalTransactionsCount += 1;
            totalTransactionAmount += totalAmount;
        }

        private void summaryButton_Click(object sender, EventArgs e)
        {
            ticketsCountSection.Hide();
            cashierNameLabel.Hide();
            cashierNameInput.Hide();
            this.Text = "All Transactions Summary";
            avgTransValueLabel.Show();
            avgTransValueDisplay.Show();
            cashierNameLabel.Text = "Total Cashiers";
            cashierNameDisplay.Text = totalTransactionsCount.ToString();
            totalTicketsSoldDisplay.Text = totalTicketsCount.ToString();
            totalReceiptsDisplay.Text = totalTransactionAmount.ToString("C");
            avgTransValueDisplay.Text = (totalTransactionAmount / totalTicketsCount).ToString("C");
        }
    }
}
