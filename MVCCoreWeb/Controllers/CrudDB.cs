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
            //var listIt = from a in db.Products
            //             join b in db.Users
            //             on a.ProductId equals b.UserId
                         

            return View(db.Products.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ViewModelProduct p)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Product pp = new Product();
                    pp.ProductName = p.ProductName;
                    pp.Price = p.Price;
                    pp.UserId = p.UserId;

                    db.Products.Add(pp);
                    db.SaveChanges();
                    ViewBag.success = "Data save successfully";
                    
                }
                return View();
            }
            catch (Exception)
            {

                return View(p);
            }
           
        }

    }
}
