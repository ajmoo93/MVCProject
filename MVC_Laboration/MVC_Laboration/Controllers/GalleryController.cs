using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCProjektData;
using System.Web.Mvc;
using System.IO;
using System.Data.Entity;

namespace MVC_Laboration.Controllers
{
    public class GalleryController : Controller
    {
        MvcDataContext db = new MvcDataContext();
        // GET: Gallery
        public ActionResult Index()
        { 
            return View();
        }
        //public ActionResult PhotList()
        //{
        //    using (var context = new MvcDataContext())
        //    {
        //        var NewPhoto = new PhotoClass();
        //        NewPhoto.PhotoId = Guid.NewGuid();
        //        NewPhoto.PhotoName = "wowowowow";
        //        context.photo.Add(NewPhoto);

        //    }
        //    return View();
        //}
        public ActionResult PhotList()
        {
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
        public ActionResult Create(Models.PhotoModel photo, HttpPostedFileBase file)
        {
            using (var context = new MvcDataContext())
            {

                // TODO: Add insert logic here

                if (photo != null)
                {
                    var phot = new PhotoClass();



                    phot.PhotoName = file.FileName;
                    phot.PhotoId = Guid.NewGuid();
                    phot.Date = DateTime.Now;
                    Path.GetFileName(file.FileName);
                    file.SaveAs(Path.Combine(Server.MapPath("~/Pictures"), file.FileName));
                    context.photo.Add(phot);
                    context.SaveChanges();
                }


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
        public ActionResult Delete(Guid id)
        {
            using (var context = new MvcDataContext())
            {
                var pht = context.photo.Single(x => x.PhotoId == id);
                return View();
            }
                
        }

        // POST: Gallery/Delete/5
        [HttpPost]
        public ActionResult Delete(Guid id,FormCollection collection)
        {
            using (var context = new MvcDataContext())
            {
                var i = context.photo.Single(x => x.PhotoId == id);
                
                context.photo.Remove(i);
                context.SaveChanges();
            }
                // TODO: Add delete logic here

                return RedirectToAction("PhotList");


        }
        public ActionResult Comment()
        {
            using (var context = new MvcDataContext())
            {
               
            }
            return View();
        }
        [HttpPost]
        public ActionResult Comment(string commentphoto)
        {
            using (var context = new MvcDataContext())
            {
                var NewComment = new CommentClass();
                NewComment.CommentPhoto = commentphoto;
                context.comment.Add(NewComment);
                context.SaveChanges();
            }
            return View("PhotList");
        }
    }
}
