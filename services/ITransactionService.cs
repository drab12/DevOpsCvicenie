using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Collections;
using InternetBanking.Model;
using System;
using System.Linq;

public interface ITransactionService
{
IList<Transaction> GetTransactions();
Transaction GetTransaction(decimal id);
void SaveTransaction(Transaction transaction);
}