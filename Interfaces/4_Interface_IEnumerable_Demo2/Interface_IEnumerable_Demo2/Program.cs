namespace Interface_IEnumerable_Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare and initialize a new list<int> of type int
            List<int> numberList = new List<int>() { 10, 20, 30 };

            //declare and initialize a new array of integer int[]
            int[] numberArray = new int[] { 100, 200, 300 };

            //Call the CollectionSum() method and pass the list to it
            CollectionSum(numberList);

            Console.WriteLine();
            //Call the CollectionSum() method and pass the list to it
            CollectionSum(numberArray);
        }

        static void CollectionSum(IEnumerable<int> collection)
        {
            //sum variable to store the sum of numbers in collection

            int sum = 0;

            //go through each item n the collection
            foreach (int item in collection)
            {
                //add the item value to sum
                sum += item;
            }

            //Print the sum
            Console.WriteLine("Sum is: {0}", sum);
        }
    }
}