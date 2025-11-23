using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module3Exercise2Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRight_Click(object sender, EventArgs e)  //adjusted to btnRight
        {
            lblOutput.Text = btnRight.Text;   //also adjusted to lblOutput
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            lblOutput.BackColor = btnRed.BackColor;   //also adjusted to lblOutput
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            lblOutput.BackColor = btnBlue.BackColor;  //also adjusted to lblOutput

        }

        private void btnLeft_Click(object sender, EventArgs e)   //adjusted all to btnLeft
        {
            lblOutput.Text = btnLeft.Text;  //also adjusted to lblOutput

        }

        private void btnExit_Click(object sender, EventArgs e)  //adjusted to btnexit
        {
            this.Close();
        }
    }
}
