using Pa201LabN5;
using Pa201LabN5.Data;
using Pa201LabN5.Enums;
using System;

// Ensure Data directory and files exist
string dataPath = "C:\\Users\\samiraa\\Desktop\\Lab\\Pa201LabN5\\Pa201LabN5\\Data\\";
if (!Directory.Exists(dataPath))
    Directory.CreateDirectory(dataPath);

string cardsPath = dataPath + "cards.json";
if (!File.Exists(cardsPath))
    File.Create(cardsPath).Dispose();

string transactionsPath = dataPath + "transactions.json";
if (!File.Exists(transactionsPath))
    File.Create(transactionsPath).Dispose();

// Instantiate services
CardService cardService = new();
TransactionService transactionService = new();

// Add a card
cardService.AddCard();

// Add a transaction
var transaction = new Transaction(1, "1234567812345678", 100, DateTime.Now);
transactionService.AddTransaction(transaction);

// Get all transactions
var allTransactions = transactionService.GetAll();
Console.WriteLine("All Transactions:");
foreach (var t in allTransactions)
    Console.WriteLine(t);

// Get transactions by card number
var cardTransactions = transactionService.GetTransactionsByCard("1234567812345678");
Console.WriteLine("Transactions for card 1234567812345678:");
foreach (var t in cardTransactions)
    Console.WriteLine(t);

// Get transactions by date range
var dateRangeTransactions = transactionService.GetTransactionsByDateRange(DateTime.Now.AddDays(-1), DateTime.Now.AddDays(1));
Console.WriteLine("Transactions in date range:");
foreach (var t in dateRangeTransactions)
    Console.WriteLine(t);