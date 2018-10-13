namespace DesignPatterns._01_StrategyPattern.Shared
{
    public sealed class Standard : DiscountRate
    {
        protected override double PercentOfDiscountRate { get =>  0.0; }

        public override double CalculateDiscount(double value)
        {
            return value * PercentOfDiscountRate;
        }
    }
}
