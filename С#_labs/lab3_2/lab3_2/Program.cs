using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_2
{
    public struct Bank_account 
    {
        public int number;
        public string type;
        public int balance;
    } 
    class Program
    {
        static void Main(string[] args)
        {
            Bank_account some_account; //объявление переменной
            some_account.number = 1; //установка значений
            some_account.type = "Debit";
            some_account.balance = 35000;

            Console.WriteLine(some_account.number);
            Console.WriteLine(some_account.type);
            Console.WriteLine(some_account.balance);
            Console.ReadKey();
        }
    }
}
