using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class Rectangle : Shape
    {
        private double area;

        public double Area
        {
            get { return this.area; }
            set { this.area = value; }
        }
        //a derived class does not inherit the constructors of the base class.  inherits properties and fields
        //however, the constructors of the base class can be accessed using the "base" keyword.
        //example:
        // public Rectangle() : base()
        //{}

        //public Rectangle(double area) : base(4)
        //{ this.area = area; }


        public Rectangle(double area)
        {
            this.area = area;
        }



    }
}
