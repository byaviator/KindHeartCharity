﻿using Microsoft.AspNetCore.Mvc;

namespace KindHeartCharity.Areas.Admin.Controllers;

[Area("Admin")]
public class DashboardController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
