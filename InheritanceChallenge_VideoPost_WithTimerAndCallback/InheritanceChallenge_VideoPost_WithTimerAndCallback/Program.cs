using System;

namespace InheritanceChallenge_VideoPost_WithTimerAndCallback
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
               Challenge: Inheritance and VideoPost with Timer and Callback

                Create a base class called Post.

                Include properties such as ID, Title, SenderByUserName, and IsPublic.
                Implement default and parameterized constructors for creating posts.
                Provide a method to update post information.
                Derive a class called VideoPost from the Post class.

                Add properties specific to video posts: videoURL and Length.
                Implement constructors to initialize video post properties.
                Adjust the ToString method to include video-related information.
                Create an instance of the VideoPost class.

                Instantiate a video post with relevant details such as title, 
                public status, sender username, video URL, and length.
                Implement advanced features using Timer and callback methods.

                Create necessary fields within the VideoPost class.
                Add member methods:
                Play: Initiates video playback and displays the current duration.
                Stop: Stops the video, halts the timer, and prints the stop time.
                Test the functionality.

                In the main program, instantiate a VideoPost object.
                Display the post information using the overridden ToString method.
                Play the video to observe the timer in action.
                Pause the video when the user presses any key.

              Aim:  This challenge aims to build a class hierarchy for posts, 
                with a focus on video posts and advanced features like using a timer for playback duration.
             */


            // Create an instance of VideoPost
            //VideoPost videoPost = new VideoPost("Funny Cat Video", true, "Precious Oranye", "https://example.com/catvideo", 20);

            // Display the post information
            //Console.WriteLine(videoPost.ToString());

            // Play the video
            //videoPost.Play();

            Console.WriteLine();

            //create a new video post
            AnotherVideoPost anotherVideoPost = new AnotherVideoPost("Funny Cat Video", "https://example.com/catvideo", 300, "Precious Oranye", true);
            // Display the post information
            Console.WriteLine(anotherVideoPost.ToString());

            // Play the video
            anotherVideoPost.Play();

        }
    }
}