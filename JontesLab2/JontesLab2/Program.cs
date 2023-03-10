using JontesLab2;

List<Person> allNames = new List<Person>();
List<Phone> retrievedPhones = new List<Phone>(); //så att vi kan retrieva mer en ett nummer

MembersStored membersStored = new MembersStored();
membersStored.FillPersons(); //Fyller med personer som initieras från membersstored klassen
//allNames = membersStored.Persons; //behövs verkligen denna om vi redan har en lista i klassen, vi kan använda get istället bara

PhoneBook phoneBook = new PhoneBook(membersStored.Persons);
phoneBook.AddRandomNumbers();

retrievedPhones = phoneBook.FindPhones(membersStored.Persons.First()); //ett test med den första personen
//Console.WriteLine(retrievedPhones);

foreach (Phone phone in retrievedPhones)
{
    Console.WriteLine($"{phone.Number}");
}

Phone oldPhone = retrievedPhones.First();
phoneBook.RemoveEntry(retrievedPhones.First()); // ta bort det första lagrade nummret
phoneBook.RemoveEntry(oldPhone); // ta bort numret som redan tagits bort
phoneBook.RemoveEntry(retrievedPhones.Last());
//ta bort sisat numret som personen har kvar, ska nu ta bort personen från db också