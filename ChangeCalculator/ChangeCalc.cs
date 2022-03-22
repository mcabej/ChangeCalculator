using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator
{
    public static class ChangeCalc
    {
        public static List<string> GetChange(decimal productPrice, decimal payment)
        {
            var changeDue = payment - productPrice;
            var change = new List<string>();

            var fiftyPounds = (int)(changeDue / 50);
            if (fiftyPounds > 0) change.Add($"{fiftyPounds} x £50");
            changeDue %= 50;

            var twentyPounds = (int)(changeDue / 20);
            if (twentyPounds > 0) change.Add($"{twentyPounds} x £20");
            changeDue %= 20;

            var tenPounds = (int)(changeDue / 10);
            if (tenPounds > 0) change.Add($"{tenPounds} x £10");
            changeDue %= 10;

            var fivePounds = (int)(changeDue / 5);
            if (fivePounds > 0) change.Add($"{fivePounds} x £5");
            changeDue %= 5;

            var twoPounds = (int)(changeDue / 2);
            if (twoPounds > 0) change.Add($"{twoPounds} x £2");
            changeDue %= 2;

            var fiftyPence = (int)(changeDue / 0.5M);
            if (fiftyPence > 0) change.Add($"{fiftyPence} x 50p");
            changeDue %= 0.5M;

            var twentyPence = (int)(changeDue / 0.2M);
            if (twentyPence > 0) change.Add($"{twentyPence} x 20p");
            changeDue %= 0.2M;

            var tenPence = (int)(changeDue / 0.1M);
            if (tenPence > 0) change.Add($"{tenPence} x 10p");
            changeDue %= 0.1M;

            var fivePence = (int)(changeDue / 0.05M);
            if (fivePence > 0) change.Add($"{fivePence} x 5p");
            changeDue %= 0.05M;

            var twoPence = (int)(changeDue / 0.02M);
            if (twoPence > 0) change.Add($"{twoPence} x 2p");
            changeDue %= 0.02M;

            var penny = (int)(changeDue / 0.01M);
            if (penny > 0) change.Add($"{penny} x 1p");

            return change;
        }

        public static decimal RequestForMoney(string message)
        {
            while (true)
            {
                Console.WriteLine(message);

                var userInput = Console.ReadLine();

                if (decimal.TryParse(userInput, out var result))
                {
                    return result;
                }

                Console.WriteLine("Invalid value, not a number {0}", userInput);
            }
        }

        public static bool IsPaymentValid(decimal productPrice, decimal payment)
        {
            return payment >= productPrice;
        }
    }
}
