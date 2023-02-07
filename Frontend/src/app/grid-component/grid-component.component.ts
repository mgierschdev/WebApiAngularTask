import { Component } from '@angular/core';
import { User } from '../app.component';

@Component({
  selector: 'app-grid-component',
  templateUrl: './grid-component.component.html',
  styleUrls: ['./grid-component.component.css']
})

export class GridComponentComponent {
  title = 'Example .Net 0.6 CRUD';
  today: number = Date.now();
}