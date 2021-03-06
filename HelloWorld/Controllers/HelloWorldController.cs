﻿using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // Testing
        // GET: /HelloWorld/ 

        public ActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public ActionResult Welcome(string name, int ID = 1)
        {
            ViewBag.message = "Hello, " + name;
            ViewBag.numTimes = ID;
            return View();
        }
    }
}