using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVCApplication1.Models;

namespace WebMVCApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Message = "This is a sample scaffolding ASP.NET MVC 5 application.";
            return View();
        }

        [HttpPost]
        public ActionResult Index(PersonModel person)
        {
            int personId = person.PersonId;
            string name = person.Name;
            string gender = person.Gender;
            string city = person.City;

            return View();
        }
    }
}