import { Component } from '@angular/core';
import {FormGroup,FormControl, Validators ,ReactiveFormsModule} from '@angular/forms';
import { PaymentDetailService } from '../../shared/payment-detail.service';
@Component({
  selector: 'app-detail-form',
  imports: [ReactiveFormsModule],
  templateUrl: './detail-form.component.html',
  styles: ``
})
export class DetailFormComponent {
  //injected payment detail service into this component
  constructor(public PaymentDetailService: PaymentDetailService) { }
  
  paymentFormGroup = new FormGroup({
    paymentDetailId: new FormControl(0), //0 is the default value to this form slot
    cardOwnerName: new FormControl('', Validators.required),
    cardNumber: new FormControl('', [Validators.required, Validators.minLength(16), Validators.maxLength(16)]),
    expirationDate: new FormControl('', [Validators.required, Validators.pattern(/^1[0-2]|(0[1-9])\/?([0-9]{4}|[0-9]{2})$/)]),
    securityCode: new FormControl('', [Validators.required, Validators.minLength(3), Validators.maxLength(4)]),
  });
  
  PaymentDetailSubmit() {
    alert("Payment Detail Submitted");
    console.log("Payment Detail Submitted");
    console.log(this.paymentFormGroup.value);
    this.PaymentDetailService.newUserData(this.paymentFormGroup.value)
    // this.service.sendFormData(this.formData);
  }
}
