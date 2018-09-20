using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LearnModel.Models;

namespace LearnModel.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            ViewBag.justtry = "ViewBag Try";

            ViewData["justtry1"] = "ViewData Example";

            Employee emp = new Employee()
            {
                EmployeeID = 141,
                Name = "Akshay",
                Gender = 'M',
                City = "Bangalore"
            };
            return View(emp);
        }
    }
}