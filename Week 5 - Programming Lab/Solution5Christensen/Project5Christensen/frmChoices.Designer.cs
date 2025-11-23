namespace Project5Christensen
{
    partial class frmChoices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChoices));
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblLeftNum = new System.Windows.Forms.Label();
            this.lblRightNum = new System.Windows.Forms.Label();
            this.txtLeftNum = new System.Windows.Forms.TextBox();
            this.txtRightNum = new System.Windows.Forms.TextBox();
            this.lblNumToCheck = new System.Windows.Forms.Label();
            this.txtNumChecked = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblMsgToUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.BackColor = System.Drawing.Color.Silver;
            this.lblInstructions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInstructions.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(19, 13);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(769, 98);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = resources.GetString("lblInstructions.Text");
            // 
            // lblLeftNum
            // 
            this.lblLeftNum.AutoSize = true;
            this.lblLeftNum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeftNum.Location = new System.Drawing.Point(95, 124);
            this.lblLeftNum.Name = "lblLeftNum";
            this.lblLeftNum.Size = new System.Drawing.Size(144, 28);
            this.lblLeftNum.TabIndex = 1;
            this.lblLeftNum.Text = "Left Number:";
            this.lblLeftNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRightNum
            // 
            this.lblRightNum.AutoSize = true;
            this.lblRightNum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightNum.Location = new System.Drawing.Point(479, 127);
            this.lblRightNum.Name = "lblRightNum";
            this.lblRightNum.Size = new System.Drawing.Size(158, 28);
            this.lblRightNum.TabIndex = 2;
            this.lblRightNum.Text = "Right Number:";
            this.lblRightNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLeftNum
            // 
            this.txtLeftNum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeftNum.Location = new System.Drawing.Point(99, 154);
            this.txtLeftNum.Name = "txtLeftNum";
            this.txtLeftNum.Size = new System.Drawing.Size(140, 30);
            this.txtLeftNum.TabIndex = 3;
            // 
            // txtRightNum
            // 
            this.txtRightNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRightNum.Location = new System.Drawing.Point(483, 154);
            this.txtRightNum.Name = "txtRightNum";
            this.txtRightNum.Size = new System.Drawing.Size(154, 22);
            this.txtRightNum.TabIndex = 4;
            // 
            // lblNumToCheck
            // 
            this.lblNumToCheck.AutoSize = true;
            this.lblNumToCheck.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumToCheck.Location = new System.Drawing.Point(270, 199);
            this.lblNumToCheck.Name = "lblNumToCheck";
            this.lblNumToCheck.Size = new System.Drawing.Size(196, 22);
            this.lblNumToCheck.TabIndex = 5;
            this.lblNumToCheck.Text = "Number to be Checked:";
            this.lblNumToCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNumChecked
            // 
            this.txtNumChecked.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumChecked.Location = new System.Drawing.Point(274, 224);
            this.txtNumChecked.Name = "txtNumChecked";
            this.txtNumChecked.Size = new System.Drawing.Size(192, 30);
            this.txtNumChecked.TabIndex = 6;
            this.txtNumChecked.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.OrangeRed;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.GreenYellow;
            this.btnClear.Location = new System.Drawing.Point(99, 271);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(122, 38);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clea&r";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Yellow;
            this.btnExit.Location = new System.Drawing.Point(515, 271);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(122, 38);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Yellow;
            this.btnCheck.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.Color.Navy;
            this.btnCheck.Location = new System.Drawing.Point(305, 260);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(122, 38);
            this.btnCheck.TabIndex = 9;
            this.btnCheck.Text = "&Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblMsgToUser
            // 
            this.lblMsgToUser.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblMsgToUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMsgToUser.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgToUser.Location = new System.Drawing.Point(12, 317);
            this.lblMsgToUser.Name = "lblMsgToUser";
            this.lblMsgToUser.Size = new System.Drawing.Size(776, 124);
            this.lblMsgToUser.TabIndex = 10;
            this.lblMsgToUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmChoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMsgToUser);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtNumChecked);
            this.Controls.Add(this.lblNumToCheck);
            this.Controls.Add(this.txtRightNum);
            this.Controls.Add(this.txtLeftNum);
            this.Controls.Add(this.lblRightNum);
            this.Controls.Add(this.lblLeftNum);
            this.Controls.Add(this.lblInstructions);
            this.Name = "frmChoices";
            this.Text = "Christensen Choices";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblLeftNum;
        private System.Windows.Forms.Label lblRightNum;
        private System.Windows.Forms.TextBox txtLeftNum;
        private System.Windows.Forms.TextBox txtRightNum;
        private System.Windows.Forms.Label lblNumToCheck;
        private System.Windows.Forms.TextBox txtNumChecked;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblMsgToUser;
    }
}

