using DesignPatterns._01_StrategyPattern.Solution;
using System;

namespace ConsoleApp._01_StrategyPattern
{
    public class StrategyPatternSolution
    {
        public static void Solution()
        {
            var user = new User() { Name = "Solution", Type = UserTypes.STANDARD };
            var purchaseOrder = new PurchaseOrder(user, 1000);
            Print(purchaseOrder);
            user.Type = UserTypes.PREMIUM;
            purchaseOrder = new PurchaseOrder(user, 1000);
            Print(purchaseOrder);
            user.Type = UserTypes.DIAMOND;
            purchaseOrder = new PurchaseOrder(user, 1000);
            Print(purchaseOrder);
        }

        public static void Print(PurchaseOrder purchaseOrder)
        {
            var result = purchaseOrder.CalculateOrderPrice();
            Console.WriteLine(" " + purchaseOrder.User.Name + ": Type : " + purchaseOrder.User.Type + " Value: " + purchaseOrder.Value + " OrderPrice: " + result);
        }
    }
}
