using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCCoreWeb.Models.Database;
using MVCCoreWeb.ViewModel;

namespace MVCCoreWeb.Controllers
{
    public class CrudDB : Controller
    {
       private TestDBContext db = new TestDBContext();

        [HttpGet]
        public IActionResult List()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ViewModelProduct p)
        {
            return View();
        }

    }
}
