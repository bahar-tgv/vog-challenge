using System.Collections.Generic;
using System.Linq;
using VogCodeChallenge.Entities;

namespace VogCodeChallenge.API.Services
{
    public interface IDataContext
    {
        IQueryable<Employee> Employees();
        IQueryable<Department> Departments();
    }
}