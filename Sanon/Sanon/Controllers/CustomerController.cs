﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sanon.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Tables()
        {
            return View();
        }
        public ActionResult Products()
        {
            return View();
        }
    }
}