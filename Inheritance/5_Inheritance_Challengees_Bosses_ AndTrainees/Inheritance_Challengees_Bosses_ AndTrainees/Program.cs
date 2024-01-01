namespace Inheritance_Challenge_Bosses__AndTrainees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*

             Inheritance Challenge 2 - Employees, Bosses and Trainees
                 Create a main class with the Main Method, 
                 then a base class Employee with the properties Name, FirstName, Salary, and the methods Work() and Pause().

                 Create a deriving class boss with the property CompanyCar and the method Lead().  
                 Create another deriving class of employees - trainees with the properties WorkingHours and SchoolHours and a method Learn().

                 Override the methods Work() of the trainee class so that it indicates the working hours of the trainee.

                 Don’t forget to create constructors.

                 Create an object of each of the three classes (with arbitrary values)

                 and call the methods, Lead() of Boss and Work() of Trainee.

                 Just print out the respective text, what the respective employees do.
                 E.g. Lead() should print out something like. I'm leading. It is up to you what you print out.

             */

            //Creating a new instance of Trainnee class
            Trainees trainee1 = new Trainees("Julian", "Okey", 40, 20);

            trainee1.Work();
            trainee1.Learn();

            Console.WriteLine();

            //Creating new instances of Bosses class
            Boss boss1 = new Boss("Happiness", "Anyanwu", true);

            boss1.Lead();

            Console.WriteLine();

            Boss boss2 = new Boss("Mr. Andrew", "Goliec", false);

            boss2.Lead();
        }
    }
}