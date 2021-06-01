using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_1
{
    class BankAccount
    {
        public static int Number;
        public static double Remain;
        public static string Type;

        public static void addInfo(int newNumber, double newRemain, string newType)
        {
            Remain = newRemain;
            Number = newNumber;
            Type = newType;
        }

        public static void showInfo()
        {
            Console.WriteLine(BankAccount.Remain);
            Console.WriteLine(BankAccount.Number);
            Console.WriteLine(BankAccount.Type);
        }
    }
    class Program
    {
        static void Main()
        {
            BankAccount account = new BankAccount();
            BankAccount.addInfo(111, 500, "Сберегательный");
            BankAccount.showInfo();
            Console.ReadKey();
        }
    }
}
