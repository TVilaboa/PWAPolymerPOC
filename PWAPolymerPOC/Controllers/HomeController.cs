﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PWAPolymerPOC.Models;

namespace PWAPolymerPOC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return File("~/index.html", "text/html");
        }
    }
}
