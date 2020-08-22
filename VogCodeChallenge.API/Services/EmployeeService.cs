using System.Collections.Generic;
using System.Linq;
using VogCodeChallenge.Entities;

namespace VogCodeChallenge.API.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IDataContext _dataContext;

        public EmployeeService(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IEnumerable<Employee> GetAll()
        {
            return _dataContext.Employees();
        }

        public IEnumerable<Employee> GetByDepartment(int departmentId)
        {
            return _dataContext.Employees().Where(e => e.Department != null && e.Department.Id == departmentId);
        }

        public IList<Employee> ListAll()
        {
            return _dataContext.Employees().ToList();
        }
    }
}