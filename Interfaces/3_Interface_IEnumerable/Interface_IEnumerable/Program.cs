namespace Interface_IEnumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating a Generic IEnumerable variable that takes any collection of type int
            //We would use this variable to tore the collections
            //that would get returned by the GetCollection() methods

            IEnumerable<int> newCollection;
            newCollection = GetCollection(1);

            //Calling collection with option 1
            //print every number we get from GetCollection(1)
            Console.WriteLine("******   Printing every member under the GetCollection(1):   ******");
            foreach (int number in  newCollection)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine("\n");

            //Calling Collection with option 2 - GetCollections(2)
            //print every number we get from GetCollection(2)
            newCollection = GetCollection(2);

            Console.WriteLine("******   Printing every member under the GetCollection(2):   ******");
            foreach (int number in newCollection)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine("\n");

            //Calling Collection with other options i.e - GetCollections(10)
            //print every number we get from other options aside 1 or 2
            newCollection = GetCollection(10);

            Console.WriteLine("******   Printing every member under other options i.e GetCollection(10):   ******");
            foreach (int number in newCollection)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine("\n");
        }

        static IEnumerable<int> GetCollection(int option)
        {
            //Create and initialize a list of numbers
            List<int> numberList = new List<int>() { 1, 2, 3, 4, 5, 6};

            //create a new queue
            Queue<int> numberQueue = new Queue<int>();

            //add numbers to queue
            numberQueue.Enqueue(10);
            numberQueue.Enqueue(20);
            numberQueue.Enqueue(30);
            numberQueue.Enqueue(40);
            numberQueue.Enqueue(50);
            numberQueue.Enqueue(60);

            //check if 1 or two is entered then return the appropriate collection
            if(option == 1)
            {
                return numberList;
            }
            else if (option == 2)
            {
                return numberQueue;
            }
            else
            {
                return new int[]{ 70, 80, 90, 100, 110, 120 };
            }

        }
    }
}