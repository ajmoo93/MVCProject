using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcLaboration4.Models;

namespace MvcLaboration4.Controllers
{
    public class AlbumController : Controller
    {
        public static List<Album> albums = new List<Album>();

        public AlbumController()
        {
            if (!albums.Any())
            {
                albums.Add(new Album {AlbumID = Guid.NewGuid(), AlbumName = "WinterWonderLand", Photos = new List<Photo>(), AlbumComments = new List<Comments> {new Comments {CommentOnAlbum = "Photos are wonderful"} } });
                albums.Add(new Album { AlbumID = Guid.NewGuid(), AlbumName = "SummerLand", Photos = new List<Photo>(), AlbumComments = new List<Comments> { new Comments { CommentOnAlbum = "Summer are great" } } });
            }
        }
        // GET: Album
        public ActionResult Index()
        {
            return View(albums);
        }

        public ActionResult CreateAlbum(Album album)
        {
            albums.Add(album);
            return View();
        }

        public ActionResult AddPhotoAlbum()
        {
            var model = new AlbumPhotoView();
            model.Photos = GalleryController.photos;
            model.Albums = albums;
            return View(model);
        }
        [HttpPost]
        public ActionResult AddPhotoAlbum(IEnumerable<Guid>photos, Guid albumId )
        {
            var album = albums.FirstOrDefault(x => x.AlbumID == albumId);
            foreach (var item in photos)
            {
                album.Photos.Add(GalleryController.photos.FirstOrDefault(x => x.PhotoID == item));
            }
            return Content("nice.");
        }

        public ActionResult Details(Guid id)
        {
            var showalbum = albums.FirstOrDefault(x => x.AlbumID == id);
            return View(showalbum);
        }

        public ActionResult Edit(Guid id)
        {
            var albumcomment = albums.FirstOrDefault(x => x.AlbumID == id);
            return View(albumcomment);
        }
        [HttpPost]
        public ActionResult Edit(Guid id, string albumComments)
        {
            var albumcomment = albums.FirstOrDefault(x => x.AlbumID == id);
            albumcomment.AlbumComments.Add(new Comments {CommentOnAlbum = albumComments});
            return View();
        }
    }
}