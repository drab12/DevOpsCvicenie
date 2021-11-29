using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Collections;
using InternetBanking.Model;
using System;
using System.Linq;
using InternetBanking.Repositories;

public class TransactionService: ITransactionService
{
private ITransactionRepository _transactionRepository;
public TransactionService(){
_transactionRepository = new TransactionRepository();
}
public IList<Transaction> GetTransactions()
{
return _transactionRepository.GetTransactions().ToList();
}
public Transaction GetTransaction(decimal id)
{
return _transactionRepository.GetTransactions()

.FirstOrDefault(x=>x.TransactionId == id);

}
public void SaveTransaction(Transaction transaction)
{
_transactionRepository.CreateTransaction(transaction);
}
}