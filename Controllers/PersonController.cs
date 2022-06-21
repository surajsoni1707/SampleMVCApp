using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleMVCApp.Controllers
{
    public class PersonController : Controller
    {
        [HttpGet]
        // GET: Person
        public ActionResult PersonalDetails()
        {
            List<string> options = new List<string>();
            options.Add("Choose An Option");
            options.Add("Yes");
            options.Add("No");
            ViewData["options"] = new SelectList(options);
            return View();
        }
        [HttpPost]
        public ActionResult PersonalDetails(FormCollection fc,ICollection<string> hobbies)
        {
            ViewBag.firstname = fc["firstname"];
            ViewBag.lastname = fc["lastname"];
            ViewBag.phone = fc["phone"];
            ViewBag.gender = fc["Gender"];
            ViewBag.hobbies = hobbies;
            ViewBag.options = fc["options"];
            return View("Details");
        }
    }
}