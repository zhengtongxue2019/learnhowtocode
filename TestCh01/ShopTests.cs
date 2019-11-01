using System.Collections.Generic;
using NUnit.Framework;

namespace TestCh01
{
    [TestFixture]
    public class ShopTests
    {
        [Test]
        public void price_95_test()
        {
            Shop shop = new Shop();
            List<Product> products = new List<Product>();
            Product product = new Product();
            product.price = 100;
            product.quantity = 10;
            products.Add(product);
            double totalPrice = 0.0f;
            shop.CalcPrice(products, ref totalPrice);
            Assert.AreEqual(100 * 10 * 0.95, totalPrice);
        }

        [Test]
        public void price_99_test()
        {
            Shop shop = new Shop();
            List<Product> products = new List<Product>();
            Product product = new Product();
            product.price = 90;
            product.quantity = 10;
            products.Add(product);
            double totalPrice = 0.0f;
            shop.CalcPrice(products, ref totalPrice);
            Assert.AreEqual(90 * 10 * 0.99, totalPrice);
        }

        [Test]
        public void price_null_test()
        {
            Shop shop = new Shop();
            double totalPrice = 0.0f;
            bool result = shop.CalcPrice(null, ref totalPrice);
            Assert.AreEqual(false, result);
        }
    }
}