using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KafeinExample.CORE.Models
{
    public class Products
    {
        [Key]
        public int UrunId { get; set; }
        public string UrunAdi { get; set; }
        public string Aciklama { get; set; }
        public int Fiyat { get; set; }
    }
}
