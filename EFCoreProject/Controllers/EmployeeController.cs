using EFCoreProject.model;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
       

        [HttpGet(Name = "getEmployees")]
        public IActionResult GetEmployees()
        {
            List<Employee> sData = new List<Employee>()
            {
                new Employee(){ Name="John", Age="30"},
                new Employee(){ Name="Smith", Age="40"},
                new Employee(){ Name="David", Age="35"},
                new Employee(){ Name="Martin", Age="50"},
            };
            return Ok(sData);
        }
    }
}
