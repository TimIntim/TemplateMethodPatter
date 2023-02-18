namespace WithoutTemplateMethod;

public class CoffeeMaker
{
    public void MakeCoffee()
    {
        BoilWater();
        GrindCoffee();
        BrewCoffee();
        PourIntoCup();
        AddSugar();
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
        Console.WriteLine("Brewing coffee in drip coffee maker");
    }

    private void PourIntoCup()
    {
        Console.WriteLine("Pouring coffee into cup");
    }
    
    private void AddSugar()
    {
        Console.WriteLine("Adding sugar to taste");
    }
}