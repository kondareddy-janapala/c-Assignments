using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Assignment2.Models;

namespace MVC_Assignment2.Controllers
{
    public class MovieController : Controller
    {
        MovieContext mc = new MovieContext();
        // GET: Movie
        public ActionResult Index()
        {
            return View(mc.Movies.ToList();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Movie m)
        {
            mc.Movies.Add(m);
            mc.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}