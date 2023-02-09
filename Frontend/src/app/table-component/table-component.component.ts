import { Component, Input } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { User, Post, APIEndpoints } from '../app.component';
import { MatDialog } from '@angular/material/dialog';
import { DialogElementsCreateDialog, DialogElementsDeleteDialog, DialogElementsEditDialog, DialogElementsPostsDialog } from '../view-dialog/view-dialog.component';
import { DialogType } from '../app.component';
import { throwError } from 'rxjs';

@Component({
  selector: 'app-table-component',
  templateUrl: './table-component.component.html',
  styleUrls: ['./table-component.component.css']
})

export class TableComponentComponent {
  userList!: User[];
  postsList!: Post[];
  displayedColumnsUser: string[] = ['id', 'firstName', 'lastName', 'email', 'phoneNumber', 'profileViews', 'creationTime', 'view', 'edit', 'delete'];
  displayedColumnsPost: string[] = ['id', 'title', 'content', 'creationTime'];

  @Input()
  userTemplate: boolean = true;

  public constructor(private http: HttpClient, public dialog: MatDialog) {
  }

  ngOnInit() {
    this.GetUserData();
    this.GetPostData();
  }

  public GetUserData() {
    var response = this.http
      .get<User[]>(APIEndpoints.USER_GET_ALL)
      .subscribe(response => {
        this.userList = response;
        console.log(this.userList);
      });
  }

  public GetPostData() {
    var response = this.http
      .get<Post[]>(APIEndpoints.POSTS_GET_ALL)
      .subscribe(response => {
        this.postsList = response;
        console.log(this.userList);
      });
  }

  public UpdateUserData(user: User) {

    console.log("updating user " + user.id + " " + user.email + " " + user.firstName + " " + user.lastName + " " + user.phoneNumber);
    var response = this.http.post<User>(APIEndpoints.USER_UPDATE, user)
      .subscribe(response => {
        console.log("API response: " + response);
      });
  }

  openDialog(type: DialogType, user: User) {

    if (type == DialogType.VIEW) {
      const dialogRef = this.dialog.open(DialogElementsPostsDialog,
        {
          data: user,
        });
    } else if (type == DialogType.EDIT) {
      const dialogRef = this.dialog.open(DialogElementsEditDialog,
        {
          data: user,
        });

      dialogRef.afterClosed().subscribe(result => {
        console.log('The dialog was closed ' + result.data);

        if (result.data != undefined) {
          // we update the API
          this.UpdateUserData(result.data);
          console.log(result.data.firstName);

        }
      });

    } else if (type == DialogType.DELETE) {
      const dialogRef = this.dialog.open(DialogElementsDeleteDialog,
        {
          data: user,
        });

      dialogRef.afterClosed().subscribe(result => {
        console.log('The dialog was closed');
      });
    } else if (type == DialogType.CREATE) {
      const dialogRef = this.dialog.open(DialogElementsCreateDialog,
        {
          data: user,
        });

      dialogRef.afterClosed().subscribe(result => {
        console.log('The dialog was closed');
      });

    }
  }

  private handleError(error: HttpErrorResponse) {
    if (error.status === 0) {
      // A client-side or network error occurred. Handle it accordingly.
      console.error('An error occurred:', error.error);
    } else {
      // The backend returned an unsuccessful response code.
      // The response body may contain clues as to what went wrong.
      console.error(
        `Backend returned code ${error.status}, body was: `, error.error);
    }
    // Return an observable with a user-facing error message.
    return throwError(() => new Error('Something bad happened; please try again later.'));
  }
}