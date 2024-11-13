// File: MainForm.cs

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class MainForm : Form
    {
        private List<Expense> expenses = new List<Expense>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void AddExpenseButton_Click(object sender, EventArgs e)
        {
            string description = descriptionTextBox.Text;
            if (decimal.TryParse(amountTextBox.Text, out decimal amount))
            {
                expenses.Add(new Expense { Description = description, Amount = amount });
                RefreshExpenseList();
                MessageBox.Show("Expense added!");
            }
            else
            {
                MessageBox.Show("Invalid amount.");
            }
        }

        private void RefreshExpenseList()
        {
            expensesListBox.Items.Clear();
            foreach (var expense in expenses)
            {
                expensesListBox.Items.Add($"{expense.Description} - ${expense.Amount:F2}");
            }
        }
    }

    public class Expense
    {
        public string Description { get; set; }
        public decimal Amount { get; set; }
    }
}
