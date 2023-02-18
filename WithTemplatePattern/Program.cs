using WithTemplatePattern;

var firstCoffeeMaker = new DripCoffeeMaker();
firstCoffeeMaker.MakeCoffee();

Console.WriteLine();

var secondCoffeeMaker = new FrenchPressCoffeeMaker();
secondCoffeeMaker.MakeCoffee();