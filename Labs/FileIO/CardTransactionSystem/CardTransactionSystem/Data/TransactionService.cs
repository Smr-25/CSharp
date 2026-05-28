using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Pa201LabN5;

namespace Pa201LabN5.Data
{
    internal class TransactionService : ITransactionService
    {
        string path = "C:\\Users\\samiraa\\Desktop\\Lab\\Pa201LabN5\\Pa201LabN5\\Data\\transactions.json";
        public List<Transaction> Transactions { get; set; } = [];

        public TransactionService()
        {
            
        }

        private void LoadTransactions()
        {
            if (!File.Exists(path))
            {
                Transactions = [];
                return;
            }

            string json;
            using (FileStream fileStream = new FileStream(path, FileMode.Open))
            using (StreamReader reader = new StreamReader(fileStream))
                json = reader.ReadToEnd();

            if (string.IsNullOrWhiteSpace(json))
                Transactions = [];
            else
                Transactions = JsonSerializer.Deserialize<List<Transaction>>(json) ?? [];
        }

        private void SaveTransactions()
        {
            string json = JsonSerializer.Serialize(Transactions);
            using FileStream fileStream = new FileStream(path, FileMode.Create);
            using StreamWriter writer = new StreamWriter(fileStream);
            writer.Write(json);
        }

        public List<Transaction> GetAll()
        {
            LoadTransactions();
            return Transactions;
        }

        public void AddTransaction(Transaction transaction)
        {
            LoadTransactions();
            Transactions.Add(transaction);
            SaveTransactions();
        }

        public List<Transaction> GetTransactionsByCard(string cardNumber)
        {
            LoadTransactions();
            return Transactions.Where(t => t.CardNumber == cardNumber).ToList();
        }

        public List<Transaction> GetTransactionsByDateRange(DateTime startDate, DateTime endDate)
        {
            LoadTransactions();
            return Transactions
                .Where(t => t.Date >= startDate && t.Date <= endDate)
                .ToList();
        }
    }
}