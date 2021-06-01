using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_1
{
    class Program
    {
      enum Bank_account { Current=1500, Nakopitelny=65000 };
       static void Main(string[] args)
        {
            Console.WriteLine(Bank_account.Current);
            Console.WriteLine((int)Bank_account.Current);
            Console.WriteLine(Bank_account.Nakopitelny);
            Console.WriteLine((int)Bank_account.Nakopitelny);
            Console.ReadKey();
        }
    }
}