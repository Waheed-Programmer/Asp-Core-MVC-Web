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
  

        public IActionResult Edit(int id)
        {

            try
            {
                dynamic Obj = new ExpandoObject();
                Obj.userDetail = _userServices.GetById(id);
                return View(Obj);
            }
            catch (Exception)
            {

                throw;
            }
        }
        
        public IActionResult Save(User u)
        {
            string err = "";
            try
            {
                if (u.UserId > 0)
                {
                    err =_userServices.Update(u);
                    if (string.IsNullOrEmpty(err)) { 
                    _userServices.SaveChanges();
                    }
                }
                else
                {
                    err = _userServices.Insert(u);
                    if (string.IsNullOrEmpty(err))
                    {
                        _userServices.SaveChanges();
                    }

                
                }
                return Json(new { err = err });
            }
            catch (Exception)
            {

                return View();
            }
        }

       public IActionResult Delete(int id)
        {
            try
            {
                var user = _userServices.GetById(id);
                if(user != null)
                {
                    _userServices.Delete(user);
                    _userServices.SaveChanges();
                    

                }
                return Json(new { success = true, message = "Successfully Deleted!!!!" });
            }
            catch (Exception)
            {

                return View();
            }
        }

    }
}
