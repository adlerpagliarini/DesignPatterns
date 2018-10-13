using DesignPatterns._01_StrategyPattern.Shared;

namespace DesignPatterns._01_StrategyPattern.Solution
{
    public class User
    {
        public string Name { get; set; }
        public UserTypes Type { get; set; }

        public DiscountRate GetDiscountRate()
        {
            return Type.GetDiscountRateImplementation();
        }
    }
}
