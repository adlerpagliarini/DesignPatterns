namespace DesignPatterns._01_StrategyPattern.Shared
{
    public sealed class Premium : DiscountRate
    {
        protected override double PercentOfDiscountRate { get =>  0.1; }

        public override double CalculateDiscount(double value)
        {
            return value * PercentOfDiscountRate;
        }
    }
}
