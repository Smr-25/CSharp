using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pa201LabN5
{
    internal interface ICardService
    {
        public void GetCards();
        public void AddCard();
        public void GetCardByCardNumber(string cardNumber);
    }
}
