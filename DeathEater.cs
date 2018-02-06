using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class DeathEater : Wizard
    {
        //fields 
        private bool hasDarkMark;


        //properties

        public bool HasDarkMark
        {
            get { return this.hasDarkMark; }
            set { this.hasDarkMark = value; }
        }

        //Constructor

        public DeathEater()
        {

        }
        public DeathEater(bool isGood)
        {
            isGood = false;

        }

        public override void MakeMagic()
        {
            Console.WriteLine("Crucio!");
        }


    }
}

