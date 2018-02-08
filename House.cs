using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    class House
    {
        //fields //i don't want anyone inside or outside of this class to alter these without going through the properties first.
        //think project with multiple developers working on it simultaneously...
        private int squareFt;
        private int roofSqFt;
        private string color;

        //properties // how we assign a value to "square foot for example" to the space that has been assigned 

        public int SquareFt { get; set; }
        public int RoofSqFt { get; set; }
        public string Color { get; set; }

        //constructors

        public House ()
        {
            //default constructor
        }



    }
}
