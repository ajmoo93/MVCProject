using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_1.Controllers
{
    public class AlbumController : Controller
    {
        // GET: Album
        public ActionResult NewAlbum(Models.AlbumModel album)
        {
            var alb = new  AlbumModel()
                {

            }
            return View();
        }
    }
}