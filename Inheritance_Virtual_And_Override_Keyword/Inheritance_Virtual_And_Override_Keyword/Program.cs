namespace Inheritance_Virtual_And_Override_Keywords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              - When a method is set to virtual, it is set to be overridden
                by a class that will inherit it's class.
              - In other words, virtual allows sub class to use the override keyword
             */

            //creating an intance of Dog
            Dog myDog = new Dog("Blake", 3);

            Console.WriteLine($"{myDog.Name} is {myDog.Age} years old ");

            myDog.Play();
            myDog.Eat();
            myDog.MakeSound();

            Console.ReadKey();
        }
    }
}