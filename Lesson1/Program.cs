using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to the Calculator!");
            char key = 'y';
            while(key != 'n')
            {
                Console.WriteLine();
                Console.Write("Enter an operation: ");
                string input = Console.ReadLine();

                string[] split = input.Split(' ');
                double num1 = GetNumber(split[0]);
                char op = GetOperator(split[1]);
                double num2 = GetNumber(split[2]);

                ShowParameters(num1, op, num2);

                double result = CalculateResult(num1, op, num2);

                Console.WriteLine("Resultado: " + result);
                Console.WriteLine();
                Console.Write("Try Again? y/n: ");
                key = Console.ReadKey().KeyChar;
            }
            
        }

        static double CalculateResult(double num1, char op, double num2)
        {
            double retVal = 0;
            switch(op)
            {
                case '+':
                    retVal = num1 + num2;
                    break;
                case '-':
                    retVal = num1 - num2;
                    break;
                case '*':
                    retVal = num1 * num2;
                    break;
                case '/':
                    retVal = num1 / num2;
                    break;
            }
            return retVal;
        }

        static double GetNumber(string text)
        {
            return double.Parse(text);
        }

        static char GetOperator(string text)
        {
            return text[0];
        }

        static void ShowParameters(double number1, char op, double number2)
        {
            
            Console.WriteLine(String.Format("{0}: {1}", "Number 1".PadRight(10), number1));
            Console.WriteLine(String.Format("{0}: {1}", "Operator".PadRight(10), op));
            Console.WriteLine(String.Format("{0}: {1}", "Number 2".PadRight(10), number2));

        }

    }
}
