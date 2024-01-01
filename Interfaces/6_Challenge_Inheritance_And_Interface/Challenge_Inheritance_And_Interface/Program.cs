using System.Collections.Generic;

namespace Challenge_Inheritance_And_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                 Create An interface called IShootable. It will contain a method Shoot;

                 Create a class Weapon with a Name attribute and method Label 
                 that will display the name of a weapon in the format "This is X!", 
                 where X is a name of a weapon;

                 Create a class Gun that inherits from Weapon, can shoot with a "Bang!" message, 
                 as the name "Gun", and is able to show the label.
             */


            //new instance
            Gun firstGun = new Gun();

            //Test for methods
            firstGun.Label();
            firstGun.Shoot();

            // verifying the interface and the parent class
            if (firstGun is IShootable && firstGun is Weapon)
                Console.WriteLine("Yes, it is my parents.");
        }
    }
}