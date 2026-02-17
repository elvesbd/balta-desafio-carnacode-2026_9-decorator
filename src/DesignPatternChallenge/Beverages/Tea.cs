using DesignPatternChallenge.Abstractions;

namespace DesignPatternChallenge.Beverages;

public class Tea : IBeverage
{
    public decimal GetCoast() => 2.50m;
    public string GetDescription() => "Chá";
}