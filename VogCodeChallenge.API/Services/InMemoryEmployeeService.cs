using System.Collections.Generic;
using System.Linq;
using VogCodeChallenge.API.Data;
using VogCodeChallenge.Entities;

namespace VogCodeChallenge.API.Services
{
    public class InMemoryEmployeeService : IEmployeeService
    {
        public IEnumerable<Employee> GetAll()
        {
            return TestData.InMemoryEmployees;
        }

        public IEnumerable<Employee> GetByDepartment(int departmentId)
        {
            return TestData.InMemoryEmployees.Where(e => e.Department != null && e.Department.Id == departmentId);
        }

        public IList<Employee> ListAll()
        {
            return TestData.InMemoryEmployees.ToList();
        }
    }
}