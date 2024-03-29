﻿using AdminLogin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminLogin.Controllers
{
    public class HomeController : Controller
    {
        AdminContext db = new AdminContext();       
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult AdminDashboard()
        {
            return View();
        }

        public ActionResult AdminLogin() 
        {
            return View();
        }
        [HttpPost]

        public ActionResult AdminLogin(Admin login)
        {
            if(ModelState.IsValid) 
            { 
                var lg=db.Admins.Where(m=>m.AdminId==login.AdminId && m.Password==login.Password).SingleOrDefault();
                if(lg!= null) 
                {
                    Session["AdminId"]=login.AdminId;
                    Session["password"]=login.Password; 

                    return RedirectToAction("AdminDashboard");
                }
                else
                {
                    ViewBag.msg = "Invalid Adminid or Password";
                }
            }
            return View();
        }

    }
}