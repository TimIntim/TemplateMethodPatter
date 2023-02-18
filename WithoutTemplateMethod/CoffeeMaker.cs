namespace WithoutTemplateMethod;

public class CoffeeMaker
{
    public void MakeCoffee()
    {
        BoilWater();
        GrindCoffee();
        BrewCoffee();
        PourIntoCup();
    }

    private void BoilWater()
    {
        Console.WriteLine("Boiling water");
    }

    private void GrindCoffee()
    {
        Console.WriteLine("Grinding coffee beans");
    }

    private void BrewCoffee()
    {
        Console.WriteLine("Brewing coffee");
    }

    private void PourIntoCup()
    {
        Console.WriteLine("Pouring coffee into cup");
    }
}