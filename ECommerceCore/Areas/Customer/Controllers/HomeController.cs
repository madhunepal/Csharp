using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ECommerceCore.Models;


namespace ECommerceCore.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
      public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
