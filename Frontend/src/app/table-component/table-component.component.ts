import { Component, Input } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { User, Post } from '../app.component';
import { MatDialog } from '@angular/material/dialog';
import { DialogElementsPostsDialog } from '../view-dialog/view-dialog.component';

@Component({
  selector: 'app-table-component',
  templateUrl: './table-component.component.html',
  styleUrls: ['./table-component.component.css']
})

export class TableComponentComponent {
  userList!: User[];
  postsList!: Post[];
  displayedColumnsUser: string[] = ['id', 'firstName', 'lastName', 'email',
    'phoneNumber', 'profileViews', 'lastLoginTime', 'creationTime',
    'view', 'edit', 'delete'];
  displayedColumnsPost: string[] = ['id', 'title', 'content', 'creationTime'];

  @Input()
  userTemplate: boolean = true;

  //dialog test 
  name!: string;

  public constructor(private http: HttpClient, public dialog: MatDialog) {
  }

  ngOnInit() {
    this.GetUserData();
    this.GetPostData();
  }

  public GetUserData() {
    var response = this.http
      .get<User[]>("https://localhost:7066/User/All")
      .subscribe(response => {
        this.userList = response;
        console.log(this.userList);
      });
  }

  public GetPostData() {
    var response = this.http
      .get<Post[]>("https://localhost:7066/User/Posts")
      .subscribe(response => {
        this.postsList = response;
        console.log(this.userList);
      });
  }

  openDialog() {
    const dialogRef = this.dialog.open(DialogElementsPostsDialog,
      {
        data: { name: this.name },
      });

    dialogRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed');
    });
  }
}