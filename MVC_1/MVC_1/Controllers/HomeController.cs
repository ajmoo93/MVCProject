using MVC_1.Models;
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
        [HttpPost]
        public ActionResult Create(Models.MyModel Image, HttpPostedFileBase file)
        {
            if (!ModelState.IsValid) { return View(Image); }
            if(file == null)
            {
                ModelState.AddModelError("Error ", "Missing Picture");
                return View(Image);
            }
            file.SaveAs(Path.Combine(Server.MapPath("~/Pictures"), file.FileName));
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
    }
}