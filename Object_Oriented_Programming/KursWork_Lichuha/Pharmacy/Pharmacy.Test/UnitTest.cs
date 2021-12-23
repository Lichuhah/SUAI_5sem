using NUnit.Framework;
using Pharmacy.Domain.Managers.Products;

namespace Pharmacy.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestBrands()
        {
            var manager = new BrandManager();
            var list = manager.All();
            Assert.IsNotEmpty(list);
        }

        [Test]
        public void TestTypes()
        {
            var manager = new TypeProductManager();
            var list = manager.All();
            Assert.IsNotEmpty(list);
        }

        [Test]
        public void TestForms()
        {
            var manager = new FormProductManager();
            var list = manager.All();
            Assert.IsNotEmpty(list);
        }

        [Test]
        public void TestCategories()
        {
            var manager = new CategoryProductManager();
            var list = manager.All();
            Assert.IsNotEmpty(list);
        }

        [Test]
        public void TestProducts()
        {
            var manager = new ProductManager();
            var list = manager.All();
            Assert.IsNotEmpty(list);
        }
    }
}