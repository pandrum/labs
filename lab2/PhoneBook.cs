namespace lab2
{
    internal class PhoneBook
    {
        public List<Person> Members { get; set; } = new List<Person>();

        public void AddEntry(Person person, Phone phone)
        {
            try
            {
                foreach (Person p in Members)
                {
                    if (p.Name.Equals(person.Name))
                    {
                        p.Phonenumbers.Add(phone);
                    }
                }
                person.Phonenumbers.Add(phone);
                Members.Add(person);
            }
            catch (Exception)
            {
                Console.WriteLine("Unknown name.");
            }
        }

        public void AddEntry(Person person)
        {
            Members.Add(person);
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
                }
                else
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
                foreach (var p in Members)
                {
                    if (p.Name.Equals(person.Name))
                    {
                        p.Phonenumbers.Remove(phone);
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Unknown name or number.");
            }
        }
    }
}