using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_IEnumerable
{
    internal class Contact
    {
        public string X { get; set; }
        public string Y { get; set; }

        public Contact(string x, string y)
        {
            X = x;
            Y = y;
        }

        public void Call()
        {
            Console.WriteLine("Calling to {0}. Phone number is {1}", X, Y);
        }
    }
}
