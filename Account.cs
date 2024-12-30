using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication18
{
    class Account
    {
        public string accountno { get; set;}
        public int pin { get; set;}
        public double balance { get; set;}
        public List<string> transationHistory;

        public Account(string accountno, int pin, double balance)
        {
            this.accountno = accountno;
            this.pin = pin;
            this.balance = balance;
            transationHistory = new List<string>(); 
        }
        public void Withdraw(double amount)
        {
            if (amount < balance)
            {
                balance = balance = amount;
                transationHistory.Add(DateTime.Now + "withdraw:" + amount);
            }
            else
            {
              Console.WriteLine("insufficient balance");
            }
        }
        public void Deposit(double amount)
        {
            balance = balance + amount;
            transationHistory.Add(DateTime.Now + "Deposit:" + amount);
        }
        public double GetBalance()
        {
            return balance;
        }

    }
}
