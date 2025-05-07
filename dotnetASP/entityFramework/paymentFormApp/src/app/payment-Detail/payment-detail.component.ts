import { Component,OnInit } from '@angular/core';
import { DetailFormComponent } from "./detail-form/detail-form.component";
import { PaymentDetailService } from '../shared/payment-detail.service';
import { NgFor } from '@angular/common';
@Component({
  selector: 'app-pizza-detail',
  imports: [DetailFormComponent,NgFor],
  templateUrl: './payment-detail.component.html',
  styles: ``
})
export class PaymentDetailComponent implements OnInit{
  // payment detail dependency injection!!!!!!
  constructor(public service: PaymentDetailService) { }
  //service is the name of variable to call paymentDetailService
  
  
  ngOnInit(): void {//run on startup
    // throw new Error('Method not implemented.');

    //this method is injected from payment-detail.service.ts
    this.service.refreshList();
  }
}
