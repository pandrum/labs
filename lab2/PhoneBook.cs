namespace lab2
{
    internal class PhoneBook
    {
        public List<Person> Members { get; set; } = new List<Person>();

        public void AddEntry(Person person, Phone phone)
        {
            try
            {
                bool match = false;
                foreach (Person member in Members)
                {
                    e))
                    {
                        Console.WriteLine("maio");
                        match= true;
                    }
                }
                if (match)
                {
                    throw new PhoneBookException();
                } else
                {
                    person.Phone.Add(phone);
                    Members.Add(person);
                }
            }
            catch (PhoneBookException e)
            {
                Console.WriteLine("Duplicate. User is already in database. " + e.Message);
            }
        }

        public List<Phone> FindPhones(string name)
        {
            List<Phone> phones = new List<Phone>();
            try
            {
                bool match = false;
                foreach (var members in Members)
                {
                    if (name.Equals(members.Name))
                    {
                        match= true;
                        phones = members.Phone;
                    }
                }
                if (!match)
                {
                    throw new PhoneBookException();
                }
            }
            catch (PhoneBookException e)
            {
                Console.WriteLine("Cannot find entry. Unknown name. " + e.Message);
            }
            return phones;
        }

        public void RemoveEntry(string name, Phone phone)
        {
            try
            {
                bool match = false;
                foreach (var p in Members)
                {
                    if (name.Equals(p.Name))
                    {
                        match= true;
                        p.Phone.Remove(phone);
                    }
                }
                if (!match)
                {
                    throw new PhoneBookException();
                }
            }
            catch (PhoneBookException e)
            {
                Console.WriteLine("Cannot remove entry. Unknown user. " + e.Message);
            }
        }
    }
}