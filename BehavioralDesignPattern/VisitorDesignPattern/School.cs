namespace VisitorDesignPattern
{
    public class School
    {
        private static readonly List<IElement> elements;
        static School()
        {
            elements = new List<IElement>
            {
                new Kid("Ram"),
                new Kid("Sara"),
                new Kid("Pam")
            };
        }
        public void PerformOperation(IVisitor visitor)
        {
            foreach (IElement? kid in elements)
            {
                kid.Accept(visitor);
            }
        }
    }
}