using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using form1.Models;

namespace form1.Controllers
{
    public class StudentController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetPersonalDetails()
        {
            Students obj = new Students();

            /*obj.FirstName = "Mayuri";
            obj.LastName = "Gupta";
            obj.Age = 20;
            obj.Gender = "Female";
            obj.City = "Gondia";*/

            return View(obj);

        }

        public ActionResult SetPersonalDetails(string FirstName, string LastName, int Age, string Gender, string City)
        {
            Students obj1 = new Students();
            obj1.FirstName = FirstName;
            obj1.LastName = LastName;
            obj1.Age = Age;
            obj1.Gender = Gender;
            obj1.City = City;

            return View(obj1);

        }
    }
}