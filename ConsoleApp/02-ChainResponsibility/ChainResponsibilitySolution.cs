using DesignPatterns._02_ChainResponsibility.Solution;
using System;

namespace ConsoleApp._02_ChainResponsibility
{
    public class ChainResponsibilitySolution
    {
        public static void Solution()
        {
            var purchaseOrder = new PurchaseOrder("Solution", new DiscountService(), 1000);
            Print(purchaseOrder);
            purchaseOrder = new PurchaseOrder("Solution", new DiscountService(), 2000);
            Print(purchaseOrder);
            purchaseOrder = new PurchaseOrder("Solution", new DiscountService(), 2400);
            Print(purchaseOrder);
            purchaseOrder = new PurchaseOrder("Solution", new DiscountService(), 3000);
            Print(purchaseOrder);
        }

        public static void Print(PurchaseOrder purchaseOrder)
        {
            var result = purchaseOrder.CalculateOrderPriceWithDiscount();
            Console.WriteLine(" " + purchaseOrder.Title + " - " + " Value: " + purchaseOrder.Value + " OrderPrice: " + result);
        }
    }
}
