﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;

namespace WebAppJP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Another way
            //ViewBag.Env = Environment.GetEnvironmentVariable("APPSETTING_SLOT_SETTING");
            ViewBag.Env = ConfigurationManager.AppSettings["SLOT_SETTING"];

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            throw new Exception("Something nasty just happened!");

            return View();
        }
    }
}