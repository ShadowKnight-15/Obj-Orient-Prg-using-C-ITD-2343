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
Due Date: 10/31/25
 */

namespace Lab_Portion___Section_2_Exam
{
    public partial class OperationsEricChristensen : Form
    {
        public OperationsEricChristensen()
        {
            InitializeComponent();
        }
        public enum Operation { None, Modulus, Factorial, Fibonacci }

        private Operation _currentShow = Operation.None;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Title bar 
            this.Text = "Operations Eric Christensen";
            this.StartPosition = FormStartPosition.CenterScreen;

            // Esc = Exit
            this.CancelButton = btnExit;

            
            txtOperand1.Font = new Font("Courier New", 14f, FontStyle.Regular);
            txtOperand2.Font = new Font("Courier New", 14f, FontStyle.Regular);
            txtOperand1.BackColor = Color.WhiteSmoke;
            txtOperand2.BackColor = Color.WhiteSmoke;
            txtOperand1.TabStop = false;
            txtOperand2.TabStop = false;

           
            lblOperand1.Font = new Font("Courier New", 14f);
            lblOperand2.Font = new Font("Courier New", 14f);
            lblOperand1.TabStop = false;
            lblOperand2.TabStop = false;

            
            lblMessage.Font = new Font("Times New Roman", 16f, FontStyle.Bold);
            lblMessage.BackColor = Color.PowderBlue;
            lblMessage.ForeColor = Color.Black;
            lblMessage.TabStop = false;
            lblMessage.Text = "";

            // DO buttons disabled until a SHOW is clicked
            EnableDoButtons(false, false, false);

            // SHOW buttons always enabled; DO buttons & others get tab order after SHOWs
            btnShowMod.TabIndex = 0; btnDoMod.TabIndex = 1;
            btnShowFact.TabIndex = 2; btnDoFact.TabIndex = 3;
            btnShowFib.TabIndex = 4; btnDoFib.TabIndex = 5;
            btnClear.TabIndex = 6; btnExit.TabIndex = 7;

            // Hook events (ok if also wired in Designer)
            btnShowMod.Click += (s, ev) => SelectOperation(Operation.Modulus);
            btnShowFact.Click += (s, ev) => SelectOperation(Operation.Factorial);
            btnShowFib.Click += (s, ev) => SelectOperation(Operation.Fibonacci);

            btnDoMod.Click += (s, ev) => DoModulus();
            btnDoFact.Click += (s, ev) => DoFactorial();
            btnDoFib.Click += (s, ev) => DoFibonacci();

            btnClear.Click += (s, ev) => lblMessage.Text = "";     // Clear only clears message area
            btnExit.Click += (s, ev) => ExitWithThanks();

            // Start with no inputs visible until a SHOW is chosen
            ShowOnlyNeededInputs(Operation.None);
        }

        // ===== UI helpers =====
        private void SelectOperation(Operation op)
        {
            _currentShow = op;
            EnableDoButtons(op == Operation.Modulus, op == Operation.Factorial, op == Operation.Fibonacci);
            ShowOnlyNeededInputs(op);

            switch (op)
            {
                case Operation.Modulus:
                    lblMessage.Text = "Enter two non-negative integers: Dividend (Operand 1) and non-zero Divisor (Operand 2).";
                    break;
                case Operation.Factorial:
                    lblMessage.Text = "Enter a non-negative integer (0–15) for factorial in Operand 1. 0! and 1! = 1.";
                    break;
                case Operation.Fibonacci:
                    lblMessage.Text = "Enter a non-negative integer (0–45) for Fibonacci term in Operand 1. F(0)=0, F(1)=1.";
                    break;
                default:
                    lblMessage.Text = "";
                    break;
            }

        }

        private void EnableDoButtons(bool mod, bool fact, bool fib)
        {
            btnDoMod.Enabled = mod;
            btnDoFact.Enabled = fact;
            btnDoFib.Enabled = fib;
        }

        private void ShowOnlyNeededInputs(Operation op)
        {
            bool two = op == Operation.Modulus;
            bool one = op == Operation.Factorial || op == Operation.Fibonacci;

            lblOperand1.Visible = one || two;
            txtOperand1.Visible = one || two;

            lblOperand2.Visible = two;
            txtOperand2.Visible = two;

            txtOperand1.Text = "";
            txtOperand2.Text = "";
        }

