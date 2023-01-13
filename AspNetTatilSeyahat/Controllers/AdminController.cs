using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspNetTatilSeyahat.Models.Siniflar;

namespace AspNetTatilSeyahat.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        // Bi alttaki webconfigden gelen istek üzerine giriş olursa buraya yönlendirsin diye yaptık
        [Authorize] 
        public ActionResult Index()
        {
            var degerler = c.Blogs.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniBlog(Blog p)
        {
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogSil(int id)
        {
            var b = c.Blogs.Find(id);
            c.Blogs.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        // Alt taraf Güncelleme ayrı sayfaya git ve o id den gelen değeri yeni sayfada açmak için bunu yaptık.
        public ActionResult BlogGetir(int? id)
        {
            var b1 = c.Blogs.Find(id);
            return View("BlogGetir", b1);
        }
        ////aşağıda da değerler değiştikten sonra göndermek için
        public ActionResult BlogGuncelle(Blog b)
        {
            var blg = c.Blogs.Find(b.Id);
            blg.Aciklama = b.Aciklama;
            blg.Baslik = b.Baslik;
            blg.BlogImage = b.BlogImage;
            blg.Tarih = b.Tarih;
            c.SaveChanges();
            return RedirectToAction("Index");
            

        }

        public ActionResult YorumListesi()
        {
            var yorumlar = c.Yorumlars.ToList();
            return View(yorumlar);
        }

        public ActionResult YorumSil(int? id)
        {
            var b = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(b);
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }

        ///Yorum Guncelleme İşlemi
        
        public ActionResult YorumGetir(int? id)
        {
            var yr = c.Yorumlars.Find(id);
            return View("YorumGetir", yr);
        }

        public ActionResult YorumGuncelle(Yorumlar y)
        {
            var yorumlar = c.Yorumlars.Find(y.Id);
            yorumlar.KullaniciAdi = y.KullaniciAdi;
            yorumlar.Mail = y.Mail;
            yorumlar.Yorum = y.Yorum;
            c.SaveChanges();
            return RedirectToAction("YorumListesi");


        }

        
    }
}