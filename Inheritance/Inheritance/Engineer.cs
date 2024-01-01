using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Engineer : Employee
    {
        public int YearOfProgExperience { get; set; }
        public string LevelOfProgSkill { get; set; }
        public int Rating { get; set; }

        public Engineer(int workHours, bool didTheJob, int yearOfProgExperience, int rating) : base(workHours, didTheJob)
        {
            YearOfProgExperience = yearOfProgExperience;
            LevelOfProgSkill = "";
            Rating = rating;
            Rating = rating;
        }

        public void Design()
        {
            if (YearOfProgExperience > 5)
            {
                Console.WriteLine("\nA senior programmer made the design");
            }
            else
            {
                Console.WriteLine("\nA junior programmer made the design");
            }
        }
        public void Program()
        {
            if (Rating < 3)
            {
                LevelOfProgSkill = "beginner";
                Console.WriteLine($"\nYour level of programming according to your program rating is: {LevelOfProgSkill} ");
            }
            else if (Rating > 3 && Rating < 5)
            {
                LevelOfProgSkill = "intermediate";
                Console.WriteLine($"\nYour level of programming according to your program rating is: {LevelOfProgSkill} ");
            }
            else
            {
                LevelOfProgSkill = "Expert";
                Console.WriteLine($"\nYour level of programming according to your program rating is: {LevelOfProgSkill} ");
            }
        }

    }
}
