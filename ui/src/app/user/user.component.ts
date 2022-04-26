import { Component, ComponentFactoryResolver, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { MatDialog } from '@angular/material/dialog/dialog';
import { UserDataService } from './user.data.service';
import { IUser, User } from './user.model';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent implements OnInit {
  user: IUser = new User(); //
  userForm = new FormGroup({
    name: new FormControl('', Validators.required,),
    surname: new FormControl('', Validators.required),
    mail: new FormControl('', [Validators.required, Validators.email]),
    bDay: new FormControl('', Validators.required),
    gender: new FormControl('', Validators.required)
  });
  constructor(public service: UserDataService) {

  }
  ngOnInit(): void {
  }

  submit(): any {
    console.log(this.user); // model ile veri alma
    console.log(Object.assign({}, this.userForm.value)); // formdan veri alma

    this.service.saveUser(this.user).subscribe((result)=>{
      console.warn(result);
    });
    window. location. reload();
    // burda da user.data.service içinde ki http metoda gidecez, api ye istek atacağız 
    
  }
}

export class DatepickerCustomIconExample {}



