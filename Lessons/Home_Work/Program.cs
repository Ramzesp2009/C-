using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool status = true;
            while (status)
            {
                Console.Clear();
                Console.WriteLine("Here is the simple calculator");
                Console.WriteLine("Please enter the number 1 then operator (+, -, /, *, **, %, sqrt, exit, help) and then number 2: ");

                double val1, val2;
                double.TryParse(Console.ReadLine(), out val1);
                string op = Console.ReadLine();
                double.TryParse(Console.ReadLine(), out val2);

                if (val1 != double.NaN || val2 != double.NaN)
                {
                    Console.WriteLine("You got not a number");
                }

                switch (op)
                {
                    case "+":
                        Add(val1, val2);
                        break;
                    case "-":
                        Subtract(val1, val2);
                        break;
                    case "*":
                        Multiply(val1, val2);
                        break;
                    case "/":
                        Divide(val1, val2);
                        break;
                    case "%":
                        Modulus(val1, val2);
                        break;
                    case "sqrt":
                        SquareRoot(val1);
                        break;
                    case "^":
                        Exponent(val1, val2);
                        break;
                    case "exit":
                        status = false;
                        break;
                    case "help":
                        Console.WriteLine("You can use the following operators: +, -, *, /, %, sqrt, ^");
                        break;
                    default:
                        Console.WriteLine("Unknown operator");
                        break;
                }
                Console.WriteLine("Do you want to continue? (y/n)");
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    Console.WriteLine("OK, let's continue");
                    System.Threading.Thread.Sleep(2000);
                }
                else if (answer == "n")
                {
                    status = false;
                    Console.WriteLine("OK, bye");
                }
                else
                {
                    Console.WriteLine("The answer wasn't understand, so let's continue.");
                    System.Threading.Thread.Sleep(2000);
                }
            }

            
        }
        static void Add(double a, double b) => Console.WriteLine(a + b);

        static void Subtract(double a, double b) => Console.WriteLine(a - b);
        
        static void Multiply(double a, double b) => Console.WriteLine(a * b);

        static void Divide(double a, double b)
        {
            if (b != 0)
            {
                Console.WriteLine(a / b);
            }
            Console.WriteLine("Division by zero isn't possible");
        }

        static void Modulus(double a, double b)
        {
            if (b != 0)
            {
                Console.WriteLine(a % b);
            }
            Console.WriteLine("Modulus by zero isn't possible");
        }

        static void SquareRoot(double a)
        {
            if (a >= 0)
            {
                Console.WriteLine(Math.Sqrt(a));
            }
            Console.WriteLine("Square root of negative number isn't possible");
        }

        static void Exponent(double a, double b)
        {
            Console.WriteLine(Math.Pow(a, b));
        }
    }
}
