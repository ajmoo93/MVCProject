using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCProjektData;
using System.Data.Entity;
using System.Web.Mvc;

namespace MVC_Laboration.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        // GET: Account/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Account/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Account/Create
        [HttpPost]
        public ActionResult CreateUser(Guid id, AccountClass user)
        {

            using (var context = new MvcDataContext())
            {
                var NewUser = new AccountClass();
                NewUser.FirstName = user.FirstName;
                NewUser.LastName = user.LastName;
                NewUser.Email = user.Email;
                NewUser.Password = user.Password;
                NewUser.Id = Guid.NewGuid();
                context.account.Add(NewUser);
                context.SaveChanges();
            }
            // TODO: Add insert logic here

            return View();
        }
    }
    // POST: Account/Edit/5
    //[HttpPost]
    //public ActionResult EditUser(Guid id, AccountClass user)
    //{
    //    using (var context = new MvcDataContext())
    //    {
    //        var UserUpdate = context.account.Single(x => x.Id == id);
    //        UserUpdate.FirstName = user.FirstName;
    //        UserUpdate.LastName = user.LastName;
    //        UserUpdate.Email = user.Email;
    //        UserUpdate.Password = user.Password;
    //        context.SaveChanges();
    //    }
    //    // TODO: Add update logic here

    //    return View();
    //}
    //[HttpPost]
    //public ActionResult DeleteUser(Guid id)
    //{
    //    using (var context = new MvcDataContext())
    //    {
    //        var user = context.account.Single(x => x.Id == id);
    //        context.account.Remove(user);
    //        context.SaveChanges();
    //    }
       
    //    return View();
    //}
}

// POST: Account/Delete/5



