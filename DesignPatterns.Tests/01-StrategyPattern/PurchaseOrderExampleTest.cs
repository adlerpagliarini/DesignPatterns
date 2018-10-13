using DesignPatterns._01_StrategyPattern.Example;
using NUnit.Framework;

namespace DesignPatterns.Tests._01_StrategyPattern
{
    [TestFixture]
    public class PurchaseOrderExampleTest
    {
        [Test]
        public void CalculateOrderPrice_ForStandardUser()
        {
            var user = new User() { Name = "Example", Type = UserTypes.STANDARD };
            var purchaseOrder = new PurchaseOrder(user, 1000);
            var result = purchaseOrder.CalculateOrderPrice();
            Assert.AreEqual(1000, result);
        }

        [Test]
        public void CalculateOrderPrice_ForPremiumUser()
        {
            var user = new User() { Name = "Example", Type = UserTypes.PREMIUM };
            var purchaseOrder = new PurchaseOrder(user, 1000);
            var result = purchaseOrder.CalculateOrderPrice();
            Assert.AreEqual(1000 * 0.9, result);
        }

        [Test]
        public void CalculateOrderPrice_ForDiamondUser()
        {
            var user = new User() { Name = "Example", Type = UserTypes.DIAMOND };
            var purchaseOrder = new PurchaseOrder(user, 1000);
            var result = purchaseOrder.CalculateOrderPrice();
            Assert.AreEqual(1000 * 0.8, result);
        }
    }
}
