using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    internal class Platinum : ICreditCard
    {
        public int GetCardLimit()
        {
            return 20000;
        }

        public string GetCardNumber()
        {
            return "456-123-458";
        }

        public string GetCardType()
        {
            return "Paltinum";
        }
    }
}
