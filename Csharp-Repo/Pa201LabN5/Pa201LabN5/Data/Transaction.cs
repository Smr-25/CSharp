using System;

namespace Pa201LabN5
{
    internal class Transaction
    {
        public int Id { get; set; }
        public string CardNumber { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }

        public Transaction(int id, string cardNumber, double amount, DateTime date)
        {
            Id = id;
            CardNumber = cardNumber;
            Amount = amount;
            Date = date;
        }

        public override string ToString()
        {
            return $"Transaction Id: {Id}, CardNumber: {CardNumber}, Amount: {Amount}, Date: {Date:yyyy-MM-dd HH:mm:ss}";
        }
    }
}