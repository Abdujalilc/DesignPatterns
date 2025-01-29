using VisitorDesignPattern;

School school = new School();
IVisitor doctor = new Doctor("James");
school.PerformOperation(doctor);
Console.WriteLine();
var salasman = new Salesman("John");
school.PerformOperation(salasman);
Console.Read();