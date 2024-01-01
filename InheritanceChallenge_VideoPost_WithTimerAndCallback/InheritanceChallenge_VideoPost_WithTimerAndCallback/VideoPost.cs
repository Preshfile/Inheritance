using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge_VideoPost_WithTimerAndCallback
{
    internal class VideoPost : Post
    {
        // Fields for VideoPost
        private string videoURL;
        private int length;
        private Timer timer;
        private int currentDuration;

        // Constructor for VideoPost
        public VideoPost(string title, bool isPublic, string senderByUserName, string videoURL, int length)
            : base(title, isPublic, senderByUserName)
        {
            this.videoURL = videoURL;
            this.length = length;
        }

        // Play method
        public void Play()
        {
            Console.WriteLine($"Playing video: {videoURL}");

            // Create a timer that calls the UpdateDuration method every second
            timer = new Timer(UpdateDuration, null, 0, 1000); //1000 milliseconds = a second

            // Wait for user to press any key to stop the video
            Console.ReadKey();

            // Stop the timer and display the stopped message
            Stop();
        }

        // Stop method
        public void Stop()
        {
            timer.Dispose(); // Stop the timer
            Console.WriteLine($"Stopped at {currentDuration}s");
        }

        // Callback method for the timer
        //its private because no other class is permitted to call it
        private void UpdateDuration(object state) //it needs an object as a parameter
        {
            currentDuration++;
            Console.WriteLine($"Current Duration: {currentDuration}s");
        }

        // Override the ToString method to include video-related information
        public override string ToString()
        {
            return $"{base.ToString()} - Video URL: {videoURL} - Length: {length}s";
        }
    }
}

