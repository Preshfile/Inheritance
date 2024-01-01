using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Employee
    {
        public double Salary { get; set; }
        public int WorkHours { get; set; }
        public bool DidTheJob { get; set; }

        public Employee( int workHours, bool didTheJob)
        {
            WorkHours = workHours;
            DidTheJob = didTheJob;
            Salary = 5000;

        }

        public void GetToWork()
        {
            if (WorkHours != 0)
            {
                Console.WriteLine("Employee worked");
            }
            else
            {
                Console.WriteLine("Employee did not work");
            }
        }
        public void DoTheJob()
        {
            if (DidTheJob == true)
            {
                Console.WriteLine("Employee did the job");
            }
            else
            {
                Console.WriteLine("Employee did not do the job");
            }
        }
        public void GetPaid()
        {
            if (DidTheJob == true)
            {
                Console.WriteLine($"Employee was paid a salary of {Salary}$");
            }
            else
            {
                Console.WriteLine("Employee was not paid");
            }
        }
    }
}
