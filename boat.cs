using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class boat : Vehicle
    {
        //constructor 
        public boat (int wheels, string color)
        {
            { this.Wheels = 0; }
            { this.Color = "white"; }
        }

        //methods 

        new public void Honk()
        {
            Console.WriteLine("toot toot!");
        }

        public void Drive()
        {
            if (Wheels >= 2)
                Console.WriteLine("Lets go for a drive!");
            else Console.WriteLine("No wheels, can't drive anywhere!");
        }

        public void DockBoat ()
        {
            if (Wheels == 0)
            {
                Console.WriteLine("You can dock your boat here!");
            }

        }

    }
}
