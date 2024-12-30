using System;
using System.Collections.Generic;  
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class ATM
    {
        Dictionary<string, Account> accounts ;
        public ATM()
        {
            accounts = new Dictionary<string, Account>();
        }
        public void AddAccount(Account account)
        {
            accounts.Add(account.accountno,account);
        }
        public bool IsValidpin(string acno, int pinnumber)
        {
            return accounts[acno].pin == pinnumber;
        }
        public void DisplayMenu(string accountno)
        {
            Console.WriteLine("1.Deposit");
            Console.WriteLine("2.Withdraw");
            Console.WriteLine("3.check balance");
            Console.WriteLine("4.transaction History");
            Console.WriteLine("5.exit");

            Console.WriteLine("enter the amount");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            { 
                case 1:
                    Console.WriteLine("enter the amount");
                    int amount = int.Parse(Console.ReadLine());
                    accounts[accountno].Deposit(amount);
                    break;
                case 2:
                    Console.WriteLine("enter the amount");
                    int withamount = int.Parse(Console.ReadLine());
                    accounts[accountno].Deposit(withamount);
                    break;

                case 3:
                    Console.WriteLine(accounts[accountno].GetBalance());
                    break;
                case 4:
                    foreach (var tran in accounts[accountno].transationHistory)
                    {
                        Console.WriteLine(tran);
                    }
                    break;   
                case 5:
                    System.Environment.Exit(0);
                    break;
            }


              

        }


    }
}
