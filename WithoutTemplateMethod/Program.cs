using WithoutTemplateMethod;

var firstCoffeeMaker = new CoffeeMaker();
firstCoffeeMaker.MakeCoffee();

Console.WriteLine();

var secondCoffeeMaker = new FrenchPressCoffeeMaker();
secondCoffeeMaker.MakeCoffee();