using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManager.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        [HttpGet]
        [Route("GetAllEmployees")]
        public IEnumerable<Employee> GetAll()
        {
            var list = new List<Employee>();

            list.Add(new Employee() { Name = "Lilly", Age = 28 });
            list.Add(new Employee() { Name = "Lucy", Age = 29 });

            return list;
        }

        [HttpGet]
        [Route("GetEmployee")]
        public Employee GetEmployee(int id)
        {
            var list = new List<Employee>();

            list.Add(new Employee() { Name = "Lilly", Age = 28 });
            list.Add(new Employee() { Name = "Lucy", Age = 29 });

            return list.ElementAt(0);
        }

        [HttpGet]
        [Route("CreateEmployee")]
        public IEnumerable<Employee> CreateEmployee()
        {
            var list = new List<Employee>();

            list.Add(new Employee() { Name = "Lilly", Age = 28 });
            list.Add(new Employee() { Name = "Lucy", Age = 29 });

            return list;
        }

        [HttpGet]
        [Route("UpdateEmployee")]
        public IEnumerable<Employee> UpdateEmployee()
        {
            var list = new List<Employee>();

            list.Add(new Employee() { Name = "Lilly", Age = 28 });
            list.Add(new Employee() { Name = "Lucy", Age = 29 });

            return list;
        }

        [HttpGet]
        [Route("DeleteEmployee")]
        public IEnumerable<Employee> DeleteEmployee()
        {
            var list = new List<Employee>();

            list.Add(new Employee() { Name = "Lilly", Age = 28 });
            list.Add(new Employee() { Name = "Lucy", Age = 29 });

            return list;
        }
    }
}