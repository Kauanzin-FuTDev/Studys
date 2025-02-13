using System;
using System.Collections.Concurrent;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Xml;
using estudos;

namespace MyApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string choice;
            double morecash;
            double lesscash;
            
            Console.Write("Enter the account number: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter the account holder's name:");
            string name = Console.ReadLine();
            Console.Write("Will there be an initial deposit (y/n)?");
            choice = Console.ReadLine();

            Bank bank = new Bank(id, name);
            Choice(bank, choice);

            Console.WriteLine();
            Console.WriteLine(bank);
            Console.WriteLine();

            Console.Write("Enter the deposit amount: ");
            morecash = double.Parse(Console.ReadLine());
            bank.Add_Cash(morecash);

            Console.WriteLine(bank);

            Console.Write("Enter a withdrawal amount: ");
            lesscash = double.Parse(Console.ReadLine());
            bank.Out_cash(lesscash);

            Console.WriteLine(bank);



        }
        static void Choice(Bank bank, string choice)
        {
            double morecash;

            if (choice.ToLower() == "y" || choice.ToLower() == "yes")
            {
                Console.Write("Initial deposit: ");
                morecash = double.Parse(Console.ReadLine());
                bank.Add_Cash(morecash);
            }
        }
}
}