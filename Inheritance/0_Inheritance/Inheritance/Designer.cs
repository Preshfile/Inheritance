using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Designer : Employee
    {
        public int YearOfDesignExperience { get; set; }
        public string LevelOfCreativity { get; set; }
        public int Rating { get; set; }

        public Designer(int workHours, bool didTheJob, int yearOfDesignExperience, int rating) : base(workHours, didTheJob)
        {
            YearOfDesignExperience = yearOfDesignExperience;
            LevelOfCreativity = "";
            Rating = rating;

        }
        public void Design()
        {
            if(YearOfDesignExperience > 5)
            {
                Console.WriteLine("\nA senior designer made the design");
            }
            else
            {
                Console.WriteLine("\nA junior designer made the design");
            }
        }
        public void DrawStuff()
        {
            if (Rating < 3)
            {
                LevelOfCreativity = "beginner";
                Console.WriteLine($"\nYour level of creativity according to your drawing rating is: {LevelOfCreativity} ");
            }
            else if (Rating > 3 && Rating < 5) 
            {
                LevelOfCreativity = "intermediate";
                Console.WriteLine($"\nYour level of creativity according to your drawing rating is: {LevelOfCreativity} ");
            }
            else 
            {
                LevelOfCreativity = "Expert";
                Console.WriteLine($"\nYour level of creativity according to your drawing rating is: {LevelOfCreativity} ");
            }
        }

        
    }
}
