﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace JontesLab2
{
    internal class PhoneBook : IPhoneBook
    {
        Dictionary<Person, List<Phone>> phonebook;
        List<Person> membersList = new List<Person>();

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

            catch (Exception e)
            {
                Console.WriteLine(e + ", Exception caught");
            }

            return phone;


        }

        public void AddRandomNumbers()
        {
            foreach (Person person in membersList)
            {
                Random random = new Random();
                Phone randomPhone = new Phone(random.Next(10000000, 20000000)); //Slumpar fram ett nummer
                Phone randomPhone2 = new Phone(0738663666); //Slumpar fram ett nummer

                List<Phone> phoneList = new List<Phone>(); //
                phoneList.Add(randomPhone);
                phoneList.Add(randomPhone2);
                AddEntry(person, phoneList);


            }
        }


        public void AddEntry(Person name, List<Phone> numbers)
        {
            phonebook.Add(name, numbers);
        }


        public void RemoveEntry(Phone number) //ta bort numret och om personen endast har ett telefonnummer ta bort personen från dictionary
        {
            //phonebook.TryGetValue(name, out List<Phone> phone);
            bool nothingHappens = true;
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
                Console.WriteLine("The program can not find the number: " + number.Number + ", to delete.");
            }

        }
    }
}