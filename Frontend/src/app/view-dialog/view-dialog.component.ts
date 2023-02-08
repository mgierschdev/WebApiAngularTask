import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { User } from '../app.component';


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
  constructor(
    public dialogRef: MatDialogRef<DialogElementsPostsDialog>,
    @Inject(MAT_DIALOG_DATA) public data: User,
  ) { }
  onNoClick(): void {
    this.dialogRef.close();
  }
}

// Delete User 
@Component({
  selector: 'dialog-elements-posts-dialog',
  templateUrl: 'delete-dialog.component.html',
})
export class DialogElementsDeleteDialog {
  constructor(
    public dialogRef: MatDialogRef<DialogElementsPostsDialog>,
    @Inject(MAT_DIALOG_DATA) public data: User,
  ) { }
  onNoClick(): void {
    this.dialogRef.close();
  }
}

// Create User 
@Component({
  selector: 'dialog-elements-posts-dialog',
  templateUrl: 'create-dialog.component.html',
})
export class DialogElementsCreateDialog {
  constructor(
    public dialogRef: MatDialogRef<DialogElementsPostsDialog>,
    @Inject(MAT_DIALOG_DATA) public data: User,
  ) { }
  onNoClick(): void {
    this.dialogRef.close();
  }
}