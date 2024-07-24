using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    internal class Titanium : ICreditCard
    {
        public int GetCardLimit()
        {
            return 5000;
        }

        public string GetCardNumber()
        {
            return "123456789";
        }

        public string GetCardType()
        {
            return "Titanium";
        }
    }
}
