namespace Interface_IEnumerator_IEnumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /*
                The IEnumerable interface
            - This is the base interface for many collections in C#
            - Its job is to provide a way to iterate through a collection
            - It is the reason we can use foreach loop to go through a list or a dictionary
              because they are inheriting from the IEnumerable interface.
            - In other words, when a collection class implements the IEnumerable interface,
              it becomes countable. We can count each item in it individually

                Two Versions of the IEnumerable interface
            - IEnumerable<T> for Generic Collections
            - IEnumerable for non Generic Collections

            - The IEnumerable<T> for Generic Collections were introduced after the non Generic Collections
            - So, it is recommended to use Generic Collections since they are improved versions

            - using Non Generic Collections require you perform Boxing and Unboxing (the converion of type object)
              which is less efficient in performance


               Differences between the IEnumerable and IEnumerator
            - The IEnumerable<T> contains a single method  that you must implement when implementing the interface.
            - The GetEnumerator() method is the one you must implement. It returns an IEnumarator<T> object
            - In other words, this is a method you must implement when you want to use IEnumerable for your class
            
            - So the IEnumerator provides the ability to iterate through the collection 
              by exposing a current property that point at the object we are currently at in the collection
            */


            //new instance of a DogShelter list
            DogShelter shelter = new DogShelter();

            //iterate through the list
            foreach(Dog dog in shelter) //without the GetEnumerator, this will flag an error 
            {                           //It needs to contain an extension definition of GetEnumerator
                                        //so we need to implement the IEnumerable<Dog> of type Dog and GetEnumerator method in the DogShelter class

                if (!dog.IsNaughty)
                {
                    dog.GiveTreat(3);
                }
                else
                {
                    dog.GiveTreat(1);
                }
            }


            /*
                   When it is recommended to use the IEnumerble<T> interface
               - Use on collection that represent a massive data table
               - You don't want to copy the entire thing into memory and cause performance issues in your application

                   When it is not recommended to use the IEnumerble<T> interface
               - When you need the results right away and are possibly mutating / editing the objects later on. 
                 In this case, is better to use an array or a list

             */
        }
    }
}