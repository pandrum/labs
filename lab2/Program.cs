using lab2;


/*

* Ta bort eller fixa check på att lägga till telefonnummer till befintlig användare.
* Skapa klass för exceptions, exempelvis NameNotFoundException
* Ta bort console logs ur PhoneBook.cs


*/
//create first person and new number
Person p1, p2;
p1 = new Person("Johan");
p2 = new Person("Mattias");
Person p1, p2;
p1 = new Person("Johan");
p2 = new Person("Mattias");

Phone ph1, ph2, ph3;
ph1 = new Phone("073656934");
ph2 = new Phone("019169363");
ph3 = new Phone("070123456");
Phone ph1, ph2, ph3;
ph1 = new Phone("073656934");
ph2 = new Phone("019169363");
ph3 = new Phone("070123456");

//init phonebook and add new persons
PhoneBook phonebook = new PhoneBook();

phonebook.AddEntry(p1, ph1);
phonebook.AddEntry(p2, ph2);
phonebook.AddEntry(p2, ph3);

phonebook.FindPhones(p1);
phonebook.FindPhones(p2);

phonebook.RemoveEntry(p2, ph3);

phonebook.FindPhones(p2);

phonebook.AddEntry(p1, ph1);
phonebook.AddEntry(p2, ph2);
phonebook.AddEntry(p2, ph3);

phonebook.FindPhones(p1);
phonebook.FindPhones(p2);

phonebook.RemoveEntry(p2, ph3);

phonebook.FindPhones(p2);