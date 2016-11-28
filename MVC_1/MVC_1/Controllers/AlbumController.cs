using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_1.Models;
using System.Web.Mvc;

namespace MVC_1.Controllers
{
    public class AlbumController : Controller
    {
        //Gör en ny Lista av AlbumModel
        public static List<AlbumModel> albume = new List<AlbumModel>();

        // GET: Album
        public ActionResult Index()
        {
            //Retunerar Listan Albume
            return View(albume);
        }
        public ActionResult CreateAlbum(AlbumModel album)
        {
            //Här skapar vi ett album
            albume.Add(album);
            return View();
        }
        //En konstruktor som tar hans om nya album
        public AlbumController()
        {
            if (!albume.Any())
            {
                albume.Add(new AlbumModel { AlbumID = Guid.NewGuid(), AlbumName = "Animals", pic = new List<MyModel>(), albumCom = new List<Comment> { new Comment { CommentAlbum = "Cows are cute" } } });
                albume.Add(new AlbumModel { AlbumID = Guid.NewGuid(), AlbumName = "Wobbely", pic = new List<MyModel>(), albumCom = new List<Comment> { new Comment { CommentAlbum = "Tigers are beautiful" } } });
            }
        }
        //Funktion för att lägga till foto i Album
        public ActionResult AddPhoto()
        {
            //Skapar upp en ny Lista
            var Mod = new Albumphoto();
            //för var picture i listan så tar vi från homekontrollern (Listan db Med bilder)
            Mod.picmod = HomeController.db;
            Mod.albumphoto = AlbumController.albume;
            //sen retunerar vi den nya Listan
            return View(Mod);

        }
        [HttpPost]
        public ActionResult AddPhoto(IEnumerable<Guid> pic, Guid Id)
        {
            var almbum = albume.FirstOrDefault(x => x.AlbumID == Id);
            foreach(var item in pic)
            {
                almbum.pic.Add(HomeController.db.FirstOrDefault(x => x.ID == item));
            }
            return View(almbum);
        }
       
        public ActionResult DeleteAlbum(Guid id)
        {
            var a = albume.FirstOrDefault(x => x.AlbumID == id);
            return View(a);
        }
        [HttpPost ActionName("DeleteAlbum")]
        public ActionResult DeleteAlbumConferm(Guid id)
        {
            var i = albume.FirstOrDefault(x => x.AlbumID == id);
            albume.Remove(i);
            return RedirectToAction("Index");
        }
    }

}