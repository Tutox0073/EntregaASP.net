using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PrimeraWeb.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeraWeb.Controllers
{
    public class WebController : Controller
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
