using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Abc.MvcWebUI.Entity;

namespace Abc.MvcWebUI.Models
{
    public class CardModel
    {
        private List<CardLine> _cardLines = new List<CardLine>();

        public List<CardLine> Cardlines
        {
            get { return _cardLines; }
        }

        public void AddProduct(Product product, int quantity)
        {
            var line = _cardLines.FirstOrDefault(i => i.Product.Id == product.Id);
            if (line == null)
            {
                _cardLines.Add(new CardLine { Product = product, Quantity = quantity });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public void DeleteProduct(Product product)
        {
            _cardLines.RemoveAll(i => i.Product.Id == product.Id);
        }

        public double Total()//karttaki ürünlerin toplam fiyatı
        {
            return _cardLines.Sum(i => i.Product.Price * i.Quantity);
        }

        public void Clear()//sepetin boşaltılması
        {
            _cardLines.Clear();
        }
    }
    public class CardLine//her bir ürünü temsil eden obje
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }//adet
    }
}