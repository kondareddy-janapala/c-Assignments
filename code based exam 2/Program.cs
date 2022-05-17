using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_based_exam_2
{
    public delegate int Calc(int value1, int value2);
    class Program
    {
        static void Main(string[] args)
        {
            Calc add = (a, b) => a + b;
            Console.WriteLine("Additoin: " + add(10, 20));
            Calc sub = (a, b) => a - b;
            Console.WriteLine("Subtraction: " + sub(10, 20));
            Calc mul = (a, b) => a * b;
            Console.WriteLine("Multiplication: " + mul(10, 20));
            Console.ReadLine();     
        }

    }
}
