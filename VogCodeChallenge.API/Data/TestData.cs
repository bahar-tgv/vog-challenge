using System.Collections.Generic;
using System.Linq;
using VogCodeChallenge.Entities;

namespace VogCodeChallenge.API.Data
{
    public static class TestData
    {
        static TestData()
        {
            InitializeDepartments();
            InitializeEmployees();
        }

        public static IEnumerable<Employee> InMemoryEmployees { get; private set; }
        public static IEnumerable<Department> InMemoryDepartments { get; private set; }


        private static void InitializeDepartments()
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

        private static void InitializeEmployees()
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