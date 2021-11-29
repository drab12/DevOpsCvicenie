import { Component, OnInit } from '@angular/core';
import { RestTransactionService } from '../../services/RestTransactionService';
import { from, Observable } from 'rxjs';
import { tap } from 'rxjs/operators';
@Component({
  selector: 'app-transaction-list',
  templateUrl: './transaction-list.component.html',
  styleUrls: ['./transaction-list.component.scss']
})
export class TransactionListComponent implements OnInit {
  transactions: any[] = [];

  constructor(transactionService: RestTransactionService) {
    transactionService.getTransactionList$().pipe(
      tap(x => this.transactions = x)
    ).subscribe(list => console.log(list));
   }

  ngOnInit(): void {
  }

}
