using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge_VideoPost_WithTimerAndCallback
{
    internal class AnotherPost
    {

        //Field
        private static int CurrentPostId;

        //properties - Giving us more information about the object
        protected int ID { get; set; } //Protected means it can only be used by this class and its derived classed
        protected string Title { get; set; }
        protected string SenderByUserName { get; set; }
        protected bool IsPublic { get; set; }

        //Default Constructor: If a derived class does not invoke a base class constructor explicitly,
        //the default constructor is called implicitly.
        public AnotherPost()
        {
            ID = 0;
            Title = "My First Post";
            SenderByUserName = "Precious Oranye";

        }

        //Instance constructor with three parameters
        public AnotherPost(string title, bool isPublic, string senderByUserName)
        {
            this.ID = GetNextID(); //increments by one each time it is called 
            this.Title = title;
            this.SenderByUserName = senderByUserName;
            this.IsPublic = isPublic;

        }

        protected int GetNextID()
        {
            return ++CurrentPostId; //increment the Id
        }

        //Update a post
        public void Update(string tittle, bool isPublic)
        {
            this.Title = tittle;
            this.IsPublic = isPublic;
        }

        //Overriding one of System.Object method - ToString() (every class inherits from the system.object class
        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}", this.ID, this.Title, this.SenderByUserName);
        }
    }
}
