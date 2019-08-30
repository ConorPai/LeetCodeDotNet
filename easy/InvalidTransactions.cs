//https://leetcode-cn.com/problems/invalid-transactions/
using System;
using System.Collections.Generic;

public class InvalidTransactionsDemo {
    private class Transaction {
        public string name;
        public int time;
        public int amount;
        public string city;
        public string originalString;
    }

    public IList<string> InvalidTransactions(string[] transactions) {
        List<Transaction> _transactions = new List<Transaction>();
        foreach (string transaction in transactions) {
            string[] components = transaction.Split(',');
            Transaction _transaction = new Transaction();
            _transaction.name = components[0];
            _transaction.time = Convert.ToInt32(components[1]);
            _transaction.amount = Convert.ToInt32(components[2]);
            _transaction.city = components[3];
            _transactions.Add(_transaction);
        }
        
        List<string> invalidTransactions = new List<string>();
        for (int i = 0; i < _transactions.Count; ++i) {
            if (_transactions[i].amount > 1000) {
                invalidTransactions.Add(transactions[i]);
                continue;
            }
            for (int j = 0; j < _transactions.Count; ++j) {
                if (Math.Abs(_transactions[i].time - _transactions[j].time) <= 60 && _transactions[i].name == _transactions[j].name && _transactions[i].city != _transactions[j].city) {
                    invalidTransactions.Add(transactions[i]);
                    break;
                }
            }
        }
        
        return invalidTransactions;
    }
}