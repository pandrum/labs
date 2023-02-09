using lab2;

//create first person and new number
Person person = new Person("Peter");
Phone phone = new Phone("0705564550");

//create second person and two new numbers
Person person2 = new Person("Johan");
Person person3 = new Person("miaaaaw");
Phone phone2 = new Phone("073656934");
Phone phone3 = new Phone("019169363");

//init phonebook and add new persons
PhoneBook phonebook = new PhoneBook();
phonebook.AddEntry(person, phone);
phonebook.AddEntry(person2, phone2);
phonebook.AddEntry(person2, phone3);

phonebook.FindPhones(person);
phonebook.FindPhones(person2);
phonebook.FindPhones(person2);
phonebook.FindPhones(person3);

phonebook.RemoveEntry(person2, phone);
phonebook.RemoveEntry(person, phone);