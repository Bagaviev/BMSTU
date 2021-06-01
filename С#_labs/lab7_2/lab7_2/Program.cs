using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_2
{
    class BankAccount
    {
        public static int Number;
        public static double Remain;
        public static string Type;
        public static int Number_cnt = 0;

        public static int numberCnt()
        {
            Number_cnt+=1;
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
            Console.WriteLine(' ');
            
            BankAccount.addInfo(10000, "Кредитный");
            BankAccount.showInfo();
            Console.ReadKey();
        }
    }
}
