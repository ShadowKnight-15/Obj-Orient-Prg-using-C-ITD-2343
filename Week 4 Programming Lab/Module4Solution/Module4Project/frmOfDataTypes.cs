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
Class: ITD 2343 - Obj-Orient Prg Using C#
Due Date: 10/4/25
 */

namespace Module4Project
{
    public partial class frmOfDataTypes : Form
    {
        public frmOfDataTypes()
        {
            InitializeComponent();
        }

        //Clear and Exit buttons
        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "";
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Integer Buttons

        private void btnByte_Click(object sender, EventArgs e)
        {
            byte leftOperand = 2, rightOperand = 3;
            byte result = (byte)(leftOperand + rightOperand);

            lblDisplay.Text = String.Format("{0} + {1} = {2}", leftOperand, rightOperand, result);
        }
        private void btnShort_Click(object sender, EventArgs e)
        {
            short leftOperand = 10, rightOperand = 4;
            short result = (short)(leftOperand - rightOperand);

            lblDisplay.Text = String.Format("{0} - {1} = {2}", leftOperand, rightOperand, result);
        }
        private void btnInt_Click(object sender, EventArgs e)
        {
            int leftOperand = 7, rightOperand = 2;
            int result = leftOperand / rightOperand;

            lblDisplay.Text = String.Format("{0} / {1} = {2}", leftOperand, rightOperand, result);
        }
        private void btnLong_Click(object sender, EventArgs e)
        {
            long leftOperand = 25, rightOperand = 4;
            long result = leftOperand % rightOperand;

            lblDisplay.Text = String.Format("{0} % {1} = {2}", leftOperand, rightOperand, result);
        }

        //Decimal Buttons

        private void btnFloat_Click(object sender, EventArgs e)
        {
            float leftOperand = 7.1234567f, rightOperand = 2.0f;
            float result = leftOperand % rightOperand;

            lblDisplay.Text = String.Format("{0} % {1} = {2:F7}", leftOperand, rightOperand, result);
        }
        private void btnDouble_Click(object sender, EventArgs e)
        {
            double leftOperand = 22.0, rightOperand = 7.0;
            double result = leftOperand / rightOperand;

            lblDisplay.Text = String.Format("{0} / {1} = {2:F15}", leftOperand, rightOperand, result);
        }
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            decimal leftOperand = 3.1415926535897932384626433832m;
            decimal rightOperand = 2.5m;
            decimal result = leftOperand * rightOperand;

            lblDisplay.Text = String.Format("{0} * {1} = {2:F28}", leftOperand, rightOperand, result);
        }

        //Math Operations

        private void btnPow_Click(object sender, EventArgs e)
        {
            double baseNum = 2.0, exponent = 3.0;
            double result = Math.Pow(baseNum, exponent);

            lblDisplay.Text = String.Format("{0} raised to {1} = {2}", baseNum, exponent, result);
        }
        private void btnRound_Click(object sender, EventArgs e)
        {
            double number = 3.14159;
            int decimals = 2; // must be int
            double result = Math.Round(number, decimals);

            lblDisplay.Text = String.Format("Rounding {0} to {1} decimals = {2}", number, decimals, result);
        }
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double number = 16.0;
            double result = Math.Sqrt(number);

            lblDisplay.Text = String.Format("The square root of {0} is {1}", number, result);
        }
    }
}
