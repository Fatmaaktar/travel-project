﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrickProject.Models.Classes;

namespace TravelTrickProject.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        Context c=new Context();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Contact() 
        {
            return View();
        }
    }
}