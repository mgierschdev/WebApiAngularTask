import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { User } from '../app.component';
import { FormControl, Validators } from '@angular/forms';



export enum FormErrorType {
  EMAIL_ERROR = 1,
  NAME_ERROR = 2,
  PHONE_ERROR = 3
}

// View posts
@Component({
  selector: 'dialog-elements-posts-dialog',
  templateUrl: 'view-dialog.component.html',
})
export class DialogElementsPostsDialog {

  constructor(
    public dialogRef: MatDialogRef<DialogElementsPostsDialog>,
    @Inject(MAT_DIALOG_DATA) public data: User,
  ) { }

  onNoClick(): void {
    this.dialogRef.close();
  }
}

// Edit user 
@Component({
  selector: 'dialog-elements-edit-dialog',
  templateUrl: 'edit-dialog.component.html',
})

export class DialogElementsEditDialog {

  public firstName = new FormControl('');
  public lastName = new FormControl('');
  public phoneNumber = new FormControl('');
  public email = new FormControl('', [Validators.required, Validators.email]);

  constructor(
    public dialogRef: MatDialogRef<DialogElementsEditDialog>,
    @Inject(MAT_DIALOG_DATA) public data: User) { }

  getErrorMessage(type: FormErrorType) {
    if (this.email.hasError('required')) {
      return 'You must enter a value';
    }

    if (type == FormErrorType.EMAIL_ERROR) {
      return this.email.hasError('email') ? 'Not a valid email' : '';
    } else if (type == FormErrorType.NAME_ERROR) {
      return "Not valid";
    } else {
      return "Phone number invalid";
    }
  }

  onNoClick(): void {
    this.dialogRef.close();
  }

  acceptedDialog(user: User) {
    var emailF = this.email.value?.toString();
    var firstNameF = this.firstName.value?.toString();
    var lastNameF = this.lastName.value?.toString();
    var phoneNumberF = this.phoneNumber.value?.toString();

    user.email = emailF != undefined && emailF != "" && this.email.valid ? emailF : user.email;
    user.firstName = firstNameF != undefined && firstNameF != "" && this.firstName ? firstNameF : user.firstName;
    user.lastName = lastNameF != undefined && lastNameF != "" && this.lastName ? lastNameF : user.lastName;
    user.phoneNumber = phoneNumberF != undefined && phoneNumberF != "" && this.phoneNumber ? phoneNumberF : user.phoneNumber;

    this.dialogRef.close({
      data: user
    });
  }
}

// Delete User 
@Component({
  selector: 'dialog-elements-delete-dialog',
  templateUrl: 'delete-dialog.component.html',
})

export class DialogElementsDeleteDialog {
  constructor(
    public dialogRef: MatDialogRef<DialogElementsDeleteDialog>,
    @Inject(MAT_DIALOG_DATA) public data: User,) { }

  acceptedDialog(user: User) {
    this.dialogRef.close({
      data: user
    });
  }

  onNoClick(): void {
    this.dialogRef.close();
  }
}

// Create User 
@Component({
  selector: 'dialog-elements-create-dialog',
  templateUrl: 'create-dialog.component.html',
})

export class DialogElementsCreateDialog {

  public firstName = new FormControl('', [Validators.required]);
  public lastName = new FormControl('', [Validators.required]);
  public phoneNumber = new FormControl('', [Validators.required]);
  public email = new FormControl('', [Validators.required, Validators.email]);

  constructor(
    public dialogRef: MatDialogRef<DialogElementsCreateDialog>,
    @Inject(MAT_DIALOG_DATA) public data: User,
  ) { }

  getErrorMessage() {
    if (this.email.hasError('required')) {
      return 'You must enter a value';
    }
    return this.email.hasError('email') ? 'Not a valid email' : '';
  }

  onNoClick(): void {
    this.dialogRef.close();
  }

  acceptedDialog() {
    var emailF = this.email.value?.toString();
    var firstNameF = this.firstName.value?.toString();
    var lastNameF = this.lastName.value?.toString();
    var phoneNumberF = this.phoneNumber.value?.toString();

    // if any is null we dont close the form 
    if (emailF == "" || firstNameF == "" || lastNameF == "" || phoneNumberF == "") {
      return;
    }

    const userData: User = {
      email: '',
      firstName: '',
      lastName: '',
      phoneNumber: '',
      id: 0,
      profileViews: 0,
      lastLoginTime: '',
      creationTime: '',
      posts: []
    };

    userData.email = emailF != undefined ? emailF : "";
    userData.firstName = firstNameF != undefined ? firstNameF : "";
    userData.lastName = lastNameF != undefined ? lastNameF : "";
    userData.phoneNumber = phoneNumberF != undefined ? phoneNumberF : "";

    if (!this.email.valid || !this.firstName.valid || !this.lastName.valid || !this.phoneNumber.valid) {
      return;
    }

    this.dialogRef.close({
      data: userData
    });
  }
}