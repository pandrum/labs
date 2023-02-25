using lab2;

Person p1, p2;
p1 = new Person("Johan");
p2 = new Person("Mattias");

Phone ph1, ph2, ph3;
ph1 = new Phone("073656934");
ph2 = new Phone("019169363");
ph3 = new Phone("070123456");

PhoneBook phonebook = new PhoneBook();

phonebook.AddEntry(p1, ph1);
phonebook.AddEntry(p2, ph2);
phonebook.AddEntry(p2, ph3);

var numbers = phonebook.FindPhones("do not exist");
foreach (var item in numbers)
{
    Console.WriteLine(item.Number);
}

phonebook.RemoveEntry("dadad", ph1);

foreach (var item in numbers)
{
    Console.WriteLine(item.Number);
}