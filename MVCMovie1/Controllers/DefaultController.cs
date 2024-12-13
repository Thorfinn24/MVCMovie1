using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCMovie1.Models;

namespace MVCMovie1.Controllers
{
    public class DefaultController : Controller
    {
        TasksEntities db = new TasksEntities();

        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(MovieTicket movieTicket)
        {
            db.MovieTickets.Add(movieTicket);
            db.SaveChanges();

            ViewBag.Message = string.Format("Hello");

            return View();
        }

        public ActionResult Details()
        {
            return View();
        }

    }
}