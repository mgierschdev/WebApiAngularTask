import { Component, Input } from '@angular/core';
import { HttpClient, HttpErrorResponse, HttpHeaders } from '@angular/common/http';
import { User, Post, APIEndpoints } from '../app.component';
import { MatDialog } from '@angular/material/dialog';
import { DialogElementsDeleteDialog, DialogElementsEditDialog, DialogElementsPostsDialog } from '../view-dialog/view-dialog.component';
import { DialogType } from '../app.component';
import { throwError } from 'rxjs';

@Component({
  selector: 'app-table-component',
  templateUrl: './table-component.component.html',
  styleUrls: ['./table-component.component.css']
})

export class TableComponentComponent {
  @Input()
  public userList!: User[];
  @Input()
  postsList!: Post[];
  displayedColumnsUser: string[] = ['id', 'firstName', 'lastName', 'email', 'phoneNumber', 'profileViews', 'creationTime', 'view', 'edit', 'delete'];
  displayedColumnsPost: string[] = ['id', 'title', 'content', 'creationTime'];

  @Input()
  userTemplate: boolean = true;

  public constructor(private http: HttpClient, public dialog: MatDialog) {
  }

  public GetUserData() {
    var response = this.http
      .get<User[]>(APIEndpoints.USER_GET_ALL)
      .subscribe(response => {
        this.userList = response;
      });
  }

  public GetPostData() {
    var response = this.http
      .get<Post[]>(APIEndpoints.POSTS_GET_ALL)
      .subscribe(response => {
        this.postsList = response;
      });
  }

  public UpdateUserData(user: User) {
    var response = this.http.post<User>(APIEndpoints.USER_UPDATE, user).subscribe(response => { });
  }

  public DeleteUser(user: User) {
    const options = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json',
      }),
      body: user,
    };

    var response = this.http.delete<User>(APIEndpoints.USER_DELETE, options)
      .subscribe(response => {
        if (response == null) {
          // we refresh the table 
          this.GetUserData();
        }
      });
  }

  public CreateUser(user: User) {
    var response = this.http.post<User>(APIEndpoints.USER_CREATE, user).subscribe(response => { });
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
        if (result.data == undefined) {
          return;
        }
        // we update the API
        this.UpdateUserData(result.data);
      });

    } else if (type == DialogType.DELETE) {
      const dialogRef = this.dialog.open(DialogElementsDeleteDialog,
        {
          data: user,
        });

      dialogRef.afterClosed().subscribe(result => {

        if (result.data == undefined) {
          return;
        }

        this.DeleteUser(result.data);
      });
    }
  }

  private handleError(error: HttpErrorResponse) {
    return throwError(() => new Error('Something bad happened; please try again later.'));
  }
}