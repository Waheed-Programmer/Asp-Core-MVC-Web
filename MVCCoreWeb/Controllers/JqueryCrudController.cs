using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCCoreWeb.Models.Database;

namespace MVCCoreWeb.Controllers
{
    public class JqueryCrudController : Controller
    {
        private TestDBContext db = new TestDBContext();
        
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetAllDataApiJson()
        {
            return Json(new { data = db.Users.ToList() });
        }
        //url: /Product/DeleteByDataApiJson
        [HttpDelete]
        public async Task<IActionResult> DeleteByDataApiJson(int id)
        {
            var p = await db.Users.FindAsync(id);
            if (p == null)
            {
                return Json(new { success = false, message = "Data Not Found!!!" });
            }

            db.Remove(p);
            await db.SaveChangesAsync();

            return Json(new { success = true, message = "Successfully Deleted!!!!" });
        }

    }
}
