using DesignPatternChallenge.Abstractions;

namespace DesignPatternChallenge.Beverages;

public class Cappuccino : IBeverage
{
    public decimal GetCost() => 4.50m;
    public string GetDescription() => "Cappuccino";
}