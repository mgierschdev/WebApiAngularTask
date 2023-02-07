import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Frontend';
}

// Get the current date and time as a date-time value.
export class DatePipeComponent {
  today: number = Date.now();
}