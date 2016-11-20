﻿using MVC_1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Information()
        {
            ViewBag.Message = "Your Information Page";
            return View();
        }

        public ActionResult Pictures()
        {
            //kallar på en lista vi gjort och lägger visar
            //vägen vart vi hämtar/lägger bilder MapPath.
            var model = new MyModel()
            {
                Images = Directory.EnumerateFiles(Server.MapPath("~/Pictures")).Select(fn => Path.GetFileName(fn))
            };

            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        //Behöver två AcrionResult för att kunna lägga till
        //ta emor datan (uppe)  och en för att lägga till(nere)
        [HttpPost]
        public ActionResult Create(Models.MyModel Image, HttpPostedFileBase file)
        {
            if (!ModelState.IsValid) { return View(Image); }
            if (file == null)
            {
                ModelState.AddModelError("Error ", "Missing Picture");
                return View(Image);
            }
            Image.date = DateTime.Now;
            file.SaveAs(Path.Combine(Server.MapPath("~/Pictures"), file.FileName));
            db.Add(new MyModel { ID = Guid.NewGuid(), ImgName = file.FileName });
            return View();
        }
        public static List<MyModel> db = new List<MyModel>();

        public HomeController()
        {
           if(!db.Any())
            {
                db.Add(new MyModel { ID = Guid.NewGuid(), ImgName = "81.jpg" });
                db.Add(new MyModel { ID = Guid.NewGuid(), ImgName = "ladda ned (1).jpg" });
                db.Add(new MyModel { ID = Guid.NewGuid(), ImgName = "ladda ned (2).jpg" });
                db.Add(new MyModel { ID = Guid.NewGuid(), ImgName = "ladda ned.jpg" });
                db.Add(new MyModel { ID = Guid.NewGuid(), ImgName = "Jece.jpg" });
            }
        }
        public ActionResult Image()
        {
            return View(db);
        }
        
        public ActionResult Delete(Guid id)
        {
            var pht = db.FirstOrDefault(x => x.ID == id);
            return View(db);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfermation(Guid id)
        {
            var i = db.FirstOrDefault(x => x.ID == id);
            db.Remove(i);
            return RedirectToAction("Pictures");


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
    }
}
//    string FP = Request.MapPath("~/Pictures/" + i.ImgName);
//    if (System.IO.File.Exists(FP))
//    {
//        System.IO.File.Delete(FP);
//        db.Remove(i);
//    }
//    return RedirectToAction("Pictures");