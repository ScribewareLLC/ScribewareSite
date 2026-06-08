using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScribewareSite.Tests
{
    public class ProductsTests
    {
        private string conString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ScribewareDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        [Test]
        public void AddProduct()
        {
            Product product = new Product
            {
                ProductName = "Test",
                Price = 4.5m
            };

            Records.Manipulate(conString, "spAddProducts", new { @pn = product.ProductName, @pr = product.Price });

            var newProduct = Records.Get<Product>(conString, "spGetAllProducts");
            Assert.That(newProduct[0].ProductName, Is.EqualTo(product.ProductName));
        }

        [Test]
        public void UpdateProduct()
        {
            var product = Records.Get<Product>(conString, "spGetProductsByName", new { @pn = "Test" });
            product[0].ProductName = "TestProduct";
            Records.Manipulate(conString, "spUpdateProducts", new { @pi = product[0].ProductId, @pn = product[0].ProductName, @pr = product[0].Price });
            var newProduct = Records.Get<Product>(conString, "spGetProductsByName", new { @pn = product[0].ProductName });
            Assert.That(newProduct[0].ProductName, Is.EqualTo(product[0].ProductName));
        }
    }
}
