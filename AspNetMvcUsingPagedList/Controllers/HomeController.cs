using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspNetMvcUsingPagedList.Models;
using PagedList;

namespace AspNetMvcUsingPagedList.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index(int? page, int pageSize = 5)
        {
            var initialStudents = db.Students.ToList().OrderByDescending(a => a.Id).ToPagedList(page ?? 1, pageSize);

            return View(initialStudents);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}