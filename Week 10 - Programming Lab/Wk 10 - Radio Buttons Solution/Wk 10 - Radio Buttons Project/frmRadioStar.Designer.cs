namespace Wk_10___Radio_Buttons_Project
{
    partial class frmRadioStar
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
            this.lblLeftOperand = new System.Windows.Forms.Label();
            this.lblRightOperand = new System.Windows.Forms.Label();
            this.txtLeftOperand = new System.Windows.Forms.TextBox();
            this.txtRightOperand = new System.Windows.Forms.TextBox();
            this.grpOperations = new System.Windows.Forms.GroupBox();
            this.rdoAdd = new System.Windows.Forms.RadioButton();
            this.rdoSubtract = new System.Windows.Forms.RadioButton();
            this.rdoMultiply = new System.Windows.Forms.RadioButton();
            this.rdoDivide = new System.Windows.Forms.RadioButton();
            this.rdoModulus = new System.Windows.Forms.RadioButton();
            this.chkVerbose = new System.Windows.Forms.CheckBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.grpOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLeftOperand
            // 
            this.lblLeftOperand.AutoSize = true;
            this.lblLeftOperand.BackColor = System.Drawing.Color.LightBlue;
            this.lblLeftOperand.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeftOperand.Location = new System.Drawing.Point(49, 39);
            this.lblLeftOperand.Name = "lblLeftOperand";
            this.lblLeftOperand.Size = new System.Drawing.Size(143, 26);
            this.lblLeftOperand.TabIndex = 0;
            this.lblLeftOperand.Text = "Left Operand:";
            // 
            // lblRightOperand
            // 
            this.lblRightOperand.AutoSize = true;
            this.lblRightOperand.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightOperand.Location = new System.Drawing.Point(223, 39);
            this.lblRightOperand.Name = "lblRightOperand";
            this.lblRightOperand.Size = new System.Drawing.Size(155, 26);
            this.lblRightOperand.TabIndex = 1;
            this.lblRightOperand.Text = "Right Operand:";
            // 
            // txtLeftOperand
            // 
            this.txtLeftOperand.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtLeftOperand.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeftOperand.Location = new System.Drawing.Point(49, 71);
            this.txtLeftOperand.Name = "txtLeftOperand";
            this.txtLeftOperand.Size = new System.Drawing.Size(143, 28);
            this.txtLeftOperand.TabIndex = 2;
            // 
            // txtRightOperand
            // 
            this.txtRightOperand.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtRightOperand.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRightOperand.Location = new System.Drawing.Point(227, 71);
            this.txtRightOperand.Name = "txtRightOperand";
            this.txtRightOperand.Size = new System.Drawing.Size(143, 28);
            this.txtRightOperand.TabIndex = 3;
            // 
            // grpOperations
            // 
            this.grpOperations.Controls.Add(this.rdoModulus);
            this.grpOperations.Controls.Add(this.rdoDivide);
            this.grpOperations.Controls.Add(this.rdoMultiply);
            this.grpOperations.Controls.Add(this.rdoSubtract);
            this.grpOperations.Controls.Add(this.rdoAdd);
            this.grpOperations.Location = new System.Drawing.Point(49, 129);
            this.grpOperations.Name = "grpOperations";
            this.grpOperations.Size = new System.Drawing.Size(321, 122);
            this.grpOperations.TabIndex = 4;
            this.grpOperations.TabStop = false;
            this.grpOperations.Text = "Math Operations Available";
            // 
            // rdoAdd
            // 
            this.rdoAdd.AutoSize = true;
            this.rdoAdd.Checked = true;
            this.rdoAdd.Location = new System.Drawing.Point(6, 31);
            this.rdoAdd.Name = "rdoAdd";
            this.rdoAdd.Size = new System.Drawing.Size(71, 20);
            this.rdoAdd.TabIndex = 0;
            this.rdoAdd.TabStop = true;
            this.rdoAdd.Text = "Add (+)";
            this.rdoAdd.UseVisualStyleBackColor = true;
            // 
            // rdoSubtract
            // 
            this.rdoSubtract.AutoSize = true;
            this.rdoSubtract.Location = new System.Drawing.Point(6, 57);
            this.rdoSubtract.Name = "rdoSubtract";
            this.rdoSubtract.Size = new System.Drawing.Size(92, 20);
            this.rdoSubtract.TabIndex = 1;
            this.rdoSubtract.Text = "Subtract (-)";
            this.rdoSubtract.UseVisualStyleBackColor = true;
            // 
            // rdoMultiply
            // 
            this.rdoMultiply.AutoSize = true;
            this.rdoMultiply.Location = new System.Drawing.Point(6, 83);
            this.rdoMultiply.Name = "rdoMultiply";
            this.rdoMultiply.Size = new System.Drawing.Size(90, 20);
            this.rdoMultiply.TabIndex = 2;
            this.rdoMultiply.TabStop = true;
            this.rdoMultiply.Text = "Multiply (x)";
            this.rdoMultiply.UseVisualStyleBackColor = true;
            // 
            // rdoDivide
            // 
            this.rdoDivide.AutoSize = true;
            this.rdoDivide.Location = new System.Drawing.Point(121, 31);
            this.rdoDivide.Name = "rdoDivide";
            this.rdoDivide.Size = new System.Drawing.Size(82, 20);
            this.rdoDivide.TabIndex = 3;
            this.rdoDivide.TabStop = true;
            this.rdoDivide.Text = "Divide (/)";
            this.rdoDivide.UseVisualStyleBackColor = true;
            // 
            // rdoModulus
            // 
            this.rdoModulus.AutoSize = true;
            this.rdoModulus.Location = new System.Drawing.Point(121, 57);
            this.rdoModulus.Name = "rdoModulus";
            this.rdoModulus.Size = new System.Drawing.Size(102, 20);
            this.rdoModulus.TabIndex = 4;
            this.rdoModulus.TabStop = true;
            this.rdoModulus.Text = "Modulus (%)";
            this.rdoModulus.UseVisualStyleBackColor = true;
            // 
            // chkVerbose
            // 
            this.chkVerbose.AutoSize = true;
            this.chkVerbose.Checked = true;
            this.chkVerbose.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVerbose.Location = new System.Drawing.Point(55, 257);
            this.chkVerbose.Name = "chkVerbose";
            this.chkVerbose.Size = new System.Drawing.Size(298, 20);
            this.chkVerbose.TabIndex = 5;
            this.chkVerbose.Text = "Check for Verbose mode (show full requation)";
            this.chkVerbose.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.LightGreen;
            this.btnCalculate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(376, 129);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(128, 41);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Yellow;
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(376, 176);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(128, 41);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.OrangeRed;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(376, 223);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 41);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.LightCyan;
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMessage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(50, 293);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(454, 273);
            this.lblMessage.TabIndex = 9;
            // 
            // frmRadioStar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(567, 607);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.chkVerbose);
            this.Controls.Add(this.grpOperations);
            this.Controls.Add(this.txtRightOperand);
            this.Controls.Add(this.txtLeftOperand);
            this.Controls.Add(this.lblRightOperand);
            this.Controls.Add(this.lblLeftOperand);
            this.Name = "frmRadioStar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Radio Buttons in Action";
            this.grpOperations.ResumeLayout(false);
            this.grpOperations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLeftOperand;
        private System.Windows.Forms.Label lblRightOperand;
        private System.Windows.Forms.TextBox txtLeftOperand;
        private System.Windows.Forms.TextBox txtRightOperand;
        private System.Windows.Forms.GroupBox grpOperations;
        private System.Windows.Forms.RadioButton rdoMultiply;
        private System.Windows.Forms.RadioButton rdoSubtract;
        private System.Windows.Forms.RadioButton rdoAdd;
        private System.Windows.Forms.RadioButton rdoModulus;
        private System.Windows.Forms.RadioButton rdoDivide;
        private System.Windows.Forms.CheckBox chkVerbose;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMessage;
    }
}

