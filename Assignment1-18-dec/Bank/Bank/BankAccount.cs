using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class BankAccount
    {
        int accountNumber;
        string accountHolderName;
        double Balance;

        public BankAccount(int accountNumber,string accountHolderName)
        {
            
            this.accountNumber = accountNumber;
            this.accountHolderName = accountHolderName;
            this.Balance = 1000;

        }

        public void Display()
        {
            Console.WriteLine("Account no is = "+accountNumber);
            Console.WriteLine("Account Holder Name is = "+accountHolderName);
            Console.WriteLine("Balance in the account is = " + Balance);
        }
        public void AccountTrans(BankAccount ob,double newBalance)
        {
            ob = new BankAccount(2, "NewName");
            ob.Balance = newBalance;
        }

        public void AccountTransByRef(ref BankAccount ob, double newBalance)
        {
            ob = new BankAccount(2,"NewName");
            ob.Balance = newBalance;
        }
        static void Main(string[] args)
        {
            BankAccount obj = new BankAccount(1, "Prabhat");
            obj.Display();
            Console.WriteLine("Balance after Updating...");
            obj.AccountTrans(obj,2000.11);
            obj.Display();
            Console.WriteLine("Balance after Updating using Ref...");
            obj.AccountTransByRef(ref obj, 8000.11);
            obj.Display();

            Console.Read();
        }
    }
}
