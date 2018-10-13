using DesignPatterns._01_StrategyPattern.Shared;
using System;
using System.Linq;

namespace DesignPatterns._01_StrategyPattern.Solution
{
    public static class UserTypesExtensionMethods
    {
        public static DiscountRate GetDiscountRateImplementation(this Enum userType)
        {
            var attribute = typeof(UserTypes).GetFields()
                .Where(f => f.Name == userType.ToString())
                .FirstOrDefault()
                ?.GetCustomAttributes(false).First() as UserTypeAttribute;

            if (attribute != null)
                return attribute.CreateInstance;

            throw new NotImplementedException();
        }
    }
}
