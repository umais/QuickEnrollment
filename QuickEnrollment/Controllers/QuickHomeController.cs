﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EnrollmentClassLibrary;
namespace QuickEnrollment.Controllers
{
    public class QuickHomeController : Controller
    {
        //
        // GET: /QuickHome/
        ITransaction myTransaction;
        public QuickHomeController(ITransaction trans)
        {
            myTransaction = trans;
        }

        public ViewResult Index()
        {

            ViewBag.MyName = myTransaction.Insert();
            return View();
        }

    }
}
