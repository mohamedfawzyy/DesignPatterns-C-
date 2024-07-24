using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    internal class MoneyBack : ICreditCard
    {
        public int GetCardLimit()
        {
            return 8500;
        }

        public string GetCardNumber()
        {
            return "458-4532-45648-33";
        }

        public string GetCardType()
        {
            return "MoneyBack";
        }
    }
}
