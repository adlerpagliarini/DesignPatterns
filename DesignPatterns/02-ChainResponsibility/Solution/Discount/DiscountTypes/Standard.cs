namespace DesignPatterns._02_ChainResponsibility.Solution.DiscountTypes
{
    public sealed class Standard : DiscountRate
    {       
        protected override DiscountParameters DiscountParameters => 
            new DiscountParameters() { DiscountPercentage = 0.0, MaxiumDiscountLimit = 1000 };

        public Standard()
        {
            base.SetHigherDiscountRate(new Premium());
        }
    }
}