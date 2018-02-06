using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class VIP : Membership
    {
        //fields
        //invisible (since we used the shorthand version in  the properties)

        //properties

        public bool IsSwanky { get; set; }
        
        //constructors
        public VIP ()
        {
            //default constructor/takes no parameters, are allowed to put something in the body.
        }

        public VIP (bool isSwanky)  // parameter does NOT have to have the same name as the property it is affecting
        {
            IsSwanky = isSwanky;
        }

        //methods

        public override void Activate()
        {
            IsSwanky = true; //once activate method is called, isSwanky goes to true
            if (IsActive == false)
            {
                IsActive = true;
                Console.WriteLine("You are now a big deal!");
            }
            else
            {
                Console.WriteLine("You're already a big deal!");
            }

        }
    }
}
