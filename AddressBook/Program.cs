namespace AddressBookProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddressBook addressBook = new AddressBook();

            addressBook.AddContact("Subodh", "Nagalwade", "Age-25 ", "Lakhani", "Maharashtra", 441804, 9422136430, "subodhnagalwade@gmail.com");


            addressBook.AddContact("Rutvik", "Dhande", "Age-22", "lakhani", "maharashtra", 441804, 9503913851, "Rutvikdhande@gmail.com");

            addressBook.ViewContact();
        }
    }
}