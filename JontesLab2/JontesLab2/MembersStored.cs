namespace JontesLab2
{
    internal class MembersStored
    {
        public List<Person> Persons;

        public MembersStored()
        {
            Persons = new List<Person>();
        }

        public void FillPersons()
        {
            Person person1 = new Person("Adam");
            Person person2 = new Person("Eva");

            Persons.Add(person1);
            Persons.Add(person2);
        }
    }
}