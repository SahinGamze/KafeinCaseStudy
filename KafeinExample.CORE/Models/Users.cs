using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KafeinExample.CORE.Models
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        public int TcKimlikNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Telefon { get; set; }
        public string Eposta { get; set; }
    }
}