        private void ExitWithThanks()
        {
            MessageBox.Show("Thanks for using the Operations app!", "Goodbye",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        // ===== Validation =====
        private (bool ok, List<string> errors, int a, int b) ReadTwoOperandsForModulus()
        {
            var errs = new List<string>();
            int a = 0, b = 0;

            if (string.IsNullOrWhiteSpace(txtOperand1.Text))
                errs.Add("Operand 1 (Dividend) is required.");
            if (string.IsNullOrWhiteSpace(txtOperand2.Text))
                errs.Add("Operand 2 (Divisor) is required.");

            if (errs.Count == 0)
            {
                if (!int.TryParse(txtOperand1.Text.Trim(), out a))
                    errs.Add("Operand 1 must be an integer (decimals/letters not allowed).");
                if (!int.TryParse(txtOperand2.Text.Trim(), out b))
                    errs.Add("Operand 2 must be an integer (decimals/letters not allowed).");
            }

            if (errs.Count == 0)
            {
                if (a < 0) errs.Add("Dividend (Operand 1) must be non-negative.");
                if (b <= 0) errs.Add("Divisor (Operand 2) must be a positive integer (not zero).");
            }

            return (errs.Count == 0, errs, a, b);
        }

        private (bool ok, List<string> errors, int n) ReadSingleOperand(Operation op)
        {
            var errs = new List<string>();
            int n = 0;

            if (string.IsNullOrWhiteSpace(txtOperand1.Text))
                errs.Add("Operand 1 is required.");

            if (errs.Count == 0 && !int.TryParse(txtOperand1.Text.Trim(), out n))
                errs.Add("Operand 1 must be an integer (decimals/letters not allowed).");

            if (errs.Count == 0 && n < 0)
                errs.Add("Negative numbers are not allowed for this operation.");

            if (errs.Count == 0)
            {
                if (op == Operation.Factorial && n > 15)
                    errs.Add("Factorial input must be in range 0–15.");
                if (op == Operation.Fibonacci && n > 45)
                    errs.Add("Fibonacci input must be in range 0–45.");
            }

            return (errs.Count == 0, errs, n);
        }

        private void ShowErrors(List<string> errors)
        {
            if (errors.Count == 0) return;
            string block = "Errors:\n - " + string.Join("\n - ", errors);
            lblMessage.Text = (string.IsNullOrEmpty(lblMessage.Text) ? "" : lblMessage.Text + "\n") + block;
        }

        // ===== Algorithms (no '/' or '%') =====
        private (int quotient, int remainder) LongDivisionNoDivNoMod(int dividend, int divisor)
        {
            int q = 0;
            int r = dividend;
            while (r >= divisor)
            {
                r -= divisor; // subtraction only
                q += 1;       // addition only
            }
            return (q, r);
        }

        private long FactorialIterative(int n)
        {
            if (n == 0 || n == 1) return 1;
            long f = 1;
            for (int i = 2; i <= n; i++) f *= i;
            return f; // up to 15! fits in Int64
        }

        private long FibonacciIterative(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            long a = 0, b = 1, c = 1;
            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }

        // ===== DO handlers =====
        private void DoModulus()
        {
            if (_currentShow != Operation.Modulus)
            {
                ShowErrors(new List<string> { "Click 'Show Modulus' first to set up inputs." });
                return;
            }

            try
            {
                var (ok, errs, a, b) = ReadTwoOperandsForModulus();
                if (!ok) { ShowErrors(errs); return; }

                var (q, r) = LongDivisionNoDivNoMod(a, b);
                string msg = $"{a} divided by {b} is {q} with a remainder of {r}.";
                lblMessage.Text = (string.IsNullOrEmpty(lblMessage.Text) ? "" : lblMessage.Text + "\n") + msg;
            }
            catch (FormatException)
            {
                ShowErrors(new List<string> { "Format error: please enter integers only." });
            }
            catch
            {
                ShowErrors(new List<string> { "An unexpected error occurred. Please try again." });
            }
        }

        private void DoFactorial()
        {
            if (_currentShow != Operation.Factorial)
            {
                ShowErrors(new List<string> { "Click 'Show Factorial' first to set up inputs." });
                return;
            }

            try
            {
                var (ok, errs, n) = ReadSingleOperand(Operation.Factorial);
                if (!ok) { ShowErrors(errs); return; }

                long f = FactorialIterative(n);
                string msg = $"The answer to {n}! is {f}.";
                lblMessage.Text = (string.IsNullOrEmpty(lblMessage.Text) ? "" : lblMessage.Text + "\n") + msg;
            }
            catch (FormatException)
            {
                ShowErrors(new List<string> { "Format error: please enter integers only." });
            }
            catch
            {
                ShowErrors(new List<string> { "An unexpected error occurred. Please try again." });
            }
        }

        private void DoFibonacci()
        {
            if (_currentShow != Operation.Fibonacci)
            {
                ShowErrors(new List<string> { "Click 'Show Fibonacci' first to set up inputs." });
                return;
            }

            try
            {
                var (ok, errs, n) = ReadSingleOperand(Operation.Fibonacci);
                if (!ok) { ShowErrors(errs); return; }

                long fn = FibonacciIterative(n);
                // Build the requested explanatory message
                string msg;
                if (n == 0)
                {
                    msg = "Fibonacci(0) = 0";
                }
                else if (n == 1)
                {
                    msg = "Fibonacci(1) = 1";
                }
                else
                {
                    var fn1 = FibonacciIterative(n - 1);
                    var fn2 = FibonacciIterative(n - 2);
                    msg = $"Fibonacci({n}) = Fibonacci({n - 1}) + Fibonacci({n - 2}) = {fn1} + {fn2} = {fn}";
                }

                lblMessage.Text = (string.IsNullOrEmpty(lblMessage.Text) ? "" : lblMessage.Text + "\n") + msg;
            }
            catch (FormatException)
            {
                ShowErrors(new List<string> { "Format error: please enter integers only." });
            }
            catch
            {
                ShowErrors(new List<string> { "An unexpected error occurred. Please try again." });
            }
        }

    }
}
