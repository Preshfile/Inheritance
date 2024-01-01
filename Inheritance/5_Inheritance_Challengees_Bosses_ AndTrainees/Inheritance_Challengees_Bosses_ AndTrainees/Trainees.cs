using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Challenge_Bosses__AndTrainees
{
    internal class Trainees : Employee
    {
        public int WorkingHours { get; set; }
        public int SchoolHours { get; set; }


        public Trainees(string firstName, string lastName, int workingHours, int schoolHours) : base(firstName, lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = 1000;

            WorkingHours = workingHours;
            SchoolHours = schoolHours;
        }

        public void Learn()
        {
            Console.WriteLine($"\nTrainee's Name: {FirstName} {LastName}\nSchool hours: {SchoolHours}hrs per week\nPaid: {Salary}$");
        }

        public override void Work()
        {
            Console.WriteLine($"\nTrainee's Name: {FirstName} {LastName}\nWork hours: {WorkingHours}Hrs per week\nPaid: {Salary}$");
        }
    }
}
