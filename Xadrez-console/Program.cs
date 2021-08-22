using System;
using Xadrez_console.Entites;

namespace Xadrez_console
{
    class Program
    {
       static void Main(string[] args)
        {
            Account acc1 = new Account(1234, "Keverson", 500.0);
            Account acc2 = new BusinessAccount(4321, "Leila", 500.0, 200.0);

            acc1.Withhdraw(10.0);
            acc2.Withhdraw(10.0);

            Console.WriteLine("Saque na classe Account: " + acc1.Balance);
            Console.WriteLine("Saque na classe BusinessAccount: " + acc2.Balance);
        }

        

    }

}