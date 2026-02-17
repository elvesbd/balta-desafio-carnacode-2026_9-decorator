using DesignPatternChallenge.Abstractions;
using DesignPatternChallenge.Beverages;
using DesignPatternChallenge.Decorators;

Console.WriteLine("=== Sistema de Pedidos - Cafeteria (Decorator) ===\n");

// Pedido 1: Espresso puro
IBeverage pedido1 = new Espresso();
Console.WriteLine($"{pedido1.GetDescription()}: R$ {pedido1.GetCost():N2}");

// Pedido 2: Espresso + Leite
IBeverage pedido2 = new MilkDecorator(new Espresso());
Console.WriteLine($"{pedido2.GetDescription()}: R$ {pedido2.GetCost():N2}");

// Pedido 3: Espresso + Leite + Chocolate (empilhando decorators)
IBeverage pedido3 = new ChocolateDecorator(
                        new MilkDecorator(
                            new Espresso()));
Console.WriteLine($"{pedido3.GetDescription()}: R$ {pedido3.GetCost():N2}");

// Pedido 4: Cappuccino com tudo
IBeverage pedido4 = new CaramelDecorator(
                        new WhippedCreamDecorator(
                            new ChocolateDecorator(
                                new MilkDecorator(
                                    new Cappuccino()))));
Console.WriteLine($"{pedido4.GetDescription()}: R$ {pedido4.GetCost():N2}");

// Pedido 5: Chá + Leite + Caramelo
IBeverage pedido5 = new CaramelDecorator(
                        new MilkDecorator(
                            new Tea()));
Console.WriteLine($"{pedido5.GetDescription()}: R$ {pedido5.GetCost():N2}");

// Pedido 6: Leite duplo! (mesmo decorator aplicado duas vezes)
IBeverage pedido6 = new MilkDecorator(
                        new MilkDecorator(
                            new Espresso()));
Console.WriteLine($"{pedido6.GetDescription()}: R$ {pedido6.GetCost():N2}");

Console.WriteLine("\n--- Composição dinâmica em runtime ---\n");

// Montando pedido dinamicamente (simulando escolhas do cliente)
IBeverage pedidoCustom = new Espresso();
Console.WriteLine($"Base: {pedidoCustom.GetDescription()} - R$ {pedidoCustom.GetCost():N2}");

pedidoCustom = new MilkDecorator(pedidoCustom);
Console.WriteLine($"+ Leite: {pedidoCustom.GetDescription()} - R$ {pedidoCustom.GetCost():N2}");

pedidoCustom = new WhippedCreamDecorator(pedidoCustom);
Console.WriteLine($"+ Chantilly: {pedidoCustom.GetDescription()} - R$ {pedidoCustom.GetCost():N2}");

pedidoCustom = new CaramelDecorator(pedidoCustom);
Console.WriteLine($"Final: {pedidoCustom.GetDescription()} - R$ {pedidoCustom.GetCost():N2}");