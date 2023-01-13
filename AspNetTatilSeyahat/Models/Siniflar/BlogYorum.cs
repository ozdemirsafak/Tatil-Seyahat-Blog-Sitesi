using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace AspNetTatilSeyahat.Models.Siniflar
{
    public class BlogYorum
    {
        public IEnumerable<Blog> Deger1 { get; set; } // 1 view da birden fazla değere ulaşmak için yaptık çünkü view sayfası 1 modeli alabiliyor sadece.Blogları listelemek için
        public IEnumerable<Yorumlar> Deger2 { get; set; } // Yorumlaru listelemek için.

        public IEnumerable<Blog> Deger3 { get; set; } // Son blogları almak için yaptık.


    }
}