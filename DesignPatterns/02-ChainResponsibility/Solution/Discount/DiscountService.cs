using DesignPatterns._02_ChainResponsibility.Solution.DiscountTypes;

namespace DesignPatterns._02_ChainResponsibility.Solution
{
    public class DiscountService : IDiscountService
    {
        private DiscountRate _discountRate { get; }

        public DiscountService()
        {
            var startChain = new Standard();
            _discountRate = startChain;
        }

        public double CalculateDiscount(double value)
        {
            return _discountRate.CalculateDiscount(value);
        }
    }
}
