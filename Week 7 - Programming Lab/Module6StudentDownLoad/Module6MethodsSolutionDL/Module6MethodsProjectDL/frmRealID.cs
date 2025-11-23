using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

/* 
 Name: Eric Christensen
Class: Obj-Orient Prg Using C# (ITD-2343-60500)
Due: 10/26/25
 */

namespace Module6MethodsProjectDL
{
    public partial class frmRealID : Form
    {
        // Public Contsants to use
        const byte ADD = 0;
        const byte SUBTRACT = 1;
        const byte MULTIPLY = 2;
        const byte DIVIDE = 3;
        const byte MODULUS = 4;

        public frmRealID()
        {
            InitializeComponent();
            ApplyFormSettings();
            WireButtonEvents();
        }

        //Put Your method here

        private void btnAdd_Click(object sender, EventArgs e) => HandleOperation(Op.Add);
        private void btnSub_Click(object sender, EventArgs e) => HandleOperation(Op.Sub);
        private void btnMul_Click(object sender, EventArgs e) => HandleOperation(Op.Mul);
        private void btnDiv_Click(object sender, EventArgs e) => HandleOperation(Op.Div);
        private void btnMod_Click(object sender, EventArgs e) => HandleOperation(Op.Mod);

        private static bool IsZero(string s) =>
            decimal.TryParse(s, out var v) && v == 0m;

        private static bool IsNegative(string s) =>
            decimal.TryParse(s, out var v) && v < 0m;
        private void ApplyFormSettings()
        {
            this.Text = "Valid ID Required";
            this.StartPosition = FormStartPosition.CenterScreen;

            // Tie Escape to Exit
            this.CancelButton = btnExit;
            btnExit.DialogResult = DialogResult.Cancel;
            lblResult.AutoSize = false;
            lblResult.Text = "";
            // Use a smaller font so all messages fit
            lblResult.Font = new Font(lblResult.Font.FontFamily, 9f);

        }
        private enum Op { Add, Sub, Mul, Div, Mod }

        private void WireButtonEvents()
        {
            
            btnAdd.Click += (s, e) => HandleOperation(Op.Add);
            btnSub.Click += (s, e) => HandleOperation(Op.Sub);
            btnMul.Click += (s, e) => HandleOperation(Op.Mul);
            btnDiv.Click += (s, e) => HandleOperation(Op.Div);
            btnMod.Click += (s, e) => HandleOperation(Op.Mod);

            btnClear.Click += (s, e) =>
            {
                txtLeft.Text = "";
                txtRight.Text = "";
                ShowMessage("", isError: false);
                txtLeft.Focus();
            };

            btnExit.Click += (s, e) => this.Close();
        }

        private void HandleOperation(Op op)
        {
            try
            {
                // Gather & report all validation issues at once
                if (!TryReadOperands(out decimal left, out decimal right, out var errors))
                {
                    
                    if ((op == Op.Div || op == Op.Mod) &&
                        decimal.TryParse(txtRight.Text, out var r0) && r0 == 0m)
                        errors.Add("Cannot divide by zero.");

                    if (op == Op.Mod &&
                        (decimal.TryParse(txtLeft.Text, out var l1) && l1 < 0m ||
                         decimal.TryParse(txtRight.Text, out var r1) && r1 < 0m))
                        errors.Add("Modulus cannot be performed with negative numbers.");

                    ShowAllErrors(errors);
                    return;
                }

                // numeric left/right, do per-op validation:
                var extra = new List<string>();
                if ((op == Op.Div || op == Op.Mod) && right == 0)
                    extra.Add("Cannot divide by zero.");
                if (op == Op.Mod && (left < 0 || right < 0))
                    extra.Add("Modulus cannot be performed with negative numbers.");
                if (extra.Count > 0)
                {
                    ShowAllErrors(extra);
                    return;
                }

                decimal result = PerformOperation(left, right, op);

                // Show success 
                string opText = GetOpText(op);
                ShowMessage($"{left} {opText} {right} = {result}", isError: false);
            }
            catch (Exception ex)
            {
                // safety net for unexpected exceptions
                ShowMessage($"Unexpected error: {ex.Message}", isError: true);
            }
        }
        private string GetOpText(Op op)
        {
            switch (op)
            {
                case Op.Add: return "+";
                case Op.Sub: return "-";
                case Op.Mul: return "×";
                case Op.Div: return "÷";
                case Op.Mod: return "mod";
                default: return "?";
            }
        }
        private decimal PerformOperation(decimal left, decimal right, Op op)
        {
            switch (op)
            {
                case Op.Add:
                    return left + right;
                case Op.Sub:
                    return left - right;
                case Op.Mul:
                    return left * right;
                case Op.Div:
                    return left / right; // right == 0 already blocked
                case Op.Mod:
                    return left % right; // negatives already blocked
                default:
                    throw new InvalidOperationException("Unknown operation.");
            }
        }

        private bool TryReadOperands(out decimal left, out decimal right, out List<string> errors)
        {
            errors = new List<string>();
            left = 0m; right = 0m;

            // Empty checks
            if (string.IsNullOrWhiteSpace(txtLeft.Text))
                errors.Add("Left operand is required.");
            if (string.IsNullOrWhiteSpace(txtRight.Text))
                errors.Add("Right operand is required.");

            // Numeric checks 
            bool leftOk = decimal.TryParse(txtLeft.Text, out left);
            bool rightOk = decimal.TryParse(txtRight.Text, out right);

            if (!string.IsNullOrWhiteSpace(txtLeft.Text) && !leftOk)
                errors.Add("Left operand must be a valid number.");
            if (!string.IsNullOrWhiteSpace(txtRight.Text) && !rightOk)
                errors.Add("Right operand must be a valid number.");

            return errors.Count == 0;
        }

        private void ShowAllErrors(List<string> messages)
        {
            var sb = new System.Text.StringBuilder();
            foreach (var m in messages)
                sb.AppendLine("• " + m);
            ShowMessage(sb.ToString().TrimEnd(), isError: true);
        }

        private void ShowMessage(string message, bool isError)
        {
            // Extra credit: color code messages
            lblResult.ForeColor = isError ? System.Drawing.Color.DarkRed : System.Drawing.Color.Black;
            lblResult.Text = (message ?? "").Replace("\n", "\r\n");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLeft.Text = "";
            txtRight.Text = "";
            lblResult.Text = "";
            txtLeft.Focus();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
