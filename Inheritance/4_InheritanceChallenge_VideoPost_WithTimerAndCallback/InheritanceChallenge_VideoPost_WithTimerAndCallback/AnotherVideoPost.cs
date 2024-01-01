using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge_VideoPost_WithTimerAndCallback
{
    internal class AnotherVideoPost : AnotherPost
    {
        //field
        protected bool IsPlaying = false;
        protected int CurrentDuration = 0;
        Timer Timer;

        //properties
        public string VideoURL { get; set; }
        public int Length { get; set; }

        public AnotherVideoPost() { }

        public AnotherVideoPost(string title, string videoURL, int length, string senderByUsername, bool isPublic)
        {
            //properties Inherited from Post including the GetNextID() method
            this.ID = GetNextID();
            this.Title = title;
            this.SenderByUserName = senderByUsername;
            this.IsPublic = isPublic;

            //member properties of the class VideoPost not Post
            this.VideoURL = videoURL;
            this.Length = length;
        }

        public void Play()
        {
           if(!IsPlaying)
            {
                IsPlaying = true;
                Console.WriteLine("Video started playing");

                Timer = new Timer(CallBackMethod, null, 0, 1000);

               //if a user presses any key, stop the video
               Console.ReadKey();

                //stop the video
                Stop();
            }
        }
        private void CallBackMethod(object zero)
        {
            if (CurrentDuration < Length)
            {
                CurrentDuration++;
                Console.WriteLine("Playing at {0}s", CurrentDuration);
                GC.Collect(); //forcing the garbage collection for the video to clean up any mess
            }
            else
            {    //when the currentDuration is more than the length of the video, the video has come to an end
                //calling the stop method
                Stop();
            }
        }
        public void Stop()
        {
            if (IsPlaying)
            {
                Console.WriteLine("Stopped at {0}s", CurrentDuration);

                CurrentDuration = 0; //reset current duration
                Timer.Dispose(); //stop the timer
            }

        }
        public override string ToString()
        {
            return String.Format("\n{0} - {1} - {2} - {3}Mb - by {4}", this.ID, this.Title, this.VideoURL, this.Length, this.SenderByUserName);
        }
    }
}
