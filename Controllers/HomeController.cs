using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FrontToBack.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult Registration()
        {
            return View();
        }

        public IActionResult NewsDetail()
        {
            return View();
        }
    }
}
