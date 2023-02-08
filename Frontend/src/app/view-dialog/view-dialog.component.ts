import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { User } from '../app.component';

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