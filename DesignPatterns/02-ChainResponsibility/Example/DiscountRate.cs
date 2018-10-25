namespace DesignPatterns._02_ChainResponsibility.Example
{
    public class DiscountRate
    {
        private readonly double discountLimit = 500;

        public double CalculateDiscount(double value)
        {
            if (value <= 1000)
                return value * 0.0;
            else if(value <= 2000)
                return value * 0.1;
            else {
                double discount = value * 0.2;
                return discount > discountLimit ? discountLimit : discount;
            }
        }
    }
}
