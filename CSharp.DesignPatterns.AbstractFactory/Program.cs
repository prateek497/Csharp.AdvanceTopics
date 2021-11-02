using System;

namespace CSharp.DesignPatterns.AbstractFactory
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

    public abstract class CreditCardAbstractFactory
    {
        public abstract ICreditCard GetCreditCard(string creditCardType);

        public CreditCardAbstractFactory CreateProduct(string type)
        {
            if (type.Equals("CreditCard")) return new CreditCard();

            return null;
        }

    }

    public class CreditCard : CreditCardAbstractFactory
    {
        public override ICreditCard GetCreditCard(string type)
        {
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
            //Created Credit Card Factory
            var creditCard = new CreditCard().CreateProduct("CreditCard");
            //Created sub factory of credit card
            var visaCreditCard =  creditCard.GetCreditCard("Visa");

            Console.Read();
        }
    }
}
