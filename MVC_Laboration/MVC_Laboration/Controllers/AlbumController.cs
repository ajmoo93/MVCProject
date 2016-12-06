using MVCProjektData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Laboration.Controllers
{
    public class AlbumController : Controller
    {
        // GET: Album
        public ActionResult Index()
        {
            return View();
        }

        // GET: Album/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        public ActionResult AlbumList()
        {
            using (var context = new MvcDataContext())
            {
                return View(context.album.ToList());
            }

        }
        // GET: Album/Create
        public ActionResult CreateAlbum()
        {
            return View();
        }

        // POST: Album/Create
        [HttpPost]
        public ActionResult CreateAlbum(AlbumClass album)
        {
            try
            {
                using (var context = new MvcDataContext())
                {
                    var NewAlbum = new AlbumClass();
                    NewAlbum.AlbumName = album.AlbumName;
                    context.album.Add(NewAlbum);
                    context.SaveChanges();
                }
                // TODO: Add insert logic here

                return RedirectToAction("AlbumList");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Addphoto(Guid id)
        {
            using (var context = new MvcDataContext())
            {
                var phot = new AlbumPhotoClass();
                phot.Id = Guid.NewGuid();
                phot.AlbumMod = context.album.Where(x => x.AlbumId == id).ToList();
                phot.PhotoMod = context.photo.Where(x => x.PhotoId == id).ToList();
                return View(phot);
            }
            

        }
        //[HttpPost]
        //public ActionResult Addphoto(Guid id, IEnumerable<Guid> photoids)
        //{
        //    using (var context = new MvcDataContext())
        //    {
        //        var album = context.album.FirstOrDefault(x => x.AlbumId == id);
        //        foreach (var photoid in photoids)
        //        {
        //            var photo = context.photo.FirstOrDefault(x => x.PhotoId == photoid);
        //            album.Photo.Add(photo);

        //        }

        //        context.SaveChanges();
        //        return View();
        //    }
           
        //}

        // GET: Album/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Album/Edit/5
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

        // GET: Album/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Album/Delete/5
        [HttpPost]
        public ActionResult DeleteAlbum(Guid id)
        {
            using (var context = new MvcDataContext())
            {
                var DeleteAlbum = context.album.Single(x => x.AlbumId == id);
            }
            // TODO: Add delete logic here
            return View();
        }
        public ActionResult DeleteAlbum(Guid id, FormCollection collection)
        {
            using (var context = new MvcDataContext())
            {
                var d = context.album.Single(x => x.AlbumId == id);
                context.album.Remove(d);
                context.SaveChanges();
            }
            return View("AlbumList");
        }
    }
}
