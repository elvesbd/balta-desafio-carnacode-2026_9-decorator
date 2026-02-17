using DesignPatternChallenge.Abstractions;

namespace DesignPatternChallenge.Decorators;

public class WhippedCreamDecorator(IBeverage beverage) : BeverageDecorator(beverage)
{
    public override decimal GetCost() => Beverage.GetCost() + 1.00m;
    public override string GetDescription() => Beverage.GetDescription() + " + Chantilly";
}