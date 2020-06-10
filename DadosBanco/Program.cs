using System;
using DadosBanco.Entities;
using DadosBanco.Entities.Exceptions;
using System.Globalization;

namespace DadosBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            try { 
                Console.WriteLine("Enter account data: ");
                Console.Write("Number: ");
                int n = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double limit = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Account c = new Account(n,holder,balance,limit);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                c.withdraw(amount);
                Console.WriteLine(c);

            }
            catch(DomainException e)
            {
                Console.WriteLine("Withdraw error: "+ e.Message);
            }
        }
    }
}
