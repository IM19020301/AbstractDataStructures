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
        // Declares the stack and calculator elemetnts.
        private IStack<double> stack;
        private PolishNotationCalculator calculator;

        public RPN()
        {
            InitializeComponent();

            // Initialises the stack and calculator elemetnts.
            stack = new ArrayStack<double>(10);
            calculator = new PolishNotationCalculator(stack);
        }

        private void Btn_Eval_Click(object sender, EventArgs e)
        {
            // Sets the expression variable using the etxt box.
            string expression = Txt_Input.Text;

            // Runs the calculators Evaluate method on the expression.
            calculator.Evaluate(expression);
        }
    }
}
