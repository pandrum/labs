namespace lab3
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double Total { get; set; }
        public static double Tax { get; set; } = 1.1;

        public Product(string name, double price, int quantity = 1)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Total = quantity * price;
        }
    }
}