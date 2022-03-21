using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ChangeCalculator.ChangeCalc;

namespace ChangeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var productPrice = RequestForMoney("Product Price:");
            var payment = RequestForMoney("Payment Received:");

            while (!IsPaymentValid(productPrice, payment))
            {
                Console.WriteLine();
                Console.WriteLine("Payment Insufficient...");
                payment = RequestForMoney("Payment Received:");
            }

            var change = GetChange(productPrice, payment);

            Console.WriteLine();

            if (change.Count > 0)
            {
                Console.WriteLine("Your change is:");

                foreach (var c in change)
                {
                    Console.WriteLine(c);
                }
            }
            else
            {
                Console.WriteLine("No change for you...");
            }
        }
    }
}

