using Pa201LabN5.Data;
using Pa201LabN5.Enums;

namespace Pa201LabN5
{
    internal class Card
    {
        public int Id { get; set; }

        public double Balans { get; set; }

        public double Bonus { get; set; }

        public Bank Bank { get; set; }

        private string _cardNumber;

        public Card(Bank bank, string cardNumber, double balans, double bonus)
        {
            Bank = bank;
            Balans = balans;
            Bonus = bonus;
            CardNumber = cardNumber;
        }

       

        public string CardNumber
        {
            //get
            //{
            //    return _cardNumber;
            //}
            //set
            //{
            //    if (_cardNumber.Length != 16) {
            //        throw new InvalidCardNumberException("Card must be 16-digits");
            //    }
            //     _cardNumber = value;
            //}

            get => _cardNumber;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length != 16)
                    throw new Exception("Card number must be 16 digits");
                _cardNumber = value;
            }
        }

     

        public bool WithDraw(double withDrawAmount)
        {
           
            
            if (withDrawAmount <= Balans)
            {
                Balans -= withDrawAmount;
                return true;
            }
            return false;
        }


        public override string ToString()
        {
            return $"{Id} {Enum.GetName(Bank)} {Balans} {Bonus} {CardNumber}";
        }

        public override bool Equals(object obj)
        {
            if (obj is not Card other)
                return false;

            return Id == other.Id &&
                   Balans == other.Balans &&
                   Bonus == other.Bonus &&
                   CardNumber == other.CardNumber;
        }

    }
}
