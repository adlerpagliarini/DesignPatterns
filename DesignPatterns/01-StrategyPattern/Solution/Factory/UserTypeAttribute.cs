using DesignPatterns._01_StrategyPattern.Shared;
using System;

namespace DesignPatterns._01_StrategyPattern.Solution
{
    public class UserTypeAttribute : Attribute
    {
        private Type _implementation { get; }

        public DiscountRate CreateInstance => (DiscountRate) Activator.CreateInstance(_implementation);

        public UserTypeAttribute(Type implementation)
        {
            _implementation = implementation;
        }
    }
}
