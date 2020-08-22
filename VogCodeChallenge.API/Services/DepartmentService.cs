using System.Collections.Generic;
using System.Linq;
using VogCodeChallenge.Entities;

namespace VogCodeChallenge.API.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDataContext _dataContext;

        public DepartmentService(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IList<Department> ListAll()
        {
            return _dataContext.Departments().ToList();
        }
    }
}