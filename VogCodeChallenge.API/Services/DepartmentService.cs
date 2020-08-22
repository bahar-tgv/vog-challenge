using System.Collections.Generic;
using VogCodeChallenge.Entities;

namespace VogCodeChallenge.API.Services
{
    public class DepartmentService : IDepartmentService
    {
        public DepartmentService()
        {
            InitializeDepartments();
        }

        private IList<Department> InMemoryDepartments { get; set; }

        public IList<Department> ListAll()
        {
            return InMemoryDepartments;
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
    }
}