using CactusStore.BLL.BusinessModels;
using NUnit.Framework;

namespace CactusStore.BLL.Tests
{
    public class CactusStoreTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Discount()
        {
            //ARRANGE

            var discount = new Discount(10);
            decimal sum = 50000;

            //ACT

            sum = discount.GetDiscountedPrice(sum);


            //ASSERT
            Assert.AreEqual(4000, sum);
        }
    }
}