using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class Membership
    {

        //fields

        private int memberID;
        private bool isActive;

        //properties

        public int MemberID  //get, but not set?  We want to be able to see the ID, but not be able to change it?
                             //permission would depend on nature of app...administrative perspective, versus an interface for gym members.
        {
            get { return this.memberID; }
            set { this.memberID = value; }
        }


        public bool IsActive
        {
            get { return this.isActive; }
            set { this.isActive = value; }
        }

        //constructors

        public Membership()
        {
            //default constructor
        }

        public Membership(int memberID, bool isActive)
        {
            this.memberID = memberID;//left of equals refers to field, right refers to the parameter....
            this.isActive = isActive;
        }

        //methods

        public virtual void Activate()
        {
            if (isActive == false)
            {
                isActive = true;
                Console.WriteLine("Your membership has been activated.");
            }
            else
            {
                Console.WriteLine("Your membership is already active.");
            }
        }


    }
}

