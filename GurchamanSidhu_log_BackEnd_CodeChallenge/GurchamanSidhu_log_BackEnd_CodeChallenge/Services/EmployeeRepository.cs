using GurchamanSidhu_log_BackEnd_CodeChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace VogCodeChallenge.API.Services
{
    public class EmployeeRepository: IEmployeeRepository
    {
        private List<Department> departments;
        private List<Employee> employees;

        public IEnumerable<Employee> GetAll()
        {
            employees = DefaultData.InsertDefaultEmployeeData();
            return employees;
        }

        public IList<Employee> ListAll()
        {
            employees = DefaultData.InsertDefaultEmployeeData();
            return employees;
        }

        public IEnumerable<Employee> GetAllByDepartmentId(int departmentId)
        {
            IEnumerable<Employee> employees = ListAll();
            return employees.Where(x => x.departmentId.Equals(departmentId));
        }
    }
}
