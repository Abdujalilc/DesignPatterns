using MementoDesignPattern;

Originator originator = new Originator();
Caretaker caretaker = new Caretaker();

originator.ledTV = new LEDTV("42 inch", "60000Rs", false);
caretaker.AddMemento(originator.CreateMemento());

originator.ledTV = new LEDTV("46 inch", "80000Rs", true);
caretaker.AddMemento(originator.CreateMemento());

originator.ledTV = new LEDTV("50 inch", "100000Rs", true);

Console.WriteLine("\nOrignator current state : " + originator.GetDetails());
Console.WriteLine("\nOriginator restoring to 42 inch LED TV");
originator.ledTV = caretaker.GetMemento(0).ledTV;
Console.WriteLine("\nOrignator current state : " + originator.GetDetails());
Console.ReadKey();