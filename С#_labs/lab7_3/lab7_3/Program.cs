using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_3
{
    class BankAccount
    {
        public static int Number;
        public static double Remain;
        public static string Type;
        public static int Number_cnt = 0;

        public static double credit(double Amount)
        {
            if (Remain >= Amount)
            {
                Remain -= Amount;
                Console.WriteLine(">Успешно");
            }
            else
                Console.WriteLine(">Недостаточно средств...");
            return Remain;
        }
        public static double debit(double Amount)
        {
            Remain += Amount;
            Console.WriteLine(">Успешно");
            return Remain;
        }

        public static int numberCnt()
        {
            Number_cnt += 1;
            return Number_cnt;
        }

        public static void addInfo(double newRemain, string newType)
        {
            Number = numberCnt();
            Remain = newRemain;
            Type = newType;
        }

        public static void showInfo()
        {
            Console.Write(BankAccount.Number);
            Console.Write(' ');
            Console.Write(BankAccount.Type);
            Console.Write(' ');
            Console.Write(BankAccount.Remain);
            Console.Write(' ');
        }
    }
    class Program
    {
        static void Main()
        {
            BankAccount account = new BankAccount();

            BankAccount.addInfo(27300, "Сберегательный");
            BankAccount.showInfo();
            Console.WriteLine("\n");

            Console.WriteLine("Пытаемся снять 30000");
            Console.WriteLine("Остаток: {0}", BankAccount.credit(30000));

            Console.WriteLine("Добавляем 2700");
            Console.WriteLine("Остаток: {0}", BankAccount.debit(2700));

            Console.WriteLine("Пытаемся снять 30000");
            Console.WriteLine("Остаток: {0}", BankAccount.credit(30000));
            Console.ReadKey();
        }
    }
}
