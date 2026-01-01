/*
    Encapsulation bundles all the data and private direct access to fields which makes it more easy and better for security
    
    In this bank account examples this prevents direct access to the balance field which prevents direct modification and
    and an authorized access of the field
*/

namespace OPP.Encapsulation
{
    public class BankAccount
    {
        private decimal _balance; // Hidden field

        public void Deposit(decimal amount)
        {
            if (amount > 0) _balance += amount; // Logic to protect the data
        }

        public decimal GetBalance() => _balance; // Controlled access
    }
}