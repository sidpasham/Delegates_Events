using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesandEvents
{
    class Program
    {
        static void Main(string[] args)
        {


























            CalculateShippingFee shippingFee;
            string input = "";
            do
            {
                Console.WriteLine("Please Enter the Zone Name");
                input = Console.ReadLine();

                if (input != "exit")
                {
                    var zone = BaseShippingZone.GetShippingZone(input);

                    Console.WriteLine("Please Enter the Price");
                    if(!double.TryParse(Console.ReadLine(), out double price))
                    {
                        Console.WriteLine("The Price Entered is Incorrect. Please Enter the Correct Price");
                    }

                    shippingFee = zone.CalcFee;
                    if (zone.isHighRisk)
                    {
                        shippingFee += delegate (double amount, ref double fee)
                        {
                            fee = fee + 25;
                        };
                    }

                    double shippingCost = 0;
                    shippingFee(price, ref shippingCost);
                    Console.WriteLine($"The shipping Cost {shippingCost}");

                }

            } while (input != "exit");
            
           
        }
    }
}
