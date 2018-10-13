namespace DesignPatterns._01_StrategyPattern.Shared
{
    public abstract class DiscountRate
    {
        protected abstract double PercentOfDiscountRate { get; }
        public abstract double CalculateDiscount(double value);
    }
}
