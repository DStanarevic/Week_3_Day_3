using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3_Day_3
{
    class Automobile:Vehicle //This lets the computer know that it's inheriting from it's base class.
    {
        private int numberOfWheels;
        private float wheelSize;
        private int numberOfDoors;

        public int NumberOfWheels
        {
            get { return this.numberOfWheels; }
        }    

        //You use :base to update the 
        public Automobile(int numberOfWheels, float wheelSize, int numberOfDoors):base(4,2000,"Red",65.0d)
        {

        }

        
    }
}
