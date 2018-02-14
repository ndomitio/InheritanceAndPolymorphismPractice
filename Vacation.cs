using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class Vacation
    {
        //fields
        private string eyeColor;

        //properties
        public string EyeColor { get; set; }
        //constructors
        public Vacation ()
        { }
        public Vacation(string eyeColor)
        { }
        
        //methods

        public int FirstMethod()
        { Console.WriteLine("What color are your eyes?");

            string userEye = Console.ReadLine().ToLower();
            switch (userEye)
            {
                case "blue":
                    return 1;
                case "green":
                    return 2;
                case "brown":
                    return 3;
                case "hazel":
                    return 4;
                case "gray":
                    return 5;
                case "amber":
                    return 6;
                default:
                    return 9;
            }

        }
            //public virtual void VacationLocation(int userNum)
            //{ }

            //public int VacationSpot(string userEye)
            //{

            //    switch (userEye)
            //    {
            //        case "blue":
            //            return 1;
            //        case "green":
            //            return 2;
            //        case "brown":
            //            return 3;
            //        case "hazel":
            //            return 4;
            //        case "gray":
            //            return 5;
            //        case "amber":
            //            return 6;
            //        default:
            //            return 9;
            //    }


        }
        //could i return a dictionary to assign eye color to value pair and corresponding number as key?
    }

