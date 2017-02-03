using MVCProjektData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCProjektData.Repositories;
using MVC_Laboration.Models;

using System.Web.Mvc;
using MVC_Laboration.Mapping;

namespace MVC_Laboration.Controllers
{
        // GET: Album
        public class AlbumController : Controller
        {
            public static List<AlbumModel> albumrepo = new List<AlbumModel>();
            //PhotoRepository photorepo = new PhotoRepository();
        //public static List<Album> albums = new List<Album>();
        //// GET: Album
        public AlbumController()
        {
            if (!albumrepo.Any())
            {
                albumrepo.Add(new AlbumModel { AlbumId = Guid.NewGuid(), AlbumName = "Earth", Photo = new List<PhotoModel>(),AComment  = new List<CommentModel> { new CommentModel { CommentAlbum = "Cows" } } });
                albumrepo.Add(new AlbumModel { AlbumId = Guid.NewGuid(), AlbumName = "Boards", Photo = new List<PhotoModel>(), AComment = new List<CommentModel> { new CommentModel { CommentAlbum = "Photos on different kind of boards" } } });
            }

        }
        public ActionResult Index()
        {
            return View(albumrepo);
        }
        public ActionResult ShowAlbum(Guid id)
        {
            var showalbum = albumrepo.FirstOrDefault(x => x.AlbumId == id);
            return PartialView("ShowAlbum", showalbum);
        }
        public ActionResult AddComment(Guid id)
        {
            var p = albumrepo.FirstOrDefault(x => x.AlbumId == id);
            return PartialView("AddComment", p);
        }
        [HttpPost]
        public ActionResult AddComment(Guid id, string albumComment)
        {
            var p = albumrepo.FirstOrDefault(x => x.AlbumId == id);
            p.AComment.Add(new CommentModel { CommentAlbum = albumComment });
            return PartialView("Index", albums);
        }
        public ActionResult AddPhotoToAlbum()
        {
            var model = new AlbumPhoto();
            model.PhotoMod = GalleryController.;
            model.AlbumMod = AlbumController.albumrepo;
            return View(model);
        }
        [HttpPost]
        public ActionResult AddPhotoToAlbum(IEnumerable<Guid> photos, Guid albumID)
        {
            var album = albumrepo.FirstOrDefault(x => x.AlbumId == albumID);
            foreach (var item in photos)
            {
                album.Photo.Add(GalleryController..FirstOrDefault(x => x.PhotoID == item));
            }
            return Content("OK!");
        }
    }
}
