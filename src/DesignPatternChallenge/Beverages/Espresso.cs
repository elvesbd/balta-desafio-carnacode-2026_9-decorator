using DesignPatternChallenge.Abstractions;

namespace DesignPatternChallenge.Beverages;

public class Espresso : IBeverage
{
    public decimal GetCost() => 3.50m;
    public string GetDescription() => "Espresso";
}