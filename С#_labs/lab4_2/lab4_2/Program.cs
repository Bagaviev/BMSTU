using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_2
{
    class Program
    {
        static void Method1()
        {
            Console.WriteLine("Введите число:");
            Console.Write("num = ");// Вводим х

            int x = Convert.ToInt32(Console.ReadLine());
            if (x > 0 && x < 366)
            {
                int year = DateTime.Now.Year; //Or any year you want
                DateTime theDate = new DateTime(year, 1, 1).AddDays(x - 1);
                string b = theDate.ToString("d.M.yyyy");   // The date in requested format
                Console.WriteLine(b);
                double y1 = (double)year % 4.0;
                double y2 = (double)year % 100.0;
                double y3 = (double)year % 400.0;
                if (y1 == 0 && y2 > 0 && y3 > 0)
                {
                    Console.WriteLine("Год високосный");
                }
            }
            else
            {
                Console.WriteLine("Числа введены не верно");
            }
        }
        static void Main(string[] args)
        {
            Method1();
            Console.ReadKey();
        }
    }
}
