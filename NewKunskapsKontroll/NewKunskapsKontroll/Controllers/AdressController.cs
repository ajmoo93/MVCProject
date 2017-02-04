using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewKunskapsKontroll.Models;

namespace NewKunskapsKontroll.Controllers
{
    public class AdressController : Controller
    {
        private static IList<AdressBok> Adresses = new List<AdressBok>();
        // GET: Adress
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(AdressBok newAdres)
        {
            newAdres.Id = Guid.NewGuid();
            Adresses.Add(newAdres);
            return View();
        }

        public ActionResult AlbumList()
        {
            return PartialView("AlbumList", Adresses);
        }

        public ActionResult Edit(Guid id)
        {
            var adress = Adresses.First(x => x.Id == id);
            return View(adress);
        }
        [HttpPost]
        public ActionResult Edit(Guid id, string name, string adress, DateTime date)
        {
            var Nadress = Adresses.First(x => x.Id == id);
            if (Nadress != null)
            {

                Nadress.Name = name;
                Nadress.Adress = adress;
                Nadress.date = date;
            }
            return View(Nadress);
        }

        public ActionResult Delete(Guid id)
        {
            var DeleteAlbum = Adresses.First(x => x.Id == id);
            return View(DeleteAlbum);
        }
        [HttpPost]
        public ActionResult Delete( AdressBok adress)
        {
            var DeleteAlbum = Adresses.First(x => x.Id == adress.Id);
            Adresses.Remove(DeleteAlbum);
            return View();

        }
    }
}