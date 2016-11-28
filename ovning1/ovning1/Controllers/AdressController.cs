using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ovning1.Models;
using System.Web.Mvc;

namespace ovning1.Controllers
{
    public class AdressController : Controller
    {
        public static List<AdressModel> Person = new List<AdressModel>();
        // GET: Adress
        public ActionResult Index()
        {
            return View();
        }
        public AdressController()
        {
            if(!Person.Any())
            {
                Person.Add(new AdressModel { id = Guid.NewGuid(), Name = " Emil", AdressName = "Plingplongvägen", PhoneNumber = "0758457", date = DateTime.Now });
                Person.Add(new AdressModel { id = Guid.NewGuid(), Name = "Tilda", AdressName = "Görgenvägen", PhoneNumber = "078454585", date = DateTime.Now });
            }
        }
            
        public ActionResult NewPerson()
        {

            return View();
        }
    }
}