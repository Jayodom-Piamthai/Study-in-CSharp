import { Injectable, Provider } from '@angular/core';
// import { Pizza } from './pizza.model';
// import { PizzaService } from './pizza.service';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { provideHttpClient } from '@angular/common/http';
import { environment } from '../../environments/environment.development';
import { subscribe } from 'diagnostics_channel';
import { PaymentDetail } from './payment-detail.model';

//exporting the service so that it can be used in other components
//by dependency injectionnnnnn
//this will be injected into payment-detail.component.ts
@Injectable({
  providedIn: 'root'
})
export class PaymentDetailService {

  //url for the page with api
  url: string = environment.apiBaseUrl + '/PaymentDetail';
  list: PaymentDetail[] = [];

  //injectorception - injecting the http client into the service from httpClient module
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
  newUserData(userData: PaymentDetail) {
    console.log(userData);
    return this.http.post(this.url, userData);
  }
}
