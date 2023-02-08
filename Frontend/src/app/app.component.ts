import { Component } from '@angular/core';

export interface User {
  id: number;
  firstName: string;
  lastName: string;
  email: string;
  phoneNumber: string;
  profileViews: number;
  lastLoginTime: string;
  creationTime: string;
  posts: Post[];
}

export interface Post {
  id: number;
  title: string;
  content: string;
  creationTime: string;
}

export enum DialogAction {
  CLOSE = 1,
  SUBMMIT = 2
}

export enum DialogType {
  VIEW = 1,
  EDIT = 2,
  DELETE = 3,
  CREATE = 4
}

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent {
}