﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EventCatalyst_CMS.Controllers
{
    public class CreatePage : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
