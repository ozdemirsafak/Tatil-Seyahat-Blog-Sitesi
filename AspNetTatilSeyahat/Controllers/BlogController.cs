using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspNetTatilSeyahat.Models.Siniflar;


namespace AspNetTatilSeyahat.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context c = new Context();
        BlogYorum by = new BlogYorum(); // blogyorumdan nesne türettik.
        public ActionResult Index()
        {
            // var bloglar = c.Blogs.ToList();
            by.Deger1 = c.Blogs.ToList();
            by.Deger3 = c.Blogs.Take(3).ToList(); // 3 tane blogun listesini al anlamında
            return View(by);

        }

        public ActionResult BlogDetay(int? id)
        {
            // var blogbul = c.Blogs.Where(x => x.Id == id).ToList(); //blogun id si gelen id ye eşitse gösteriyor
            by.Deger1 = c.Blogs.Where(x => x.Id == id).ToList();
            by.Deger2 = c.Yorumlars.Where(x => x.BlogId == id).ToList();
            return View(by);
        }

        [HttpGet]
        public PartialViewResult YorumYap(int? id)
        {
            ViewBag.deger = id; // blog blogdetay yorum kısmında id yi aldık seçmeli yapcaz
            return PartialView();
        }

       [HttpPost]
        public PartialViewResult YorumYap(Yorumlar y)
        {
            c.Yorumlars.Add(y);
            c.SaveChanges();
            return PartialView();
        }
       
        

    }
}