namespace DesignPatterns._02_ChainResponsibility.Solution.DiscountTypes
{
    public sealed class Premium : DiscountRate
    {
        protected override DiscountParameters DiscountParameters =>
            new DiscountParameters() { DiscountPercentage = 0.1, MaxiumDiscountLimit = 2000 };

        public Premium()
        {
            base.SetHigherDiscountRate(new Diamond());
        }
    }
}
