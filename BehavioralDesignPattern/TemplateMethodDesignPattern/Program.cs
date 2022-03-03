using TemplateMethodDesignPattern;

Console.WriteLine("Build a Concrete House\n");
HouseTemplate houseTemplate = new ConcreteHouse();
// call the template method
houseTemplate.BuildHouse();
Console.WriteLine();
Console.WriteLine("Build a Wooden House\n");
houseTemplate = new WoodenHouse();
// call the template method
houseTemplate.BuildHouse();
Console.Read();