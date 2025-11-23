using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 Name: Eric Christensen
Class: Obj-Orient Prg Using C# ITD-2343
Due Date: 11/7/25
 */

namespace Module_9_Christensen_Project
{
    public partial class frmCheckDigit : Form
    {
        private const int ACCOUNT_LENGTH = 8;
        public frmCheckDigit()
        {
            InitializeComponent();

            this.AcceptButton = btnProcess;
            this.CancelButton = btnExit;

            btnProcess.Click += btnProcess_Click;
            btnReset.Click += btnReset_Click;
            btnExit.Click += btnExit_Click;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            ProcessPayment();
        }
        private void ResetForm()
        {
            txtAccount.Text = "";
            txtConfirmAccount.Text = "";
            txtPayment.Text = "";
            txtMessage.Text = "";

            txtAccount.Focus();
        }
        private void ProcessPayment()
        {
            txtMessage.Text = ""; // clear previous messages

            string account = txtAccount.Text.Trim();
            string confirmAccount = txtConfirmAccount.Text.Trim();
            string paymentInput = txtPayment.Text.Trim();

            // Validate all inputs and either show errors or success message
            string errorMessages = ValidateInputs(account, confirmAccount, paymentInput, out decimal paymentAmount);

            if (!string.IsNullOrEmpty(errorMessages))
            {
                // Show all validation errors in message area
                txtMessage.Text = errorMessages;
                return;
            }

            // If we got here, everything is valid
            string formattedPayment = paymentAmount.ToString("C", CultureInfo.CurrentCulture);
            string dateText = DateTime.Now.ToString("MMMM d"); // e.g., July 10

            string successMessage =
                $"A payment of {formattedPayment} was applied to account {account} on {dateText}." +
                Environment.NewLine +
                "Thank you for your payment.";

            txtMessage.Text = successMessage;
        }
        private string ValidateInputs(string account, string confirmAccount, string paymentInput, out decimal paymentAmount)
        {
            paymentAmount = 0m;
            var messages = "";

            // 1. Empty checks
            if (string.IsNullOrEmpty(account))
                messages += "- Account Number is required." + Environment.NewLine;

            if (string.IsNullOrEmpty(confirmAccount))
                messages += "- Confirmation Account Number is required." + Environment.NewLine;

            if (string.IsNullOrEmpty(paymentInput))
                messages += "- Payment Amount is required." + Environment.NewLine;

            // Only continue deeper if something is present
            // 2. Account numeric and length
            if (!string.IsNullOrEmpty(account))
            {
                if (!IsAllDigits(account))
                {
                    messages += "- Account Number must contain digits only." + Environment.NewLine;
                }
                else if (account.Length != ACCOUNT_LENGTH)
                {
                    messages += $"- Account Number must be exactly {ACCOUNT_LENGTH} digits long." + Environment.NewLine;
                }
                else if (!IsValidCheckDigit(account))
                {
                    messages += "- Account Number failed the check-digit validation." + Environment.NewLine;
                }
            }

            // 3. Confirmation matches (only if both provided)
            if (!string.IsNullOrEmpty(account) && !string.IsNullOrEmpty(confirmAccount))
            {
                if (account != confirmAccount)
                {
                    messages += "- Account Number and Confirmation do not match." + Environment.NewLine;
                }
            }

            // 4. Confirm account numeric and length too
            if (!string.IsNullOrEmpty(confirmAccount))
            {
                if (!IsAllDigits(confirmAccount))
                {
                    messages += "- Confirmation Account Number must contain digits only." + Environment.NewLine;
                }
                else if (confirmAccount.Length != ACCOUNT_LENGTH)
                {
                    messages += $"- Confirmation Account Number must be exactly {ACCOUNT_LENGTH} digits long." + Environment.NewLine;
                }
            }

            // 5. Payment amount: allow $, commas, decimals
            if (!string.IsNullOrEmpty(paymentInput))
            {
                if (!TryParsePayment(paymentInput, out paymentAmount))
                {
                    messages += "- Payment Amount is not a valid currency value." + Environment.NewLine;
                }
                else if (paymentAmount <= 0)
                {
                    messages += "- Payment Amount must be greater than zero." + Environment.NewLine;
                }
            }

            if (string.IsNullOrEmpty(messages))
            {
                // Everything valid
                return "";
            }

            // Prepend header for clarity
            return "Please correct the following errors:" + Environment.NewLine + messages;
        }
        private bool IsAllDigits(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private bool IsValidCheckDigit(string account)
        {
            // Expecting exact ACCOUNT_LENGTH and all digits checked earlier.
            if (account.Length != ACCOUNT_LENGTH || !IsAllDigits(account))
                return false;

            int sum = 0;
            for (int i = 0; i < ACCOUNT_LENGTH - 1; i++)
            {
                sum += account[i] - '0';
            }

            int expectedCheckDigit = sum % 10;
            int actualCheckDigit = account[ACCOUNT_LENGTH - 1] - '0';

            return expectedCheckDigit == actualCheckDigit;
        }

        private bool TryParsePayment(string input, out decimal amount)
        {
            // Accept standard currency styles: $, commas, decimals, etc.
            return decimal.TryParse(
                input,
                NumberStyles.Currency,
                CultureInfo.CurrentCulture,
                out amount);
        }
    }
}
