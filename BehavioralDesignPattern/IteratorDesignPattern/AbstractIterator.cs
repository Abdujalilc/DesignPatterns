namespace IteratorDesignPattern
{
    interface AbstractIterator
    {
        Employee First();
        Employee Next();
        bool IsCompleted { get; }
    }
}