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
        public IEnumerable<Employee> Get()
        {
            var employees = _employeeService.ListAll();
            //It is better to return DTO for seperating original model from the model we want to show to users
            return employees;
        }
        
        [HttpGet]
        [Route("department/{departmentId}")]
        public IEnumerable<Employee> GetByDepartmentId(int departmentId)
        {
            var employees = _employeeService.GetAll().Where(e=> e.Department!= null && e.Department.Id == departmentId).ToList();
            //It is better to return DTO for seperating original model from the model we want to show to users
            return employees;
        }
    }
}
