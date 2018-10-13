namespace DesignPatterns._01_StrategyPattern.Shared
{
    public sealed class Diamond : DiscountRate
    {
        protected override double PercentOfDiscountRate { get =>  0.2; }

        public override double CalculateDiscount(double value)
        {
            return value * PercentOfDiscountRate;
        }
    }
}
