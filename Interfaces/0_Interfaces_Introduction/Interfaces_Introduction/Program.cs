namespace Interfaces_Introduction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Interfaces

              - Interfaces provide a way to define a contract that classes can implement. 
              - Interfaces are a key feature of object-oriented programming (OOP) that allows for abstraction and polymorphism.
              - Think of interfaces as contracts whereby... 
              - a class that implements an interface agrees to provide implementations 
                for all objects defined by the interface.
              - This means an interface will contain the contract terms, methods and properties.
              - How it is being implemented is up to the class that implements the interface
              - As long as the interface methods are implemented in our class, the interface remains happy
              - Interfaces cannot contain any implementation
              - Names of interfaces are generally prefixed with the "i" to distinguish them from other C# objects e.g IProtect, IStrong, etc

              - Interfaces are created using the interface keyword
             */

            //creating new tickets and comparing them
            Ticket ticket1 = new Ticket(20);
            Ticket ticket2 = new Ticket(20);

            Console.WriteLine(ticket1.Equals(ticket2));//true

            Ticket ticket3 = new Ticket(10);
            Ticket ticket4 = new Ticket(50);

            Console.WriteLine(ticket3.Equals(ticket4));//false


            Console.ReadLine();

        }
    }
}