using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventCatalyst_CMS.Views.Admin
{
    public class AdminController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
