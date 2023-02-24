namespace JontesLab2
{
    internal interface IPhoneBook
    {
        void RemoveEntry(Phone number);

        void AddEntry(Person name, Phone number);

        List<Phone> FindPhones(Person name);
    }
}