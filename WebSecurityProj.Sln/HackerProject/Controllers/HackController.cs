using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HackerProject.Controllers
{
    public class HackController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CompromisedTransfer()
        {
            return View();
        }

        public IActionResult Frame()
        {
            return View();
        }
    }
}