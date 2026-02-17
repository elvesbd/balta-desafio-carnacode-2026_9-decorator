using DesignPatternChallenge.Abstractions;

namespace DesignPatternChallenge.Decorators;

public class ChocolateDecorator(IBeverage beverage) : BeverageDecorator(beverage)
{
    public override decimal GetCoast() => Beverage.GetCoast() + 0.70m;
    public override string GetDescription() => Beverage.GetDescription() + " + Chocolate";
}