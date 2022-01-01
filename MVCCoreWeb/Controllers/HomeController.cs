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
        
        [HttpGet]
        public IActionResult Employe()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Employe(EmployeModel e)
        {
            return View(e);
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Math()
        {
            ModelMath model = new ModelMath();
            model.Result = 0;
            return View(model);
        }
        [HttpPost]
        public IActionResult Math(ModelMath m)
        {
            if (ModelState.IsValid)
            {
                m.Result = m.FirstNum + m.LastNum;
                
            }           
                return View(m);
           
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
