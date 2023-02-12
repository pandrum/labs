namespace lab2
{
    internal class Person
    {
        public string Name { get; set; }
        public List<Phone> Phone { get; set; } = new List<Phone>();

        public Person(string name)
        {
            Name=name;
        }
    }
}