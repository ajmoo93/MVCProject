using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mv
using MVC_Peoject.Models;



namespace MVC_Peoject.Controllers
{
    public class PhotoController : Controller
    {
        GalleryContext db = new GalleryContext();
        // GET: Photo
        public ActionResult AlbumList()
        {
            using (var context = new GalleryContext())
            {
                var NewAlbum = new AlbumClass();
                NewAlbum.AlbumID = Guid.NewGuid();
                NewAlbum.AlbumName = "wowowowow";
                context.album.Add(NewAlbum);
                context.SaveChanges();
            }
            
                return View(db.album.ToList());
        }

        // GET: Photo/Details/5
        public ActionResult Details(int id)
        {


            return View();
        }

        // GET: Photo/Create
        public ActionResult Create()
        {



            return View();
        }

        // POST: Photo/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("CreatePhoto");
            }
            catch
            {
                return View();
            }
        }

        // GET: Photo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Photo/Edit/5
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

        // GET: Photo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Photo/Delete/5
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
