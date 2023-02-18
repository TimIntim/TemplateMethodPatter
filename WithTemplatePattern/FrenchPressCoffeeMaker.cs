namespace WithTemplatePattern;

public class FrenchPressCoffeeMaker : CoffeeMakerTemplate
{
    protected override void BrewCoffee()
    {
        Console.WriteLine("Steeping coffee in French press");
    }

    protected override void AddCondiments()
    {
        Console.WriteLine("Adding milk and sugar to taste");
    }
}