using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
   
namespace ConsoleApplication18
{
    class Program
    {
        static void Main(string[] args)
        {
            Account ac=new Account("12345",2002,1000);
            Account ac1 = new Account("12346", 2822, 1000);
            Account ac2 = new Account("12347",2004,1000);

            ATM am = new ATM();
            am.AddAccount(ac);
            am.AddAccount(ac1);
            am.AddAccount(ac2);

            Console.WriteLine("enter your account no");
            string accno = Console.ReadLine();
            Console.WriteLine("enter the pin");
            int pin = int.Parse(Console.ReadLine());

            if (am.IsValidpin(accno, pin) == true)
            {
                while (true)
                {
                    am.DisplayMenu(accno);
                }
            }
            else
            {
                Console.WriteLine("Incorrenct username/password");
            }

        }
    }
}
