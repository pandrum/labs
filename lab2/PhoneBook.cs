namespace lab2
{
    internal class PhoneBook
    {
        public List<Person> Persons { get; set; } = new List<Person>();

        public void AddEntry(Person person, Phone phone)
        {
            try
            {
                foreach (Person p in Persons)
                {
                    if (p.Name.Equals(person.Name))
                    {
                        p.Phonenumbers.Add(phone);
                    }
                }
                person.Phonenumbers.Add(phone);
                Persons.Add(person);
            }
            catch (Exception)
            {
                Console.WriteLine("Unknown name.");
            }
        }

        public void FindPhones(Person person)
        {
            try
            {
                if (person.Phonenumbers.Count > 1)
                {
                    Console.WriteLine($"{person.Name}'s phone numbers are: ");
                    foreach (var phone in person.Phonenumbers)
                    {
                        Console.WriteLine(phone.Number);
                    }
                } else
                {
                    Console.WriteLine($"{person.Name}'s phone numbers is: {person.Phonenumbers.First().Number}");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Unknown name.");
            }
        }

        public void RemoveEntry(Person person, Phone phone)
        {
            try
            {
                foreach (var p in Persons)
                {
                    if (p.Name.Equals(person.Name))
                    {
                        p.Phonenumbers.Remove(phone);
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Unknown name.");
            }
        }
    }
}