import { Injectable } from '@angular/core';
import { Observable, /*of, throwError*/ } from 'rxjs';
import { HttpClient, HttpHeaders, HttpErrorResponse } from '@angular/common/http';

const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' }),
};

let apiUrl = "http://192.168.4.108:50000/api/";


@Injectable({
  providedIn: 'root'
})
export class ApiService {

  constructor(private http: HttpClient) { }

  getSystemUsers(): Observable<any> {
    return this.http.get<any>("api/Demo");
  }
}
