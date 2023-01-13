using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspNetTatilSeyahat.Models.Siniflar;

namespace AspNetTatilSeyahat.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Hakkimizdas.ToList(); // Context içinde bulunan tablolardan hakkimizdasa ulas ve listeye çevir.
            return View(degerler);
        }
    }
}