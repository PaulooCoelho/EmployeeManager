import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

interface Employee {
  name: string;
  age: number;
}

@Injectable({
  providedIn: 'root'
})

export class EmployeeService {

  url = 'http://localhost:58980/api/Employee/';

  constructor(private http: HttpClient) { }

  getAllEmployees() {
    return this.http.get(this.url + 'GetAllEmployees');
  }

  getEmployee() {
    return this.http.get(this.url + 'GetEmployee');
  }

  createEmployee() {
    return this.http.get(this.url + 'CreateEmployee');
  }  

  updateEmployee() {
    return this.http.get(this.url + 'UpdateEmployee');
  }  

  deleteEmployee() {
    return this.http.get(this.url + 'DeleteEmployee');
  }  
}
