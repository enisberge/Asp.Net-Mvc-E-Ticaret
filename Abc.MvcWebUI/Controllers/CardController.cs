using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Web.Mvc;
using Abc.MvcWebUI.Entity;
using Abc.MvcWebUI.Models;

namespace Abc.MvcWebUI.Controllers
{
    public class CardController : Controller
    {
        DataContext dbContext = new DataContext();

        public ActionResult Index()
        {
            return View(GetCard());
        }
        public ActionResult AddtoCard(int Id)
        {
            var product = dbContext.Products.Where(i => i.Id == Id).FirstOrDefault();
            if (product != null)
            {
                GetCard().AddProduct(product, 1);
            }
            return RedirectToAction("Index");
        }

        public ActionResult RemoveFromCard(int Id)
        {
            var product = dbContext.Products.FirstOrDefault(i => i.Id == Id);
            if (product != null)
            {
                GetCard().DeleteProduct(product);
            }
            return RedirectToAction("Index");
        }

        public CardModel GetCard()
        {
            var card = (CardModel)Session["Card"];

            if (card == null)
            {
                card = new CardModel();
                Session["Card"] = card;//session içinde kart nesnesi saklanacak böylece tekrar tekrar kart oluşturulmayacak
            }

            return card;
        }

        public PartialViewResult Summary()
        {
            return PartialView(GetCard());
        }
        [Authorize] //burayı bu şekilde yaparsak kullanıcı yalnızca login olursa checkoutu görür
        public ActionResult Checkout()
        {
            return View(new ShippingDetailsModel());
        }
        [HttpPost]
        public ActionResult Checkout(ShippingDetailsModel entity)
        {
            var card = GetCard();
            if (card.Cardlines.Count == 0)
            {
                ModelState.AddModelError("UrunYokError", "Sepetinizde Ürün Bulunmamaktadır !");
            }
            else
            {
                if (ModelState.IsValid)
                {
                    //sorunsuz ise Siparişi Veritabanına Kayde

                    SaveOrder(card, entity);

                    card.Clear();//cardı sıfırla
                    return View("Completed");
                }
                else
                {
                    return View(entity);
                }
            }

            return View(new ShippingDetailsModel());
        }

        private void SaveOrder(CardModel card, ShippingDetailsModel entity)
        {
            var order = new Order();
            order.OrderNumber = "A" + (new Random()).Next(11111, 99999).ToString();
            order.Total = card.Total();
            order.OrderDate = DateTime.Now;
            order.OrderState = EnumOrderState.Waiting;
            order.UserName = User.Identity.Name;

            order.AdresBasligi = entity.AdresBasligi;
            order.Adres = entity.Adres;
            order.Sehir = entity.Sehir;
            order.Semt = entity.Semt;
            order.Mahalle = entity.Mahalle;
            order.PostaKodu = entity.PostaKodu;

            order.OrderLines = new List<OrderLine>();

            foreach (var pr in card.Cardlines)
            {
                var orderLine = new OrderLine();
                orderLine.Quantity = pr.Quantity;
                orderLine.Price = pr.Quantity * pr.Product.Price;
                orderLine.ProductId = pr.Product.Id;

                order.OrderLines.Add(orderLine);
            }

            dbContext.Orders.Add(order);
            dbContext.SaveChanges();
        }
    }
}
