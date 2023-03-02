namespace lab3
{
    internal interface IElement
    {
        public void Accept(IVisitor visitor);
    }
}