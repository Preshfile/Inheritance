using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_IEnumerator_IEnumerable
{
    internal class DogShelter : IEnumerable<Dog> //this is a Generic IEnumerable because it has a type
    {
        //DogShelter has a list we can iterate through,
        //so we need to implement the IEnumerable<Dog> interface of the type Dog
        //with the GetEnumerator method here. 
        //It must implement the interface member GetEnumerator() else we encounter an error.

        //List of type Dog List<Dog>
        public List<Dog> dogs;

        //initialize the dog list with values
        public DogShelter()
        {
            dogs = new List<Dog>()
            {
                new Dog("Sif", false),
                new Dog("Manelo", true),
                new Dog("Santos", true),
                new Dog("Vick", false),
                new Dog("Zazu", true),
                new Dog("Polun", false),
                new Dog("Duralo", false),
                new Dog("Mounto", false)
            };
        }

        //The system through quick fixes automatically returns a Generic and non generic IEnumerator
        IEnumerator<Dog> IEnumerable<Dog>.GetEnumerator()
        {
           return dogs.GetEnumerator();
        }

        //this won't be implemented because we are not using a non generic collection
        //If you get rid of it, we get an error of not implementing every member, so we just let it be
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
