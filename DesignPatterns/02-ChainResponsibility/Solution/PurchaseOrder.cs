namespace DesignPatterns._02_ChainResponsibility.Solution
{
    public class PurchaseOrder
    {
        public string Title { get; set; }
        public double Value { get; set; }

        private IDiscountService _discountService;

        public double CalculateOrderPriceWithDiscount() => this.Value - _discountService.CalculateDiscount(this.Value);

        public PurchaseOrder(string title, IDiscountService discountService, double value)
        {
            Title = title;
            _discountService = discountService;
            Value = value;
        }
    }
}
