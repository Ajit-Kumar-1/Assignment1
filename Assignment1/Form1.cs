using System;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        // A counter to keep track of the total amount charged so far
        double totalTransactionAmount = 0;

        // A counter to keep track of the total number of tickets sold so far
        int totalTicketsCount = 0;

        // A counter to keep track of the toal number of transactions so far
        int totalTransactionsCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // A visual change that couldn't be specified in the Design, hence implemented programmatically
            buttonContainer.BorderStyle = BorderStyle.FixedSingle;
        }
        
        // Method invoked on pressing the "Enter" button on the Home screen
        private void enterButton_Click(object sender, EventArgs e)
        {
            // Transitioning between screens(panels) shown
            homePanel.Hide();
            mainPanel.Show();

            //Drawing focus by default to the cashier name entry field
            cashierNameInput.Focus();

            // Setting the window title
            Text = "Purchase Tickets";
        }

        // Method invoked on pressing the "Exit" button
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Method invoked on pressing the "Clear" button
        private void clearButton_Click(object sender, EventArgs e)
        {
            // Deleting all the controls in the form
            while (Controls.Count > 0)
            {
                Controls[0].Dispose();
            }
            // Restoring the initial state of the form
            InitializeComponent();
        }

        // Method invoked on pressing the "Calculate" button
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Preventing button function when the application is not supposed to calculate
            if (calculateButton.Text == "")
                return;

            // Initializing variables to keep count of each type of ticket
            var adultCount = 0;
            var studentCount = 0;
            var childCount = 0;

            // Handling exception in data entry for number of adult tickets
            try
            {
                adultCount = int.Parse(adultCountInput.Text);
            }   
            catch
            {
                MessageBox.Show("Please enter numerical data for number of adult tickets", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Handling exception in data entry for number of student tickets
            try
            {
                studentCount = int.Parse(studentCountInput.Text);
            }
            catch
            {
                MessageBox.Show("Please enter numerical data for number of student tickets", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Handling exception in data entry for number of child tickets
            try
            {
                childCount = int.Parse(childCountInput.Text);
            }
            catch
            {
                MessageBox.Show("Please enter numerical data for number of children tickets", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Adding up the total number of tickets to be sold in this transaction
            var totalTickets = (adultCount + studentCount + childCount);

            // Preventing transaction in the event that net tickets sold remain zero
            if(totalTickets == 0)
            {
                MessageBox.Show("Please select some tickets", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Setting the window title
            Text = "Transaction Summary";

            // 
            informationDisplay.Show();

            // Displaying
            totalTicketsSoldDisplay.Text = totalTickets.ToString();

            // Displaying amount charged in this transaction
            var totalAmount = adultCount * 7.99 + studentCount * 4.99 + childCount * 2.99;
            totalReceiptsDisplay.Text = totalAmount.ToString("C");

            // Displaying cashier name for the transaction
            cashierNameDisplay.Text = cashierNameInput.Text;

            // Functionally enabling the "Summary" button
            summaryButton.Text = "&Summary";

            // Functionally disabling the "Calculate" button
            calculateButton.Text = "";

            // Disabling the input section
            ticketsCountSection.Enabled = false;
            cashierNameLabel.Enabled = false;
            cashierNameInput.Enabled = false;

            // Ensuring that the 4th row of the Information Display table are hidden
            avgTransValueLabel.Hide();
            avgTransValueDisplay.Hide();

            // Updating the counter variable for tickets sold
            totalTicketsCount += totalTickets;

            // Updating the counter variable for transactions
            totalTransactionsCount += 1;

            // Updating the counter for total amount in transactions
            totalTransactionAmount += totalAmount;
        }

        // Method invoked on pressing the "Summary" button
        private void summaryButton_Click(object sender, EventArgs e)
        {
            // Preventing display of Summary information when functionally disabled
            if (summaryButton.Text == "")
                return;

            // Hiding the input section
            ticketsCountSection.Hide();
            cashierNameLabel.Hide();
            cashierNameInput.Hide();

            // Setting the window title
            Text = "All Transactions Summary";

            // Displaying the otherwise hidden 4th column of the Information Display table
            avgTransValueLabel.Show();
            avgTransValueDisplay.Show();

            // Displaying the Summary information from data stored in counter variables
            cashierNameLabel.Text = "Total Cashiers";
            cashierNameDisplay.Text = totalTransactionsCount.ToString();
            totalTicketsSoldDisplay.Text = totalTicketsCount.ToString();
            totalReceiptsDisplay.Text = totalTransactionAmount.ToString("C");
            avgTransValueDisplay.Text = (totalTransactionAmount / totalTicketsCount).ToString("C");
        }

        // Configuring tooltip display on hovering over the "Exit" button
        private void exitButton_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(exitButton, "Press to exit application");
        }

        // Configuring tooltip display on hovering over the "Clear" button
        private void clearButton_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(clearButton, "Press to go back to the previous screen");
        }

        // Configuring tooltip display on hovering over the "Calculate" button
        private void calculateButton_MouseHover(object sender, EventArgs e)
        {
            if(calculateButton.Text.Length > 0)
                toolTip.SetToolTip(calculateButton, "Press to calculate the price of the tickets");
        }

        // Configuring tooltip display on hovering over the "Summary" button
        private void summaryButton_MouseHover(object sender, EventArgs e)
        {
            if (summaryButton.Text.Length > 0)
                toolTip.SetToolTip(summaryButton, "Press to show a summary of all transactions so far");
        }
    }
}
