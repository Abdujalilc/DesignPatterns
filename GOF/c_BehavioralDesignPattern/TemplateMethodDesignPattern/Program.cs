AbstractClass instance = new ConcreteClass();
instance.TemplateMethod(); // Step 1 → Custom Step 2 → Step 3

// Abstract Class with Template Method
abstract class AbstractClass
{
    public void TemplateMethod()
    {
        Step1();
        Step2();
        Step3();
    }
    private void Step1() => Console.WriteLine("Step 1");
    protected abstract void Step2(); // Subclasses override
    private void Step3() => Console.WriteLine("Step 3");
}

// Concrete Implementation
class ConcreteClass : AbstractClass
{
    protected override void Step2() => Console.WriteLine("Custom Step 2");
}
