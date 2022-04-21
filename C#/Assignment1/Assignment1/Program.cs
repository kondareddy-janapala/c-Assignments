using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter integer 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter integer 2: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Two integers are equql");
            }
            else
            {
                Console.WriteLine("Two integers are not equal");
            }

            int number;
            Console.WriteLine("enter the numbers to check whether it is positive or negative");
            number = int.Parse(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine("given number is positive");
            }
            else
            {
                Console.WriteLine("given number is negative");
            }
            int number1, number2, result;
            char operation;
            Console.WriteLine("enter the first number: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the second number: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1 addition");
            Console.WriteLine("2 subtration");
            Console.WriteLine("3 multiplication");
            Console.WriteLine("4 division");
            operation = Convert.ToChar(Console.ReadLine());
            switch (operation)
            {
                case '1':
                    result = number1 + number2;
                    Console.WriteLine("the addition of two numbers is : {0}", result);
                    break;
                case '2':
                    result = number1 - number2;
                    Console.WriteLine("the subtraction of two numbers is : {0}", result);
                    break;
                case '3':
                    result = number1 * number2;
                    Console.WriteLine("the multiplication of two numbers is : {0}", result);
                    break;
                case '4':
                    result = number1 / number2;
                    Console.WriteLine("the division of two numbers is : {0}", result);
                    break;
                default:
                    Console.WriteLine("invalid operator");
                    break;

            }
            Console.ReadLine();
        }
    }
}
