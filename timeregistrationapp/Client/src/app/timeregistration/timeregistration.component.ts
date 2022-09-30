import { Component, OnInit } from '@angular/core';
import TimeRegistration from '../models/timeregistration';
import { TimeRegistrationService } from './timeregistration.service';


@Component({
  selector: 'app-timeregistration', 
  templateUrl: './timeregistration.component.html',
  styleUrls: ['./timeregistration.component.css']

})
export class TimeregistrationComponent implements OnInit {

  listRegistrations:TimeRegistration[] = [];
  creatingRegistration:TimeRegistration = {
     comments:'',
     contactPerson: '',
     contactPersonNumber:'',
     customer:'',
     description:'',
     employee:'',
     hours:0,
     registrationTime:new Date()
  };


  constructor(private service:TimeRegistrationService) { }

  ngOnInit(): void {
    this.getList();
  }

  getList(){
    this.service.getRegistrations().subscribe((result:any) => {
          this.listRegistrations = result;
    })
  }

  create(){
    this.service.createTimeregistration(this.creatingRegistration).subscribe(() => {
      this.creatingRegistration = {
        comments:'',
        contactPerson: '',
        contactPersonNumber:'',
        customer:'',
        description:'',
        employee:'',
        hours:0,
        registrationTime:new Date()
     };
     this.getList();
    })
  }


}
