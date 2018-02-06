using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class HogwartsStudent : Wizard
    {
        //fields

        private int yearInSchool;

        //properties

        public int YearInSchool
        {
            get { return this.yearInSchool; }
            set { this.yearInSchool = value; }

        }

        //constructors

        public HogwartsStudent()
        {
            //default constructor
        }

        public HogwartsStudent (int yearInSchool)
        {
            this.yearInSchool = yearInSchool;
            this.IsGood = true;  //references the property, since the field is private in the base class.
        }

        //methods
        public int Study()
        {
            return yearInSchool++;
        }

        public override void MakeMagic()
        {
            Console.WriteLine("Accio book");
        }
    }
}
