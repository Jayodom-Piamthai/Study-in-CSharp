import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { PaymentDetailComponent } from './pizza-detail/payment-detail.component';
import { DetailFormComponent } from "./pizza-detail/detail-form/detail-form.component";

@Component({
  selector: 'app-root',
  imports: [ PaymentDetailComponent],
  templateUrl: './app.component.html',
  styles: [],
})
export class AppComponent {
  title = 'PizzaApp';
}
