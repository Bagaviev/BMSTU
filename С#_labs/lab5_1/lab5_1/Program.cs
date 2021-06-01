using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_1
{
    class Program
    {
        static int max(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Наибольшее число: {0}", max(a, b));
            Console.ReadKey();
        }
    }
}
