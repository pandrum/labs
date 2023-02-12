﻿// See https://aka.ms/new-console-template for more information
using JontesLab2;

Console.WriteLine("Hello, World!");

List<Person> allNames = new List<Person>();
List<Person> retrievedName = new List<Person>(); //så att vi kan retrieva mer en ett nummer
List<Phone> retrievedPhones = new List<Phone>(); //så att vi kan retrieva mer en ett nummer



MembersStored membersStored = new MembersStored();
membersStored.FillPersons(); //Fyller med personer som initieras från membersstored klassen
allNames = membersStored.Persons;



PhoneBook phoneBook = new PhoneBook(allNames);
phoneBook.AddRandomNumbers();

retrievedPhones = phoneBook.FindPhones(allNames.First()); //ett test med den första personen
Console.WriteLine(retrievedPhones);
Phone oldPhone = retrievedPhones.First();
phoneBook.RemoveEntry(retrievedPhones.First()); // ta bort det första lagrade nummret
phoneBook.RemoveEntry(oldPhone); // ta bort numret som redan tagits bort