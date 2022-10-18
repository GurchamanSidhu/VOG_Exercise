using GurchamanSidhu_log_BackEnd_CodeChallenge.Models;
using System;
using System.Collections.Generic;

namespace VogCodeChallenge.API.Services
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
        IList<Employee> ListAll();
        IEnumerable<Employee> GetAllByDepartmentId(int departmentId);
    }
}
