using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class CreditCardFactory
    {

        public static ICreditCard GetCreditCard(string CreditType) {
             ICreditCard creditCard;
            if (CreditType == "MoneyBank")
            {
                creditCard = new MoneyBack();
            }
            else if (CreditType == "Titanium")
            {

                creditCard = new Titanium();
            }
            else if (CreditType == "MoneyBack")
            {
                creditCard = new MoneyBack();
            }
            else {
                creditCard = null;
            }
                return creditCard;
        }
    }
}
