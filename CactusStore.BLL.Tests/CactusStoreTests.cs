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

            var discount = new Discount((decimal)0.2);
            decimal sum = 5000;

            //ACT

            sum = discount.GetDiscountedPrice(sum);


            //ASSERT
            Assert.AreEqual(5000, sum);
        }
    }
}