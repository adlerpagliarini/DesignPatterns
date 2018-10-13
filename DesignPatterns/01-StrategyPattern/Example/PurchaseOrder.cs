using DesignPatterns._01_StrategyPattern.Shared;
using System;

namespace DesignPatterns._01_StrategyPattern.Example
{
    public class PurchaseOrder
    {
        public double Value { get; set; }
        public User User { get; set; }

        private DiscountRate _discountRate { get; set; }

        public double CalculateOrderPrice()
        {
            if (User.Type == UserTypes.STANDARD)
                _discountRate = new Standard();
            else if (User.Type == UserTypes.PREMIUM)
                _discountRate = new Premium();
            else if (User.Type == UserTypes.DIAMOND)
                _discountRate = new Diamond();
            else
                throw new NotImplementedException();

            return this.Value - _discountRate.CalculateDiscount(this.Value);
        }

        public PurchaseOrder(User user, double value)
        {
            User = user;
            Value = value;
        }
    }
}
