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
        [HttpGet]
        // GET: Employee
        public ActionResult GetAllEmployee()
        {
          
            return View();
        }
        [HttpPost]
        public ActionResult GetAllEmployee(FormCollection fc)
        {
            ViewBag.EmpId = fc["EmpId"];
            ViewBag.name = fc["EmpName"];
            ViewBag.Gender = fc["Gender"];
            ViewBag.department = fc["department"];
            ViewBag.salary = fc["EmpSal"];
            return View("EmpDetails");
        }



    }
}