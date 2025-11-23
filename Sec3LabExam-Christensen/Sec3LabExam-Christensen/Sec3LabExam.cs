using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sec3LabExam_Christensen
{
    public partial class Sec3LabExam: Form
    {
        private int plainToCipherCount = 0;

        private int cipherToPlainCount = 0;

        private const string PLAIN_ALPHABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string CIPHER_ALPHABET = "RSNEPHCATIMGLXWVFUJZKOBYDQ";

        public Sec3LabExam()
        {
            InitializeComponent();
            InitializeCustomSetting();
        }
        private void InitializeCustomSetting()
        {
            rdoPlainToCipher.Checked = true;
            this.AcceptButton = btnConvert;
            this.CancelButton = btnExit;
            
        }
        private string ConvertText(string input, bool plainToCipher)
        {
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }

            // Convert everything to uppercase to make it easier
            string upperInput = input.ToUpper();
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < upperInput.Length; i++)
            {
                char ch = upperInput[i];
                if (char.IsLetter(ch))
                {
                    string fromAlphabet = plainToCipher ? PLAIN_ALPHABET : CIPHER_ALPHABET;
                    string toAlphabet = plainToCipher ? CIPHER_ALPHABET : PLAIN_ALPHABET;
                    int index = fromAlphabet.IndexOf(ch);

                    if (index >= 0)
                    {
                        char convertedChar = toAlphabet[index];
                        result.Append(convertedChar);
                    }
                    else
                    {
                        result.Append(ch);
                    }
                }
                else
                {
                    result.Append(ch);
                }
            }
            return result.ToString();
        }
        private void ResetForm()
        {
            txtEntered.Clear();
            txtConverted.Clear();
            rdoPlainToCipher.Checked = true;
            rdoCipherToPlain.Checked = false;
            txtEntered.Focus();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            string message =
                "Conversion Summary: \n\n" +
                $"Plain Text -> Cipher Text:{plainToCipherCount}\n" +
                $"Cipher Text -> Plain Text:{cipherToPlainCount}\n\n" +
                "Thank you for using the decoder.";
            MessageBox.Show(message, "Session Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
        private void btnConvert_Click(object sender, EventArgs e) 
        {
            List<string> errors = new List<string>();

            string input = txtEntered.Text;

            if (string.IsNullOrWhiteSpace(input))
            {
                errors.Add("Please enter a message to convert.");
            }

            // Make sure one of the radio buttons is selected
            if (!rdoPlainToCipher.Checked && !rdoCipherToPlain.Checked)
            {
                errors.Add("Please select a conversion direction (Plain → Cipher or Cipher → Plain).");
            }

            // If there are any errors, show them in message box and stop
            if (errors.Count > 0)
            {
                string errorMessage = string.Join(Environment.NewLine, errors);
                MessageBox.Show(errorMessage, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // No errors: do the conversion
            bool plainToCipher = rdoPlainToCipher.Checked;
            string output = ConvertText(input, plainToCipher);

            txtConverted.Text = output;

            // Update counters
            if (plainToCipher)
            {
                plainToCipherCount++;
            }
            else
            {
                cipherToPlainCount++;
            }
        }
    }
}
