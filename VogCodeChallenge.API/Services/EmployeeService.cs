﻿using System.Collections.Generic;
using System.Linq;
using VogCodeChallenge.API.Data;
using VogCodeChallenge.Entities;

namespace VogCodeChallenge.API.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly RelationalDbContext _db;

        public EmployeeService(RelationalDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Employee> GetAll()
        {
            return _db.Employees;
        }

        public IEnumerable<Employee> GetByDepartment(int departmentId)
        {
            return _db.Employees.Where(e => e.Department != null && e.Department.Id == departmentId);
        }

        public IList<Employee> ListAll()
        {
            return _db.Employees.ToList();
        }
    }
}