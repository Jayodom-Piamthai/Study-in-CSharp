import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { PaymentDetailComponent } from './payment-Detail/payment-detail.component';
import { DetailFormComponent } from './payment-Detail/detail-form/detail-form.component';

@Component({
  selector: 'app-root',
  imports: [ PaymentDetailComponent],
  templateUrl: './app.component.html',
  styles: [],
})
export class AppComponent {
  title = 'PizzaApp';
}
