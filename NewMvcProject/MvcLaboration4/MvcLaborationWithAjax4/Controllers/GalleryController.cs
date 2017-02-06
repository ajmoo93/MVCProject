using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using MvcLaborationdata.Repository;
using MvcLaborationWithAjax4.Mapping;
using MvcLaborationWithAjax4.Models;

namespace MvcLaborationWithAjax4.Controllers
{
    public class GalleryController : Controller
    {
        PhotoRepository photorepo = new PhotoRepository();
        // GET: Gallery

        
        public ActionResult Index()
        {

            return View(photorepo.GetPhotos().Select(x => PhotoModelMapping.ModelToEntity(x)).ToList());
        }

        public ActionResult IndexPartial(Photo photo)
        {
            return PartialView(photo);
        }

        public ActionResult AddNewPhoto()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNewPhoto(string comment, HttpPostedFileBase[] files, Photo newphoto)
        {
            Thread.Sleep(3000);
            if (!ModelState.IsValid)
            {
                return View(newphoto);
            }
            if (files == null)
            {
                ModelState.AddModelError("error", "No picture");
            }
            foreach (var file in files)
            {
                file.SaveAs(Path.Combine(Server.MapPath("/Image"), file.FileName));
                newphoto.PhotoID = Guid.NewGuid();
                newphoto.PhotoName = file.FileName;
                newphoto.PhotoComment = new List<Comments> {new Comments {Id = Guid.NewGuid(), CommentOnPicture = comment} };
                var photos = PhotoModelMapping.EntityToModel(newphoto);
                photorepo.AddPhoto(photos);
            }
            return PartialView("Index", photorepo.GetPhotos().Select(x => PhotoModelMapping.ModelToEntity(x)).ToList());
        }

        public ActionResult ShowPhoto(Guid id)
        {
            var showphotos = photorepo.GetPhoto(id);
            var showphot = PhotoModelMapping.ModelToEntity(showphotos);
            return PartialView(showphot);
        }

        public ActionResult AddComment(Guid id)
        {
            var photo = photorepo.GetPhoto(id);
            var phot = PhotoModelMapping.ModelToEntity(photo);
            return PartialView("AddComment", phot);
        }
        [HttpPost]
        public ActionResult AddComment(Guid id, string photoComment)
        {
            var photo = photorepo.AddCommentPhoto(id, photoComment);
            var photos = PhotoModelMapping.ModelToEntity(photo);
            return PartialView("IndexPartial", photos);
        }
        [HttpPost]
        public ActionResult DeletePhoto(Guid id, Photo photo)
        {
            var phot = photorepo.GetPhoto(id);
            string fullpath = Request.MapPath("~/images/" + phot.PhotoName);
            if (System.IO.File.Exists(fullpath))
            {
                System.IO.File.Delete(fullpath);
                photorepo.DeletePhoto(phot);
            }

            return RedirectToAction("Index", photorepo.GetPhotos().Select(x => PhotoModelMapping.ModelToEntity(x)).ToList());
        }

       
    }
}