using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OPP.Inheritance
{
    public class Account
    {
        public string? AccountNumber { get; set; }
        public decimal Balance { get; protected set; }

        public void Deposit(decimal amount) => Balance += amount;
    }

    public class SavingsAccount : Account
    {
        public decimal InterestRate { get; set; }

        public void ApplyInterest()
        {
            // Accesses 'Balance' from the parent class
            decimal interest = Balance * InterestRate;
            Deposit(interest);
            Console.WriteLine($"Interest of {interest:C} applied.");
        }
    }
}