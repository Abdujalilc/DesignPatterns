IExpression exp = new Add(new Number(5), new Number(3));
Console.WriteLine(exp.Interpret()); // 8

interface IExpression { int Interpret(); } // Abstract Expression

class Number : IExpression // Terminal Expression
{
    private int _value;
    public Number(int value) => _value = value;
    public int Interpret() => _value;
}

class Add : IExpression // Non-Terminal Expression
{
    private IExpression _left, _right;
    public Add(IExpression left, IExpression right) => (_left, _right) = (left, right);
    public int Interpret() => _left.Interpret() + _right.Interpret();
}
