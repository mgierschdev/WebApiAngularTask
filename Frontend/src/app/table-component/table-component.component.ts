import { Component, Input, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { User, Post } from '../app.component';

@Component({
  selector: 'app-table-component',
  templateUrl: './table-component.component.html',
  styleUrls: ['./table-component.component.css']
})

// @Injectable()
export class TableComponentComponent {
  @Input() userList: User[];
  @Input() postsList: Post[];
  displayedColumnsUser: string[] = ['id', 'firstName', 'lastName', 'email', 'phoneNumber', 'profileViews', 'lastLoginTime', 'creationTime'];
  displayedColumnsPost: string[] = ['id', 'title', 'content', 'creationTime'];
  userTemplate: boolean = true;
  // private API: HttpClient;

  public constructor(/*private httpClient: HttpClient*/) {
    // To be loaded from the backend
    this.userList = this.USER_DATA;
    this.postsList = this.POST_DATA;
    // this.API = httpClient;

    // this.GetUserData();
    // this.GetPosttData();
  }

  public SetUserTemplate(val: boolean) {
    this.userTemplate = val;
  }

  // public GetUserData() {
  //   console.log(this.API.get('https://localhost:7066/User/All'));
  // }

  // public GetPosttData() {
  //   console.log(this.API.get('https://localhost:7066/User/Posts'));
  // }

  USER_DATA: User[] = [
    { id: '1', firstName: 'name', lastName: 'name', email: 'name', phoneNumber: 'name', profileViews: '1', lastLoginTime: '01/01/2023', creationTime: '01/01/2023' },
    { id: '2', firstName: 'name', lastName: 'name', email: 'name', phoneNumber: 'name', profileViews: '1', lastLoginTime: '01/01/2023', creationTime: '01/01/2023' },
    { id: '3', firstName: 'name', lastName: 'name', email: 'name', phoneNumber: 'name', profileViews: '1', lastLoginTime: '01/01/2023', creationTime: '01/01/2023' },
    { id: '4', firstName: 'name', lastName: 'name', email: 'name', phoneNumber: 'name', profileViews: '1', lastLoginTime: '01/01/2023', creationTime: '01/01/2023' },
    { id: '5', firstName: 'name', lastName: 'name', email: 'name', phoneNumber: 'name', profileViews: '1', lastLoginTime: '01/01/2023', creationTime: '01/01/2023' },
    { id: '6', firstName: 'name', lastName: 'name', email: 'name', phoneNumber: 'name', profileViews: '1', lastLoginTime: '01/01/2023', creationTime: '01/01/2023' },
    { id: '7', firstName: 'name', lastName: 'name', email: 'name', phoneNumber: 'name', profileViews: '1', lastLoginTime: '01/01/2023', creationTime: '01/01/2023' },
  ];

  POST_DATA: Post[] = [
    { id: '1', title: 'Post Title', content: 'Content', creationTime: '01/01/2023' },
    { id: '2', title: 'Post Title', content: 'Content', creationTime: '01/01/2023' },
    { id: '3', title: 'Post Title', content: 'Content', creationTime: '01/01/2023' },
    { id: '4', title: 'Post Title', content: 'Content', creationTime: '01/01/2023' },
    { id: '5', title: 'Post Title', content: 'Content', creationTime: '01/01/2023' }
  ];
}