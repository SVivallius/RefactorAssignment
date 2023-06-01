using System;
using System.Text;

namespace CalculatorRPN
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleStack stack = new DoubleStack();
            while (true)
            {
                if (stack.Depth == 0)
                {
                    Console.WriteLine("Commands: q c + - * / number");
                    Console.WriteLine("[]");
                }
                else
                {
                    Console.WriteLine(stack.ToString());
                }
                string input = Console.ReadLine().Trim();
                if (input == "") input = " ";
                char command = input[0];
                if (Char.IsDigit(command))
                {
                    double value = Convert.ToDouble(input);
                    stack.Push(value);
                }
                else if (command == '+')
                {
                    stack.Push(stack.Pop() + stack.Pop());
                }
                else if (command == '*')
                {
                    stack.Push(stack.Pop() * stack.Pop());
                }
                else if (command == '-')
                {
                    double d = stack.Pop();
                    stack.Push(stack.Pop() - d);
                }
                else if (command == '/')
                {
                    double d = stack.Pop();
                    stack.Push(stack.Pop() / d);
                }
                else if (command == 'c')
                {
                    stack.Clear();
                }
                else if (command == 'q')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Illegal command, ignored");
                }

            }
        }
    }

    
}
