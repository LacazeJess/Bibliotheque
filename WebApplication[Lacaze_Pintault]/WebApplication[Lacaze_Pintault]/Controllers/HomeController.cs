﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication_Lacaze_Pintault_.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Auteurs_Abonnes()
        {
            return View();
        }

        public ActionResult Emprunts()
        {
            return View();
        }
    }
}