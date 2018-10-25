namespace DesignPatterns._02_ChainResponsibility.Example
{
    public class PurchaseOrder
    {
        public string Title { get; set; }
        public double Value { get; set; }

        private DiscountRate _discountRate;

        public double CalculateOrderPriceWithDiscount() => this.Value - _discountRate.CalculateDiscount(this.Value);

        public PurchaseOrder(string title, double value)
        {
            Title = title;
            _discountRate = new DiscountRate();
            Value = value;
        }
    }
}
