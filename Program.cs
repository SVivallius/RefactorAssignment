using Calculator.Classes;
using System;
using System.Text;

namespace CalculatorRPN;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        DoubleStack stack = new DoubleStack();

        while (running)
        {
            stack.RenderStack();

            string input = Console.ReadLine().Trim();
            if (input == "") input = " "; // Prevents null reference in storing the command character.
            char command = input[0];

            if (Char.IsDigit(command))
            {
                double value = Convert.ToDouble(input);
                stack.StackNumeric(value);
            }
            else switch (command)
            {
                case '+': stack.Add(); break;
                case '-': stack.Substract(); break;
                case '*': stack.Multiply(); break;
                case '/': stack.Divide(); break;
                case 'c': stack.ClearStack(); break;
                case 'q': running = false; break;
                default: Console.WriteLine("Illegal command, ignored"); break;
            }
        }
    }
}


