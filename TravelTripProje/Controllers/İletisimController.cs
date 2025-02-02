using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Sınıflar;

namespace TravelTripProje.Controllers
{
    public class İletisimController : Controller
    {
        // GET: İletisim
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult İlet()
        {
            return View();
        }
        [HttpPost]
        public ActionResult İlet(İletisim iltsm)
        {
            if (ModelState.IsValid)
            {
                c.İletisims.Add(iltsm);
                c.SaveChanges();
                TempData["Message"] = "Mesajınız başarıyla gönderildi! En yakın zamanda dönüş yapılacaktır...";
                return RedirectToAction("Index");
            }
            return View(iltsm);
        }
    }
}