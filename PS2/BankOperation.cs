using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS2
{
    abstract class Account
    {
        private string accNo;

        public string AccountNumber
        {
            get {  return accNo; }
           private set { accNo = value; }
        }

        public decimal Balance { get; protected set; }

        public Account(string accountno)
        {
            AccountNumber = accountno;
            Balance = 0;
           
        }

        public virtual void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited: {amount} Current Balance: {Balance}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invalid Amount");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public virtual void WithDraw(decimal amount)
        {
            if (amount > 0 && Balance>amount) 
            {
                Balance -= amount;
                Console.WriteLine($"Amount Withdrawl is: {amount} Balance is: {Balance}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
                Console.WriteLine();
            }
            Console.WriteLine();
        }


        public abstract void Transfer(Account destinationaccount, decimal amount);

    }

    class SavingsAccount : Account
    {
        public SavingsAccount(string acountNumber) : base(acountNumber) { }

        public override void Transfer(Account destinationaccount, decimal amount)
        {
            if(amount>0 && Balance>=amount)
            {
                Balance -= amount;
                destinationaccount.Deposit(amount);
                Console.WriteLine($"Transferred: {amount} to account: {destinationaccount.AccountNumber}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invalid transfer amount or Insufficient Balance");
            }
            Console.WriteLine();
        }
    }

    class CheckingAccount : Account
    {
        public CheckingAccount(string accountNumber) : base(accountNumber) { }

        public override void Transfer(Account destinationaccount, decimal amount)
        {
            if(amount> 0 && Balance>=amount ) 
            {
                Balance -= amount;
                destinationaccount.Deposit(amount);
                Console.WriteLine($"Transferred: {amount} to Account :{destinationaccount.AccountNumber} Current Balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Invalid Transfer Amount or Insufficient Balance");
            }
            Console.WriteLine();
        }
    }
}
