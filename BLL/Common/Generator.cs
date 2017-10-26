using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Data;

namespace BLL.Common
{
    public static class Generator
    {
        public static string GetARandomItem(Random r)
        {
            return ShopItems.Groceries[r.Next(1, ShopItems.Groceries.Length)];
        }

        public static string GetARandomName(Random r)
        {
            string name;

            var names = Names.MaleNameList.Union<string>(Names.FemaleNameList).ToArray<string>();
            name = names[r.Next(1, names.Length)];

            return name;
        }
    }
}
