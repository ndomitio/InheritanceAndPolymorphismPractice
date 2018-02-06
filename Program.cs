using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard wizardOne = new Wizard(true);

            HogwartsStudent longbottom = new HogwartsStudent(7);

            DeathEater malfoy = new DeathEater();  //from derived class, isGood set to false.

            wizardOne.MakeMagic();  //same method called, 3 different outputs based on the body of the method in the base/derived class
            longbottom.MakeMagic();
            malfoy.MakeMagic();


            //boat MyBoat= new boat (0, "red");
            //car MyCar = new car(4, "white");

            ////calls from derived class if present, i commented the car honk method, so it defaulted to the base class....
            ////if uncommented, will refer back to the derived class method
            //MyBoat.Honk();
            //MyCar.Honk();
        }

        //To call methods and properties of a class in the program class, you have to instantiate an object from that class.   
    }
}
