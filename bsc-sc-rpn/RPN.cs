using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

            // Put test code here.
            // Int Stack test.
            Console.WriteLine("===================");
            Console.WriteLine("Creating int Stack.");

            ArrayStack<int> stackInt = new ArrayStack<int>(2);

            stackInt.IsEmpty();
            stackInt.Push(0);
            stackInt.Push(1);
            stackInt.Push(2);
            stackInt.Push(2);
            stackInt.IsEmpty();


            // String Stack test.
            Console.WriteLine("===================");
            Console.WriteLine("Creating string Stack.");

            ArrayStack<string> stackString = new ArrayStack<string>(10);

            stackString.IsEmpty();
            stackString.Push("Beans");
            stackString.IsEmpty();
        }

        private void Btn_Eval_Click(object sender, EventArgs e)
        {
            // Read and Parse Expression here... 
        }
    }
}
