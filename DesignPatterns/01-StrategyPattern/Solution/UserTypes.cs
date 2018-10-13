using DesignPatterns._01_StrategyPattern.Shared;

namespace DesignPatterns._01_StrategyPattern.Solution
{
    public enum UserTypes
    {
        [UserTypeAttribute(typeof(Standard))]
        STANDARD,
        [UserTypeAttribute(typeof(Premium))]
        PREMIUM,
        [UserTypeAttribute(typeof(Diamond))]
        DIAMOND
    }
}
