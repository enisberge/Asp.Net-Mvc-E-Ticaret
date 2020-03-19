using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Models
{
    public class ShippingDetailsModel
    {
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen adres tanımını giriniz  ")]
        public string AdresBasligi { get; set; }
        [Required(ErrorMessage = "Lütfen adres bilgisi giriniz  ")]
        public string Adres { get; set; }
        [Required(ErrorMessage = "Lütfen şehir bilgisi tanımını giriniz  ")]
        public string Sehir { get; set; }
        [Required(ErrorMessage = "Lütfen semt bilgisi tanımını giriniz  ")]
        public string Semt { get; set; }
        [Required(ErrorMessage = "Lütfen mahalle bilgisi tanımını giriniz  ")]
        public string Mahalle { get; set; }
        public string PostaKodu { get; set; }
    }
}