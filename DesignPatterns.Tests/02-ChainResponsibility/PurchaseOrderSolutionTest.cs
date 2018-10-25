using DesignPatterns._02_ChainResponsibility.Solution;
using NUnit.Framework;

namespace DesignPatterns.Tests._02_ChainResponsibility
{
    [TestFixture]
    public class PurchaseOrderSolutionTest
    {
        [Test]
        public void CalculateOrderPrice_ForStandardDiscount()
        {
            var purchaseOrder = new PurchaseOrder("Example", new DiscountService(), 1000);
            var result = purchaseOrder.CalculateOrderPriceWithDiscount();
            Assert.AreEqual(1000, result);
        }

        [Test]
        public void CalculateOrderPrice_ForPremiumDiscount()
        {
            var purchaseOrder = new PurchaseOrder("Example", new DiscountService(), 2000);
            var result = purchaseOrder.CalculateOrderPriceWithDiscount();
            Assert.AreEqual(2000 * 0.9, result);
        }

        [Test]
        public void CalculateOrderPrice_ForDiamondDiscount()
        {
            var purchaseOrder = new PurchaseOrder("Example", new DiscountService(), 2400);
            var result = purchaseOrder.CalculateOrderPriceWithDiscount();
            Assert.AreEqual(2400 * 0.8, result);
        }

        [Test]
        public void CalculateOrderPrice_ForDiamondDiscountLimit()
        {
            var purchaseOrder = new PurchaseOrder("Example", new DiscountService(), 3000);
            var result = purchaseOrder.CalculateOrderPriceWithDiscount();
            Assert.AreEqual(3000 - 500, result);
        }
    }
}
