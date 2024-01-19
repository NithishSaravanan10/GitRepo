import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-details',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './details.component.html',
  styleUrl: './details.component.css'
})
export class DetailsComponent {

  toggleButton !:boolean;
  details !: any[];

  constructor(){
    console.log("Hello")
    this.toggleButton = false;
    this.details = [
      {'empid':101,'empName':"Bharath",'designation':"Software Analyst",'dateOfJoining':"20/1/23",'address':"Chennai",'salary':2000009980},
      {'empid':102,'empName':"Sam",'designation':"Software Developer",'dateOfJoining':"20/1/23",'address':"Chennai",'salary':3000000},
      {'empid':103,'empName':"Ashiq",'designation':"Software Developer",'dateOfJoining':"20/1/23",'address':"Chennai",'salary':4000000},
      {'empid':104,'empName':"Dhivyan",'designation':"Data Analyst",'dateOfJoining':"20/1/23",'address':"Chennai",'salary':500000},
      {'empid':105,'empName':"Daneil",'designation':"Software Developer",'dateOfJoining':"20/1/23",'address':"Chennai",'salary':670000},
      {'empid':106,'empName':"Ram",'designation':"Software Developer",'dateOfJoining':"20/1/23",'address':"Chennai",'salary':6540000},
      {'empid':107,'empName':"Shyam",'designation':"Software Analyst",'dateOfJoining':"20/1/23",'address':"Chennai",'salary':6600000},
      {'empid':108,'empName':"Rajeev",'designation':"Data Analyst",'dateOfJoining':"20/1/23",'address':"Chennai",'salary':6600000},
    ]
  }

  ShowHideButtonClick(){
    if(this.toggleButton == false){
      this.toggleButton = true;
    }
    else{
      this.toggleButton = false;
    }
    console.log(this.toggleButton);
  }



}
