using DesignPatterns._02_ChainResponsibility.Example;
using System;

namespace ConsoleApp._02_ChainResponsibility
{
    public class ChainResponsibilityExample
    {
        public static void Example()
        {
            var purchaseOrder = new PurchaseOrder("Example", 1000);
            Print(purchaseOrder);
            purchaseOrder = new PurchaseOrder("Example", 2000);
            Print(purchaseOrder);
            purchaseOrder = new PurchaseOrder("Example", 2400);
            Print(purchaseOrder);
            purchaseOrder = new PurchaseOrder("Example", 3000);
            Print(purchaseOrder);
        }

        public static void Print(PurchaseOrder purchaseOrder)
        {
            var result = purchaseOrder.CalculateOrderPriceWithDiscount();
            Console.WriteLine(" " + purchaseOrder.Title + " - " + " Value: " + purchaseOrder.Value + " OrderPrice: " + result);
        }
    }
}
