using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS2
{
    public  class BankApp
    {
        static void Main(string[] args)
        {
            
            //creating Saving Account
            SavingsAccount savingsAccount = new SavingsAccount("SAV-123456");
            Console.WriteLine("Creating Savings Account: "+savingsAccount.AccountNumber);
            Console.WriteLine("Depositing Amount");
            savingsAccount.Deposit(1000);
            Console.WriteLine("Withdraw Amount");
            savingsAccount.WithDraw(200);
           

            

            //Creating checking accounts
            
            CheckingAccount checkingAccount = new CheckingAccount("CHK-789012");
            Console.WriteLine("Creating Checking Account: "+checkingAccount.AccountNumber);
            Console.WriteLine("Depositing Into Checking Account");
            checkingAccount.Deposit(500);
            Console.WriteLine("Withdreaw Amount");
            checkingAccount.WithDraw(100);



            Console.WriteLine("Transferring Amount between Acounts");
            // Transfer between accounts
            savingsAccount.Transfer(checkingAccount, 300);
            checkingAccount.Transfer(savingsAccount, 150);


        }
    }
}
