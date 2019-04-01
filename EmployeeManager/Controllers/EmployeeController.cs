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
        public IEnumerable<Employee> GetAll()
        {
            var list = new List<Employee>();

            list.Add(new Employee() { Name = "Lilly" });
            list.Add(new Employee() { Name = "Lucy" });

            return list;
        }

        [HttpGet("{name}")]
        public Employee Get(string name)
        {
            return new Employee() { Name = name };
        }

        [HttpPost]
        public Employee Insert([FromBody]Employee cat)
        {
            // write the new cat to database
            return cat;
        }

        [HttpPut("{name}")]
        public Employee Update(string name, [FromBody]Employee cat)
        {
            cat.Name = name;
            // write the updated cat to database
            return cat;
        }

        [HttpDelete("{name}")]
        public void Delete(string name)
        {
            // delete the cat from the database

        }
    }
}