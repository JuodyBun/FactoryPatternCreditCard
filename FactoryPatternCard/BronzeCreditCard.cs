using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternCard
{
    class BronzeCreditCard : CreditCard
    {
        private readonly string _cardType;
        private int _creditLimit;
        private int _annualCharge;


        public BronzeCreditCard(int creditLimit, int annualCharge)
        {
            _cardType = "Bronze";
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }

        public override int CardType
        {
            get { return _cardType; }
        }

        public override int CreditLimit
        {
            get { return _creditLimit; }
            set { _creditLimit = value; }
        }

        public override int AnnualCharge
        {
            get { return _annualCharge; }
            set { _annualCharge = value; }
        }
    }
}
