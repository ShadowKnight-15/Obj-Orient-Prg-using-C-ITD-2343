namespace Module3Exercise2Project
{
    partial class Form1
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
            this.btnRed = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();                //adjusted all according to the right name
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.ForeColor = System.Drawing.Color.Red;
            this.btnRed.Location = new System.Drawing.Point(28, 20);
            this.btnRed.Margin = new System.Windows.Forms.Padding(4);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(124, 55);
            this.btnRed.TabIndex = 0;
            this.btnRed.Text = "&Red";
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.ForeColor = System.Drawing.Color.Blue;
            this.btnBlue.Location = new System.Drawing.Point(501, 20);           //adjusted all to btnBlue
            this.btnBlue.Margin = new System.Windows.Forms.Padding(4);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(124, 55);
            this.btnBlue.TabIndex = 1;
            this.btnBlue.Text = "&Blue";
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(504, 191);
            this.btnRight.Margin = new System.Windows.Forms.Padding(4);              //adjusted all to btnRight
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(124, 55);
            this.btnRight.TabIndex = 2;
            this.btnRight.Text = "&R";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(28, 191);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(4);          //adjusted all to btnLeft
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(124, 55);
            this.btnLeft.TabIndex = 3;
            this.btnLeft.Text = "&L";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(185, 288);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);                //adjusted all to btnExit
            this.btnExit.Name = "btnExit"; 
            this.btnExit.Size = new System.Drawing.Size(284, 119);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.Color.Yellow;
            this.lblOutput.Font = new System.Drawing.Font("Times New Roman", 24F);      //Adjusted all to lblOutput
            this.lblOutput.ForeColor = System.Drawing.Color.Black;
            this.lblOutput.Location = new System.Drawing.Point(185, 20);
            this.lblOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(284, 226);
            this.lblOutput.TabIndex = 5;
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(641, 422);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnRed);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnBlue; // Fix - rename to  btnBlue
        private System.Windows.Forms.Button btnRight; // Fix - rename to  btnRight
        private System.Windows.Forms.Button btnLeft; // Fix - rename to  btnLeft
        private System.Windows.Forms.Button btnExit; // Fix - rename to  btnExit
        private System.Windows.Forms.Label lblOutput; // Fix - rename to  lblOutput
    }
}

