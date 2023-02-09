using lab2;

//create first person and new number
Person p1 = new Person("Peter");
Person p2 = new Person("Johan");
Phone phone = new Phone("0705564550");

//create second person and two new numbers

//init phonebook and add new persons
PhoneBook phonebook = new PhoneBook();
phonebook.AddEntry(p1, phone);
phonebook.AddEntry(p2);

foreach (var p in phonebook.Persons)
{
    Console.WriteLine(p.Name);
}