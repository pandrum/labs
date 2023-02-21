﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JontesLab2
{
    internal interface IPhoneBook
    {
        void RemoveEntry(Phone number);
        void AddEntry(Person name, Phone number);
        List<Phone> FindPhones(Person name);

    }
}