using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_inlamning.Models;
using System.Web.Mvc;

namespace MVC_inlamning.Controllers
{
    public class AdressController : Controller
    {
        public static List<PersonModel> Person = new List<PersonModel>();
        // GET: Adress
        public ActionResult Index()
        {
            return View();
        }
        public AdressController()
        {
            if (!Person.Any())
            {
                Person.Add(new PersonModel { PId = Guid.NewGuid(), Name = " Emil", AdressName = "Plingplongvägen", PhoneNumber = "0758457", date = DateTime.Now });
                Person.Add(new PersonModel { PId = Guid.NewGuid(), Name = "Tilda", AdressName = "Görgenvägen", PhoneNumber = "078454585", date = DateTime.Now });
            }
        }

        public ActionResult NewPerson(Guid id)
        {
            var P = new PersonModel();
            Person.Add(P);
            return View(P);
        }
        public ActionResult NewPersonCon(Guid id)
           
        {
            if (!ModelState.IsValid)
            {
                return View("Create", person);
            }
            man.Add(person);
            return RedirectToAction("Index");
        }
    }
}
            
        }
    }
}