﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspNetTatilSeyahat.Models.Siniflar;
using System.Runtime;

namespace AspNetTatilSeyahat.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c = new Context();
        public ActionResult Index()
        {
            
            var degerler = c.Blogs.Take(7).ToList(); // 7 tane blog göstercek ana sayfada resim
            return View(degerler);
        }

        public ActionResult About()
        {
            return View();
        }
        public PartialViewResult Partial1()
        {
            var degerler = c.Blogs.OrderByDescending(x=>x.Id).Take(2).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial2()
        {
            var degerler = c.Blogs.Where(x => x.Id == 8).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial3()
        {
            var deger = c.Blogs.Take(10).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial4()
        {
            var deger = c.Blogs.Take(3).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial5()
        {
            var deger = c.Blogs.Take(3).OrderByDescending(x => x.Id).ToList();
            return PartialView(deger);
        }
    }
}