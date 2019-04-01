import { Component, OnInit } from '@angular/core';
import { EmployeeService } from '../employee.service';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})

export class HomeComponent implements OnInit {

  employees$: Object;

  constructor(private employeeService: EmployeeService) { }

  ngOnInit() {
    this.employeeService.getAllEmployees().subscribe(data => this.employees$ = data);
  }

  getEmployees() {
    return this.employeeService.getAllEmployees().subscribe(data => this.employees$ = data);
  }

}
