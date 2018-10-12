using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TitanDemo.Models;

namespace TitanDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            using (TodoEntities db = new TodoEntities())
            {
                ViewBag.Message = "Your have "+ db.Todos.Count() + " todo items.";
            }

            return View();
        }

        public ActionResult Contact()
        {
            using (TodoEntities db = new TodoEntities())
            {
                db.Todos.Add(new Todo()
                {
                    Name = "Item 1",
                    IsComplete = false
                });

                db.SaveChanges();
            }

            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}