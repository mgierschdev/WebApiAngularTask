import { HttpClient } from '@angular/common/http';
import { Component, Input } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { APIEndpoints, DialogType, Post, User } from '../app.component';
import { DialogElementsCreateDialog } from '../view-dialog/view-dialog.component';

@Component({
  selector: 'app-grid-component',
  templateUrl: './grid-component.component.html',
  styleUrls: ['./grid-component.component.css']
})

export class GridComponentComponent {
  title = 'Example .Net 0.6 CRUD';
  today: number = Date.now();
  @Input()
  public userList!: User[];
  @Input()
  public postsList!: Post[];

  public constructor(private http: HttpClient, public dialog: MatDialog) {
  }

  ngOnInit() {
    this.GetUserData();
    this.GetPostData();
  }

  public CreateUser(user: User) {
    var response = this.http.post<User>(APIEndpoints.USER_CREATE, user).subscribe(response => { 
      this.GetUserData();
    });
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

  public openDialog(type: DialogType) {
    if (type != DialogType.CREATE) {
      return;
    }
    const dialogRef = this.dialog.open(DialogElementsCreateDialog, {});

    dialogRef.afterClosed().subscribe(result => {
      if (result.data == undefined) {
        return;
      }
      //create user
      this.CreateUser(result.data);
    });
  }
}