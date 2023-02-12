﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Persons.Add(person1);

        }
    }
}