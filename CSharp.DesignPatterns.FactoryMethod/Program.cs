using System;

namespace CSharp.DesignPatterns.FactoryMethod
{
    public interface ICreditCard
    {
        int GetCreditCardCharge();
        string GetCreditCardType();
        int GetCreditCardLimit();
    }

    public class VisaCreditCard : ICreditCard
    {
        public int GetCreditCardLimit()
        {
            return 100;
        }

        public int GetCreditCardCharge()
        {
            return 100;
        }

        public string GetCreditCardType()
        {
            return "Visa";
        }
    }

    public class PlatinumCreditCard : ICreditCard
    {
        public int GetCreditCardLimit()
        {
            return 150;
        }

        public int GetCreditCardCharge()
        {
            return 150;
        }

        public string GetCreditCardType()
        {
            return "Platinum";
        }
    }

    public class TitaniumCreditCard : ICreditCard
    {
        public int GetCreditCardLimit()
        {
            return 200;
        }

        public int GetCreditCardCharge()
        {
            return 200;
        }

        public string GetCreditCardType()
        {
            return "Titanium";
        }
    }

    public static class CreditCardFactory
    {
        public static ICreditCard GetCreditCard(string type) {

            ICreditCard creditCard = null;

            if (type.Equals("Visa"))
            {
                creditCard = new VisaCreditCard();
            }

            else if (type.Equals("Platinum"))
            {
                creditCard = new PlatinumCreditCard();
            }

            else if (type.Equals("Titanium"))
            {
                creditCard = new TitaniumCreditCard();
            }

            return creditCard;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string type = "Visa";

            var creditCard = CreditCardFactory.GetCreditCard(type);

            Console.WriteLine("CardType : " + creditCard.GetCreditCardType());
            Console.WriteLine("CreditLimit : " + creditCard.GetCreditCardLimit());
            Console.WriteLine("AnnualCharge :" + creditCard.GetCreditCardCharge());

            Console.ReadLine();
        }
    }
}
