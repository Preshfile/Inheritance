using Inheritance;

namespace Inheritance_Introduction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               - Inheritance is a fundamental concept in OOP
               - It allows a child or derived class to inherit from a parent of base class.
               - This promotes code reuse, makes it easier to create and maintain applications
                 and speeds up implementation.
               - The class whose members are inherited is the Base or parents Class
               - while the class that inherits the members of the base class is called - The Derived or child class
             
                     Example1:

                 A base class could be - Car
                                            Properties - HP, Windows, Wheel
                                            Method - Drive, Honk
                                                     //These are properties and methods that are true for all cars

                       Derived classes - StreetCar
                                            Property - Comfort
                                            Method - StreetRide
                                                     //Property and method unique to the street car

                                       - RaceCar
            Console.WriteLine(               Property - Turbo
                                             Method - Racing
                                                     //Property and method unique to the race car


                     Example2:
                 A base class could be - Employee
                                            Properties - Salary, WorkHours
                                            Method - GetToWork, DoTheJob, GetPaid
                                                     //These are properties and methods that are true for all employees

                       Derived classes - Designer
                                            Property - YOfDesignExperience, LevelOfCreativity
                                            Method - Design, DrawStuff
                                                     //Property and method unique to the designer

                                       - Engineer   
                                           Property - YOfProgExperience, LevelOfProgSkill
                                            Method - Design, Program
                                                     //Property and method unique to the programmer

            The idea behind inheritance is the re-usability of code.
            Inheritance allows us to reuse not only our code but that of other developers
            */

            //creating new instance of a race car
            RaceCar raceCar1 = new RaceCar(1050, "stitched leather wheel", "black Net windows");
            raceCar1.Racing();


            //creating new instance of a street car
            StreetCar streetCar1 = new StreetCar(444, "Shinny metal wheel", "bullet proof windows", true);
            streetCar1.StreetRide();


            //creating new instance of a designer
            Designer designer1 = new Designer(7, true, 5, 4);
            designer1.Design();
            designer1.DrawStuff();

            Designer designer2 = new Designer(4, false, 2, 2);
            designer2.Design();
            designer2.DrawStuff();


            //creating new instance of an engineer
            Engineer engineer1 = new Engineer(10, true, 10, 5);
            engineer1.Design();
            engineer1.Program();

            Engineer engineer2 = new Engineer(5, false, 3, 2);
            engineer2.Design();
            engineer2.Program();
        }
    }
}