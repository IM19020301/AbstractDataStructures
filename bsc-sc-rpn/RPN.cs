using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bsc_sc_rpn
{
    public partial class RPN : Form
    {
        private IStack<double> stack;
        private PolishNotationCalculator calculator;

        public RPN()
        {
            InitializeComponent();

            ArrayStack<int> stackInt = new ArrayStack<int>(2);
        }

        private void Btn_Eval_Click(object sender, EventArgs e)
        {
            // Read and Parse Expression here... 

            int expressionItem;

            string expression = Txt_Input.Text;
            string[] expressionItems = expression.Split(' ');

            int i = 0;
            foreach (string str in expressionItems)
            {
                // Declares varaibles.
                bool isNumber;

                // Sets variables.
                isNumber = false;

                // Checks if number is valid and able to be used.
                if (Int32.TryParse(str, out expressionItem) && expressionItem > 0)
                {
                    // Marks number as valid.
                    isNumber = true;
                }

                // If number is valid adds it to the inputArray.
                if (isNumber == true)
                {
                    // Adds the number to the inputArray.
                    Console.WriteLine("Adding " + expressionItem + " to stack.");
                    i++;
                }
                else
                {
                    Console.WriteLine("ExpressionItem is not a valid input.");
                }
            }
        }
    }
}
