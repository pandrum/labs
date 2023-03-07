namespace lab3
{
    internal interface IVisitor
    {
        public void Visit(Invoice element);

        public void Visit(InvoiceLine element);

        public void Visit(Product element);
    }
}