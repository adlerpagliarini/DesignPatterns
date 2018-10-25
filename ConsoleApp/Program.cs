using ConsoleApp._01_StrategyPattern;
using ConsoleApp._02_ChainResponsibility;
using System;


namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StrategyPatternExample.Example();
            Console.WriteLine();
            StrategyPatternSolution.Solution();
            Console.WriteLine();
            ChainResponsibilityExample.Example();
            Console.WriteLine();
            ChainResponsibilitySolution.Solution();
            Console.ReadKey();
        }
    }
}
