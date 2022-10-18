using GurchamanSidhu_log_BackEnd_CodeChallenge.Models;
using System.Collections.Generic;

namespace VogCodeChallenge.API.Services
{
    public static class DefaultData
    {
        public static List<Employee> InsertDefaultEmployeeData()
        {
            List<Employee> defaultEmployees = new List<Employee>()
            {
                new Employee() {
                    firstName = "Gurchaman",lastName = "Sidhu",jobTitle = "Software Developer",addressOfResidence = "Calgary", departmentId = 1 },
                new Employee() {
                    firstName = "Steve",lastName = "Jobs",jobTitle = "Director",addressOfResidence = "Edmonton", departmentId = 1 },
                new Employee() {
                    firstName = "Christano",lastName = "Ronaldo",jobTitle = "Gym trainer",addressOfResidence = "Vancouver", departmentId = 2 },
                new Employee() {
                    firstName = "John",lastName = "Travolta",jobTitle = "Senior Accountant",addressOfResidence = "Toronto", departmentId = 3 },
            };

            return defaultEmployees;
        }

        public static List<Department> InsertDefaultDepartmentData()
        {
            List<Department> defaultDepartments = new List<Department>() {
                new  Department() {
                    departmentId = 1,name = "Information Systems",address = "Calgary"},
                new  Department() {
                    departmentId = 2,name = "Sports",address = "Vancouver"},
                 new  Department() {
                    departmentId = 3,name = "Accounts",address = "Toronto"},
            };

            return defaultDepartments;
        }

        //public static void InsertDefaultData(IEmployeeRepository repository)
        //public static void InsertDefaultData()
        //{
        //    List<Department> defaultDepartments = new List<Department>() {
        //        new  Department() {
        //            departmentId = 1,name = "Information Systems",address = "Calgary"},
        //        new  Department() {
        //            departmentId = 2,name = "Sports",address = "Vancouver"},
        //         new  Department() {
        //            departmentId = 3,name = "Accounts",address = "Toronto"},
        //    };

        //    List<Employee> defaultEmployees = new List<Employee>()
        //    {
        //        new Employee() {
        //            firstName = "Gurchaman",lastName = "Sidhu",jobTitle = "Software Developer",addressOfResidence = "Calgary", departmentId = 1 },
        //        new Employee() {
        //            firstName = "Steve",lastName = "Jobs",jobTitle = "Director",addressOfResidence = "Edmonton", departmentId = 1 },
        //        new Employee() {
        //            firstName = "Christano",lastName = "Ronaldo",jobTitle = "Gym trainer",addressOfResidence = "Vancouver", departmentId = 2 },
        //        new Employee() {
        //            firstName = "John",lastName = "Travolta",jobTitle = "Senior Accountant",addressOfResidence = "Toronto", departmentId = 3 },
        //    };

        //    List<Employee> employees = new List<Employee>();
        //    employees.AddRange(defaultEmployees);

        //    //repository.setEmployees(employees);
        //    //repository.setDepartments(departments);
        //}
    }
}