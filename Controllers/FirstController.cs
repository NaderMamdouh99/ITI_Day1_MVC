using Day1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day1.Controllers
{
    public class FirstController : Controller
    {
        static List<Course> CoursesData = new List<Course>()
        {
            new Course(){Id = 1, Name ="Css"},
            new Course(){Id = 2, Name = "Html"}
        };
        public JsonResult Courses()
        {
            return Json(CoursesData, JsonRequestBehavior.AllowGet);
        }
    }
}