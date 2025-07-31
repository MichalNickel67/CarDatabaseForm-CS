using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Cars1
{
    public partial class RegisterForm : Form
    {
        string password;
        private string connectionString = "AccountsDataSet.AccountsTable";
        List<AccountClass> AccountList { get; set; } = new List<AccountClass>();
        public RegisterForm()
        {
            InitializeComponent();
            PasswordCriteria.Text = "Password Must Meet These Requirements\nAt Least 10 characters\nAt Least 1 Lowercase Letter\nAt Least 1 Uppercase Letter\n At Least 1 Digit\n At Least 1 Special Character";
            PasswordBox.PasswordChar = '*';
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ADDTESTING_Click(object sender, EventArgs e)
        {
            outputListBox.Items.Clear();
            password = PasswordBox.Text;
            int numberOfCharacters = password.Length;
            outputListBox.Items.Add(PasswordBox.Text);
            outputListBox.Items.Add("The Number of Characters is " + numberOfCharacters);

            bool hasUpper = password.Any(char.IsUpper);
            bool hasLower = password.Any(char.IsLower);
            bool hasSpecial = password.Any(ch => !Char.IsLetterOrDigit(ch));
            bool hasDigit = password.Any(char.IsDigit);
            int strength = 0;

            if (numberOfCharacters > 10) strength += 10;
            if (hasUpper) strength += 5;
            if (hasLower) strength += 5;
            if(hasSpecial) strength += 5;
            if(hasDigit) strength += 5;

            outputListBox.Items.Add("Strength is " + strength);

            if (strength >= 30)
            {
                outputListBox.Items.Add("That is good enough");
            }
            else
            {
                if (numberOfCharacters < 10) outputListBox.Items.Add("Need More Characters");
                if (!hasUpper) outputListBox.Items.Add("Need A Uppercase Letter!");
                if (!hasLower) outputListBox.Items.Add("Need A Lowercase Letter!");
                if (!hasSpecial) outputListBox.Items.Add("Need A Special Character!");
                if (!hasDigit) outputListBox.Items.Add("Need A Number!");
            }
        }

        private void showhide_Click(object sender, EventArgs e)
        {
            password = PasswordBox.Text;
            if (PasswordBox.PasswordChar.Equals('\0'))
            {
                PasswordBox.PasswordChar = '*';
                PasswordBox.Text = password;
                showhide.Text = "show";
            }
            else
            {
                PasswordBox.PasswordChar = '\0';
                PasswordBox.Text = password;
                showhide.Text = "hide";
            }
        }

        private void UsernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string username = UsernameBox.Text;
            string password = PasswordBox.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill out all fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsPasswordValid(password))
            {
                MessageBox.Show("Password must contain at least 10 characters, including at least 1 uppercase letter, 1 lowercase letter, 1 digit, and 1 special character.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AccountClass ac = new AccountClass(username, password);
            AccountList.Add(ac);

            try
            {
                this.accountsTableTableAdapter.CreateNewAccount(username, password);
                this.accountsTableTableAdapter.Fill(this.accountsDataSet.AccountsTable);
                UsernameBox.Text = "";
                PasswordBox.Text = "";
                MessageBox.Show("You have been registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while registering: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsPasswordValid(string password)
        {
            if (password.Length < 10)
                return false;

            if (!password.Any(char.IsUpper) || !password.Any(char.IsLower) || !password.Any(char.IsDigit) || !password.Any(ch => !char.IsLetterOrDigit(ch)))
                return false;

            return true;
        }

        private void accountsTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.accountsTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.accountsDataSet);

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            this.accountsTableTableAdapter.Fill(this.accountsDataSet.AccountsTable);

        }

    }
}
