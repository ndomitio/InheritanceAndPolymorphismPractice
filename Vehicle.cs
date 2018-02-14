using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class Vehicle
    {

        //fields
        private string color;
        private int wheels;
        

        //properties

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public int Wheels
        {
            get { return this.wheels; }
            set { this.wheels = value; }
        }

        //constructors 

        public Vehicle()
        {

        }

        public Vehicle(int wheels, string color)
        {
            { this.wheels = wheels; }
            { this.color = color; }
        }

        //methods
        public void Honk()
        { Console.WriteLine("Honk!"); }

    }
}
