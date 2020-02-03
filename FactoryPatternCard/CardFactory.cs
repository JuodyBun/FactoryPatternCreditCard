using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternCard
{
    abstract class CardFactory
    {
        public abstract CreditCard GetCreditCard();
    }
}
