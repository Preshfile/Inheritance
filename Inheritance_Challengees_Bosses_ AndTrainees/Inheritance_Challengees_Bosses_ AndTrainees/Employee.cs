using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Challenge_Bosses__AndTrainees
{
    internal class Employee
    {
        protected string FirstName { get; set; }
        protected string LastName { get; set; }
        protected int Salary { get; set; }

        public Employee(string firstName, string lastName)
        {   
            FirstName = firstName;
            LastName = lastName;
            Salary = 0;
        }

        public virtual void Work()
        {
            Console.WriteLine( $"Name of Employee: {FirstName} {LastName}\nSalary: {Salary}$");
        }
        public void Pause()
        {
            Console.WriteLine("I am having a break.");
        }
    }
}
