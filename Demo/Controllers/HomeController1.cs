﻿using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
