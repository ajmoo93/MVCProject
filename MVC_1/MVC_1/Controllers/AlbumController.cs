﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_1.Models;
using System.Web.Mvc;

namespace MVC_1.Controllers
{
    public class AlbumController : Controller
    {
        public static List<AlbumModel> albume = new List<AlbumModel>();

        // GET: Album
        public ActionResult Index()
        {
            return View(albume);
        }
        public ActionResult CreateAlbum(AlbumModel album)
        {
            albume.Add(album);
            return View();
        }
        public AlbumController()
        {
            if (!albume.Any())
            {
                albume.Add(new AlbumModel { AlbumID = Guid.NewGuid(), AlbumName = "Animals", pic = new List<MyModel>(), albumCom = new List<Comment> { new Comment { CommentAlbum = "Cows are cute" } } });
                albume.Add(new AlbumModel { AlbumID = Guid.NewGuid(), AlbumName = "Wobbely", pic = new List<MyModel>(), albumCom = new List<Comment> { new Comment { CommentAlbum = "Tigers are beautiful" } } });
            }
        }
        public ActionResult AddPhoto()
        {
            var Mod = new Albumphoto();
            Mod.picmod = HomeController.db;
            Mod.albumphoto = AlbumController.albume;
            return View(Mod);

        }

        public ActionResult AddPhoto(IEnumerable<Guid> pictures, Guid id)
        {
           
            return View();
        }
       
        public ActionResult DeleteAlbum(Guid id)
        {
            return View();
        }
    }
}