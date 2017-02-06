using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcLaborationdata.Repository;
using System.Web.Mvc;
using MvcLaborationdata.Entities;
using MvcLaborationWithAjax4.Mapping;
using MvcLaborationWithAjax4.Models;

namespace MvcLaborationWithAjax4.Controllers
{
    public class AlbumController : Controller
    {
        AlbumRepository albumrepo = new AlbumRepository();
        PhotoRepository photorepo = new PhotoRepository();
        // GET: Album
        public ActionResult Index()
        {
            return View(albumrepo.GetAlbum().Select(x => AlbumModelMapping.ModelToEntity(x)).ToList());
        }

        public ActionResult IndexPartial(Album album)
        {
            return PartialView(album);
        }

        public ActionResult AddNewAlbum()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddNewAlbum(Album newalbum, string albumcomment)
        {
            newalbum.AlbumID = Guid.NewGuid();
            newalbum.AlbumName = newalbum.AlbumName;
            newalbum.AlbumComments = new List<Comments> {new Comments {Id = Guid.NewGuid(), CommentOnAlbum = albumcomment} };
            var albums = AlbumModelMapping.EntityToModel(newalbum);
            albumrepo.AddAlbum(albums);
            return View(newalbum);
        }

        public ActionResult ShowAlbum(Guid id)
        {
            var s = albumrepo.ShowAlbum(id);
            var show = AlbumModelMapping.ModelToEntity(s);
            return PartialView("ShowAlbum", show);
        }

        public ActionResult AddComment(Guid id)
        {
            var a = albumrepo.ShowAlbum(id);
            var Addcomment = AlbumModelMapping.ModelToEntity(a);
            return PartialView("AddComment", Addcomment);
        }
        [HttpPost]
        public ActionResult AddComment(Guid id, string albumComment)
        {
            var album = albumrepo.AddComment(id, albumComment);
            var albums = AlbumModelMapping.ModelToEntity(album);
            return PartialView("IndexPartial", albums);
        }

        public ActionResult AddPhotoToAlbum()
        {
            var aModel = new AlbumPhotoView();
            aModel.Albums = albumrepo.GetAlbum().Select(x => AlbumModelMapping.ModelToEntity(x)).ToList();
            aModel.Photos = photorepo.GetPhotos().Select(x => PhotoModelMapping.ModelToEntity(x)).ToList();
            return View(aModel);
        }
        //[HttpPost]
        //public ActionResult AddPhotoToAlbum(IEnumerable<Guid> photos, Guid albumid)
        //{
        //    albumrepo.AddPhotoToAlbum(photos, albumid);
           
        //    return Content("Good!");
        //}
    }
}