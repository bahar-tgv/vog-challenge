using System.Collections.Generic;
using VogCodeChallenge.Entities;

namespace VogCodeChallenge.API.Services
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAll();
        IList<Employee> ListAll();
    }
}