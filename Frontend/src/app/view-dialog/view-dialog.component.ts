import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { Regex, User } from '../app.component';
import { FormControl, Validators } from '@angular/forms';
import { Validator } from 'fluentvalidation-ts';

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

// the package found for fluent validation in the npm register does not support email validationss
type UserValidator = {
  firstName: string;
  lastName: string;
  phoneNumber: string;
}

class PersonUpdateValidator extends Validator<UserValidator> {
  constructor() {
    super();

    this.ruleFor('firstName')
      .length(2, 250)
      .withMessage('firstName');

    this.ruleFor('lastName')
      .length(2, 250)
      .withMessage('lastName');

    this.ruleFor('phoneNumber')
      .matches(new RegExp(Regex.EMAIL))
      .withMessage('phoneNumber');
  }
}

class PersonCreateValidator extends Validator<UserValidator> {
  constructor() {
    super();

    this.ruleFor('firstName')
      .notEmpty()
      .length(2, 250)
      .withMessage('firstName');

    this.ruleFor('lastName')
      .length(2, 250)
      .notEmpty()
      .withMessage('lastName');

    this.ruleFor('phoneNumber')
      .notEmpty()
      .matches(new RegExp(Regex.EMAIL))
      .withMessage('phoneNumber');
  }
}

// Edit user 
@Component({
  selector: 'dialog-elements-edit-dialog',
  templateUrl: 'edit-dialog.component.html',
})

export class DialogElementsEditDialog {

  public fluentValidator: PersonUpdateValidator;
  public firstName = new FormControl('', Validators.minLength(2));
  public lastName = new FormControl('', Validators.minLength(2));
  public phoneNumber = new FormControl('', Validators.pattern(Regex.EMAIL));
  public email = new FormControl('', [Validators.required, Validators.email]);

  constructor(
    public dialogRef: MatDialogRef<DialogElementsEditDialog>,
    @Inject(MAT_DIALOG_DATA) public data: User) {
    this.fluentValidator = new PersonUpdateValidator();
  }

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
    // form data
    var emailF = this.email.value?.toString();
    var firstNameF = this.firstName.value?.toString();
    var lastNameF = this.lastName.value?.toString();
    var phoneNumberF = this.phoneNumber.value?.toString();

    // fluent validation response
    const userValidator: UserValidator = {
      firstName: firstNameF != undefined && firstNameF != "" ? firstNameF : user.firstName,
      lastName: lastNameF != undefined && lastNameF != "" ? lastNameF : user.lastName,
      phoneNumber: phoneNumberF != undefined && phoneNumberF != "" ? phoneNumberF : user.phoneNumber,
    };

    var fluentValidationResponse = this.fluentValidator.validate(userValidator);
    console.log(fluentValidationResponse);
    if (fluentValidationResponse) {
      if (fluentValidationResponse["firstName"]) {
        return;
      }

      if (fluentValidationResponse["lastName"]) {
        return;
      }

      if (fluentValidationResponse["phoneNumber"]) {
        return;
      }
    }

    // Angular UI assignment 
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

  public fluentValidator: PersonCreateValidator;

  public firstName = new FormControl('', Validators.minLength(2));
  public lastName = new FormControl('', Validators.minLength(2));
  public phoneNumber = new FormControl('', Validators.pattern(Regex.EMAIL));
  public email = new FormControl('', [Validators.required, Validators.email]);

  constructor(
    public dialogRef: MatDialogRef<DialogElementsCreateDialog>,
    @Inject(MAT_DIALOG_DATA) public data: User,
  ) {
    this.fluentValidator = new PersonCreateValidator();
  }

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
    // Form data  
    var emailF = this.email.value?.toString();
    var firstNameF = this.firstName.value?.toString();
    var lastNameF = this.lastName.value?.toString();
    var phoneNumberF = this.phoneNumber.value?.toString();

    //Fluent validator
    // fluent validation response
    const userValidator: UserValidator = {
      firstName: firstNameF != undefined && firstNameF != "" ? firstNameF : "",
      lastName: lastNameF != undefined && lastNameF != "" ? lastNameF : "",
      phoneNumber: phoneNumberF != undefined && phoneNumberF != "" ? phoneNumberF : "",
    };

    var fluentValidationResponse = this.fluentValidator.validate(userValidator);
    console.log(fluentValidationResponse);
    if (fluentValidationResponse) {
      if (fluentValidationResponse["firstName"]) {
        return;
      }

      if (fluentValidationResponse["lastName"]) {
        return;
      }

      if (fluentValidationResponse["phoneNumber"]) {
        return;
      }
    }

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