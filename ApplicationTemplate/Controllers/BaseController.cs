﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApplicationTemplate.Controllers
{
    public class BaseController : Controller
    {
        public BaseController()
        {

        }

        // GET: Base
        public ActionResult Index()
        {
            return View();
        }
    }
}