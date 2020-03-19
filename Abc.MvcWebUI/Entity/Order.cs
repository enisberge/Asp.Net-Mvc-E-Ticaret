using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Entity
{
    public class Order
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }//sipariş no
        public double Total { get; set; }//karttaki ödenmesi gereken miktar
        public DateTime OrderDate { get; set; }
        public EnumOrderState OrderState { get; set; }

        public string UserName { get; set; }
        public string AdresBasligi { get; set; }
        public string Adres { get; set; }
        public string Sehir { get; set; }
        public string Semt { get; set; }
        public string Mahalle { get; set; }
        public string PostaKodu { get; set; }

        public virtual List<OrderLine> OrderLines { get; set; }//siparişin detay bilgileri burada saklanacak
    }
    public class OrderLine//her bir elemanı temsil eden satır
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }

        public int Quantity { get; set; }
        public double Price { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }



    }
}