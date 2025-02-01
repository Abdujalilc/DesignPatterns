Element element = new ConcreteElement();
Visitor visitor = new ConcreteVisitor();
element.Accept(visitor); // Visiting ConcreteElement

// Visitor interface
interface Visitor { void Visit(ConcreteElement element); }

// Concrete Visitor
class ConcreteVisitor : Visitor
{
    public void Visit(ConcreteElement element) => Console.WriteLine("Visiting ConcreteElement");
}

// Element interface
abstract class Element { public abstract void Accept(Visitor visitor); }

// Concrete Element
class ConcreteElement : Element
{
    public override void Accept(Visitor visitor) => visitor.Visit(this);
}
