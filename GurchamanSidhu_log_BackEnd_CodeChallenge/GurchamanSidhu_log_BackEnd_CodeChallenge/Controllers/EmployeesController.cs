using GurchamanSidhu_log_BackEnd_CodeChallenge.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Services;

namespace GurchamanSidhu_log_BackEnd_CodeChallenge.Controllers
{
    [ApiController]
    [Route("API/[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly EmployeeService employeeService;

        public EmployeesController(EmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Employee>> Employees()
        {
            return new ActionResult<IEnumerable<Employee>>(employeeService.GetAll());
        }

        [HttpGet("department/{departmentId}")]
        public ActionResult<IEnumerable<Employee>> GetAllByDepartmentId(int departmentId)
        {
            return new ActionResult<IEnumerable<Employee>>(employeeService.GetAllByDepartmentId(departmentId));
        }

        [HttpGet("department2/{departmentId}")]
        public ActionResult<IEnumerable<Employee>> GetAllByDepartmentId2(int departmentId)
        {
            return new ActionResult<IEnumerable<Employee>>(employeeService.GetAllByDepartmentId(departmentId));
        }
    }
}
