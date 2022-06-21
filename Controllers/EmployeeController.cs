using SampleMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleMVCApp.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult GetAllEmployee()
        {
            List<Employee> empList = new List<Employee>()
        {
            new Employee{  Id = 1, Name = "Suraj", Department = "IT", Salary = 100000.1 },
            new Employee{  Id = 2, Name = "Aman", Department = "Finance", Salary = 300000.1 },
            new Employee{  Id = 3, Name = "Raju", Department = "Hr", Salary = 220000.1 },
            new Employee{  Id = 4, Name = "ihil", Department = "IT", Salary = 310000.1 },
        };
            ViewBag.EmpList = empList;
            return View();
        }
    }
}