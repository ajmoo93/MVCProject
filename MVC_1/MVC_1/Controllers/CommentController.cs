using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_1.Models;
using System.Web.Mvc;

namespace MVC_1.Controllers
{
    public class CommentController : Controller
    {
        // GET: Comment
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Comment(ContreollerModel model)
        {
           
            return View();
        }
    }
}