using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class AccountTest
    {
        static void Main(string[] args)
        {
            Account account1 = new Account(50M);
            Account account2 = new Account( -7.53M );
            Console.WriteLine("account1 balance: {0:C}\n",account1.Balance);
            Console.WriteLine("account2 balance: {0:C}\n",account2.Balance);
            decimal depositAmount;
            Console.WriteLine("Enter deposit amount for account1:");
            depositAmount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("adding {0:C} to account1 balance\n", depositAmount);
            account1.Credit(depositAmount);
            Console.WriteLine("account1 balance: {0:C}\n", account1.Balance);
            Console.WriteLine("account2 balance: {0:C}\n", account2.Balance);
            Console.WriteLine("Enter deposit amount for account2:");
            depositAmount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("adding {0:C} to account2 balance\n", depositAmount);
            account2.Credit(depositAmount);
            Console.WriteLine("account1 balance: {0:C}\n", account1.Balance);
            Console.WriteLine("account2 balance: {0:C}\n", account2.Balance);
        }
    }
}
