using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class car : Vehicle
    {
        //constructor



        public car (int wheels, string color)
        {
            { this.Wheels = 4; }
            { this.Color = "red"; }
        }

   


        //methods


        new public void Honk()
        {
            Console.WriteLine("beep beep");
        }

        public void Drive()
        {
            if (Wheels >= 2)
                Console.WriteLine("Lets go for a drive!");
        }

        public void CarWash ()
        {
            Console.WriteLine("Time to wash your car!");
        }

    }
}
