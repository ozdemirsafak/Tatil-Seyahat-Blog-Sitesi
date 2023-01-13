using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspNetTatilSeyahat.Models.Siniflar
{
    public class Yorumlar
    {
        [Key]
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string Mail { get; set; }
        public string Yorum { get; set; }
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; } // Blog tablodan gelen olan degeri tutcak ilişkili.1 yorum sadece 1 blok için geçerli olabilir.Bir blogun 1 den fazla yorumu olabilir.
    }
}