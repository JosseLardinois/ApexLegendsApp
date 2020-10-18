using ApexLegendsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static DataLibraryApex.BusinessLogic.KarakterProcessor;

namespace ApexLegendsApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult ViewKarakter()
        {
            ViewBag.Message = "Karakter Lijst";

            var data = LoadKarakters();

            List<KarakterModel> karakters = new List<KarakterModel>();
            
            foreach(var row in data)
            {
                karakters.Add(new KarakterModel
                {
                    KarakterID = row.KarakterId,
                    KarakterNaam = row.KarakterNaam,
                    KarakterSoort = row.KarakterSoort
                });
            }

            return View(karakters);
        }
        public ActionResult SignKarakterUp()
        {
            ViewBag.Message = "Karakter Sign up";

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignKarakterUp(KarakterModel model)
        {
            if (ModelState.IsValid)
            {
                int recordsGemaakt = CreateKarakter(
                    model.KarakterID, 
                    model.KarakterNaam,
                    model.KarakterSoort);
                return RedirectToAction("Index");
            }

            return View();
        }


    }
}