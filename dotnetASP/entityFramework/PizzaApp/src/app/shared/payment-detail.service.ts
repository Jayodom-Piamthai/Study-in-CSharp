import { Injectable, Provider } from '@angular/core';
// import { Pizza } from './pizza.model';
// import { PizzaService } from './pizza.service';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { provideHttpClient } from '@angular/common/http';
import { environment } from '../../environments/environment.development';
import { subscribe } from 'diagnostics_channel';

@Injectable({
  providedIn: 'root'
})
export class PaymentDetailService {

  url: string = environment.apiBaseUrl + '/PaymentDetail';

  constructor(private http:HttpClient) { }
  refreshList() {
    this.http.get(this.url).subscribe({
      next: (res) => {
        console.log(res);
      },
      error: (err) => {
        console.error(err);
      }
    }) 
  }
}
