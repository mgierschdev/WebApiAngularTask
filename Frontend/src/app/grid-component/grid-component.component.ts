import { Component } from '@angular/core';
import { TableComponentComponent } from '../table-component/table-component.component';

export interface Tile {
  color: string;
  cols: number;
  rows: number;
  text: string;
}

@Component({
  selector: 'app-grid-component',
  templateUrl: './grid-component.component.html',
  styleUrls: ['./grid-component.component.css']
})

export class GridComponentComponent {
  title = 'Example .Net 0.6 CRUD';
  today: number = Date.now();
  displayedColumns: string[] = ['position', 'name', 'weight', 'symbol'];
}
