﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FoodDelivery.Web.Models;

namespace RemontWeb.Controllers
{
    public class UploadController : Controller
    {
        // GET: Upload
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Print(HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
            {
                var dto = FoodClass.FoodDeliveryHelper.LoadFromStream(file.InputStream);

                return View(dto);
            }

            return RedirectToAction("Index");
        }
    }
}