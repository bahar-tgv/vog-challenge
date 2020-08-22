using System.Collections.Generic;
using System.Linq;
using VogCodeChallenge.Entities;

namespace VogCodeChallenge.API.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IDepartmentService _departmentService;

        public EmployeeService(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
            InitializeEmployees();
        }

        private IList<Employee> InMemoryEmployees { get; set; }

        public IEnumerable<Employee> GetAll()
        {
            return InMemoryEmployees.AsEnumerable();
        }

        public IList<Employee> ListAll()
        {
            return InMemoryEmployees;
        }


        private void InitializeEmployees()
        {
            var departments = _departmentService.ListAll();
            var firstEmployee = new Employee
            {
                Id = 10,
                FirstName = "John",
                LastName = "Doe",
                JobTitle = "Software Engineer",
                Address = "1010, First Avenue, Calgary, Alberta, Canada",
                Department = departments.FirstOrDefault(d => d.Id == 1)
            };
            var secondEmployee = new Employee
            {
                Id = 11,
                FirstName = "Jane",
                LastName = "Bloggs",
                JobTitle = "Director of Engineering",
                Address = "2020, Second Avenue, Calgary, Alberta, Canada",
                Department = departments.FirstOrDefault(d => d.Id == 2)
            };

            var thirdEmployee = new Employee
            {
                Id = 12,
                FirstName = "Bahar",
                LastName = "Taghavi",
                JobTitle = "Software Engineer",
                Address = "3030, third Avenue, Calgary, Alberta, Canada",
                Department = departments.FirstOrDefault(d => d.Id == 1)
            };
            InMemoryEmployees = new List<Employee> {firstEmployee, secondEmployee, thirdEmployee};
        }
    }
}