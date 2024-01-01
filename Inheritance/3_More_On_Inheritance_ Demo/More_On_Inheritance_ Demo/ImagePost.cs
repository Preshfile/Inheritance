using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More_On_Inheritance__Demo
{

    //ImagePost class derives from Post and adds a property(ImageURL) and two constructors
    internal class ImagePost : Post
    {
        public string ImageURL { get; set; }

        public ImagePost(){} //we don't call the constructor in the base class explicitly here. its called implicitly

        public ImagePost(string title, string senderByUsername, string imageURL, bool isPublic)
        {
            //properties Inherited from Post including the GetNextID() method
            this.ID = GetNextID();
            this.Title = title;
            this.SenderByUserName = senderByUsername;
            this.IsPublic = isPublic;

            //member property of the class ImagePost not Post
            this.ImageURL = imageURL;
        }

        public override string ToString()
        {
            return String.Format("\n{0} - {1} - {2} - by {3}", this.ID, this.Title, this.ImageURL, this.SenderByUserName);
        }
    }
}
