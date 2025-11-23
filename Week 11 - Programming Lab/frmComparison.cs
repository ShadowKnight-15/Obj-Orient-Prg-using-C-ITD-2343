using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* 
 Name: Eric Christensen
Class: ITD 2343 - Object Oriented Programming with C#
Due date: 11/18/25
 */

namespace Project5Christensen
{
    public partial class frmComparison : Form
    {
        public frmComparison()
        {
            InitializeComponent();

            //Check and exit Button

            this.AcceptButton = btnCheck;

            this.CancelButton = btnExit;

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "Are You sure you want to exit?",
                "Exit Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLeftNum.Text = "";
            txtRightNum.Text = "";
            txtNumChecked.Text = "";
            lblMsgToUser.Text = string.Empty;
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            List<string> errors = new List<string>();

            // --- Empty checks ---
            if (string.IsNullOrWhiteSpace(txtLeftNum.Text))
            {
                errors.Add("Left value is required.");
            }

            if (string.IsNullOrWhiteSpace(txtRightNum.Text))
            {
                errors.Add("Right value is required.");
            }

            if (string.IsNullOrWhiteSpace(txtNumChecked.Text))
            {
                errors.Add("Value to be checked is required.");
            }

            double low = 0;
            double high = 0;
            double check = 0;

            // --- Numeric checks (only if not empty) ---
            if (!string.IsNullOrWhiteSpace(txtLeftNum.Text))
            {
                if (!double.TryParse(txtLeftNum.Text, out low))
                {
                    errors.Add("Left value must be a valid numeric value.");
                }
            }

            if (!string.IsNullOrWhiteSpace(txtRightNum.Text))
            {
                if (!double.TryParse(txtRightNum.Text, out high))
                {
                    errors.Add("Right value must be a valid numeric value.");
                }
            }

            if (!string.IsNullOrWhiteSpace(txtNumChecked.Text))
            {
                if (!double.TryParse(txtNumChecked.Text, out check))
                {
                    errors.Add("Value to be checked must be a valid numeric value.");
                }
            }

            // --- Bounds check (only if both numeric are good) ---
            if (errors.Count == 0)
            {
                if (low >= high)
                {
                    errors.Add("The lower bound must be less than the upper bound.");
                }
            }

            // --- If any errors, show ALL of them and stop ---
            if (errors.Count > 0)
            {
                string allErrors = string.Join(Environment.NewLine, errors);
                MessageBox.Show(allErrors, "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                lblMsgToUser.Text = string.Empty;
                return;
            }

            ComparisonClass comparer = new ComparisonClass
            {
                LeftValue = low,
                RightValue = high,
                CheckValue = check
            };
            string resultMessage = comparer.GetResultMessage();

            lblMsgToUser.Text = resultMessage;

            txtNumChecked.Text = string.Empty;
            txtNumChecked.Focus();
        }
    }
}