﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCCoreWeb.Interfaces;

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
            try
            {
                return View();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
