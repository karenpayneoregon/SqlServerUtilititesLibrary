using System;
using System.Windows.Forms;
using DataLibrary;

namespace Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Check if SQL-Server is available.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void sqlServerAvailableButton_Click(object sender, EventArgs e)
        {
            var ops = new Utilities();
            var result = await ops.SqlServerIsAvailable();

            if (ops.IsSuccessFul)
            {
                MessageBox.Show($"SQL-Server available: {(result ? "Yes" : "No")}");
            }
            else
            {
                MessageBox.Show(ops.LastExceptionMessage);
            }
            
        }
        /// <summary>
        /// Check if a specific server is available by server name.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void isSpecificServerAvailableButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(serverNameTextBox.Text)) return;

            var ops = new Utilities();
            var result = await ops.SqlServerIsAvailable(serverNameTextBox.Text);

            if (ops.IsSuccessFul)
            {
                MessageBox.Show($"{serverNameTextBox.Text} is available {(result ? "Yes" : "No")}");
            }
            else
            {
                MessageBox.Show(ops.LastExceptionMessage);
            }
            
        }
    }
}
