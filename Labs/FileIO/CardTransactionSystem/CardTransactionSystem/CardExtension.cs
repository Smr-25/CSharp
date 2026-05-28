using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pa201LabN5.Enums;

namespace Pa201LabN5
{
    internal static class CardExtension
    {
        public static string MaskCardNumber(this string cardNumber)
        {
            string first4 = cardNumber[..4];
            string last4 = cardNumber[^4..];
            string maskedMiddle = new string('*', cardNumber.Length - 8);

            return first4 + maskedMiddle + last4;

        }

        public static void ExpenseAndGetBonus(this Card card,double expense)
        {
            if(card.Balans >= expense)
            {
                card.Balans -= expense;
            }
            switch ((int)card.Bank)
            {
                case (int)(Bank.Kapital):
                    card.Bonus += card.Bonus * 0.05;
                    break;
                case (int)(Bank.ABB):
                    card.Bonus += card.Bonus * 0.03;
                    break;
                case (int)(Bank.LeoBank):
                    card.Bonus += card.Bonus * 0.04;
                    break;
                default:
                    Console.WriteLine("Bank is wrong");
                    break;
            }

        }
    }
}