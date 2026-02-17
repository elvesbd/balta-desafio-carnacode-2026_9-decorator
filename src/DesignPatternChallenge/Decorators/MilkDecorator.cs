using DesignPatternChallenge.Abstractions;

namespace DesignPatternChallenge.Decorators;

public class MilkDecorator(IBeverage beverage) : BeverageDecorator(beverage)
{
    public override decimal GetCoast() => Beverage.GetCoast() + 0.50m;
    public override string GetDescription() => Beverage.GetDescription() + " + Leite";
}