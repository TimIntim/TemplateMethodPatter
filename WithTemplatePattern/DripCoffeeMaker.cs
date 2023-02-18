namespace WithTemplatePattern;

public class DripCoffeeMaker : CoffeeMakerTemplate
{
    protected override void BrewCoffee()
    {
        Console.WriteLine("Brewing coffee in drip coffee maker");
    }

    protected override void AddCondiments()
    {
        Console.WriteLine("Adding sugar to taste");
    }
}