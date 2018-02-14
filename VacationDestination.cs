using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class VacationDestination : Vacation
    {
        //fields
        //properties
        //constructors
        
        //methods

        public void VacationLocation(int userNum)
        {
            switch (userNum)
            {
                case 1:
                    Console.WriteLine("Hawaii");
                    break;
                case 2:
                    Console.WriteLine("Florida");
                    break;
                case 3:
                    Console.WriteLine("Aruba");
                    break;
                case 4:
                    Console.WriteLine("Jamaica");
                    break;
                case 5:
                    Console.WriteLine("Put in Bay");
                    break;
                case 6:
                    Console.WriteLine("Mexico");
                    break;
                case 9:
                    Console.WriteLine("Venice");
                    break;
            }

        }

        //public override void VacationLocation(int userNum)
        //{
        //    switch (userNum)
        //    { case 1:
        //            Console.WriteLine("Hawaii");
        //            break;
        //        case 2:
        //            Console.WriteLine("Florida");
        //            break;
        //        case 3:
        //            Console.WriteLine("Aruba");
        //            break;
        //        case 4:
        //            Console.WriteLine("Jamaica");
        //            break;
        //        case 5:
        //            Console.WriteLine("Put in Bay");
        //            break;
        //        case 6:
        //            Console.WriteLine("Mexico");
        //            break;
        //        case 9:
        //            Console.WriteLine("Venice");
        //            break;
        //   }

        //}
    }
}

