var collection = new NumbersCollection(new int[] { 1, 2, 3 });
var iterator = collection.GetIterator();
while (iterator.HasNext())
    Console.WriteLine(iterator.Next()); // 1 2 3

interface IIterator { bool HasNext(); int Next(); } // Iterator interface

class NumberIterator : IIterator // Concrete Iterator
{
    private int[] _numbers;
    private int _index = 0;
    public NumberIterator(int[] numbers) => _numbers = numbers;
    public bool HasNext() => _index < _numbers.Length;
    public int Next() => _numbers[_index++];
}

class NumbersCollection // Iterable Collection
{
    private int[] _numbers;
    public NumbersCollection(int[] numbers) => _numbers = numbers;
    public IIterator GetIterator() => new NumberIterator(_numbers);
}
