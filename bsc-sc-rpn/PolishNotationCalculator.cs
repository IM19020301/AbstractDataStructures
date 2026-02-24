using System;

namespace bsc_sc_rpn
{
    public class PolishNotationCalculator
    {
        /* Use the IStack<double> interface type to allow the flexibility of using different stack implementations 
         * (e.g., ArrayStack or LinkedListStack). */
        private IStack<double> stack;

        public PolishNotationCalculator(IStack<double> stackImplementation)
        {
            stack = stackImplementation;
        }

        public double Evaluate(string expression)
        {
            double expressionItem;

            expressionItem = 0;

            string[] expressionItems = expression.Split(' ');

            foreach (string str in expressionItems)
            {
                // Declares varaibles.
                bool isNumber;

                // Sets variables.
                isNumber = false;

                if (str == "+")
                {
                    double number1 = stack.Pop();
                    double number2 = stack.Pop();

                    Console.WriteLine("Adding top two numbers in stack.");
                }
                else if (str == "-")
                {
                    Console.WriteLine("Subtracting top two numbers in stack.");
                }
                else if (str == "*")
                {
                    Console.WriteLine("Multiplying top two numbers in stack.");
                }
                else if (str == "/")
                {
                    Console.WriteLine("Dividing top two numbers in stack.");
                }
                // Checks if number is valid and able to be used.
                else if (double.TryParse(str, out expressionItem))
                {
                    // Marks number as valid.
                    isNumber = true;
                }
                else
                {
                    Console.WriteLine("ExpressionItem is not a valid input.");
                }

                // If number is valid adds it to the inputArray.
                if (isNumber == true)
                {
                    stack.Push(expressionItem);
                }
            }


            /*
             * 1. Split the expression into individual tokens using a space as the delimiter.
             * 2. Iterate over each token:
             *      - If the token is a number, push it onto the stack.
             *      - If the token is an operator (+, -, *, /):
             *          a. Pop two numbers from the stack (b first, then a).
             *          b. Perform the operation (a + b, a - b, etc.).
             *          c. Push the result back onto the stack.
             * 3. After processing all tokens, the result of the calculation will be the single number remaining on the stack.
             *    Pop and return it as the final result.
             */

            // return stack.Pop();
            return 0;
        }
    }
}
