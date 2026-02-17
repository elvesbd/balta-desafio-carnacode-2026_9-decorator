using DesignPatternChallenge.Abstractions;

namespace DesignPatternChallenge.Beverages;

public class Espresso : IBeverage
{
    public decimal GetCoast() => 3.50m;
    public string GetDescription() => "Espresso";
}