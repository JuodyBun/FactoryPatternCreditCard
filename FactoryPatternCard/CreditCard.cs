using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternCard
{
    abstract class CreditCard
    {
        public abstract int CardType { get; }
        public abstract int CreditLimit { get; set; }
        public abstract int AnnualCharge { get; set; }
    }
}
