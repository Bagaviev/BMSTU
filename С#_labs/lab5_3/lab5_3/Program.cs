using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_3
{
    class Program
    {
        static bool fact(ref int num)
        {
            int c = num;
            num = 1;
            for (int i = 1; i <= c; i++)
                try
                {
                    checked
                    {
                        num *= i;
                    }
                }
                catch { return false; }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число для которого нужен факториал: ");
            int a = Convert.ToInt32(Console.ReadLine());
            bool flag = fact(ref a);
            Console.WriteLine(Convert.ToString(flag) + " " + Convert.ToString(a));

            int gap = 5000;
            System.Threading.Thread.Sleep(gap);

            int x = 1;
            while (true)
            {
                Random rnd = new Random();
                int gap1 = rnd.Next(200, 2000);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("These likes for dash.guss: {0}", x);
                System.Threading.Thread.Sleep(gap1);
                x++;
                Console.Clear();
            }
        }
    }
}
