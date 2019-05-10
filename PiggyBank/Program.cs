using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    class Program
    {
        static void Main(string[] args)
        {
            PiggybankEventHandler _eventHandler = null;

            string input = "";
            do
            {
                Console.WriteLine("How much do you want to deposit?");
                if(!int.TryParse(Console.ReadLine(),out int deposit))
                {
                    Console.WriteLine("Please Enter the correct Deposit");
                }

                if(input != "exit")
                {
                    MyPiggyClass mc = new MyPiggyClass();
                    _eventHandler += mc.AddMoneytoPiggyBank;

                    _eventHandler(deposit);

                    Console.WriteLine($"The Balance is {mc.balance}");
                }

            } while (input != "exit");
        }
    }
}
