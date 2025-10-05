using EFCoreProject.BusinessAccessLayer;
using EFCoreProject.model;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeBAL _employeeBAL;

        public EmployeeController(EmployeeBAL employeeBAL)
        {
            _employeeBAL = employeeBAL;
        }

        // GET /Employee
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_employeeBAL.GetAllEmployees());
        }

        // GET /Employee/5
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var employee = _employeeBAL.GetEmployee(id);
            if (employee == null) return NotFound();
            return Ok(employee);
        }

        // POST /Employee
        [HttpPost]
        public IActionResult CreateEmployee(Employee employee)
        {
            _employeeBAL.AddEmployee(employee);
            return Ok();
        }

        // PUT /Employee/5
        [HttpPut("{id}")]
        public IActionResult UpdateEmployee(int id, Employee employee)
        {
            if (id != employee.Id) return BadRequest("Id mismatch");
            _employeeBAL.UpdateEmployee(employee);
            return Ok();
        }

        // DELETE /Employee/5
        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            _employeeBAL.DeleteEmployee(id);
            return Ok();
        }
    }
}
