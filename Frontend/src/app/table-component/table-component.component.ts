import { Component, Input } from '@angular/core';
import { User, Post } from '../app.component';

@Component({
  selector: 'app-table-component',
  templateUrl: './table-component.component.html',
  styleUrls: ['./table-component.component.css']
})

export class TableComponentComponent {
  displayedColumns: string[] = ['position', 'name', 'weight', 'symbol'];
  @Input() UserList : User[];
  @Input() PostsList : Post[];
  dataSource : any;

  public constructor(){
    this.UserList = [];
    this.PostsList = [];
  }
}
