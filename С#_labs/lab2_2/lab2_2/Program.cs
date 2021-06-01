using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            double x1 = double.Parse(Console.ReadLine());
            
            Console.Write("Введите второе число (можно даже ноль): ");
            double x2 = double.Parse(Console.ReadLine());
            try
            {
                if (x2==0)
                {
                    throw new Exception("Второе число ноль");
                }
                Console.WriteLine("{0} / {1} = {2}", x1, x2, x1 / x2);
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} / {1} = {2}", x1, x2, "inf");
                Console.WriteLine("Сообщение:    {0}\n", ex.ToString());
            }
            Console.ReadKey();
        }
    }
}