﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_FormWizard.Controllers
{
    public class WizardController : Controller
    {
        //
        // GET: /Wizard/

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult StepOne()
        {
            return View();
        }


        [HttpPost]
        public ActionResult StepOne(string Email, string Name)
        {
            return View();
        }

        [HttpGet]
        public ActionResult StepTwo()
        {
            return View();
        }


        //[HttpPost]
        //public ActionResult StepTwo()
        //{
        //    return View();
        //}

        [HttpGet]
        public ActionResult StepThree()
        {
            return View();
        }


        //[HttpPost]
        //public ActionResult StepThree()
        //{
        //    return View();
        //}
    }
}
