using System.Globalization;
using System.Text;
using DadosBanco.Entities.Exceptions;

namespace DadosBanco.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawlLimit { get; set; }
        public Account() { }

        public Account(int number, string holder, double balance, double withdrawlLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawlLimit = withdrawlLimit;
        }

        public void deposit(double amount)
        {
            Balance += amount;
        }

        public void withdraw(double amount)
        {
            if(amount > WithdrawlLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit!");
            }
            if(amount > Balance)
            {
                throw new DomainException("Not enough balance!");
            }
            Balance -= amount;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("New balance: ");
            sb.Append(Balance.ToString("F2",CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
