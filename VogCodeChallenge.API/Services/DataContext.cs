using System.Collections.Generic;
using System.Linq;
using VogCodeChallenge.Entities;

namespace VogCodeChallenge.API.Services
{
    public class DataContext : IDataContext
    {
        public DataContext()
        {
            InitializeDepartments();
            InitializeEmployees();
        }

        private IEnumerable<Employee> InMemoryEmployees { get; set; }
        private IEnumerable<Department> InMemoryDepartments { get; set; }

        public IQueryable<Employee> Employees()
        {
            return InMemoryEmployees.AsQueryable();
        }

        public IQueryable<Department> Departments()
        {
            return InMemoryDepartments.AsQueryable();
        }

        private void InitializeDepartments()
        {
            var firstDepartment = new Department
            {
                Id = 1,
                Name = "Engineering Department",
                Address = "11, First St, Calgary, Alberta, Canada"
            };

            var secondDepartment = new Department
            {
                Id = 2,
                Name = "Management Department",
                Address = "12, First Str, Calgary, Alberta, Canada"
            };
            InMemoryDepartments = new List<Department> {firstDepartment, secondDepartment};
        }

        private void InitializeEmployees()
        {
            var firstEmployee = new Employee
            {
                Id = 10,
                FirstName = "John",
                LastName = "Doe",
                JobTitle = "Software Engineer",
                Address = "1010, First Avenue, Calgary, Alberta, Canada",
                Department = InMemoryDepartments.FirstOrDefault(d => d.Id == 1)
            };
            var secondEmployee = new Employee
            {
                Id = 11,
                FirstName = "Jane",
                LastName = "Bloggs",
                JobTitle = "Director of Engineering",
                Address = "2020, Second Avenue, Calgary, Alberta, Canada",
                Department = InMemoryDepartments.FirstOrDefault(d => d.Id == 2)
            };

            var thirdEmployee = new Employee
            {
                Id = 12,
                FirstName = "Bahar",
                LastName = "Taghavi",
                JobTitle = "Software Engineer",
                Address = "3030, third Avenue, Calgary, Alberta, Canada",
                Department = InMemoryDepartments.FirstOrDefault(d => d.Id == 1)
            };
            InMemoryEmployees = new List<Employee> {firstEmployee, secondEmployee, thirdEmployee};
        }
    }
}