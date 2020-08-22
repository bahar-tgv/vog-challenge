using System.Collections.Generic;
using VogCodeChallenge.Entities;

namespace VogCodeChallenge.API.Services
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAll();
        IEnumerable<Employee> GetByDepartment(int departmentId);
        IList<Employee> ListAll();
    }
}