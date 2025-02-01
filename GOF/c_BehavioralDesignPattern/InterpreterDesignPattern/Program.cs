var context = new Context();
context.SetVariable("x", 5);
context.SetVariable("y", 3);

var expression = new Add(context.GetVariable("x"), context.GetVariable("y"));
Console.WriteLine(expression.Interpret()); // 8

class Context // Holds variable values
{
    private Dictionary<string, int> _variables = new();
    public void SetVariable(string name, int value) => _variables[name] = value;
    public int GetVariable(string name) => _variables[name];
}

class Add // Concrete Expression (No recursion)
{
    private int _left, _right;
    public Add(int left, int right) => (_left, _right) = (left, right);
    public int Interpret() => _left + _right;
}
