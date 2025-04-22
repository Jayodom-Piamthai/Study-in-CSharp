import { Injectable, Provider } from '@angular/core';
// import { Pizza } from './pizza.model';
// import { PizzaService } from './pizza.service';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { provideHttpClient } from '@angular/common/http';
import { environment } from '../../environments/environment.development';
import { subscribe } from 'diagnostics_channel';
import { PaymentDetail } from './payment-detail.model';

@Injectable({
  providedIn: 'root'
})
export class PaymentDetailService {

  url: string = environment.apiBaseUrl + '/PaymentDetail';
  list: PaymentDetail[] = [];

  constructor(private http:HttpClient) { }
  refreshList() {
    this.http.get(this.url).subscribe({
      next: (res) => {
        // console.log(res);
        this.list = res as PaymentDetail[];
      },
      error: (err) => {
        console.error(err);
      }
    }) 
  }
}
