using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Collections;
using InternetBanking.Model;
using System;
using System.Linq;


namespace InternetBanking {
[ApiController]
[Route("api/transaction")]
public class TransactionController: ControllerBase
{
    private ITransactionService _transactionService;
    //List<Transaction> tr = new List<Transaction>();
public TransactionController(ITransactionService transactionService){
    _transactionService = transactionService;
//tr.Add(new Transaction() { TransactionId = 1, FullName="prva", TransactionType=0, AccountNumber="120",BankCode="100", IssueDate=new DateTime(2011, 6, 10), Amount=20 });

}


[HttpGet]
public IList<Transaction> GetAll()
{
    return _transactionService.GetTransactions();
}

[HttpGet("{id}")]
public Transaction Get(decimal id)
{
    return _transactionService.GetTransaction(id);
}
[HttpPost]
public void SaveTransaction(Transaction transaction){
    _transactionService.SaveTransaction(transaction);
}
}
}