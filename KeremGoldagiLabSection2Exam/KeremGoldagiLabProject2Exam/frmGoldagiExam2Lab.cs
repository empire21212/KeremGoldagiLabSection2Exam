using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

/*************************
* Name: Kerem Goldagi
* Class: ITD-2343-60486
* Trimester: Fall 2026
* Due Date: 10/14/2026
*************************/

namespace KeremGoldagiLabProject2Exam
{
    public partial class frmGoldagiExam2Lab : System.Windows.Forms.Form
    {
        int iLeft = 0;        
        int iResult = 0;

        
        public frmGoldagiExam2Lab()
        {
            InitializeComponent();
        }
        
        private void btnShowModulus_Click(object sender, EventArgs e)
        {
            string ModulusInstructions = "The modulus operator (%) returns the remainder of a division.\n\n" +
                "For example: 7 % 3 = 1\n\n" +
                "Note: Modulus by 0 (zero) is undefined, since division operations by 0 (zero) break basic algebraic principles.\n\n" +
                "To use this feature in Operations <Kerem Goldagi>, enter two positive integers and click the Modulus Operation button or press 'ALT + M'.\n\n";

            txtFirstOperand.Visible = true;
            txtFirstOperand.Location = new Point(289, 113);
            txtSecondOperand.Visible = true;
            txtSecondOperand.Location = new Point(443, 113);
            lblModulus.Visible = true;

            btnDoModulus.Enabled = true;
            btnDoFactorial.Enabled = false;
            btnDoFibonacci.Enabled = false;

            MessageBox.Show(ModulusInstructions, "Requirements for Modulus Operation");
        }

        private void btnShowFactorial_Click(object sender, EventArgs e)
        {
            string FactorialInstructions = "The factorial of a number is calculated by multiplying the number by the preceding integers down to 1.\n\n" +
                "For example: 5! = 5 * 4 * 3 * 2 * 1 = 120\n\n" +
                "Note: 0! and 1! equal to 1.\n\n"+
                "To use this feature in Operations <Kerem Goldagi>, enter an integer ranging from 0 to 15 and click the Factorial Operation button or press 'ALT + F'.\n\n";

            txtFirstOperand.Visible = true;
            txtFirstOperand.Location = new Point(366, 113);

            txtSecondOperand.Visible = false;

            btnDoModulus.Enabled = false;
            btnDoFactorial.Enabled = true;
            btnDoFibonacci.Enabled = false;

            MessageBox.Show(FactorialInstructions, "Requirements for Factorial Operation");
        }

        private void btnShowFibonacci_Click(object sender, EventArgs e)
        {
            string FibonacciInstructions = "The Fibonacci sequence is a series of positive numbers where each number is the sum of the two preceding integers.\n\n" +
                "For example: 1, 1, 2, 3, 5, 8, 13, ...\n\n" +
                "Note: Fibonacci(0) equal to 1.\n\n" +
                "To use this feature in Operations <Kerem Goldagi>, enter an integer ranging from 0 to 45 and click the Fibonacci Operation button or press 'ALT + B'.\n\n";

            txtFirstOperand.Visible = true;
            txtFirstOperand.Location = new Point(366, 113);

            txtSecondOperand.Visible = false;

            btnDoModulus.Enabled = false;
            btnDoFactorial.Enabled = false;
            btnDoFibonacci.Enabled = true;

            MessageBox.Show(FibonacciInstructions, "Requirements for Fibonacci Operation");
        }        

        private void btnDoModulus_Click(object sender, EventArgs e)
        {
            int iRight = 0;
            int iRemainder = 0;

            if (string.IsNullOrEmpty(txtFirstOperand.Text) || string.IsNullOrEmpty(txtSecondOperand.Text))
            {
                lblDisplayResult.Text = "Please enter positive integers for both operands.";
                return;
            }

            if (!int.TryParse(txtFirstOperand.Text, out iLeft) ||
                !int.TryParse(txtSecondOperand.Text, out iRight))
            {
                lblDisplayResult.Text = "Please enter positive integers for both operands.";
                return;
            }

            if (iLeft <= 0 || iRight <= 0)
            {
                lblDisplayResult.Text = "Please enter positive integers for both operands.";
                return;
            }

            iRemainder = iLeft;
            iResult = 0;

            while (iRemainder >= iRight)
            {
                iRemainder -= iRight;
                iResult ++;
            }

            lblDisplayResult.Text = $"{iLeft:n0} divided by {iRight:n0} is {iResult:n0} " + 
                $"with a remainder of {iRemainder}";
        }

        private void btnDoFactorial_Click(object sender, EventArgs e)
        {
            if (!ValidateOperand(txtFirstOperand.Text, 15, out iLeft))
                return;

            long f = 1;
                     
            if (iLeft == 0 || iLeft == 1)

            {
                f = 1;
                lblDisplayResult.Text = $"The answer to {iLeft}! is {f:n0}";
            }
            else
            {
                for (int i = 1; i <= iLeft; i++)
                {
                    f *= i;
                }

                lblDisplayResult.Text = $"The answer to {iLeft}! is {f:n0}";
            }
        }

        private void btnDoFibonacci_Click(object sender, EventArgs e)
        {
            if (!ValidateOperand(txtFirstOperand.Text, 45, out iLeft))
                return;

            if (iLeft == 0 || iLeft == 1)
            {
                lblDisplayResult.Text = $"The Fibonacci({iLeft}) = {iLeft}";
                return;
            }

            int previous = 0;
            int current = 1;

            for (int i = 2; i < iLeft; i++)
            {
                int next = previous + current;
                previous = current;
                current = next;
            }

            iResult = previous + current;

            lblDisplayResult.Text = $"Fibonacci({iLeft}) is equal to\n" +
                $"Fibonacci({iLeft - 1}) + Fibonacci({iLeft - 2})\n" +
                $"= {current} + {previous} = {iResult}";
        }

        private bool ValidateOperand(string input, int maximum, out int number)
        {
            number = 0;

            if (string.IsNullOrWhiteSpace(input))
            {
                lblDisplayResult.Text = "The operand is empty.\n" +
                    $"Please enter a number from 0 to {maximum}.";
                return false;
            }

            if (!int.TryParse(input, out number))
            {
                decimal numericValue;

                if (decimal.TryParse(input, out numericValue))
                {
                    lblDisplayResult.Text =
                        $"Enter a whole number from 0 to {maximum}. " +
                        "Decimal values are prohibited, and large values may be out of range.";
                }
                else
                {
                    lblDisplayResult.Text =
                        $"Invalid input. Enter an integer from 0 to {maximum}.";
                }

                return false;
            }

            if (number < 0 || number > maximum)
            {
                lblDisplayResult.Text =
                    $"Please enter an integer from 0 to {maximum}.";
                return false;
            }

            return true;
        }                  

        private void btnClear_Click(object sender, EventArgs e)
        {
            string clearMessage = "Clear button only clears the result.";

            MessageBox.Show(clearMessage, "Warning");
            lblDisplayResult.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string exitMessage = "Thank you for using Operations <Kerem Goldagi>";

            MessageBox.Show(exitMessage, "Exit Message");

            this.Close();
        }

        private void frmGoldagiExam2Lab_Load(object sender, EventArgs e)
        {

            txtFirstOperand.Visible = false;
            txtSecondOperand.Visible = false;
            lblModulus.Visible = false;

            btnDoModulus.Enabled = false;
            btnDoFactorial.Enabled = false;
            btnDoFibonacci.Enabled = false;
        }

        private void txtOperand_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
