namespace VisitorDesignPattern
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}