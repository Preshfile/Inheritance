namespace Inheritance_Challenge_MultiLevelInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             create a multilevel inheritance challenge in C#. 
             Consider a scenario where you are building a system to model different types of vehicles. 
             Start with a base class Vehicle, 
             create a subclass Car that inherits from Vehicle, and 
             then create another subclass SportsCar that inherits from Car. 
             Each class should have unique properties and methods, 
             and you should demonstrate the use of inheritance in a practical manner.
             
             */


            // Creating instances
            Vehicle genericVehicle = new Vehicle("GenericBrand", 2022);
            Car myCar = new Car("Toyota", 2020, 4);
            SportsCar mySportsCar = new SportsCar("Ferrari", 2023, 2, true);

            // Using inherited properties and methods
            genericVehicle.DisplayInfo();

            myCar.DisplayInfo();
            myCar.Start();

            mySportsCar.DisplayInfo();
            mySportsCar.Start();
            mySportsCar.Accelerate();
        }
    }
}