using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OllyHomeworkProject.Util
{
    class Item
    {
        public Random R { get; private set; }
        public string Name { get; protected set; }
        public int CostInCents { get; }
        public int Amount { get; }

        public int TotalCostInCents
        {
            get
            {
                return CostInCents * Amount;
            }
        }

        public decimal TotalCostInDollars
        {
            get
            {
                return Convert.ToDecimal(TotalCostInCents) / Convert.ToDecimal(100);
            }
        }

        public Item(Random r)
        {
            R = r;
            Name = Generator.GetARandomItem(R);
            if (!Name.EndsWith("s")) Name += "s";

            CostInCents = (R.Next(1, 19) * 5); // Value multiples of 5
            Amount = R.Next(4, 10);
        }

        public void Rename()
        {
            Name = Generator.GetARandomItem(R);
        }
    }
}
