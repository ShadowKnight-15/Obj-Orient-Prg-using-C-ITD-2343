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
Class: Obj-Orient Prg Using C# ITD-2343
Due Date: 11/11/25
 
 */
namespace Wk_10___Radio_Buttons_Project
{
    public partial class frmRadioStar : Form
    {
        private const string APP_TITLE = "Radio Buttons in Action";

        private enum MathOperation
        {
            Add,
            Subtract,
            Multiply,
            Divide,
            Modulus
        }
        public frmRadioStar()
        {
            InitializeComponent();
            InitializeCustomSettings();
        }
        private void InitializeCustomSettings()
        {
            // Form title (in case not already set in Designer)
            this.Text = APP_TITLE;

            // Tie Enter to Calculate, Esc to Exit
            this.AcceptButton = btnCalculate;
            this.CancelButton = btnExit;

            // Default states
            ResetForm();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lblMessage.Text = ""; // clear previous

            // Determine which operation is selected
            MathOperation op = GetSelectedOperation();

            // Get and validate operands
            if (!TryGetOperands(out int left, out int right, out List<string> errors))
            {
                // Input formatting / presence problems
                lblMessage.Text = string.Join(Environment.NewLine, errors);
                return;
            }

            // Additional validation based on operation
            ValidateOperationRules(op, left, right, errors);

            if (errors.Count > 0)
            {
                lblMessage.Text = string.Join(Environment.NewLine, errors);
                return;
            }

            // If we get here, we can safely calculate
            int result;

            switch (op)
            {
                case MathOperation.Add:
                    result = left + right;
                    break;

                case MathOperation.Subtract:
                    result = left - right;
                    break;

                case MathOperation.Multiply:
                    result = left * right;
                    break;

                case MathOperation.Divide:
                    // We already validated divide-by-zero
                    result = left / right;
                    break;

                case MathOperation.Modulus:
                    // We already validated zero and negative restrictions
                    result = left % right;
                    break;

                default:
                    // Should never happen
                    lblMessage.Text = "An unknown operation was selected.";
                    return;
            }

            // Display based on Verbose mode
            if (chkVerbose.Checked)
            {
                string symbol = GetOperationSymbol(op);
                lblMessage.Text = $"{left} {symbol} {right} = {result}";
            }
            else
            {
                lblMessage.Text = $"The Answer is {result}";
            }
        }
        private void ResetForm()
        {
            txtLeftOperand.Text = "";
            txtRightOperand.Text = "";
            lblMessage.Text = "";

            // Default operation: Addition
            rdoAdd.Checked = true;

            // Verbose ON by default
            chkVerbose.Checked = true;

            // Focus to left operand
            txtLeftOperand.Focus();
        }

        private MathOperation GetSelectedOperation()
        {
            if (rdoAdd.Checked) return MathOperation.Add;
            if (rdoSubtract.Checked) return MathOperation.Subtract;
            if (rdoMultiply.Checked) return MathOperation.Multiply;
            if (rdoDivide.Checked) return MathOperation.Divide;
            if (rdoModulus.Checked) return MathOperation.Modulus;

            // Fallback – should not happen if Add is default
            return MathOperation.Add;
        }

        private string GetOperationSymbol(MathOperation op)
        {
            switch (op)
            {
                case MathOperation.Add: return "+";
                case MathOperation.Subtract: return "-";
                case MathOperation.Multiply: return "*";
                case MathOperation.Divide: return "/";
                case MathOperation.Modulus: return "%";
                default: return "?";
            }
        }
        private bool TryGetOperands(out int left, out int right, out List<string> errors)
        {
            errors = new List<string>();
            left = 0;
            right = 0;

            string leftText = txtLeftOperand.Text.Trim();
            string rightText = txtRightOperand.Text.Trim();

            bool leftEmpty = string.IsNullOrEmpty(leftText);
            bool rightEmpty = string.IsNullOrEmpty(rightText);

            // Handle empty cases (can combine messages)
            if (leftEmpty && rightEmpty)
            {
                errors.Add("Both operand boxes are empty. Please enter a left and right integer value.");
                return false;
            }
            else if (leftEmpty)
            {
                errors.Add("The left operand is empty. Please enter an integer value.");
            }
            else if (!int.TryParse(leftText, out left))
            {
                errors.Add("The left operand is not a valid integer. Please enter integers only.");
            }

            if (rightEmpty)
            {
                errors.Add("The right operand is empty. Please enter an integer value.");
            }
            else if (!int.TryParse(rightText, out right))
            {
                errors.Add("The right operand is not a valid integer. Please enter integers only.");
            }
            return errors.Count == 0;
        }
        private void ValidateOperationRules(MathOperation op, int left, int right, List<string> errors)
        {
            // Divide or Mod by zero not allowed
            if ((op == MathOperation.Divide || op == MathOperation.Modulus) && right == 0)
            {
                errors.Add("You cannot divide or take modulus by zero. Please enter a non-zero right operand.");
            }

            // Modulus on negative numbers not allowed (either operand)
            if (op == MathOperation.Modulus && (left < 0 || right < 0))
            {
                errors.Add("Modulus operation is not allowed with negative numbers. Please use non-negative integers for both operands.");
            }
        }   

     }
}
