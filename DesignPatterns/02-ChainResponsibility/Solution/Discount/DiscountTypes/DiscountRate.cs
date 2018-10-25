using System;

namespace DesignPatterns._02_ChainResponsibility.Solution.DiscountTypes
{
    public abstract class DiscountRate
    {
        private DiscountRate HigherDiscountRate { get; set; }

        protected abstract DiscountParameters DiscountParameters { get; }    

        public virtual double CalculateDiscount(double value)
        {
            if (value <= DiscountParameters.MaxiumDiscountLimit)
                return Calculate(value);
            else if(HigherDiscountRate != null)
                return HigherDiscountRate.CalculateDiscount(value);

            throw new Exception("Não foi possível calcular desconto para este valor");
        }

        protected virtual double Calculate(double value)
        {
            return value * DiscountParameters.DiscountPercentage;
        }

        public DiscountRate SetHigherDiscountRate(DiscountRate discountRate)
        {
            HigherDiscountRate = discountRate;
            return this;
        }
    }
}
