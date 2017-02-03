using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcLaborationData.Repository;
using System.Web.Mvc;
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
            return View(albumrepo.GetAllAlbums().Select(x => AlbumModelMapping.ModelToEntity(x)).ToList());
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
            var a = albumrepo.ShowAlbum(id);
            var Addcomment = AlbumModelMapping.ModelToEntity(a);
            return PartialView("AddComment", Addcomment);
        }
        [HttpPost]
        public ActionResult AddComment(Guid id, string albumComment)
        {
            var album = albumrepo.AddCommentToAlbum(id, albumComment);
            var albums = AlbumModelMapping.ModelToEntity(album);
            return PartialView("IndexPartial", albums);
        }

        public ActionResult AddPhotoToAlbum()
        {
            var aModel = new AlbumPhotoView();
            aModel.Albums = albumrepo.GetAllAlbums().Select(x => AlbumModelMapping.ModelToEntity(x)).ToList();
            aModel.Photos = photorepo.GetAllPhotos().Select(x => PhotoModelMapping.ModelToEntity(x)).ToList();
            return View(aModel);
        }

        public ActionResult AddPhotoToAlbum(IEnumerable<Guid> photos, Guid albumid)
        {
            albumrepo.AddPhotoToAlbum(photos, albumid);
            return Content("Good!");
        }
    }
}