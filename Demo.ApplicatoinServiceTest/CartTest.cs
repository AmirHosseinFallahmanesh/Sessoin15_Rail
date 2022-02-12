using Demo.ApplicationService;
using Xunit;

namespace Demo.ApplicatoinServiceTest
{
    public class CartTest
    {
        [Fact]
        public void CanAddItem()
        {
            Cart cart = new Cart();
            cart.AddItem("iphone13", 2500, 2);
            int count=cart.GetCartLines().Count;
            Assert.Equal(1, count);

        }

        [Fact]
        public void CanCalculateTotalPrice()
        {
            Cart cart = new Cart();
            cart.AddItem("iphone13", 2500, 2);
            cart.AddItem("S22", 1500, 1);
            double result=cart.CalulateTotalPrice();
            Assert.Equal(6500,result);
        }

        [Fact]
       public void CanAddDiscount()
        {
            Cart cart = new Cart();
            cart.AddItem("iphone13", 2000, 2);
            cart.AddItem("S22", 1000, 1);
            cart.AddDiscount(20);
            double result = cart.CalulateTotalPrice();
            Assert.Equal(4000, result);
        }

        [Fact]
        public void CanRemoveItem()
        {
            Cart cart = new Cart();
            cart.AddItem("iphone13", 2000, 2);
            cart.RemoveItem("iphone13");
            int count = cart.GetCartLines().Count;
            Assert.Equal(0, count);


        }

        [Fact]
        public void CanUpdateItem()
        {
            Cart cart = new Cart();
            cart.AddItem("iphone13", 2000,2);
            cart.UpdateCartLine("iphone13", 2000,4);
            double result=cart.CalulateTotalPrice();
            Assert.Equal(8000, result);
        }

        [Fact]
        public void CanClearCart()
        {
            Cart cart = new Cart();

            cart.AddItem("iphone13", 2000, 2);

            cart.Clear();
            int result=cart.GetCartLines().Count;
            Assert.Equal(0, result);
        }
    }
}
