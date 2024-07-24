using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public interface ICreditCard
    {
        public string GetCardType();
        public string GetCardNumber();
        public int GetCardLimit();
    }
}
