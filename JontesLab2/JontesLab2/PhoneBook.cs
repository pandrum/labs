namespace JontesLab2
{
    internal class PhoneBook : IPhoneBook
    {
        private Dictionary<Person, List<Phone>> phonebook;
        private List<Person> membersList = new List<Person>();

        public PhoneBook(List<Person> allMembers)
        {
            phonebook = new Dictionary<Person, List<Phone>>(); //ett dictionary med key value pair där varje value är en lista
            membersList = allMembers;
        }

        public List<Phone> FindPhones(Person name) //hittar numret som korresponderar mot personens namn
        {
            //List<Phone> list = new List<Phone>();
            List<Phone> phone = null;

            try
            {
                phonebook.TryGetValue(name, out phone);

                if (phone == null)
                {
                    throw new ArgumentNullException(paramName: nameof(name), message: "The search function can not find a corresponding phone number");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Exception caught.");
            }

            return phone;
        }

        public void AddRandomNumbers()
        {
            foreach (Person person in membersList)
            {
                Random random = new Random();
                Phone randomPhone = new Phone(random.Next(10000000, 20000000)); //Slumpar fram ett nummer
                Phone randomPhone2 = new Phone(random.Next(20000000, 30000000)); //Slumpar fram ett nummer

                //AddEntry(person, phoneList);
                AddEntry(person, randomPhone);
                AddEntry(person, randomPhone2);
                AddEntry(person, randomPhone2);
            }
        }

        public void AddEntry(Person name, Phone number)
        {
            bool registered = false;
            bool duplicate = false;
            //kolla om personen finns, då addera till den personens lista
            //annars skapa ny lista
            //check innan om numnet redan finns

            try
            {
                if (membersList.Contains(name)) //vi gör en check för att explicit ´checka att personen vi adderar finns i members listan
                {
                    foreach (KeyValuePair<Person, List<Phone>> kvp in phonebook) //vi går igenom våra namn
                    {
                        foreach (List<Phone> list in phonebook.Values) //för varje namn, tillhörande nummer
                        {
                            if (list.Contains(number))
                            {
                                duplicate = true;
                            }
                        }
                        if (duplicate) //duplicates ska ej läggas till
                        {
                            break;
                        }

                        if (kvp.Key.Name == name.Name)
                        {
                            kvp.Value.Add(number); //personen finns registrerad, vi adderar till personens redan existerande lista
                            registered = true;
                        }
                    }
                    if (registered == false && duplicate == false) //personen är ny vi skapar en lista tillhörande och lägger i vårat första nummer
                    {
                        List<Phone> phoneList = new List<Phone>
                        {
                            number
                        };
                        phonebook.Add(name, phoneList);
                    }
                    if (duplicate)
                    {
                        throw new DuplicateEntryException("The number is a duplicate.");
                    }
                }
            }
            catch (DuplicateEntryException e)
            {
                Console.WriteLine($"Exception caught. {e.Message}");
            }
        }

        public void RemoveEntry(Phone number) //ta bort numret och om personen endast har ett telefonnummer ta bort personen från dictionary
        {
            //phonebook.TryGetValue(name, out List<Phone> phone);
            bool nothingHappens = true;
            try
            {
                foreach (KeyValuePair<Person, List<Phone>> kvp in phonebook) //vi går igenom våra namn
                {
                    foreach (List<Phone> list in phonebook.Values) //för varje namn, tillhörande nummer
                    {
                        if (list.Contains(number))
                        {
                            list.Remove(number);
                            nothingHappens = false;
                        }
                        if (list.Count() == 0) //om personen i fråga inte har fler nummer längre, ta bort personen från dictionary
                        {
                            phonebook.Remove(kvp.Key);
                            break; //gå ut loopen
                        }
                    }
                }
                if (nothingHappens)
                {
                    throw new NotFoundException("Can not find the number to delete.");
                }
            }
            catch (NotFoundException e)
            {
                Console.WriteLine($"Exception caught. {e.Message}");
            }
        }
    }
}