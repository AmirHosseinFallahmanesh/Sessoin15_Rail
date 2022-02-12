using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.ApplicationService
{
    public class Cart
    {
        private List<CartLine> cartLines = new List<CartLine>();
        private double disocunt = 0;
        public void AddItem(string product,double price,int qunatity)
        {
            CartLine cartLine = new CartLine()
            {
                Price = price,
                Product = product,
                Quantity = qunatity
            };
            cartLines.Add(cartLine);
        }

        public List<CartLine> GetCartLines()
        {
            return cartLines;
        }

        public double CalulateTotalPrice()
        {
            double totalPrice = cartLines.Sum(a => a.Quantity * a.Price);
            double discount = totalPrice * (disocunt / 100);
            double finalPrice = totalPrice - discount;
            return finalPrice;
            
        }

        public void AddDiscount(int discount)
        {
            this.disocunt = discount;
        }

        public void RemoveItem(string product)
        {
            CartLine cartLine = cartLines.First(a => a.Product == product);
            cartLines.Remove(cartLine);


        }

        public void UpdateCartLine(string product, double price, int qunatity)
        {
            int index = cartLines.FindIndex(a => a.Product == product);
            cartLines[index].Price = price;
            cartLines[index].Quantity = qunatity;
        }

        public void Clear()
        {
            cartLines.Clear();
        }
    }

    public class CartLine
    {
        public  string Product { get; set; }
        public  double Price { get; set; }

        public int Quantity { get; set; }
    }
}
