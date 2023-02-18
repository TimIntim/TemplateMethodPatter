namespace WithTemplatePattern;

public abstract class CoffeeMakerTemplate
{
    public void MakeCoffee()
    {
        BoilWater();
        GrindCoffee();
        BrewCoffee();
        PourIntoCup();
        AddCondiments();
    }

    private void BoilWater()
    {
        Console.WriteLine("Boiling water");
    }

    private void GrindCoffee()
    {
        Console.WriteLine("Grinding coffee beans");
    }

    protected abstract void BrewCoffee();

    private void PourIntoCup()
    {
        Console.WriteLine("Pouring coffee into cup");
    }

    protected abstract void AddCondiments();
}
    