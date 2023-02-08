import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { User } from '../app.component';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { DialogAction } from '../app.component';

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

  getErrorMessage() {
    if (this.email.hasError('required')) {
      return 'You must enter a value';
    }
    return this.email.hasError('email') ? 'Not a valid email' : '';
  }

  onNoClick(): void {
    this.dialogRef.close();
  }

  acceptedDialog(user: User) {

    var emailF = this.email.value?.toString();
    var firstNameF = this.firstName.value?.toString();
    var lastNameF = this.lastName.value?.toString();
    var phoneNumberF = this.phoneNumber.value?.toString();

    user.email = emailF != undefined ? emailF : user.email;
    user.firstName = firstNameF != undefined ? firstNameF : user.firstName;
    user.lastName = lastNameF != undefined ? lastNameF : user.lastName;
    user.phoneNumber = phoneNumberF != undefined ? phoneNumberF : user.phoneNumber;

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
    @Inject(MAT_DIALOG_DATA) public data: User,
  ) { }
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
  constructor(
    public dialogRef: MatDialogRef<DialogElementsCreateDialog>,
    @Inject(MAT_DIALOG_DATA) public data: User,
  ) { }
  onNoClick(): void {
    this.dialogRef.close();
  }
}