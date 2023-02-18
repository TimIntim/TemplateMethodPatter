namespace WithoutTemplateMethod;

public class FrenchPressCoffeeMaker
{
    public void MakeCoffee()
    {
        BoilWater();
        GrindCoffee();
        SteepCoffee();
        PourIntoCup();
        AddMilk();
        AddSugar();
    }

    // The method are the same as in CoffeeMaker.cs
    private void BoilWater()
    {
        Console.WriteLine("Boiling water");
    }

    // The method are the same as in CoffeeMaker.cs
    private void GrindCoffee()
    {
        Console.WriteLine("Grinding coffee beans");
    }

    // The method aren't in CoffeeMaker.cs
    private void SteepCoffee()
    {
        Console.WriteLine("Steeping coffee in French press");
    }

    // The method are the same as in CoffeeMaker.cs
    private void PourIntoCup()
    {
        Console.WriteLine("Pouring coffee into cup");
    }

    // The method aren't in CoffeeMaker.cs
    private void AddMilk()
    {
        Console.WriteLine("Adding milk to taste");
    }

    // The method aren't in CoffeeMaker.cs
    private void AddSugar()
    {
        Console.WriteLine("Adding sugar to taste");
    }
}