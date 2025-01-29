namespace VisitorDesignPattern
{
    public interface IVisitor
    {
        void Visit(IElement element);
    }
}