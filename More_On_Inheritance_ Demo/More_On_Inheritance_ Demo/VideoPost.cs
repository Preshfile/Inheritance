using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More_On_Inheritance__Demo
{
    internal class VideoPost : Post
    {

        //properties
        public string VideoURL { get; set; }
        public int Length { get; set; }

        public VideoPost() {}

        public VideoPost(string title, string videoURL, int length, string senderByUsername, bool isPublic)
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
        public override string ToString()
        {
            return String.Format("\n{0} - {1} - {2} - {3}Mb - by {4}", this.ID, this.Title, this.VideoURL, this.Length, this.SenderByUserName);
        }
    }
}
