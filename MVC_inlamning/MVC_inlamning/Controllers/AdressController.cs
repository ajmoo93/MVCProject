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
            //if (!Person.Any())
            //{
            //    Person.Add(new PersonModel { PId = Guid.NewGuid(), Name = " Emil", AdressName = "Plingplongvägen", PhoneNumber = "075845758", date = DateTime.Now });
            //    Person.Add(new PersonModel { PId = Guid.NewGuid(), Name = "Tilda", AdressName = "Görgenvägen", PhoneNumber = "078454585", date = DateTime.Now });
            //}
        }
        public ActionResult ShowPerson()
        {
            return PartialView(Person);
        }
        
        public ActionResult NewPerson()
        {
            //var P = new PersonModel();
            //Person.Add(P);
            return View();
        } 
        [HttpPost]
        public ActionResult NewPerson(PersonModel pers)           
        {
            //var lahkneNyLahkme = Person.First(x => x.PId == pers.PId);
            pers.PId = Guid.NewGuid();
            if (!ModelState.IsValid)
            {
                //returnerar new person
                return View("NewPerson", pers);
            }
            // lägger til ldin person i listan
            Person.Add(pers);
            //retunerar en lista av person
            return PartialView("List", Person);
        }

        public ActionResult List()
        {
            return PartialView("List", Person);
        }


        [HttpPost]
        public ActionResult DeleteCon(Guid id)
        {
            var i = Person.FirstOrDefault(x => x.PId == id);
            Person.Remove(i);
            return View("NewPerson");

        }
        public ActionResult Edit(Guid id)
        {
            var pers = Person.First(x => x.PId == id);
            return View(pers);
        }

        [HttpPost]
        public ActionResult Edit(PersonModel person)
        {
            var pers = Person.FirstOrDefault(x => x.PId == person.PId);
            pers.Name = person.Name;
            pers.AdressName = person.AdressName;
            pers.PhoneNumber = person.PhoneNumber;
            pers.date = person.date;
                
            return PartialView("List", pers);
        }
    }
}
