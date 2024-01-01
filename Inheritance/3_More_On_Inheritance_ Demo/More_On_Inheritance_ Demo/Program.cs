namespace More_On_Inheritance__Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating a new post
            Post post1 = new Post("Consistency is a valuable skill", true, "Precious Oranye"); //if no argument is passed to the Post constructor, the default constructor is automatically called

            Console.WriteLine(post1.ToString());
           

            //Creating a new image post
            ImagePost imagePost1 = new ImagePost("Check out my newly created image post", "Precious Oranye", 
                   "https://example.com/imagepost", true);

            Console.WriteLine(imagePost1.ToString());

            //Creating a new video post
            VideoPost videoPost1 = new VideoPost("Check out my newly created video post", "https://site/example.com/videopost", 50, "Precious Oranye",
                   true);

            Console.WriteLine(videoPost1.ToString());

            Console.ReadLine();

            //Note once you call on any of the newly created Post, ImagePost or VideoPost type, followed by a dot(.),
            //you will be presented with lots of methods or properties you can with with.
            //Some of these were not created by us.
            //It is so because the sub classes inherit from the base class and both the sub and base classes inherit from the System.Objet class
            //Hence, can access the accessible properties and methods of theses classes.
        }
    }
}