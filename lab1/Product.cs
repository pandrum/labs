namespace Lab1
{
    internal class Product
    {
        private string name;

        public string Name
        {
            get { return name; }    //read
            set                     //write
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                } else
                {
                    System.Console.WriteLine("Name cannot be empty or null!");
                }
            }
        }

        public Product(string name)
        {
            Name = name;
        }
    }
}