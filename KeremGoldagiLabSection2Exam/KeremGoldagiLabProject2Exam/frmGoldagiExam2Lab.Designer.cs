namespace KeremGoldagiLabProject2Exam
{
    partial class frmGoldagiExam2Lab
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
            this.lblDisplayResult = new System.Windows.Forms.Label();
            this.btnShowModulus = new System.Windows.Forms.Button();
            this.btnShowFactorial = new System.Windows.Forms.Button();
            this.btnShowFibonacci = new System.Windows.Forms.Button();
            this.btnDoModulus = new System.Windows.Forms.Button();
            this.btnDoFactorial = new System.Windows.Forms.Button();
            this.btnDoFibonacci = new System.Windows.Forms.Button();
            this.txtFirstOperand = new System.Windows.Forms.TextBox();
            this.txtSecondOperand = new System.Windows.Forms.TextBox();
            this.lblModulus = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDisplayResult
            // 
            this.lblDisplayResult.BackColor = System.Drawing.Color.LightBlue;
            this.lblDisplayResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisplayResult.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayResult.Location = new System.Drawing.Point(172, 262);
            this.lblDisplayResult.Name = "lblDisplayResult";
            this.lblDisplayResult.Size = new System.Drawing.Size(497, 119);
            this.lblDisplayResult.TabIndex = 10;
            this.lblDisplayResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShowModulus
            // 
            this.btnShowModulus.AutoSize = true;
            this.btnShowModulus.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnShowModulus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowModulus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowModulus.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowModulus.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnShowModulus.Location = new System.Drawing.Point(33, 49);
            this.btnShowModulus.Name = "btnShowModulus";
            this.btnShowModulus.Padding = new System.Windows.Forms.Padding(5);
            this.btnShowModulus.Size = new System.Drawing.Size(250, 44);
            this.btnShowModulus.TabIndex = 0;
            this.btnShowModulus.Text = "Requirements for Modulus";
            this.btnShowModulus.UseVisualStyleBackColor = false;
            this.btnShowModulus.Click += new System.EventHandler(this.btnShowModulus_Click);
            // 
            // btnShowFactorial
            // 
            this.btnShowFactorial.AutoSize = true;
            this.btnShowFactorial.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnShowFactorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowFactorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowFactorial.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowFactorial.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnShowFactorial.Location = new System.Drawing.Point(289, 49);
            this.btnShowFactorial.Name = "btnShowFactorial";
            this.btnShowFactorial.Padding = new System.Windows.Forms.Padding(5);
            this.btnShowFactorial.Size = new System.Drawing.Size(254, 44);
            this.btnShowFactorial.TabIndex = 1;
            this.btnShowFactorial.Text = "Requirements for Factorial";
            this.btnShowFactorial.UseVisualStyleBackColor = false;
            this.btnShowFactorial.Click += new System.EventHandler(this.btnShowFactorial_Click);
            // 
            // btnShowFibonacci
            // 
            this.btnShowFibonacci.AutoSize = true;
            this.btnShowFibonacci.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnShowFibonacci.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowFibonacci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowFibonacci.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowFibonacci.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnShowFibonacci.Location = new System.Drawing.Point(549, 49);
            this.btnShowFibonacci.Name = "btnShowFibonacci";
            this.btnShowFibonacci.Padding = new System.Windows.Forms.Padding(5);
            this.btnShowFibonacci.Size = new System.Drawing.Size(259, 44);
            this.btnShowFibonacci.TabIndex = 2;
            this.btnShowFibonacci.Text = "Requirements for Fibonacci";
            this.btnShowFibonacci.UseVisualStyleBackColor = false;
            this.btnShowFibonacci.Click += new System.EventHandler(this.btnShowFibonacci_Click);
            // 
            // btnDoModulus
            // 
            this.btnDoModulus.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDoModulus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoModulus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoModulus.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoModulus.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnDoModulus.Location = new System.Drawing.Point(149, 168);
            this.btnDoModulus.Name = "btnDoModulus";
            this.btnDoModulus.Padding = new System.Windows.Forms.Padding(5);
            this.btnDoModulus.Size = new System.Drawing.Size(134, 67);
            this.btnDoModulus.TabIndex = 3;
            this.btnDoModulus.Text = "&Modulus Operation";
            this.btnDoModulus.UseVisualStyleBackColor = false;
            this.btnDoModulus.Click += new System.EventHandler(this.btnDoModulus_Click);
            // 
            // btnDoFactorial
            // 
            this.btnDoFactorial.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDoFactorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoFactorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoFactorial.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoFactorial.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnDoFactorial.Location = new System.Drawing.Point(350, 168);
            this.btnDoFactorial.Name = "btnDoFactorial";
            this.btnDoFactorial.Padding = new System.Windows.Forms.Padding(5);
            this.btnDoFactorial.Size = new System.Drawing.Size(134, 67);
            this.btnDoFactorial.TabIndex = 4;
            this.btnDoFactorial.Text = "&Factorial Operation";
            this.btnDoFactorial.UseVisualStyleBackColor = false;
            this.btnDoFactorial.Click += new System.EventHandler(this.btnDoFactorial_Click);
            // 
            // btnDoFibonacci
            // 
            this.btnDoFibonacci.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDoFibonacci.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoFibonacci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoFibonacci.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoFibonacci.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnDoFibonacci.Location = new System.Drawing.Point(549, 168);
            this.btnDoFibonacci.Name = "btnDoFibonacci";
            this.btnDoFibonacci.Padding = new System.Windows.Forms.Padding(5);
            this.btnDoFibonacci.Size = new System.Drawing.Size(134, 67);
            this.btnDoFibonacci.TabIndex = 5;
            this.btnDoFibonacci.Text = "Fi&bonacci Operation";
            this.btnDoFibonacci.UseVisualStyleBackColor = false;
            this.btnDoFibonacci.Click += new System.EventHandler(this.btnDoFibonacci_Click);
            // 
            // txtFirstOperand
            // 
            this.txtFirstOperand.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFirstOperand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstOperand.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstOperand.Location = new System.Drawing.Point(366, 116);
            this.txtFirstOperand.MaxLength = 8;
            this.txtFirstOperand.Name = "txtFirstOperand";
            this.txtFirstOperand.Size = new System.Drawing.Size(100, 29);
            this.txtFirstOperand.TabIndex = 9;
            this.txtFirstOperand.TabStop = false;
            this.txtFirstOperand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFirstOperand.TextChanged += new System.EventHandler(this.txtOperand_TextChanged);
            // 
            // txtSecondOperand
            // 
            this.txtSecondOperand.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSecondOperand.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondOperand.Location = new System.Drawing.Point(366, 116);
            this.txtSecondOperand.MaxLength = 8;
            this.txtSecondOperand.Name = "txtSecondOperand";
            this.txtSecondOperand.Size = new System.Drawing.Size(100, 29);
            this.txtSecondOperand.TabIndex = 8;
            this.txtSecondOperand.TabStop = false;
            this.txtSecondOperand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblModulus
            // 
            this.lblModulus.AutoSize = true;
            this.lblModulus.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModulus.Location = new System.Drawing.Point(402, 119);
            this.lblModulus.Name = "lblModulus";
            this.lblModulus.Size = new System.Drawing.Size(28, 22);
            this.lblModulus.TabIndex = 11;
            this.lblModulus.Text = "%";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Silver;
            this.btnExit.Location = new System.Drawing.Point(68, 286);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 71);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Black;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Silver;
            this.btnClear.Location = new System.Drawing.Point(689, 286);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 71);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "&Clear Result";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmGoldagiExam2Lab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(841, 431);
            this.Controls.Add(this.txtFirstOperand);
            this.Controls.Add(this.lblModulus);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtSecondOperand);
            this.Controls.Add(this.btnDoFibonacci);
            this.Controls.Add(this.btnDoFactorial);
            this.Controls.Add(this.btnDoModulus);
            this.Controls.Add(this.btnShowFibonacci);
            this.Controls.Add(this.btnShowFactorial);
            this.Controls.Add(this.btnShowModulus);
            this.Controls.Add(this.lblDisplayResult);
            this.Name = "frmGoldagiExam2Lab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operations <Kerem Goldagi>";
            this.Load += new System.EventHandler(this.frmGoldagiExam2Lab_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDisplayResult;
        private System.Windows.Forms.Button btnShowModulus;
        private System.Windows.Forms.Button btnShowFactorial;
        private System.Windows.Forms.Button btnShowFibonacci;
        private System.Windows.Forms.Button btnDoModulus;
        private System.Windows.Forms.Button btnDoFactorial;
        private System.Windows.Forms.Button btnDoFibonacci;
        private System.Windows.Forms.TextBox txtFirstOperand;
        private System.Windows.Forms.TextBox txtSecondOperand;
        private System.Windows.Forms.Label lblModulus;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
    }
}

