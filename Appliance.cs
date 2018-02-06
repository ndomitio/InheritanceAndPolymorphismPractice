using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public abstract class Appliance
    {
        //field
        private bool isElectric;

        //properties

        public bool IsElectric
        {
            get { return this.isElectric; }
            set { this.isElectric = value; }
        }

        //constructors- NONE - b/c abstract class

        //methods--no body since it is abstract class

        public abstract void Work();
    }
}
