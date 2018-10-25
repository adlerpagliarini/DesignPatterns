namespace DesignPatterns._02_ChainResponsibility.Solution.DiscountTypes
{ 
    public sealed class Diamond : DiscountRate
    {
        protected override DiscountParameters DiscountParameters =>
            new DiscountParameters() { DiscountPercentage = 0.2};

        private readonly double discountLimit = 500;

        public override double CalculateDiscount(double value)
        {
            return Calculate(value);
        }

        protected override double Calculate(double value)
        {
            double discount = value * DiscountParameters.DiscountPercentage;
            return discount > discountLimit ? discountLimit : discount;
        }
    }
}
