﻿using Microsoft.AspNetCore.Mvc;

namespace SiemensECommerce.UI.Controllers
{
    public class AdminHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}