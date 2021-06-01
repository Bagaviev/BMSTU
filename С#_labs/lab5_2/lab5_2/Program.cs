using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_2
{
    class Program
    {

        static void f(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} {1}", a, b);
            f(ref a, ref b);
            Console.WriteLine("{0} {1}", a, b);
            Console.ReadKey();
        }
    }
}