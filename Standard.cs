using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class Standard : Membership
    {
        //fields
        //invisible

        //Properties
        public int Cost { get; set; }// get/set inside brackets without declaring a field....shorthand version of what we had been implementing,
        //still creates lower case field...

        //constructors
        public Standard()
        {
            //default constructor
        }


        public Standard(int cost)
        {
            //overloaded constructor
            Cost = cost;  //property cost is equal to whatever is passed through parameter.
            
        }


        //methods

        public override void Activate()
        {
            //base.Activate();//would execute same as base class method body   
            if (IsActive == false)
            {
                IsActive = true;
                Console.WriteLine("Your standard membership has been activated.");
            }
            else
            {
                Console.WriteLine("Your standard membership is already active.");
            }

        }
    }
}
