namespace Sec3LabExam_Christensen
{
    partial class Sec3LabExam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtEntered = new System.Windows.Forms.TextBox();
            this.txtConverted = new System.Windows.Forms.TextBox();
            this.lblEnteredTxt = new System.Windows.Forms.Label();
            this.lblConvertedTxt = new System.Windows.Forms.Label();
            this.grpConvertType = new System.Windows.Forms.GroupBox();
            this.rdoCipherToPlain = new System.Windows.Forms.RadioButton();
            this.rdoPlainToCipher = new System.Windows.Forms.RadioButton();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpConvertType.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEntered
            // 
            this.txtEntered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntered.Location = new System.Drawing.Point(12, 56);
            this.txtEntered.Multiline = true;
            this.txtEntered.Name = "txtEntered";
            this.txtEntered.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEntered.Size = new System.Drawing.Size(429, 419);
            this.txtEntered.TabIndex = 0;
            // 
            // txtConverted
            // 
            this.txtConverted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConverted.Location = new System.Drawing.Point(689, 56);
            this.txtConverted.Multiline = true;
            this.txtConverted.Name = "txtConverted";
            this.txtConverted.ReadOnly = true;
            this.txtConverted.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConverted.Size = new System.Drawing.Size(429, 419);
            this.txtConverted.TabIndex = 1;
            // 
            // lblEnteredTxt
            // 
            this.lblEnteredTxt.AutoSize = true;
            this.lblEnteredTxt.BackColor = System.Drawing.Color.Salmon;
            this.lblEnteredTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnteredTxt.Location = new System.Drawing.Point(12, 33);
            this.lblEnteredTxt.Name = "lblEnteredTxt";
            this.lblEnteredTxt.Size = new System.Drawing.Size(149, 20);
            this.lblEnteredTxt.TabIndex = 2;
            this.lblEnteredTxt.Text = "Enter Text Here:";
            // 
            // lblConvertedTxt
            // 
            this.lblConvertedTxt.AutoSize = true;
            this.lblConvertedTxt.BackColor = System.Drawing.Color.Salmon;
            this.lblConvertedTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConvertedTxt.Location = new System.Drawing.Point(685, 33);
            this.lblConvertedTxt.Name = "lblConvertedTxt";
            this.lblConvertedTxt.Size = new System.Drawing.Size(142, 20);
            this.lblConvertedTxt.TabIndex = 3;
            this.lblConvertedTxt.Text = "Converted Text:";
            // 
            // grpConvertType
            // 
            this.grpConvertType.BackColor = System.Drawing.Color.MistyRose;
            this.grpConvertType.Controls.Add(this.rdoCipherToPlain);
            this.grpConvertType.Controls.Add(this.rdoPlainToCipher);
            this.grpConvertType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpConvertType.Location = new System.Drawing.Point(447, 75);
            this.grpConvertType.Name = "grpConvertType";
            this.grpConvertType.Size = new System.Drawing.Size(236, 99);
            this.grpConvertType.TabIndex = 4;
            this.grpConvertType.TabStop = false;
            this.grpConvertType.Text = "Select Conversion:";
            // 
            // rdoCipherToPlain
            // 
            this.rdoCipherToPlain.AutoSize = true;
            this.rdoCipherToPlain.Location = new System.Drawing.Point(6, 59);
            this.rdoCipherToPlain.Name = "rdoCipherToPlain";
            this.rdoCipherToPlain.Size = new System.Drawing.Size(187, 22);
            this.rdoCipherToPlain.TabIndex = 1;
            this.rdoCipherToPlain.TabStop = true;
            this.rdoCipherToPlain.Text = "Convert to Plain Text";
            this.rdoCipherToPlain.UseVisualStyleBackColor = true;
            // 
            // rdoPlainToCipher
            // 
            this.rdoPlainToCipher.AutoSize = true;
            this.rdoPlainToCipher.Location = new System.Drawing.Point(6, 31);
            this.rdoPlainToCipher.Name = "rdoPlainToCipher";
            this.rdoPlainToCipher.Size = new System.Drawing.Size(199, 22);
            this.rdoPlainToCipher.TabIndex = 0;
            this.rdoPlainToCipher.TabStop = true;
            this.rdoPlainToCipher.Text = "Convert to Cipher Text";
            this.rdoPlainToCipher.UseVisualStyleBackColor = true;
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.PaleGreen;
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(482, 204);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(157, 59);
            this.btnConvert.TabIndex = 5;
            this.btnConvert.Text = "&Convert";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Yellow;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(483, 269);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(157, 59);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(482, 334);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(157, 59);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Sec3LabExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1130, 487);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.grpConvertType);
            this.Controls.Add(this.lblConvertedTxt);
            this.Controls.Add(this.lblEnteredTxt);
            this.Controls.Add(this.txtConverted);
            this.Controls.Add(this.txtEntered);
            this.Name = "Sec3LabExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Decoder";
            this.grpConvertType.ResumeLayout(false);
            this.grpConvertType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEntered;
        private System.Windows.Forms.TextBox txtConverted;
        private System.Windows.Forms.Label lblEnteredTxt;
        private System.Windows.Forms.Label lblConvertedTxt;
        private System.Windows.Forms.GroupBox grpConvertType;
        private System.Windows.Forms.RadioButton rdoCipherToPlain;
        private System.Windows.Forms.RadioButton rdoPlainToCipher;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
    }
}

