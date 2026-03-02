using System;

namespace bsc_sc_rpn
{
    public class PolishNotationCalculator
    {
        /* Use the IStack<double> interface type to allow the flexibility of using different stack implementations 
         * (e.g., ArrayStack or LinkedListStack). */
        private IStack<double> stack;

        // PolishNotationCalculator constructor.
        public PolishNotationCalculator(IStack<double> stackImplementation)
        {
            stack = stackImplementation;
        }

        // Evaluate method to process the exrpession.
        public double Evaluate(string expression)
        {
            // Declares varaibles.
            double expressionItem;
            double number1;
            double number2;
            double result;

            // Sets variables.
            expressionItem = 0;
            number1 = 0;
            number2 = 0;
            result = 0;

            // Breaks apart the expression into individual items.
            string[] expressionItems = expression.Split(' ');

            // Foreach loop to run throuh the entire expressionItems array.
            foreach (string str in expressionItems)
            {
                // Declares varaibles.
                bool isNumber;

                // Sets variables.
                isNumber = false;

                // If array item is "+" operator adds top numbers in stack together.
                if (str == "+")
                {
                    // Fetches the top two numbes from the stack.
                    number1 = stack.Pop();
                    number2 = stack.Pop();

                    // Adds the two numbers together.
                    result = number2 + number1;

                    // Returns feedback to the console.
                    Console.WriteLine(number2 + " + " + number1 + " = " + result);

                    // Adds the result to the stack.
                    stack.Push(result);
                }
                // Else if array item is "-" operator subtracts top numbers in stack from each other.
                else if (str == "-")
                {
                    // Fetches the top two numbes from the stack.
                    number1 = stack.Pop();
                    number2 = stack.Pop();

                    // Subtracts the two numbers from each other.
                    result = number2 - number1;

                    // Returns feedback to the console.
                    Console.WriteLine(number2 + " - " + number1 + " = " + result);

                    // Adds the result to the stack.
                    stack.Push(result);
                }
                // Else if array item is "*" operator multiplies top numbers in stack by each other.
                else if (str == "*")
                {
                    // Fetches the top two numbes from the stack.
                    number1 = stack.Pop();
                    number2 = stack.Pop();

                    // Multiplies the two numbers by each other.
                    result = number2 * number1;

                    // Returns feedback to the console.
                    Console.WriteLine(number2 + " * " + number1 + " = " + result);

                    // Adds the result to the stack.
                    stack.Push(result);
                }
                // Else if array item is "/" operator divides top numbers in stack by each other.
                else if (str == "/")
                {
                    // Fetches the top two numbes from the stack.
                    number1 = stack.Pop();
                    number2 = stack.Pop();

                    // Divides the two numbers by each other.
                    result = number2 / number1;

                    // Returns feedback to the console.
                    Console.WriteLine(number2 + " / " + number1 + " = " + result);

                    // Adds the result to the stack.
                    stack.Push(result);
                }
                // Else if array item is a number check if its valid and usable.
                else if (double.TryParse(str, out expressionItem))
                {
                    // Marks number as valid.
                    isNumber = true;
                }
                // Else tell user that array item is not a valid input.
                else
                {
                    // Returns feedback to the console.
                    Console.WriteLine("ExpressionItem is not a valid input.");
                }

                // If number is valid adds it to the stack.
                if (isNumber == true)
                {
                    // Adds the number to the stack.
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
