namespace lab2
{
    internal class PhoneBook
    {
        public List<Person> Members { get; set; } = new List<Person>();

        public void AddEntry(Person person, Phone phone)
        {
            try
            {
                person.Phone.Add(phone);
                Members.Add(person);
            }
            catch (Exception)
            {
                throw new NameNotFoundException("Can not add user.");
            }
        }

        public List<Phone> FindPhones(string name)
        {
            try
            {
                var phones = new List<Phone>();

                foreach (var p in Members)
                {
                    if (name.Equals(p.Name))
                    {
                        phones = p.Phone;
                    }
                }
                return phones;
            }
            catch (Exception)
            {
                throw new NameNotFoundException("Unknown user.");
            }
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
                        p.Phone.Remove(phone);
                    }
                }
                if (!match)
                {
                    throw new NameNotFoundException();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Unknown user.");
            }
        }
    }
}