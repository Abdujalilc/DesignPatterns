using VisitorDesignPattern;

School school = new School();
var visitor1 = new Doctor("James");
school.PerformOperation(visitor1);
Console.WriteLine();
var visitor2 = new Salesman("John");
school.PerformOperation(visitor2);
Console.Read();