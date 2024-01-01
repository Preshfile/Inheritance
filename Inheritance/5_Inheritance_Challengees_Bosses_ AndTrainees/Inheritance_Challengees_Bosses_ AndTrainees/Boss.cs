using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Challenge_Bosses__AndTrainees
{
    internal class Boss : Employee
    {
        public bool CompanyCar { get; set; }

        public Boss(string firstName, string lastName, bool companyCar) : base ( firstName, lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = 5000;

            CompanyCar = companyCar;
        }

        public void Lead()
        {
            if (CompanyCar == true)
            {
                Console.WriteLine($"Name of Boss: {FirstName} {LastName}\nHas Company Car: Yes\nPaid: {Salary}$");
            }
            else
            {
                Console.WriteLine($"Name of Boss: {FirstName} {LastName}\nHas Company Car: No\nPaid: {Salary}$");
            }
        }
    }
}
