import {Component} from '@angular/core';
import {MatDialog} from '@angular/material/dialog';

@Component({
  selector: 'app-view-dialog',
  templateUrl: 'view-dialog.component-button.html'
})

export class ViewDialogComponent {
  constructor(public dialog: MatDialog) { }

  openDialog() {
    this.dialog.open(DialogElementsExampleDialog);
  }
}

@Component({
  selector: 'dialog-elements-example-dialog',
  templateUrl: 'view-dialog.component.html',
})
export class DialogElementsExampleDialog {
}