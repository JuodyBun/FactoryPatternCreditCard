using System;

namespace FactoryPatternCard
{
    class Program
    {
        static void Main(string[] args)
        {
            CardFactory factory = null;
            Console.Write("Enter the card type you would like to visit - 1 (Gold), 2 (Silver), 3 (Bronze): ");
            string num = Console.ReadLine();
            int card = Convert.ToInt32(num);

            switch (card)
            {
                case 1:
                    factory = new CreditCardFactory.GoldFactory(100000, 300);
                    break;
                case 2:
                    factory = new CreditCardFactory.SilverFactory(50000, 100);
                    break;
                case 3:
                    factory = new CreditCardFactory.BronzeFactory(10000, 0);
                    break;
                default:
                    break;
            }

            CreditCard creditCard = factory.GetCreditCard();
            Console.WriteLine("\nYour card details are below : \n");
            Console.WriteLine("Card Type: {0}\nCredit Limit: {1}\nAnnual Charge: {2}",
                creditCard.CardType, creditCard.CreditLimit, creditCard.AnnualCharge);
            Console.ReadKey();
        }    
    }
}
