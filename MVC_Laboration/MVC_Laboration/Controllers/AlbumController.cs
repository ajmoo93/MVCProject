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
            AlbumRepository albumrepo = new AlbumRepository();
            PhotoRepository photorepo = new PhotoRepository();
            //public static List<Album> albums = new List<Album>();
            //// GET: Album
            //public AlbumController()
            //{
            //    if (!albums.Any())
            //    {
            //        albums.Add(new Album { AlbumID = Guid.NewGuid(), AlbumName = "WaterSports", Photos = new List<Photo>(), AlbumComment = new List<Comments> { new Comments { CommentOnAlbum = "Photos with different watersports" } } });
            //        albums.Add(new Album { AlbumID = Guid.NewGuid(), AlbumName = "Boards", Photos = new List<Photo>(), AlbumComment = new List<Comments> { new Comments { CommentOnAlbum = "Photos on different kind of boards" } } });
            //    }

            //}
            public ActionResult Index()
            {
                return View(albumrepo.GetAllAlbums().Select(x => AlbumModelMapping.ModelToEntity(x)).ToList());
                //return View(albums);
            }
            public ActionResult IndexPartial(AlbumClass album)
            {
                return PartialView(album);
            }
            public ActionResult AddNewAlbum()
            {
                return View();
            }
            [HttpPost]
            public ActionResult AddNewAlbum(AlbumModel newalbum, string albumcomment)
            {
                newalbum.AlbumId = Guid.NewGuid();
                newalbum.AlbumName = newalbum.AlbumName;
                newalbum.AComment = new List<CommentModel> { new CommentModel { Id = Guid.NewGuid(), CommentAlbum = albumcomment } };
                var albums = AlbumModelMapping.EntityToModel(newalbum);
                albumrepo.AddNewAlbum(albums);
                return View(newalbum);
            }
            public ActionResult ShowAlbum(Guid id)
            {
                var showalbum = albumrepo.ShowAlbum(id);
                var show = AlbumModelMapping.ModelToEntity(showalbum);
                return PartialView("ShowAlbum", show);
            }
            public ActionResult AddComment(Guid id)
            {
                var p = albumrepo.ShowAlbum(id);
                var addcomment = AlbumModelMapping.ModelToEntity(p);
                return PartialView("AddComment", addcomment);
            }
            [HttpPost]
            public ActionResult AddComment(Guid id, string albumComment)
            {
                //var p = albums.FirstOrDefault(x => x.AlbumID == id);
                //p.AlbumComment.Add(new Comments { CommentOnAlbum = albumComment });
                var album = albumrepo.AddCommentToAlbum(id, albumComment);
                var albums = AlbumModelMapping.ModelToEntity(album);
                return PartialView("IndexPartial", albums);
            }
            public ActionResult AddPhotoToAlbum()
            {
                var model = new AlbumPhoto();
            model.AlbumMod = albumrepo.GetAllAlbums().Select(x => AlbumModelMapping.ModelToEntity(x)).ToList();
                model.PhotoMod = photorepo.GetAllPhoto().Select(x => PhotoModelMapping.ModelToEntity(x)).ToList();
                //var model = new ViewAlbumPhoto();
                //model.Photos = GalleryController.photos;
                //model.Albums = AlbumController.albums;
                return View(model);
            }
            [HttpPost]
            public ActionResult AddPhotoToAlbum(IEnumerable<Guid> photos, Guid albumID)
            {
                albumrepo.AddPhotoToAlbum(photos, albumID);
                //var album = albums.FirstOrDefault(x => x.AlbumID == albumID);
                //foreach (var item in photos)
                //{
                //    album.Photos.Add(GalleryController.photos.FirstOrDefault(x => x.PhotoID == item));
                //}
                return Content("OK!");
            }
        }
    }
