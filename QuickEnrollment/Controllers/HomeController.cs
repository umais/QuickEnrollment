using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuickEnrollment.Models;
using System.Collections;
using EnrollmentClassLibrary;
namespace QuickEnrollment.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        ITransaction myTransaction;

        public HomeController(ITransaction trans)
        {
            this.myTransaction=trans;
        }

        public ViewResult Index()
        {
            string todaysDateTime = DateTime.Now.ToString();
            ViewBag.MyName = myTransaction.Insert();
            ViewBag.ILike=new  List<String>{"Counting to 1 to 10","Learning My ABC's","Watching Educational Shows"};
            return View();
        }

        public ViewResult Enrolltoday()
        {
            return View();
        }

        public ViewResult TestExtension()
        {
            //Instantiate the class with an interface reference.
            //Call Extension Method and Return Some Values to the View in Question
            double amount=300.09;
            return View("TestExtension",(object) String.Format("Message {0:c}",amount));
        }

        public ViewResult DisplayFirstName()
        {
            Enrollment m = new Enrollment { FirstName = "Umais", LastName = "Siddiqui" };
            var result = m.DisplayFirstName();
            return View("TestExtension", (object)String.Format("Your First Name is : {0}", result));
        }

        public ViewResult DisplayByLastName(string id)
        {
            Enrollments test = new Enrollments { enrollments = new List<Enrollment> { new Enrollment { FirstName = "Umais", LastName = "Siddiqui" }, new Enrollment { FirstName = "Naveed", LastName = "Aziz" }, new Enrollment { FirstName = "Farah", LastName = "Aziz" }, new Enrollment { FirstName = "Tayyib", LastName = "Siddiqui" }, new Enrollment { FirstName = "Amir", LastName = "saleem" } } };
            IEnumerable<Enrollment> a=test.getEnrollmentmembersByLastName(id);
            string result = "";
            foreach (Enrollment b in a)
            { 
                result += "  " + "FirstName:" + b.FirstName + " LastName:" + b.LastName;
            }

            return View("TestExtension", (object) String.Format("Here is the List:{0}",result));
        }
    }
}
