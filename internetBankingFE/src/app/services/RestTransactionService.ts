import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";

interface ITransaction {
    getTransactionList$:()=> Observable<any>
    getTransactionDetail$:(id: number) => Observable<any>
}

@Injectable({
    providedIn: "root"
})
export class RestTransactionService implements ITransaction {
    constructor(private http: HttpClient) {}

    getTransactionList$(): Observable<any> {
        return this.http.get("/api/transaction");
    }

    getTransactionDetail$(id: number): Observable<any> {
        return this.http.get('api/transaction/$(id)');
    }
}