namespace Creating_And_Using_YourOwn_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              - C# is a single inheritance language not a multi inheritance 
              - can only inherit from one class
              - In other words, a class can't have multiple base classes in C#

             in this project, we want to implement object destruction
              - We need a way to enforce the destructible behavior 
              - on every class that uses it. just like a contract
              - Best approach in this case is we create an interface we would name IDestroyeable
              - This way, any class that implement this interface will be forced to follow our requirement, 
              - and then customize it depending on the class itself

              - So, we create an interface called an IDestroyable
              - we implement it in the needed classes with all it's members (properties and methods)
              - click on show "potential fixes" when you bring your mouse close to the interface
              - then click on "implement all members". This way, the members will be automatically implemented
              - This is the auto generated version
              - The members can also be manually implemented
             */


            //Creating two objects of type chair
            Chair officeChair = new Chair("Red", "Wood");
            Chair gamingChair = new Chair("Black", "Aluminum");

            //Creating two objects of type car
            Car damagedCar = new Car(70f, "Black");

            //Add the two chairs to the IDestroyable list of the car
            //So that when we destroy the car,
            //The destroyable objects that are near the car will get destroyed as well.
            damagedCar.DestroyablesNearby.Add(officeChair);
            damagedCar.DestroyablesNearby.Add(gamingChair);

            //Destroy the car
            damagedCar.Destroy();

            /*
              - Interfaces are used for communication between related or non-related classes
              - that do not care about the type of class
              - but only on the fact that the classes implemented same interface

            Pros:
             - Interfaces define clear behavioral model: 
               keeps semantics of code clearer with the objects separations
             - Makes code readable
             - Interfaces promoted code maintainability 
             - Design pattern
             - Gateway to multiple inheritance
            */
        }
    }
}