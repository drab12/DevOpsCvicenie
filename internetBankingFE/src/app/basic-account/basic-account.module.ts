import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { BasicAccountRoutingModule } from './basic-account-routing.module';
import { TransactionDetailComponent } from './transaction-detail/transaction-detail.component';
import { TransactionListComponent } from './transaction-list/transaction-list.component';


@NgModule({
  declarations: [
    TransactionDetailComponent,
    TransactionListComponent
  ],
  imports: [
    CommonModule,
    BasicAccountRoutingModule
  ]
})
export class BasicAccountModule { }
