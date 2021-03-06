﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mvc
using System.Web.Mvc;


namespace MVC_Project1.Controllers
{
    public class GalleryController : Controller
    {
        //MVCProjektContext db = new MVCProjektContext();
        //// GET: Photo
        //public ActionResult PhotoList()
        //{
        //    using (var context = new MVCProjektContext())
        //    {
        //        var NewPhoto = new PhotoClass();
        //        NewPhoto.PhotoId = Guid.NewGuid();
        //        NewPhoto.PhotoName = "wowowowow";
        //        context.photo.Add(NewPhoto);
        //        context.SaveChanges();
        //    }

        //    return View(db.photo.ToList());
        //}
        MVCProjektContext db = new MVCProjektContext();
        public ActionResult PhotoList()
        {
            using (var context = new MVCProjektContext())
            {
                var NewPhoto = new PhotoClass();
                NewPhoto.PhotoId = Guid.NewGuid();
                NewPhoto.PhotoName = "Kanduni";
                context.photo.Add(NewPhoto);
                context.SaveChanges();
            }
            return View(db.photo.ToList());
        }

        // GET: Gallery/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Gallery/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Gallery/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Gallery/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Gallery/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Gallery/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Gallery/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
