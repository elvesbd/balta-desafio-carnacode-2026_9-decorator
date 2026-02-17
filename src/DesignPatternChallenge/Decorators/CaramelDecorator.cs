using DesignPatternChallenge.Abstractions;

namespace DesignPatternChallenge.Decorators;

public class CaramelDecorator(IBeverage beverage) : BeverageDecorator(beverage)
{
    public override decimal GetCoast() => Beverage.GetCoast() + 0.80m;
    public override string GetDescription() => Beverage.GetDescription() + " + Caramelo";
}