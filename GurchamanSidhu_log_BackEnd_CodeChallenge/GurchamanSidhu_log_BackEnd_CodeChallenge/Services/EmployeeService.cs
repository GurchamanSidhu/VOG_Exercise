using GurchamanSidhu_log_BackEnd_CodeChallenge.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace VogCodeChallenge.API.Services
{
    public class EmployeeService
    {
        private IEmployeeRepository employeeRepository { get; set; }

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public IEnumerable<Employee> GetAll()
        {
            return employeeRepository.GetAll();
        }

        public IList<Employee> ListAll()
        {
            return employeeRepository.ListAll();
        }

        public IEnumerable<Employee> GetAllByDepartmentId(int departmentId)
        {
            return employeeRepository.GetAllByDepartmentId(departmentId);
        }
    }
}
