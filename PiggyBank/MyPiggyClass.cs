using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    public delegate int PiggybankEventHandler(int amount);
    public class MyPiggyClass
    {
        public int balance { get; set; }
        public int AddMoneytoPiggyBank(int amount)
        {
            balance += amount;
            return balance;
        }
    }
}
