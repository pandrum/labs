namespace lab3
{
    internal class InvoiceLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public InvoiceLine(Product product, int quantity = 1)
        {
            Product = product;
            Quantity=quantity;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}