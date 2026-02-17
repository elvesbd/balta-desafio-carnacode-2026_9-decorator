using DesignPatternChallenge.Abstractions;

namespace DesignPatternChallenge.Decorators;

public abstract class BeverageDecorator(IBeverage beverage) : IBeverage
{
    protected readonly IBeverage Beverage = beverage;

    public abstract decimal GetCost();
    public abstract string GetDescription();
}