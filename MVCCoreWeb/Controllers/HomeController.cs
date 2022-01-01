using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCCoreWeb.Models;

namespace MVCCoreWeb.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Math()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Math(ModelMath m)
        {
            if (ModelState.IsValid)
            {
                m.Result = m.FirstNum + m.LastNum;
                return View();
            }
            else
            {
                return View(m);
            }
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
