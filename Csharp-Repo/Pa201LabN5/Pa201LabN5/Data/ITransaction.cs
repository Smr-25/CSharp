using System;
using System.Collections.Generic;

namespace Pa201LabN5
{
    internal interface ITransactionService
    {
        List<Transaction> GetAll();
        void AddTransaction(Transaction transaction);
        List<Transaction> GetTransactionsByCard(string cardNumber);
        List<Transaction> GetTransactionsByDateRange(DateTime startDate, DateTime endDate);
    }
}