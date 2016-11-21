//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using MVC_1.Models;
//using System.Web.Mvc;

//namespace MVC_1.Controllers
//{
//    public class CommentController : Controller
//    {
//        private static ContreollerModel Vmodel;
//        // GET: Comment
//        public ActionResult Comment()
//        {
//            Vmodel = new ContreollerModel();
//            return View(Vmodel);
//        }
//        [HttpPost]
//        public ActionResult Comment(ContreollerModel model)
//        {
//           if(ModelState.IsValid)
//            {
//                Vmodel.comments.Add(new Comment() { CommentData = model.CommentData });
//            }
//            return View("Comment", Vmodel);
//        }
//    }
//}