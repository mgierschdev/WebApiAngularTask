import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { APIEndpoints, DialogType, User } from '../app.component';
import { DialogElementsCreateDialog } from '../view-dialog/view-dialog.component';

@Component({
  selector: 'app-grid-component',
  templateUrl: './grid-component.component.html',
  styleUrls: ['./grid-component.component.css']
})

export class GridComponentComponent {
  title = 'Example .Net 0.6 CRUD';
  today: number = Date.now();

  public constructor(private http: HttpClient, public dialog: MatDialog) {
  }

  public CreateUser(user: User) {
    var response = this.http.post<User>(APIEndpoints.USER_UPDATE, user)
      .subscribe(response => {
        console.log("API response: " + response);
      });
  }

  public openDialog(type: DialogType) {
    if (type != DialogType.CREATE) {
      return;
    }
    const dialogRef = this.dialog.open(DialogElementsCreateDialog,{});

    dialogRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed');
    });
  }

}