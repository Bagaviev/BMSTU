using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_4
{
    class Program
    {
        static int Factorial(int a)
        {
            if (a == 0) return 1;
            return a * Factorial(a - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            string a = Console.ReadLine();
            int b = Int32.Parse(a);
            Console.WriteLine("fact=" + Factorial(b));
            Console.ReadKey();
        }
    }
}