using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Model;
using BLL.Common;

namespace BLL.Year3
{
    public class Questions
    {
        private static Random r = new Random();
        public string GenerateQuestion1()
        {
            Item item1 = new Item(r);
            Item item2 = new Item(r);

            while (item1.Name == item2.Name)
            {
                item2.Rename();
            }

            var totalCostInCents = item1.TotalCostInCents + item2.TotalCostInCents;
            var totalCostInDollars = Convert.ToDecimal(totalCostInCents) / Convert.ToDecimal(100);

            var paidAmountInCents = GetPaidAmountInCents(totalCostInCents);
            var paidAmountInDollar = Convert.ToDecimal(paidAmountInCents) / Convert.ToDecimal(100);

            var question = "{0} wants to buy {1} {2} which costs {3}c each and {4} {5} which costs {6}c each. \nIf {0} paid ${7}, how much change would {0} receive?";
            var answer = "Answer: {0}c or ${1:0.00}";

            return string.Format(question, Generator.GetARandomName(r), item1.Amount, item1.Name, item1.CostInCents, item2.Amount, item2.Name, item2.CostInCents, paidAmountInDollar);
            //Console.WriteLine(answer, paidAmountInCents - totalCostInCents, paidAmountInDollar - totalCostInDollars);
        }

        private static int GetPaidAmountInCents(int costInCents)
        {
            var more = r.Next(1, 5) * 500; //Get extra value to add on top of the cost as a paid amount
            var roundedCostInCents = (int)(Math.Ceiling(costInCents / 500.0) * 500); // Round the cost to nearest $5.00 in cents

            return roundedCostInCents + more;
        }

        public string GenerateQuestion2()
        {
            var topNumber = r.Next(30, 90);
            var bottomNumber = r.Next(3, 10);

            return string.Format("{0} x {1} = ", topNumber, bottomNumber);
        }
    }
}
