using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using VogCodeChallenge.API.Services;
using VogCodeChallenge.Entities;

namespace VogCodeChallenge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Employee>> Get()
        {
            var employees = _employeeService.ListAll();
            //It is better to return DTO for seperating original model from the model we want to show to users
            return Ok(employees);
        }

        [HttpGet]
        [Route("department/{departmentId}")]
        public ActionResult<IEnumerable<Employee>> GetByDepartmentId(int departmentId)
        {
            if (departmentId <= 0) return BadRequest("Department Id is out of range");
            var employees = _employeeService.GetByDepartment(departmentId);
            //It is better to return DTO for seperating original model from the model we want to show to users
            if (employees != null && employees.Any())
                return Ok(employees);

            return NotFound();
        }
    }
}