using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCCoreWeb.Interfaces;
using MVCCoreWeb.Models.Database;

namespace MVCCoreWeb.Controllers
{
    public class RepositoryController : Controller
    {
        private IUser _userServices;
        public RepositoryController(IUser userServices)
        {
           this._userServices = userServices;
        }
        public IActionResult Index()
        {
            try
            {
                dynamic Obj = new ExpandoObject();
                Obj.userList = _userServices.GetUsers();
                return View(Obj);
            }
            catch (Exception)
            {

                return View();
            }
        }
  

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Save(User u)
        {
            try
            {
                if (u.UserId > 0)
                {

                }
                else
                {

                }
                return View();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
