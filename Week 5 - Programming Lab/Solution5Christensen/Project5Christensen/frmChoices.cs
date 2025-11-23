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
Due date: 10/7/25
 */

namespace Project5Christensen
{
    public partial class frmChoices : Form
    {
        public frmChoices()
        {
            InitializeComponent();

            //Check and exit Button

            this.AcceptButton = btnCheck;

            this.CancelButton = btnExit;

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLeftNum.Text = "";
            txtRightNum.Text = "";
            txtNumChecked.Text = "";
            lblMsgToUser.Text = "Inputs cleared. Enter new values to continue.";
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            // Parse inputs
            int low = int.Parse(txtLeftNum.Text);
            int high = int.Parse(txtRightNum.Text);
            int check = int.Parse(txtNumChecked.Text);

            // Compare check value with the range
            if (check == low)
            {
                // Equal to low end
                lblMsgToUser.Text = "The number is equal to the Low End of the Range.";
            }
            else if (check == high)
            {
                // Equal to high end
                lblMsgToUser.Text = "The number is equal to the High End of the Range.";
            }
            else if (check < low)
            {
                // Below the low end
                lblMsgToUser.Text = "The number is less than the Low End of the Range.";
            }
            else if (check > high)
            {
                // Above the high end
                lblMsgToUser.Text = "The number is greater than the High End of the Range.";
            }
            else
            {
                // Within the range
                lblMsgToUser.Text = $"The number is in the range of {low} and {high}.";
            }

            // Clear the check textbox and return focus for new input
            txtNumChecked.Text = "";
            txtNumChecked.Focus();
        }
    }
}