﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcLaboration4.Models;

namespace MvcLaboration4.Controllers
{
    public class GalleryController : Controller
    {
        public static List<Photo> photos = new List<Photo>();

        // GET: Gallery
        public GalleryController()
        {
            if (!photos.Any())
            {

                photos.Add(new Photo { PhotoID = Guid.NewGuid(), PhotoName = "Cat1.jpg", PhotoComment = new List<Comments> { new Comments { CommentOnPicture = "Cat one" } } });
                photos.Add(new Photo { PhotoID = Guid.NewGuid(), PhotoName = "Cat2.jpeg", PhotoComment = new List<Comments> { new Comments { CommentOnPicture = "Cat two" } } });
                photos.Add(new Photo { PhotoID = Guid.NewGuid(), PhotoName = "Cat3.jpg", PhotoComment = new List<Comments> { new Comments { CommentOnPicture = "Cat three" } } });
                photos.Add(new Photo { PhotoID = Guid.NewGuid(), PhotoName = "Cat4.jpg", PhotoComment = new List<Comments> { new Comments { CommentOnPicture = "Cat four" } } });
                
            }
        }
        public ActionResult Gallery()
        {
            return View(photos);
        }

        public ActionResult ShowImage(Guid id)
        {
            var showphoto = photos.FirstOrDefault(x => x.PhotoID == id);
            return View(showphoto);
        }
        public ActionResult UploadPicture()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UploadPicture(string comment, HttpPostedFileBase[] files, Photo photo)
        {
            if (!ModelState.IsValid)
            {
                return View(photo);
            }
            if (files == null)
            {
                ModelState.AddModelError("error", "Ingen Bild!");
                return View(photo);
            }
            foreach (var file in files)
            {
                file.SaveAs(
                Path.Combine(Server.MapPath("~/Image"), file.FileName));
                photos.Add(new Photo { PhotoID = Guid.NewGuid(), PhotoName = file.FileName, PhotoComment = new List<Comments> { new Comments { CommentOnPicture = comment } } });
            }

            return View();
        }
        public ActionResult DeletePicture(Guid id)
        {
            var photo = photos.FirstOrDefault(x => x.PhotoID == id);
            return View(photo);
        }
        [HttpPost]
        public ActionResult DeletePicture(Guid id, Photo photo)
        {

            var p = photos.FirstOrDefault(x => x.PhotoID == id);
            string fullPath = Request.MapPath("~/Image/" + p.PhotoName);

            if (System.IO.File.Exists(fullPath))
            {
                System.IO.File.Delete(fullPath);
                //Session["DeleteSuccess"] = "Yes";
                photos.Remove(p);
            }
            return RedirectToAction("Gallery");
        }
        public ActionResult AddComment(Guid id)
        {
            var p = photos.FirstOrDefault(x => x.PhotoID == id);
            return PartialView("AddComment", p);
        }

        [HttpPost]
        public ActionResult AddComment(Guid id, string photoComment)
        {
            var p = photos.FirstOrDefault(x => x.PhotoID == id);
            p.PhotoComment.Add(new Comments { CommentOnPicture = photoComment });
            return PartialView("Index", p);

        }
    }
}
