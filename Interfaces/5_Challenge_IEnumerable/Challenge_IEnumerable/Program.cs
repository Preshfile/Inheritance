namespace Challenge_IEnumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*   IEnumerable
                        
                Create Contact and PhoneBook classes in the right way 
                
                 You have to use this list of Contact:

                 Contacts = new List<Contact>{
                                 new Contact("Andre", "435797087"),
                                 new Contact("Lisa", "435677087"),
                                 new Contact("Dine", "3457697087"),
                                 new Contact("Sofi", "4367697087")
                             };

                 The method Call should print "Calling to X. Phone number is Y" 
                 where X is a name and Y is a phone number.

             */



            PhoneBook MyPhoneBook = new PhoneBook();

            foreach (Contact contact in MyPhoneBook)
            {
                contact.Call();
            }
        }
    }
}