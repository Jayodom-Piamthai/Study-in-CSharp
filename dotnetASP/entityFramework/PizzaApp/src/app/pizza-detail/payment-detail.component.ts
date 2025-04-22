import { Component,OnInit } from '@angular/core';
import { DetailFormComponent } from "./detail-form/detail-form.component";
import { PaymentDetailService } from '../shared/payment-detail.service';

@Component({
  selector: 'app-pizza-detail',
  imports: [DetailFormComponent],
  templateUrl: './payment-detail.component.html',
  styles: ``
})
export class PaymentDetailComponent implements OnInit{
  constructor(public service: PaymentDetailService) { }
  
  
  ngOnInit(): void {
    // throw new Error('Method not implemented.');
    this.service.refreshList();
  }
}
