using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternCard
{
    class CreditCardFactory 
    {
        public class BronzeFactory : CardFactory
        {
            private int _creditLimit;
            private int _annualCharge;

            public BronzeFactory(int creditLimit, int annualCharge)
            {
                _creditLimit = creditLimit;
                _annualCharge = annualCharge;
            }

            public override CreditCard GetCreditCard()
            {
                return new BronzeCreditCard(_creditLimit, _annualCharge);
            }
        }

        public class SilverFactory : CardFactory
        {
            private int _creditLimit;
            private int _annualCharge;

            public SilverFactory(int creditLimit, int annualCharge)
            {
                _creditLimit = creditLimit;
                _annualCharge = annualCharge;
            }

            public override CreditCard GetCreditCard()
            {
                return new SilverCreditCard(_creditLimit, _annualCharge);
            }
        }

        public class GoldFactory : CardFactory
        {
            private int _creditLimit;
            private int _annualCharge;

            public GoldFactory(int creditLimit, int annualCharge)
            {
                _creditLimit = creditLimit;
                _annualCharge = annualCharge;
            }

            public override CreditCard GetCreditCard()
            {
                return new GoldCreditCard(_creditLimit, _annualCharge);
            }
        }
    }
}
