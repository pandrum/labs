namespace lab3
{
    internal class Product
    {
        public string Name { get; set; }
        public double UnitPrice { get; set; }

        public Product(string name, double unitPrice)
        {
            Name = name;
            UnitPrice = unitPrice;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}