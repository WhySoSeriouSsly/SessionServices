using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Session.Entities.Concrete
{
    public class Cart
    {
        public Cart()
        {
            CartLines = new List<CartLine>();//hiçbir ürün yokken hata vermemesi için
            //Burada cartlines başlar.
        }
        public List<CartLine> CartLines { get; set; }
        public decimal Total
        {
            get { return CartLines.Sum(c => c.Product.UnitPrice * c.Quantity); }
        }
    }
}
