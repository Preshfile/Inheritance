using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Introduction
{
    internal class Ticket : IEquatable<Ticket> //the IEquatable interface that allows us to compare objects
    {                                         //It takes the object one wants to compare
        //store duration prop
        public int HourDuration { get; set; }

        public Ticket(int hourDuration)
        {
            HourDuration = hourDuration;
        }

        public bool Equals(Ticket other)
        {
            return this.HourDuration == other.HourDuration;
        }
    }
}
