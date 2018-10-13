using DesignPatterns._01_StrategyPattern.Shared;

namespace DesignPatterns._01_StrategyPattern.Solution
{
    public class PurchaseOrder
    {
        public double Value { get; set; }
        public User User { get; set; }

        private DiscountRate _discountRate { get { return User.GetDiscountRate(); } }

        public double CalculateOrderPrice() => this.Value - _discountRate.CalculateDiscount(this.Value);

        public PurchaseOrder(User user, double value)
        {
            User = user;
            Value = value;
        }
    }
}
