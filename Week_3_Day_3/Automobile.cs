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

        //You use :base to update the fiels in the vehicle class, but not every instance will use this. public Automobile() :base(4,2000,"Red",65.0d)
        public Automobile(int numberOfWheels, float wheelSize, int numberOfDoors, int seats, int caryingCapacity, string color, double movementSpeed)
        {
            //These are in the Automobile class. 
            this.numberOfWheels = numberOfWheels;
            this.wheelSize = wheelSize;
            this.numberOfDoors = numberOfDoors;
            //These fields are in the vehicle class. 
            this.seats = seats;
            this.caryingCapacity = caryingCapacity;
            this.color = color;
            this.MovementSpeed = movementSpeed;


        }

        
    }
}
